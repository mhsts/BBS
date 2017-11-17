using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace BBS.View.DataLists.DataItems
{
    public class ProductStockItem
    {
        private Product product;

        public ProductStockItem(Product p)
        {
            product = p;

            Name = product.Name;
            SellPrice = product.Price;
            BuyPrice = product.BuyPrice;
            Amount = product.Amount;
            DiscountType = Product.DiscountToString(product.Discount);
            BarCode = product.BarCode.Value ?? "";
            Active = product.Active;
            Category = product.Category;
        }

        public Product GetProduct()
        {
            return product;
        }

        [DisplayName("Naam")]
        public string Name { get; private set; }
        
        [DisplayName("Verkoop")]
        public decimal SellPrice { get; private set; }

        [DisplayName("Inkoop")]
        public decimal BuyPrice { get; private set; }

        [DisplayName("Aantal")]
        public int Amount { get; private set; }

        [DisplayName("Korting")]
        public string DiscountType { get; private set; }

        [DisplayName("Barcode")]
        public string BarCode { get; private set; }
        
        [DisplayName("Actief")]
        public bool Active { get; private set; }

        [DisplayName("Categorie")]
        public ProductCategory Category { get; private set; }
    }
}
