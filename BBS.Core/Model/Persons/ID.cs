using System;

namespace BBS
{
    [Serializable]
    public class ID
    {
        private BarCode barCode;
        private BarCode barCode2;
        private string touchCode = "";
        private string alternativePassword = "";

        protected ID()
        {
            BarCode2 = new BarCode("");
        }

        public ID(String barcode, String pw):this()
        {
            barCode = new BarCode(barcode);
            alternativePassword = pw;
        }

        public ID(String barcode, String pw, String touchCode)
            : this(barcode, pw)
        {
            this.touchCode = touchCode;
        }

        public BarCode BarCode
        {
            get { return barCode; }
            set { barCode = value; }
        }

        public BarCode BarCode2
        {
            get { return barCode2 ?? (barCode2 = new BarCode("")); }
            set { barCode2 = value; }
        }

        public string TouchCode
        {
            get { return touchCode; }
            set { touchCode = value; }
        }

        public string Password
        {
            get { return alternativePassword; }
            set { alternativePassword = value; }
        }
        
        public string GetBarCodeNumber()
        {
            return barCode.Value;
        }

        public override bool Equals(Object other)
        {
            if (other is ID)
                if (((ID)other).GetBarCodeNumber().Equals(this.GetBarCodeNumber()))
                    return true;

            return false;
        }

        public bool AdminMatches(ID id)
        {
            if (this.alternativePassword.Equals(id.alternativePassword))
                return true;
            return false;
        }
                
        public bool Matches(ID id)
        {
            if (EqualsAndApplicable(GetBarCodeNumber(), id.GetBarCodeNumber()) ||
                EqualsAndApplicable(BarCode2.Value, id.GetBarCodeNumber()) ||
                EqualsAndApplicable(alternativePassword, id.GetAlternativePassword()) ||
                EqualsAndApplicable(touchCode, id.TouchCode))
                return true;
            return false;
        }

        private bool EqualsAndApplicable(string one, string two)
        {
            return !String.IsNullOrEmpty(one) && one.Equals(two);
        }

        private string GetAlternativePassword()
        {
            return alternativePassword;
        }

        public override int GetHashCode()
        {
            int hashBarCode = 0;
            if (Int32.TryParse(this.GetBarCodeNumber(), out hashBarCode))
                return hashBarCode;
            else
                return base.GetHashCode();
        }
    }
}
