using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PavolsProductShop.Models;

namespace PavolsProductShop.Controllers
{
  public class ProductController : Controller
  {
    public IActionResult Detail(string slugLink)
    {
      Product product = DataBase.GetProduct(slugLink);
      return View(product);
    }

    public IActionResult List()
    {
      List<Product> products = DataBase.GetProducts();
      return View(products);
    }
  }
}
