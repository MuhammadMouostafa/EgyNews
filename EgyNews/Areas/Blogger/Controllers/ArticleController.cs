using EgyNews.Data;
using EgyNews.Models;
using EgyNews.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EgyNews.Areas.Blogger.Controllers
{
    [Area("Blogger")]
    [Authorize(Roles = "Blogger,Admin")]
    public class ArticleController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ArticleController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            var categories = _unitOfWork.Articles.GetAll();
            return View(categories);
        }

        public IActionResult Upsert(int? id)
        {
            ViewBag.Categories = _unitOfWork.Categories.GetAll()
                .Select(c => new SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.Name
                })
                .ToList();

            if (id != null && id != 0)
            {
                return View(_unitOfWork.Articles.Get(u => u.Id == id));
            }
                
            return View(new Article());
        }

        [HttpPost]
        public IActionResult Upsert(Article article, IFormFile? imageFile)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                if (imageFile != null)
                {
                    string filename = Guid.NewGuid().ToString() + Path.GetExtension(imageFile.FileName);
                    string articlePaht = Path.Combine(wwwRootPath, @"images\article");

                    if (!string.IsNullOrEmpty(article.ImageUrl))
                    {
                        var oldImagePath = Path.Combine(wwwRootPath, article.ImageUrl);

                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }

                    using (var fileStream = new FileStream(Path.Combine(articlePaht, filename), FileMode.Create))
                    {
                        imageFile.CopyTo(fileStream);
                    }

                    article.ImageUrl = @"\images\article\" + filename;
                }
                else
                {
                    if (article.Id == 0)
                    {
                        ViewBag.Categories = _unitOfWork.Categories.GetAll()
                        .Select(c => new SelectListItem
                        {
                            Value = c.Id.ToString(),
                            Text = c.Name
                        })
                        .ToList();
                        TempData["Error"] = "Failed to create article without uploading image";
                        return View(article);
                    }
                }
                if (article.Id == 0)
                {
                    _unitOfWork.Articles.Add(article);
                }
                else
                {
                    _unitOfWork.Articles.Update(article);
                }
                _unitOfWork.SaveChanges();
                TempData["Success"] = article.Id == 0 ? "Article created successfully" : "Article updated successfully";
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Categories = _unitOfWork.Categories.GetAll()
                .Select(c => new SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.Name
                })
                .ToList();
            TempData["Error"] = article.Id == 0 ? "Failed to create article" : "Failed to update article";
            return View(article);
        }


        public IActionResult Delete(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var article = _unitOfWork.Articles.GetById(id);
            if (article == null)
            {
                return NotFound();
            }
            return View(article);
        }
        [HttpPost]
        public IActionResult Delete(Article article)
        {
            _unitOfWork.Articles.Delete(article.Id);
            _unitOfWork.SaveChanges();
            TempData["Success"] = "Article deleted successfully";
            return RedirectToAction(nameof(Index));
        }
    }
}
