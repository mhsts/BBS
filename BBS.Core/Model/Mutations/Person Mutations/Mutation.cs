using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BBS
{
    [Serializable]
    public abstract class Mutation
    {
        protected Person owner;
        protected Decimal cost;
        protected DateTime timestamp;
        protected bool active;

        public Mutation()
        {
            active = true;
        }

        public virtual Decimal GetCostAndCommit()
        {
            timestamp = DateTime.Now;
            active = false;

            return GetCost();
        }

        public virtual Decimal GetCost()
        {
            return this.cost;
        }

        public Person GetOwner()
        {
            return this.owner;
        }
    }
}
