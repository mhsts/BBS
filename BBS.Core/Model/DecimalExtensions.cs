using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace BBS.Model
{
    public static class DecimalExtensions
    {
        public static decimal ParseInvariant(string str)
        {
            string dot = CultureInfo.InvariantCulture.NumberFormat.CurrencyDecimalSeparator;

            str = str.Replace(".", dot).Replace(",", dot);

            return Decimal.Parse(str,CultureInfo.InvariantCulture);
        }
    }
}
