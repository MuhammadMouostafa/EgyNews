using EgyNews.Data;
using EgyNews.Models;
using EgyNews.Repository.IRepository;

namespace EgyNews.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public void Add(Category category)
        {
            _db.Categories.Add(category);
        }

        public void Delete(int id)
        {
            var category = _db.Categories.Find(id);
            if (category == null)
            {
                throw new ArgumentException("Category not found");
            }
            _db.Categories.Remove(category);
        }

        public IEnumerable<Category> GetAll()
        {
            return _db.Categories.ToList();
        }

        public Category GetById(int id)
        {
            return _db.Categories.Find(id);
        }

        public void Update(Category category)
        {
            _db.Categories.Update(category);
        }
    }
}
