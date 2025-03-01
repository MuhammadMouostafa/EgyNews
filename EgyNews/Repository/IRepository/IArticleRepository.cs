using System.Linq.Expressions;
using EgyNews.Models;

namespace EgyNews.Repository.IRepository
{
    public interface IArticleRepository
    {
        IEnumerable<Article> GetAll();
        Article GetById(int id);

        Article Get(Expression<Func<Article, bool>> filter, string? includeProperties = null);
        void Add(Article article);
        void Update(Article article);
        void Delete(int id);
    }
}
