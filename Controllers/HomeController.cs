using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ViewData.Models;

namespace ViewData.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var Data = new List<Product>
            {
                new Product {ID = 1, Name = "เสื้อกล้าม", Price = 39},
                new Product {ID = 2, Name = "เสื้อคอกลม", Price = 59},
                new Product {ID = 3, Name = "เสื้อคอกลมแขนยาว", Price = 79},
                new Product {ID = 4, Name = "เสื้อกล้ามพิมพ์ลาย", Price = 100},
                new Product {ID = 5, Name = "เสื้อคอกลมพิมพ์ลาย", Price = 160},
                new Product {ID = 6, Name = "เสื้อคอกลมแขนยาวพิมพ์ลาย", Price = 180},
            };

            ViewData["ProductList"] = Data;//อาศัย class ViewData ในการแสดงผล (ProductList เป็นชื่อไว้เก็บข้อมูล)
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
