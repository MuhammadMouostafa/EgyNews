using EgyNews.Data;
using EgyNews.Repository.IRepository;

namespace EgyNews.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public ICategoryRepository Categories { get; private set; }
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Categories = new CategoryRepository(_db);
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
