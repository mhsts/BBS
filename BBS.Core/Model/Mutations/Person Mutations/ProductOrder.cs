using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BBS
{
    [Serializable]
    public class ProductOrder
    {
        private Product product;
        private int amount;
        private Decimal cost;

        public ProductOrder(Product p)
        {
            product = p;
        }

        public void AddAmount(int a)
        {
            this.amount += a;
            cost = product.CalculateCost(amount);
        }

        public void SetAmount(int a)
        {
            amount = a;
            cost = product.CalculateCost(amount);
        }

        public int GetAmount()
        {
            return amount;
        }

        public int GetUnpaidAmount()
        {
            return SpecialPrices.GetNumFree(this.product.Discount, amount);
        }

        public Decimal GetCost()
        {
            return this.cost;
        }

        public override string ToString()
        {
            return String.Format("  {1}x {0} (= {2:0.00} euro){3}", product.ToString(), amount, cost, Environment.NewLine);
        }

        public Product GetProduct()
        {
            return product;
        }

        public string ToFriendlyString()
        {
            return String.Format("{0}x {1}",amount,product.Name);
        }
    }

}
