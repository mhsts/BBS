using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BBS
{
    [Serializable]
    public class Person : NamedObject
    {
        private ID id;
        private Decimal balance = 0m;
        private List<Mutation> mutations = new List<Mutation>();
        protected Mutation currentMutation = null;
        private PersonRole role = PersonRole.NORMAL;
        private bool groupAccount = false; //bijv: klusgroep/rowans
        private DateTime lastActivity = DateTime.Now;
        private DateTime negativeBalanceSince = DateTime.Now;
        private string emailAddress = "";

        public virtual bool ShowToUser()
        {
            return true;
        }

        public ID ID
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime LastActivity
        {
            get
            {
                return lastActivity;
            }
        }

        public PersonRole Role
        {
            get
            {
                return role;
            }
            set
            {
                role = value;
            }
        }

        public string EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }

        public bool GroupAccount
        {
            get
            {
                return groupAccount;
            }
            set
            {
                groupAccount = value;
            }
        }

        public Decimal Balance
        {
            get
            {
                return balance;
            }
        }

        public enum PersonRole
        {
            NORMAL,
            BAR,
            ADMIN,
        }

        public Person(String pName, ID pId)
        {
            name = pName;
            id = pId;
        }

        public Person(String pName, String barCode, String pw)
        {
            name = pName;
            id = new ID(barCode, pw);
        }

        public bool IsAdmin()
        {
            if (role == PersonRole.ADMIN)
                return true;
            return false;
        }

        public bool IsBar()
        {
            if (role == PersonRole.BAR || role == PersonRole.ADMIN)
                return true;
            return false;
        }

        public static bool IsBar(Person p)
        {
            if (p.Role == PersonRole.BAR || p.Role == PersonRole.ADMIN)
                return true;
            return false;
        }

        public void AbortMutation()
        {
            if (currentMutation != null)
            {
                //do stuff? no penalties?
                currentMutation = null;
            }
        }

        public bool HasNegativeBalance()
        {
            return balance < 0;
        }

        public DateTime GetNegativeBalanceSinceTimeStamp()
        {
            if (balance < 0)
                return negativeBalanceSince;

            return DateTime.Now; //return something, but should be ignored: perhaps use nullable?
        }

        public virtual bool CommitMutation()
        {
            if (currentMutation != null)
            {
                if (!currentMutation.GetOwner().Equals(this))
                {
                    MessageBoxCreator.RaiseWarning("Mutation with nonmatching owner!");
                    return false;
                }

                if (balance > 0) //Positive balance
                    negativeBalanceSince = DateTime.Now; //positive balance, so update the 'last' time.
                
                if (currentMutation is Order)
                    if ((currentMutation as Order).ProductOrders.Count == 0) //no changes
                    {
                        currentMutation = null;
                        return false;
                    }

                decimal cost = currentMutation.GetCostAndCommit();

                balance -= cost;

                mutations.Add(currentMutation);
                Session.AddPersonMutationToHistory(currentMutation);
                lastActivity = DateTime.Now;
                currentMutation = null;
                return true;
            }
            //nothing to commit
            return false;
        }

        public override string ToString()
        {
            return this.name;
        }

        public bool HasCurrentMutation()
        {
            return (currentMutation != null);
        }

        public Order CreateNewOrder()
        {
            if (currentMutation != null)
            {
                MessageBoxCreator.RaiseWarning("Current order not null!");
                return null;
            }

            Order ord = new Order(this);
            this.currentMutation = ord;
            return ord;
        }

        public void AddNewMutation(Mutation m)
        {
            if (currentMutation != null)
            {
                MessageBoxCreator.RaiseWarning("Current order not null!");
                return;
            }

            this.currentMutation = m;
        }

        public static string RoleToString(PersonRole personRole)
        {
            switch(personRole)
            {
                case PersonRole.NORMAL:
                    return "";
                case PersonRole.BAR:
                    return "Bar";
                case PersonRole.ADMIN:
                    return "Admin";
                default:
                    return "Onbekend";
            }
        }

        public string ToStringMutations()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Mutation m in mutations)
                sb.Append(m.ToString());

            return sb.ToString();
        }

        public void PruneHistory()
        {
            mutations = new List<Mutation>();
        }

        public void PruneHistory(int maxRemaining)
        {
            mutations = mutations.Skip(Math.Max(0, mutations.Count - maxRemaining)).ToList();
        }
    }
}
