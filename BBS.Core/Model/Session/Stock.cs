using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BBS
{
public static class Stock
{
    private static List<Product> products = new List<Product>();

    public static List<Product> Products
	{
        get
        {
            return products;
        }
        set
        {
            products = value;
        }
	}

    public static Product GetProduct(String productName)
	{
		foreach(Product p in products)
            if (p.Name.Equals(productName))
				return p;
		return null;
	}
	
	public static Product GetProduct(BarCode bc)
	{
        foreach (Product p in products)
            if (p.BarCode.Equals(bc))
                return p;
        return null;
	}
		
	static Stock()
	{
		//LoadProducts();
		//TEMP:
		products.Add(new Product("Bier", 0.60m, 0.49m, new BarCode("321920"),DiscountType.ElfHalenTienBetalen,64,ProductCategory.Bier));
		products.Add(new Product("Cola", 0.30m, 0.25m, new BarCode("423143"),DiscountType.None,64,ProductCategory.Fris));
        products.Add(new Product("Dr Pepper", 0.30m, 0.25m, new BarCode("423143"), DiscountType.None, 64, ProductCategory.Fris));
        products.Add(new Product("Fanta", 0.30m, 0.25m, new BarCode("543244"), DiscountType.None, 64, ProductCategory.Fris));
        products.Add(new Product("Chips", 0.60m, 0.56m, new BarCode("967657"), DiscountType.None, 64, ProductCategory.Chips));
	}
 
    public static bool ExistsProductWithName(string input)
    {
        foreach (Product p in products)
            if (p.Name.Equals(input))
                return true;
        return false;
    }

    public static void AddProduct(Product p)
    {
        Products.Add(p);
    }

    public static Product FindProduct(BarCode barcode)
    {
        foreach (Product p in products)
            if (p.BarCode.Equals(barcode))
                return p;
        return null;
    }

    public static bool RemoveProduct(Product targetProduct)
    {
        Person currentUser = Session.GetCurrentUser();

        if (currentUser == null || !currentUser.IsAdmin())
            return false;

        return products.Remove(targetProduct);
    }
}
}
