using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BBS
{
    [Serializable]
    public class StockAddition : BarMutation
    {
        private Product product;
        int amount;

        public StockAddition(Product p, int a)
        {
            amount = a;
            product = p;
            cost = p.BuyPrice * amount;

            //do it:
            product.Amount += a;
        }

        public Product Product
        {
            get
            {
                return product;
            }
        }

        public int Amount
        {
            get
            {
                return amount;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format("Aanvulling van {0} met {1}", product.Name, amount));
            sb.Append(Environment.NewLine);
            return sb.ToString();
        }
    }
}
