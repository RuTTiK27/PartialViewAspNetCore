using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PartialViewAspNetCore.Models;

namespace PartialViewAspNetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Products()
        {
            List<Product> products = new List<Product>
            {
                new Product { Id = 1,Name="Bag",Description="Description for Bag",Price=1000,Image="~/Images/bag.jpg" },
                new Product { Id = 2,Name="Camera",Description="Description for Camera",Price=45000,Image="~/Images/camera.jpg" },
                new Product { Id = 3,Name="Glass",Description="Description for Glass",Price=250,Image="~/Images/glass.jpg" }
            };
            return View(products);
        }
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
