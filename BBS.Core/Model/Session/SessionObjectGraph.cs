using System;
using System.Collections.Generic;
using System.Text;

namespace BBS
{
    [Serializable]
    public class SessionObjectGraph
    {
        public bool ShouldShowVoorraadWarnings;

        private List<Person> persons;
        private List<Mutation> mutationHistory; // NO LONGER USED
        private List<Product> products;
        private StringBuilder log;
        private StringBuilder transLog;
        private List<PeriodicReport> reports;

        public SessionObjectGraph(List<Person> pPersons, List<Product> pProducts, List<PeriodicReport> pReports)
        {
            persons = pPersons;
            products = pProducts;

            log = Logger.LogBuilder;
            transLog = Logger.TransLog;
            
            reports = pReports;
        }

        internal List<Person> GetPersons()
        {
            return persons;
        }
        
        internal List<Product> GetProducts()
        {
            return products;
        }

        internal StringBuilder GetLogBuilder()
        {
            return log;
        }

        internal StringBuilder GetTransLog()
        {
            return transLog;
        }

        internal List<PeriodicReport> GetReports()
        {
            return reports;
        }
    }
}
