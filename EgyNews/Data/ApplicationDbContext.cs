using EgyNews.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EgyNews.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
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

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Name = "Blogger", NormalizedName = "BLOGGER" },
                new IdentityRole { Name = "Reader", NormalizedName = "READER" }
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
                new Article { Id = 13, Title = "Diplomatic Talks Between Nations", Content = "High-level diplomatic talks have begun between two neighboring countries...", PublishDate = DateTime.Now.AddDays(-3), CategoryId = 1, ImageUrl = "https://picsum.photos/600/400?random=13" },
                new Article { Id = 14, Title = "New Legislation on Climate Change", Content = "A new bill aimed at combating climate change has been introduced...", PublishDate = DateTime.Now.AddDays(-4), CategoryId = 1, ImageUrl = "https://picsum.photos/600/400?random=14" },
                new Article { Id = 15, Title = "Political Scandal Unveiled", Content = "A major political scandal has been uncovered, involving high-ranking officials...", PublishDate = DateTime.Now.AddDays(-5), CategoryId = 1, ImageUrl = "https://picsum.photos/600/400?random=15" },

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
                new Article { Id = 16, Title = "Quantum Computing Advancements", Content = "A breakthrough in quantum computing has been achieved...", PublishDate = DateTime.Now.AddDays(-6), CategoryId = 2, ImageUrl = "https://picsum.photos/600/400?random=16" },
                new Article { Id = 17, Title = "Cybersecurity Threats on the Rise", Content = "Experts warn of increasing cybersecurity threats...", PublishDate = DateTime.Now.AddDays(-7), CategoryId = 2, ImageUrl = "https://picsum.photos/600/400?random=17" },
                new Article { Id = 18, Title = "New Smart Home Devices", Content = "Tech companies have introduced a range of new smart home devices...", PublishDate = DateTime.Now.AddDays(-8), CategoryId = 2, ImageUrl = "https://picsum.photos/600/400?random=18" },
                new Article { Id = 19, Title = "The Future of Autonomous Vehicles", Content = "Autonomous vehicles are set to revolutionize transportation...", PublishDate = DateTime.Now.AddDays(-9), CategoryId = 2, ImageUrl = "https://picsum.photos/600/400?random=19" },

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
                new Article { Id = 20, Title = "Global Economic Growth Forecast", Content = "The IMF has released its latest global economic growth forecast...", PublishDate = DateTime.Now.AddDays(-10), CategoryId = 3, ImageUrl = "https://picsum.photos/600/400?random=20" },
                new Article { Id = 21, Title = "Startups to Watch in 2023", Content = "A list of promising startups that are making waves...", PublishDate = DateTime.Now.AddDays(-11), CategoryId = 3, ImageUrl = "https://picsum.photos/600/400?random=21" },
                new Article { Id = 22, Title = "Impact of Inflation on Consumers", Content = "Rising inflation is affecting consumer spending habits...", PublishDate = DateTime.Now.AddDays(-12), CategoryId = 3, ImageUrl = "https://picsum.photos/600/400?random=22" },
                new Article { Id = 23, Title = "New Trade Agreements Signed", Content = "Several countries have signed new trade agreements...", PublishDate = DateTime.Now.AddDays(-13), CategoryId = 3, ImageUrl = "https://picsum.photos/600/400?random=23" },
                new Article { Id = 24, Title = "The Rise of Remote Work", Content = "Remote work is becoming the new norm for many businesses...", PublishDate = DateTime.Now.AddDays(-14), CategoryId = 3, ImageUrl = "https://picsum.photos/600/400?random=24" },

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
                new Article { Id = 25, Title = "Advances in Gene Therapy", Content = "Gene therapy is showing promise in treating genetic disorders...", PublishDate = DateTime.Now.AddDays(-15), CategoryId = 4, ImageUrl = "https://picsum.photos/600/400?random=25" },
                new Article { Id = 26, Title = "The Benefits of Meditation", Content = "Studies show that meditation can improve mental health...", PublishDate = DateTime.Now.AddDays(-16), CategoryId = 4, ImageUrl = "https://picsum.photos/600/400?random=26" },
                new Article { Id = 27, Title = "New Discoveries in Space Exploration", Content = "Astronomers have made new discoveries in space...", PublishDate = DateTime.Now.AddDays(-17), CategoryId = 4, ImageUrl = "https://picsum.photos/600/400?random=27" },
                new Article { Id = 28, Title = "The Future of Vaccines", Content = "Researchers are developing new vaccine technologies...", PublishDate = DateTime.Now.AddDays(-18), CategoryId = 4, ImageUrl = "https://picsum.photos/600/400?random=28" },
                new Article { Id = 29, Title = "Mental Health Awareness Campaign", Content = "A new campaign aims to raise awareness about mental health...", PublishDate = DateTime.Now.AddDays(-19), CategoryId = 4, ImageUrl = "https://picsum.photos/600/400?random=29" },
                new Article { Id = 30, Title = "Breakthrough in Renewable Energy", Content = "Scientists have developed a new renewable energy source...", PublishDate = DateTime.Now.AddDays(-20), CategoryId = 4, ImageUrl = "https://picsum.photos/600/400?random=30" },

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
                new Article { Id = 31, Title = "Olympic Games 2024 Preparations", Content = "Preparations for the 2024 Olympic Games are underway...", PublishDate = DateTime.Now.AddDays(-21), CategoryId = 5, ImageUrl = "https://picsum.photos/600/400?random=31" },
                new Article { Id = 32, Title = "Rising Stars in Tennis", Content = "Young tennis players are making a name for themselves...", PublishDate = DateTime.Now.AddDays(-22), CategoryId = 5, ImageUrl = "https://picsum.photos/600/400?random=32" },
                new Article { Id = 33, Title = "The Evolution of Basketball", Content = "Basketball has evolved significantly over the years...", PublishDate = DateTime.Now.AddDays(-23), CategoryId = 5, ImageUrl = "https://picsum.photos/600/400?random=33" },
                new Article { Id = 34, Title = "Esports: The New Frontier", Content = "Esports is gaining popularity as a competitive sport...", PublishDate = DateTime.Now.AddDays(-24), CategoryId = 5, ImageUrl = "https://picsum.photos/600/400?random=34" },
                new Article { Id = 35, Title = "The Impact of Sports on Mental Health", Content = "Sports can have a positive impact on mental health...", PublishDate = DateTime.Now.AddDays(-25), CategoryId = 5, ImageUrl = "https://picsum.photos/600/400?random=35" },
                new Article { Id = 36, Title = "New Rules in Football", Content = "Football's governing body has introduced new rules...", PublishDate = DateTime.Now.AddDays(-26), CategoryId = 5, ImageUrl = "https://picsum.photos/600/400?random=36" },
                new Article { Id = 37, Title = "The Rise of Women in Sports", Content = "Women are breaking barriers in the world of sports...", PublishDate = DateTime.Now.AddDays(-27), CategoryId = 5, ImageUrl = "https://picsum.photos/600/400?random=37" },

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
                },
                new Article { Id = 38, Title = "The Future of Streaming Services", Content = "Streaming services are changing the entertainment industry...", PublishDate = DateTime.Now.AddDays(-28), CategoryId = 6, ImageUrl = "https://picsum.photos/600/400?random=38" },
                new Article { Id = 39, Title = "Upcoming Music Festivals", Content = "A list of the most anticipated music festivals of the year...", PublishDate = DateTime.Now.AddDays(-29), CategoryId = 6, ImageUrl = "https://picsum.photos/600/400?random=39" },
                new Article { Id = 40, Title = "The Impact of Social Media on Entertainment", Content = "Social media is reshaping how we consume entertainment...", PublishDate = DateTime.Now.AddDays(-30), CategoryId = 6, ImageUrl = "https://picsum.photos/600/400?random=40" },
                new Article { Id = 41, Title = "New Broadway Shows to Watch", Content = "Broadway is back with a lineup of exciting new shows...", PublishDate = DateTime.Now.AddDays(-31), CategoryId = 6, ImageUrl = "https://picsum.photos/600/400?random=41" },
                new Article { Id = 42, Title = "The Rise of Independent Films", Content = "Independent films are gaining recognition in the industry...", PublishDate = DateTime.Now.AddDays(-32), CategoryId = 6, ImageUrl = "https://picsum.photos/600/400?random=42" },
                new Article { Id = 43, Title = "Celebrity Fashion Trends", Content = "Celebrities are setting new fashion trends this season...", PublishDate = DateTime.Now.AddDays(-33), CategoryId = 6, ImageUrl = "https://picsum.photos/600/400?random=43" },
                new Article { Id = 44, Title = "The Evolution of Video Games", Content = "Video games have come a long way since their inception...", PublishDate = DateTime.Now.AddDays(-34), CategoryId = 6, ImageUrl = "https://picsum.photos/600/400?random=44" }
            );
        }
    }
}
