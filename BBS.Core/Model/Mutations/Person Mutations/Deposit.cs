using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BBS
{
    [Serializable]
    public class Deposit : Mutation
    {
        private Person barPersoon;

        public Deposit(Person benificiary, Person pBarPerson, Decimal amount)
        {
            owner = benificiary;
            barPersoon = pBarPerson;
            cost = -1m * amount;
        }

        public override Decimal GetCostAndCommit()
        {
            if (barPersoon == null || !barPersoon.IsBar())
            {
                String pBarPerson = (barPersoon != null) ? barPersoon.ToString() : "(null)";
                MessageBoxCreator.RaiseWarning(String.Format("Deposit by null or non-bar! ({0})", pBarPerson));
                return 0m;
            }

            return base.GetCostAndCommit();
        }

        public override String ToString()
        {
            StringBuilder sb = new StringBuilder();

            String sOwner = (owner != null) ? owner.ToString() : "(null)";
            String pBarPerson = (barPersoon != null) ? barPersoon.ToString() : "(null)";

            sb.Append(String.Format("Bijstorting tegoed van {0} op {3} door bar/admin {1}: {2:0.00}", sOwner, pBarPerson, -1m * this.cost, timestamp.ToShortDateString()));
            sb.Append(Environment.NewLine);

            return sb.ToString();
        }
    }

}
