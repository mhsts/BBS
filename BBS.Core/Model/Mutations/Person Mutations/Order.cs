using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace BBS
{
    [Serializable]
    public class Order : Mutation
    {
        private List<ProductOrder> productOrders = new List<ProductOrder>();

        public List<ProductOrder> ProductOrders
        {
            get
            {
                return productOrders;
            }
            set
            {
                productOrders = value;
            }
        }

        public Order(Person p)
        {
            this.owner = p;
        }

        public void AddProductOrder(ProductOrder po)
        {
            ProductOrder alreadyInOrder = null;

            foreach (ProductOrder orderPO in productOrders)
            {
                if (orderPO.GetProduct().Equals(po.GetProduct()))
                {
                    alreadyInOrder = orderPO;
                    break;
                }
            }

            if (alreadyInOrder != null)
            {
                alreadyInOrder.AddAmount(po.GetAmount());
                this.cost = this.GetCost(); //recalculate
            }
            else
            {
                productOrders.Add(po);
                this.cost += po.GetCost();
            }
        }

        public override Decimal GetCostAndCommit()
        {
            foreach (ProductOrder po in productOrders) //adjust stock amounts
                po.GetProduct().DeductStockAmount(po.GetAmount());

            return base.GetCostAndCommit();
        }

        public override Decimal GetCost()
        {
            cost = 0m;
            foreach (ProductOrder po in productOrders)
                cost += po.GetCost();
            return cost;
        }

        public string ToShortString()
        {
            return String.Format("Bestelling van {0}, totaal: {1:0.00}", owner.Name, GetCost());
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format("Bestelling van {0} op {2}, totaal: {1:0.00} :", owner.Name, GetCost(), timestamp.ToString("dddd dd-MM-yy",CultureInfo.CreateSpecificCulture("nl-NL"))));
            sb.Append(Environment.NewLine);
            foreach (ProductOrder po in productOrders)
                sb.Append(po.ToString());
            return sb.ToString();
        }

        public void RemoveProductOrder(ProductOrder productOrder)
        {
            if (!productOrders.Remove(productOrder))
                MessageBoxCreator.RaiseWarning("Fout bij weghalen order.");
        }
    }
}
