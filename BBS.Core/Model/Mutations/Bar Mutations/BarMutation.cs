using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BBS
{
    [Serializable]
    public class BarMutation
    {
        protected Person owner;
        protected Decimal cost = 0m;
        protected DateTime timestamp = DateTime.Now;
        
        public Decimal GetCost()
        {
            return cost;
        }
    }
}
