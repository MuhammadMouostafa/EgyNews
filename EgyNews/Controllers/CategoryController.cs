using EgyNews.Data;
using EgyNews.Models;
using Microsoft.AspNetCore.Mvc;

namespace EgyNews.Controllers
{
    public class CategoryController : Controller
    {
        private ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var categories = _db.Categories.ToList();
            return View(categories);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category newCategory)
        {
            _db.Categories.Add(newCategory);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var category = _db.Categories.Find(id);
            if(category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            _db.Categories.Update(category);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var category = _db.Categories.Find(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }
        [HttpPost]
        public IActionResult Delete(Category category)
        {
            _db.Categories.Remove(category);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
