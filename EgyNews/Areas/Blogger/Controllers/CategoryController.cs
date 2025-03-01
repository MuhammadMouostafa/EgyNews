using EgyNews.Data;
using EgyNews.Models;
using EgyNews.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace EgyNews.Areas.Blogger.Controllers
{
    [Area("Blogger")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            var categories = _unitOfWork.Categories.GetAll();
            return View(categories);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category newCategory)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Categories.Add(newCategory);
                _unitOfWork.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(newCategory);
        }

        public IActionResult Edit(int id)
        {
            var category = _unitOfWork.Categories.GetById(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Categories.Update(category);
                _unitOfWork.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        public IActionResult Delete(int id)
        {
            var category = _unitOfWork.Categories.GetById(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }
        [HttpPost]
        public IActionResult Delete(Category category)
        {
            _unitOfWork.Categories.Delete(category.Id);
            _unitOfWork.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
