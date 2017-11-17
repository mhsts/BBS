using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BBS
{
    [Serializable]
    public class Product : NamedObject
    {
        private Decimal price;
        private DiscountType discount;
        private int amount;
        private Decimal buyPrice;
        private BarCode barCode = new BarCode("(null)");
        private bool active = true;
        public int InternalCount;
        private ProductCategory category;

        #region Props

        public bool Active
        {
            get { return active; }
            set { active = value; }
        }

        public Decimal BuyPrice
        {
            get { return buyPrice; }
            set { buyPrice = value; }
        }
        public DiscountType Discount
        {
            get { return discount; }
            set { discount = value; }
        }
        public int Amount
        {
            get { return amount;}
            set { amount = value; }
        }

        public BarCode BarCode
        {
            get { return barCode; }
            set { barCode = value; }
        }

        public Decimal Price
        {
            get { return this.price; }
            set { price = value; }
        }
        public ProductCategory Category
        {
            get { return this.category; }
            set { category = value; }
        }
        #endregion

        public static String DiscountToString(DiscountType d)
        {
            switch (d)
            {
                case DiscountType.None:
                    return "";
                case DiscountType.DrieHalenTweeBetalen:
                    return "3 voor 2";
                case DiscountType.ElfHalenTienBetalen:
                    return "11 voor 10";
                default:
                    return "Onbekend";
            }
        }

        public void DeductStockAmount(int deductAmount)
        {
            amount -= deductAmount;
            InternalCount += deductAmount; //how often is this product bought (to sort in the buy list)

            if (amount <= 0 && Session.ShouldShowProductAmountWarnings)
                MessageBoxCreator.RaiseWarning(String.Format("Voorraad nul of negatief, werk bij!({0})", name));
        }

        public Product(string pName)
        {
            name = pName;
        }

        public Product(string pName, Decimal pPrice, Decimal pBuyPrice, BarCode pBarCode, DiscountType type, int pAmount, ProductCategory pCategory)
        {
            name = pName;
            price = pPrice;
            discount = type;
            buyPrice = pBuyPrice;
            amount = pAmount;
            barCode = pBarCode;
            category = pCategory;
        }

        public override bool Equals(Object other)
        {
            if (other is Product)
                if (((Product)other).Name.Equals(this.name))
                    return true;

            return false;
        }

        public virtual Decimal CalculateCost(int amount)
        {
            Decimal pp = amount * price;
            pp -= SpecialPrices.CalculateDiscount(discount, this, amount);
            return pp;
        }

        public override string ToString()
        {
            return String.Format("{0} ({1:0.00})", name, price);
        }

        internal string ToStockString()
        {
            return String.Format("{0} ({1:0.00})({2:0.00}) {3} {4}", name, price, buyPrice, amount, barCode.Value);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

}
