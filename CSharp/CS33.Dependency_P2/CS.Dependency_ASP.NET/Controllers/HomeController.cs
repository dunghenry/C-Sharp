using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CS.Dependency_ASP.NET.Models;

namespace CS.Dependency_ASP.NET.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ProductServices _productService;

        public HomeController(ILogger<HomeController> logger, ProductServices productService)
        {
            _logger = logger;
            _productService = productService;
        }
        public IActionResult ProductInfo(string productID){
            Console.WriteLine(productID);
            var product = _productService.FindProduct(productID);
            return View(product);
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
