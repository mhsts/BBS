using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BBS
{
    public class PersonReport
    {
        private Person innerPerson;
        private Decimal deposited;
        private Decimal spend;

        public PersonReport(Person p)
        {
            innerPerson = p;
        }

        public Person Owner
        {
            get
            {
                return innerPerson;
            }
        }

        public Decimal Deposited
        {
            get
            {
                return deposited;
            }
            set
            {
                deposited = value;
            }
        }
        public Decimal Spend
        {
            get
            {
                return spend;
            }
            set
            {
                spend = value;
            }
        }
    }
}
