using EgyNews.Models;
using Microsoft.EntityFrameworkCore;

namespace EgyNews.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed initial data for Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Politics" },
                new Category { Id = 2, Name = "Technology" },
                new Category { Id = 3, Name = "Business And Economy" },
                new Category { Id = 4, Name = "Health & Science" },
                new Category { Id = 5, Name = "Sports" },
                new Category { Id = 6, Name = "Entertainment" }
            );

        }
    }
}
