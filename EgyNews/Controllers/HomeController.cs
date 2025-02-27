using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Globalization;
using EgyNews.Models;
using Microsoft.AspNetCore.Mvc;

namespace EgyNews.Controllers
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

            
            var Numbers = new List<int>() { 1, 2, 3, 4 };

            ViewBag.NumbersList = Numbers;
            ViewData["NumbersList"] = Numbers;
            TempData["NumbersList"] = Numbers;


            return View();
            //return RedirectToAction("Privacy"); 
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
