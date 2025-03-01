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
        public DbSet<Article> Articles { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed initial data for Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Politics" },
                new Category { Id = 2, Name = "Technology" },
                new Category { Id = 3, Name = "Business And Economy" },
                new Category { Id = 4, Name = "Health And Science" },
                new Category { Id = 5, Name = "Sports" },
                new Category { Id = 6, Name = "Entertainment" }
            );

            // Seed initial data for Articles
            modelBuilder.Entity<Article>().HasData(
                // Articles for Politics
                new Article
                {
                    Id = 1,
                    Title = "New Government Policies Announced",
                    Content = "The government has announced a series of new policies aimed at boosting the economy and reducing unemployment. These policies include tax cuts for small businesses, increased funding for education, and infrastructure development projects. Experts believe these measures could stimulate economic growth, but critics argue that they may lead to a higher national debt. The policies are expected to be implemented over the next two years.",
                    PublishDate = DateTime.Now.AddDays(-2),
                    CategoryId = 1,
                    ImageUrl = "https://picsum.photos/600/400?random=1"
                },
                new Article
                {
                    Id = 2,
                    Title = "Election Results Declared",
                    Content = "The results of the national elections have been declared, with the incumbent party securing a narrow victory. The opposition has raised concerns about alleged irregularities in the voting process, but international observers have declared the elections free and fair. The new government is expected to focus on healthcare reform and climate change initiatives in its first term.",
                    PublishDate = DateTime.Now.AddDays(-1),
                    CategoryId = 1,
                    ImageUrl = "https://picsum.photos/600/400?random=2"
                },

                // Articles for Technology
                new Article
                {
                    Id = 3,
                    Title = "New AI Breakthrough",
                    Content = "Researchers have developed a new AI model capable of predicting weather patterns with 95% accuracy. This breakthrough could revolutionize industries such as agriculture, aviation, and disaster management. The AI uses advanced machine learning algorithms to analyze vast amounts of meteorological data. Experts believe this technology could save billions of dollars annually by improving weather forecasting.",
                    PublishDate = DateTime.Now.AddDays(-3),
                    CategoryId = 2,
                    ImageUrl = "https://picsum.photos/600/400?random=3"
                },
                new Article
                {
                    Id = 4,
                    Title = "Apple Launches New iPhone",
                    Content = "Apple has unveiled its latest iPhone, featuring a revolutionary camera system and enhanced battery life. The new model also includes a faster processor and improved security features. Tech enthusiasts are excited about the device, which is expected to set new standards in the smartphone industry. Pre-orders for the iPhone have already broken records, with millions of units sold within the first 24 hours.",
                    PublishDate = DateTime.Now.AddDays(-4),
                    CategoryId = 2,
                    ImageUrl = "https://picsum.photos/600/400?random=4"
                },

                // Articles for Business And Economy
                new Article
                {
                    Id = 5,
                    Title = "Stock Market Hits All-Time High",
                    Content = "The stock market has reached an all-time high, driven by strong corporate earnings and positive economic data. Investors are optimistic about the future, with many expecting further gains in the coming months. However, some analysts warn that the market may be overvalued and could be due for a correction. Despite these concerns, the bullish trend shows no signs of slowing down.",
                    PublishDate = DateTime.Now.AddDays(-5),
                    CategoryId = 3,
                    ImageUrl = "https://picsum.photos/600/400?random=5"
                },
                new Article
                {
                    Id = 6,
                    Title = "New Tax Reforms Announced",
                    Content = "The government has introduced new tax reforms aimed at boosting small businesses and stimulating economic growth. The reforms include lower corporate tax rates, simplified filing procedures, and incentives for innovation. Small business owners have welcomed the changes, which they say will reduce their financial burden and encourage expansion. Critics, however, argue that the reforms may lead to a reduction in public services.",
                    PublishDate = DateTime.Now.AddDays(-6),
                    CategoryId = 3,
                    ImageUrl = "https://picsum.photos/600/400?random=6"
                },

                // Articles for Health And Science
                new Article
                {
                    Id = 7,
                    Title = "Breakthrough in Cancer Research",
                    Content = "Scientists have made a significant breakthrough in cancer research, discovering a new treatment that targets cancer cells without harming healthy tissue. The treatment, which uses a combination of immunotherapy and gene editing, has shown promising results in early clinical trials. Researchers believe this could lead to a cure for certain types of cancer within the next decade.",
                    PublishDate = DateTime.Now.AddDays(-7),
                    CategoryId = 4,
                    ImageUrl = "https://picsum.photos/600/400?random=7"
                },
                new Article
                {
                    Id = 8,
                    Title = "New COVID-19 Variant Detected",
                    Content = "A new variant of COVID-19 has been detected, raising concerns among health officials. The variant appears to be more contagious than previous strains, but early data suggests that existing vaccines remain effective. Governments around the world are monitoring the situation closely and considering additional measures to prevent the spread of the virus.",
                    PublishDate = DateTime.Now.AddDays(-8),
                    CategoryId = 4,
                    ImageUrl = "https://picsum.photos/600/400?random=8"
                },

                // Articles for Sports
                new Article
                {
                    Id = 9,
                    Title = "World Cup 2023 Highlights",
                    Content = "The World Cup 2023 has kicked off with thrilling matches and unexpected results. Fans around the world are glued to their screens as their favorite teams compete for the prestigious trophy. The tournament has already seen several upsets, with underdog teams defeating traditional powerhouses. The excitement is expected to build as the competition progresses.",
                    PublishDate = DateTime.Now.AddDays(-9),
                    CategoryId = 5,
                    ImageUrl = "https://picsum.photos/600/400?random=9"
                },
                new Article
                {
                    Id = 10,
                    Title = "New Record in Marathon",
                    Content = "An athlete has set a new world record in the marathon, finishing the race in under two hours. The incredible feat has stunned the sports world and raised questions about the limits of human endurance. The runner credited their success to a rigorous training regimen and a focus on mental preparation. The record is expected to stand for years to come.",
                    PublishDate = DateTime.Now.AddDays(-10),
                    CategoryId = 5,
                    ImageUrl = "https://picsum.photos/600/400?random=10"
                },

                // Articles for Entertainment
                new Article
                {
                    Id = 11,
                    Title = "New Marvel Movie Release",
                    Content = "The latest Marvel movie has broken box office records on its opening weekend, grossing over $500 million worldwide. Fans have praised the film for its stunning visuals, gripping storyline, and standout performances. The movie is expected to dominate the box office for weeks to come and has already sparked speculation about future sequels and spin-offs.",
                    PublishDate = DateTime.Now.AddDays(-11),
                    CategoryId = 6,
                    ImageUrl = "https://picsum.photos/600/400?random=11"
                },
                new Article
                {
                    Id = 12,
                    Title = "Grammy Awards 2023 Winners",
                    Content = "The Grammy Awards 2023 saw some surprising wins and memorable performances. Artists from various genres were honored for their contributions to music, with several newcomers taking home major awards. The event was a celebration of creativity and diversity, showcasing the best of the music industry. Fans are already looking forward to next year's ceremony.",
                    PublishDate = DateTime.Now.AddDays(-12),
                    CategoryId = 6,
                    ImageUrl = "https://picsum.photos/600/400?random=12"
                }
            );
        }
    }
}
