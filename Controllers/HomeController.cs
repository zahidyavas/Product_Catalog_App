using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Product_Catalog_App.Models;

namespace Product_Catalog_App.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string searchString)
        {
            var products = Repository.Products;
            if(!String.IsNullOrEmpty(searchString))
            {
                ViewBag.SearchString = searchString;
                products = products.Where(p => p.Name!.ToLower().Contains(searchString)).ToList();
            }
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
