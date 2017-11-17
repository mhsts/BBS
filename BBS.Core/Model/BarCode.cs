using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace BBS
{
    [Serializable]
    public class BarCode
    {
        private string val = "";
        public string Value
        {
            get { return val; }
            set { val = value; }
        }

        public static BarCode NULL = new BarCode("");

        public BarCode(string barCode)
        {
            val = barCode;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            bool same = false;

            if (obj is BarCode)
                same = ((BarCode)obj).val.Equals(this.val);
            else if (obj is string)
                same = obj.Equals(this.val);

            return same;
        }
        
        public override string ToString()
        {
            return val;
        }
    }
}
