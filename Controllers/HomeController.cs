using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Product_Catalog_App.Models;

namespace Product_Catalog_App.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(Repository.Products);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
