using System.Diagnostics;
using EgyNews.Models;
using EgyNews.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace EgyNews.Areas.Reader.Controllers
{
    [Area("Reader")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var categories = _unitOfWork.Categories.GetAll().ToList();
            int x = categories.First().Id;
            return View(categories);
        }

        public IActionResult ArticlesByCategory(int categoryId)
        {
            var category = _unitOfWork.Categories.GetById(categoryId);
            if (category == null)
            {
                return NotFound();
            }

            var articles = _unitOfWork.Articles.GetAllByCategory(categoryId);

            ViewBag.CategoryName = category.Name;
            return PartialView("_ArticlesCard", articles);
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
