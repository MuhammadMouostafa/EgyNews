﻿using EgyNews.Data;
using EgyNews.Models;
using EgyNews.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EgyNews.Areas.Blogger.Controllers
{
    [Area("Blogger")]
    public class ArticleController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ArticleController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
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
        public IActionResult Upsert(Article article)
        {
            if (article.Id == 0)
            {
                _unitOfWork.Articles.Add(article);
            }
            else
            {
                _unitOfWork.Articles.Update(article);
            }
            _unitOfWork.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Edit(Article article)
        {
            _unitOfWork.Articles.Update(article);
            _unitOfWork.SaveChanges();
            return RedirectToAction(nameof(Index));
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
            return RedirectToAction(nameof(Index));
        }
    }
}
