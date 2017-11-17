using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BBS
{
    [Serializable]
    public class WriteOff : BarMutation
    {
        private Product product;
        private int amount;

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

        public WriteOff(Product p, int a)
        {
            owner = Session.GetCurrentUser();
            product = p;
            amount = a;
            cost = product.BuyPrice * amount;

            //do it:
            product.Amount -= a;
        }
    }
}
