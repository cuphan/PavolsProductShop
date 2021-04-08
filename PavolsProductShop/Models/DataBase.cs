using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PavolsProductShop.Models
{
  public class DataBase
  {
    public static List<Product> GetProducts()
    {
      List<Product> products = new List<Product>
      {
        new Product
        {
          ProductID = 1,
          Name = "Product 1",
          Price = (decimal) 499.00
        },
        new Product
        {
          ProductID = 2,
          Name = "Best Product Ever",
          Price = (decimal) 1109.00
        },
        new Product
        {
            ProductID = 3,
            Name = "Third Product",
            Price = (decimal)2017.00
        },
        new Product
        {
            ProductID = 4,
            Name = "Worst Product Ever",
            Price = (decimal)1480.99
        },
        new Product
        {
            ProductID = 5,
            Name = "Some other Product",
            Price = (decimal)290.00
        },
        new Product
        {
            ProductID = 6,
            Name = "Sitxh Product",
            Price = (decimal)405.00
        },
        new Product
        {
            ProductID = 7,
            Name = "Still Another Product",
            Price = (decimal)899.99
        },
        new Product
        {
            ProductID = 8,
            Name = "Product Of the Month",
            Price = (decimal)1499.99
        },
        new Product
        {
            ProductID = 9,
            Name = "Nineth Product",
            Price = (decimal)69.99
        },
        new Product
        {
            ProductID = 10,
            Name = "Final Product",
            Price = (decimal)99.99
        }
      };
      return products;
    }

    public static Product GetProduct(string slug)
    {
      List<Product> products = DataBase.GetProducts();
      foreach(Product p in products)
      {
        if (p.Slug == slug)
        {
          return p;
        }
      }
      return null;
    }
  }
}
