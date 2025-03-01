namespace EgyNews.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICategoryRepository Categories { get; }
        IArticleRepository Articles { get; }
        void SaveChanges();
    }
}
