using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BBS
{
    public class PeriodicReportDataSet
    {
        public Decimal BrutoWinst = 0m;
        public Decimal Afschrijvingen = 0m;
        public Decimal AndereInkopen = 0m;
        public Decimal NettoWinst = 0m;
        public Decimal Inkopen = 0m;
        public Decimal Uitstaand = 0m;
        public Decimal Cash = 0m;
        public Decimal Inkomsten = 0m;
        public List<ProductReport> ProductReports = new List<ProductReport>();
        public List<PersonReport> PersonReports = new List<PersonReport>();
        public List<OtherBuys> OtherBuys = new List<OtherBuys>();
        public List<StockAddition> StockAdditions = new List<StockAddition>();
    }
}
