using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BBS
{
    [Serializable]
    public class OtherBuys : BarMutation
    {
        private string description = "";

        public OtherBuys(string desc, Decimal c)
        {
            description = desc;
            cost = c;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format("@ {1} euro: '{0}'", description, cost));
            sb.Append(Environment.NewLine);
            return sb.ToString();
        }
    }
}
