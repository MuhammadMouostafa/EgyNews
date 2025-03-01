using System.Linq.Expressions;
using EgyNews.Data;
using EgyNews.Models;
using EgyNews.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace EgyNews.Repository
{
    public class ArticleRepository : IArticleRepository
    {
        private ApplicationDbContext _db;

        public ArticleRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public IEnumerable<Article> GetAll()
        {
            return _db.Articles.Include(a => a.Category).ToList();
        }

        public Article GetById(int id)
        {
            return _db.Articles.Include(a => a.Category)
                .FirstOrDefault(a => a.Id == id);
        }

        public void Add(Article article)
        {
            _db.Articles.Add(article);
        }

        public void Update(Article article)
        {
            _db.Articles.Update(article);
        }

        public void Delete(int id)
        {
            var article = _db.Articles.Find(id);
            if (article == null)
            {
                throw new ArgumentException("Article not found");
            }
            _db.Articles.Remove(article);
        }

        public Article Get(Expression<Func<Article, bool>> filter, string? includeProperties = null)
        {
            IQueryable<Article> query = _db.Articles;
            query = query.Where(filter);
            if (!string.IsNullOrWhiteSpace(includeProperties))
            {
                foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }
            return query.FirstOrDefault();
        }
    }
}
