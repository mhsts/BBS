using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BBS
{
    public class ProductReport
    {
        private Product innerProduct;
        private Decimal grossIncome;
        private int amount;
        private int amountWriteOff;
        private int numFree;

        public int NumFree
        {
            get
            {
                return numFree;
            }
            set
            {
                numFree = value;
            }
        }

        public ProductReport(Product p)
        {
            innerProduct = p;
        }

        public Product Product
        {
            get
            {
                return innerProduct;
            }
        }

        public Decimal GrossIncome
        {
            get
            {
                return grossIncome;
            }
            set
            {
                grossIncome = value;
            }
        }

        public int Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
            }
        }
        public int AmountWriteOff
        {
            get
            {
                return amountWriteOff;
            }
            set
            {
                amountWriteOff = value;
            }
        }
        public Decimal AmountWriteOffCost
        {
            get
            {
                return amountWriteOff * innerProduct.BuyPrice;
            }
        }
    }
}
