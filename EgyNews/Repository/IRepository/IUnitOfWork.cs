namespace EgyNews.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICategoryRepository Categories { get; }
        void SaveChanges();
    }
}
