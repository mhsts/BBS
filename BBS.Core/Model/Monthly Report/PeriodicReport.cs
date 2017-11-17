using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BBS
{
    [Serializable]
    public class PeriodicReport
    {
        private DateTime startDate;
        
        public DateTime StartDate
        {
            get
            {
                return startDate;
            }
            set
            {
                startDate = value;
            }
        }

        public PeriodicReport()
        {
            startDate = DateTime.Now;
        }

        public override string ToString()
        {
            return startDate.ToString("MMMM yyyy");
        }

        public List<BarMutation> BarMutations = new List<BarMutation>();
        public List<Mutation> PersonMutations = new List<Mutation>();

        public PeriodicReportDataSet CalculateTotals()
        {
            PeriodicReportDataSet monthRep = new PeriodicReportDataSet();
            //MessageBox.Show("1");
            foreach (Person p in Session.Persons)
                monthRep.PersonReports.Add(new PersonReport(p));
            //MessageBox.Show("2");

            foreach (Mutation m in PersonMutations)
            {
                PersonReport personRep = monthRep.PersonReports.Find(new IsForPerson(m.GetOwner()).Match);

                if (personRep == null)
                {
                    personRep = new PersonReport(new Person("<Verwijderd>", "", ""));
                    monthRep.PersonReports.Add(personRep);
                }

                if (m is Order)
                {
                    Order o = (Order)m;
                    foreach (ProductOrder prodOrder in o.ProductOrders)
                    {
                        ProductReport productRep = monthRep.ProductReports.Find(new IsForProduct(prodOrder.GetProduct()).Match);

                        if (productRep == null) //add the product if it doesn't 
                        {
                            productRep = new ProductReport(prodOrder.GetProduct());
                            monthRep.ProductReports.Add(productRep);
                        }

                        productRep.Amount += prodOrder.GetAmount();
                        productRep.NumFree += prodOrder.GetUnpaidAmount();
                        Decimal paid = prodOrder.GetCost();
                        Decimal cost = (prodOrder.GetAmount() * prodOrder.GetProduct().BuyPrice);
                        productRep.GrossIncome += (paid - cost);
                        personRep.Spend += paid;
                        monthRep.Inkomsten += paid;
                        monthRep.Uitstaand += paid;
                    }
                }
                else if (m is Deposit)
                {
                    Decimal paid = -m.GetCost(); //neg value, so invert
                    personRep.Deposited += paid;
                    monthRep.Uitstaand -= paid;
                }
            }
            //MessageBox.Show("3");
            foreach (BarMutation bm in BarMutations)
            {
                if (bm is WriteOff)
                {
                    WriteOff wo = (WriteOff)bm;

                    monthRep.Afschrijvingen -= bm.GetCost();
                    ProductReport pr = monthRep.ProductReports.Find(new IsForProduct(wo.Product).Match);
                    if (pr != null)                        
                        pr.AmountWriteOff += wo.Amount;
                }
                else if (bm is StockAddition)
                {
                    monthRep.Inkopen += bm.GetCost();
                    monthRep.StockAdditions.Add(bm as StockAddition);
                }
                else if (bm is OtherBuys)
                {
                    monthRep.AndereInkopen += bm.GetCost();
                    monthRep.OtherBuys.Add(bm as OtherBuys);
                }
            }
            //MessageBox.Show("4");
            foreach (ProductReport pr in monthRep.ProductReports)
                monthRep.BrutoWinst += pr.GrossIncome;
            //MessageBox.Show("5");
            monthRep.NettoWinst += monthRep.BrutoWinst;
            monthRep.NettoWinst -= monthRep.Afschrijvingen;
            monthRep.NettoWinst -= monthRep.AndereInkopen;
            //MessageBox.Show("6");
            monthRep.Cash = monthRep.Inkomsten;
            monthRep.Cash -= monthRep.Afschrijvingen;
            monthRep.Cash -= monthRep.AndereInkopen;
            monthRep.Cash -= monthRep.Inkopen;
            monthRep.Cash -= monthRep.Uitstaand;
            //MessageBox.Show("7");
            return monthRep;
        }

        public class IsForProduct //inner class
        {
            private Product iProduct;

            public IsForProduct(Product p)
            {
                iProduct = p;
            }

            public bool Match(ProductReport pr)
            {
                return pr.Product.Equals(iProduct);
            }
        }
        public class IsForPerson //inner class
        {
            private Person iPerson;

            public IsForPerson(Person p)
            {
                iPerson = p;
            }

            public bool Match(PersonReport pr)
            {
                return pr.Owner.Equals(iPerson);
            }
        }
    }
}
