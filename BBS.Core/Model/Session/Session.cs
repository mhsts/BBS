using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace BBS
{
    public static class Session
    {
        public static bool ShouldShowProductAmountWarnings { get; set; }
        public static string BackupPath = ".//backups//";
        public static bool SkipSaveOnExit = false;

        private static Person currentUser;
        private static List<Person> persons = new List<Person>();
        private static List<PeriodicReport> reports = new List<PeriodicReport>();
        
        public static bool ExistsPersonWithName(String name)
        {
            foreach (Person p in persons)
                if (p.Name.Equals(name))
                    return true;
            return false;
        }

        static Session()
        {
            ShouldShowProductAmountWarnings = true;
            Person p = new Person("RecoveryAdmin","","");
            p.Role = Person.PersonRole.ADMIN;
            Session.Persons.Add(p);
        }

        public static List<Person> Persons
        {
            get { return persons; }
            set { persons = value; }
        }

        public static bool Load()
        {
            SessionObjectGraph graph = (SessionObjectGraph)CryptoStore.LoadObject("session");

            if (graph == null)
            {
                //todo: grrr, now what?!
                reports.Add(new PeriodicReport());

                return false;
            }
            else
            {
                ShouldShowProductAmountWarnings = graph.ShouldShowVoorraadWarnings;
                persons = graph.GetPersons();
                EnsureContantPersonPresent();
                Stock.Products = graph.GetProducts();
                Logger.LogBuilder = graph.GetLogBuilder();
                Logger.TransLog = graph.GetTransLog();
                currentUser = null;

                reports = graph.GetReports();

                if (reports == null)
                    reports = new List<PeriodicReport>();

                if (reports.Count == 0)
                    reports.Add(new PeriodicReport());
                else
                {
                    //we got previous reports, let's check if it's the right month;
                    PeriodicReport lastReport = reports[reports.Count - 1];
                    if (lastReport.StartDate.Month != DateTime.Now.Month)
                        reports.Add(new PeriodicReport());
                }

                foreach (Person p in persons)
                    p.AbortMutation(); //safetycheck

                return true;
            }
        }

        private static void EnsureContantPersonPresent()
        {
            bool present = false;

            foreach (Person p in persons)
                if (p is ContantPerson)
                    present = true;

            if (!present)
                persons.Add(new ContantPerson());
        }

        public static void PruneSessionSize()
        {
            Logger.TrimContents(); //make logs smaller
            foreach (var p in persons)
            {
                // save only the last 50 transactions per person
                p.PruneHistory(50);
            }
            // take at most last 3 periodic reports
            reports = reports.Skip(Math.Max(0, reports.Count - 3)).ToList();
        }

        public static bool SaveWithName(string name)
        {
            SessionObjectGraph graph = new SessionObjectGraph(persons, Stock.Products, reports)
            {
                ShouldShowVoorraadWarnings = ShouldShowProductAmountWarnings
            };
            return CryptoStore.SaveObject(graph, name);
        }
        
        public static bool Save()
        {
            bool success = Session.SaveWithName("session-temp");
            if (success)
            {
                if (File.Exists("session.crypt"))
                {
                    File.Replace("session-temp.crypt", "session.crypt", "session.deleted", true);
                }
                else
                {
                    File.Move("session-temp.crypt", "session.crypt");
                }
            }
            return success;
        }

        public static bool SaveBackup()
        {
            if (!Directory.Exists(BackupPath))
            {
                Directory.CreateDirectory(BackupPath);
            }

            return SaveWithName(BackupPath + "backup-" + DateTime.Now.ToString("MMddyyyyHHmmss"));
        }

        public static void AddPersonMutationToHistory(Mutation m)
        {
            GetCurrentReport().PersonMutations.Add(m);
            Logger.Log(m.ToString());
            if (m is Order)
                Logger.LogTransaction(m.ToString());
            Session.Save();
        }
        
        public static void AddBarMutation(BarMutation m)
        {
            GetCurrentReport().BarMutations.Add(m);
            Logger.Log(m.ToString());
            Session.Save();
        }

        public static void ClearHistory()
        {
            if (SaveBackup())
            {
                Logger.Reset();
                Logger.Log("Geschiedenis leeg gemaakt");
                reports = new List<PeriodicReport>(); //dangerous!!
                foreach (Person p in persons)
                    p.PruneHistory();
            }
        }

        public static Person GetCurrentUser()
        {
            return currentUser;
        }

        public static bool LogInUser(Person targetPerson, ID id)
        {
            if (currentUser != null)
                return false;

            if (targetPerson.ID.Matches(id))
            {
                currentUser = targetPerson;
                return true;
            }
            return false;
        }

        public static bool CanLogInUser(Person targetPerson, ID id)
        {
            if (currentUser != null)
                return false;

            if (targetPerson.ID.Matches(id))
                return true;

            return false;
        }

        public static bool LogInUser(ID id)
        {
            if (currentUser != null)
                return false;

            foreach (Person p in persons)
                if (LogInUser(p, id))
                    return true;

            return false;
        }

        public static bool LogOutCurrentUser()
        {
            if (currentUser != null)
            {
                if (currentUser.HasCurrentMutation())
                {
                    MessageBoxCreator.RaiseWarning("Er is nog een transactie gaande, handel deze eerst af!");
                    return false;
                }
                else
                {
                    currentUser = null;
                    return true;
                }
            }
            return true;
        }

        public static bool LogInAdmin(Person p, ID id)
        {
            if (currentUser != null)
                return false;
            if (p.ID.AdminMatches(id))
                if (p.IsBar())
                {
                    currentUser = p;
                    return true;
                }
            return false;
        }

        public static bool LogInAdmin(ID id)
        {
            if (currentUser != null)
                return false;

            foreach (Person p in persons)
                if (LogInAdmin(p, id))
                    return true;

            return false;
        }

        public static bool RemovePerson(Person tp)
        {
            Person currentUser = Session.GetCurrentUser();

            if (currentUser == null || !currentUser.IsAdmin())
                return false;

            foreach (Person p in persons)
            {
                if (p.Name.Equals(tp.Name))
                {
                    if (Math.Round(tp.Balance,1) == 0m)
                    {
                        Logger.Log(String.Format("Account {0} verwijdered.", tp.Name));
                        return persons.Remove(tp);                        
                    }
                    else
                        break;
                }
            }
            return false;
        }

        public static List<Person> GetElevatedAccounts()
        {
            return persons.Where(Person.IsBar).Where(p => (!(p is ContantPerson))).ToList();
        }

        public static PeriodicReport GetCurrentReport()
        {
            if (reports.Count == 0)
                reports.Add(new PeriodicReport());

            return reports[reports.Count - 1];
        }

        public static List<PeriodicReport> GetReports()
        {
            return reports;
        }


        /// <summary>
        /// Returns false if exit cannot be safely performed (consider cancelling a window close action in that case)
        /// </summary>
        /// <returns></returns>
        public static bool Exit()
        {
            if (SkipSaveOnExit)
                return true;

            if (!Environment.HasShutdownStarted)
            {
                if (Session.GetCurrentUser() != null)
                {
                    MessageBoxCreator.RaiseWarning("Log eerst uit en/of handel eerst de huidige mutatie af! Anders gaat ie kapot!");
                    return false;
                }
                PruneSessionSize();
                Session.SaveBackup();
                if (!Session.Save())
                {                  
                    if (!MessageBoxCreator.RaiseYesNo("Toch afsluiten?"))
                        return false;
                }
            }
            else //system shutdown:
            {
                // minimize actions..

                if (Session.GetCurrentUser() != null)
                    Session.GetCurrentUser().AbortMutation();

                //Session.SaveBackup();
                //Session.Save();
            }
            return true;
        }
    }
}
