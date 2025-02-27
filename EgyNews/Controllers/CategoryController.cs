using EgyNews.Models;
using Microsoft.AspNetCore.Mvc;

namespace EgyNews.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            Category category = new Category();
            category.Id = 1;
            category.Name = "Category 1";


            return View(category);
        }
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}
