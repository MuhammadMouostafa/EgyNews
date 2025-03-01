using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EgyNews.Migrations
{
    /// <inheritdoc />
    public partial class insertArticles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "ImageUrl", "PublishDate", "Title" },
                values: new object[,]
                {
                    { 1, 1, "The government has announced a series of new policies aimed at boosting the economy and reducing unemployment. These policies include tax cuts for small businesses, increased funding for education, and infrastructure development projects. Experts believe these measures could stimulate economic growth, but critics argue that they may lead to a higher national debt. The policies are expected to be implemented over the next two years.", "https://picsum.photos/600/400?random=1", new DateTime(2025, 2, 27, 1, 2, 45, 168, DateTimeKind.Local).AddTicks(1365), "New Government Policies Announced" },
                    { 2, 1, "The results of the national elections have been declared, with the incumbent party securing a narrow victory. The opposition has raised concerns about alleged irregularities in the voting process, but international observers have declared the elections free and fair. The new government is expected to focus on healthcare reform and climate change initiatives in its first term.", "https://picsum.photos/600/400?random=2", new DateTime(2025, 2, 28, 1, 2, 45, 168, DateTimeKind.Local).AddTicks(1416), "Election Results Declared" },
                    { 3, 2, "Researchers have developed a new AI model capable of predicting weather patterns with 95% accuracy. This breakthrough could revolutionize industries such as agriculture, aviation, and disaster management. The AI uses advanced machine learning algorithms to analyze vast amounts of meteorological data. Experts believe this technology could save billions of dollars annually by improving weather forecasting.", "https://picsum.photos/600/400?random=3", new DateTime(2025, 2, 26, 1, 2, 45, 168, DateTimeKind.Local).AddTicks(1419), "New AI Breakthrough" },
                    { 4, 2, "Apple has unveiled its latest iPhone, featuring a revolutionary camera system and enhanced battery life. The new model also includes a faster processor and improved security features. Tech enthusiasts are excited about the device, which is expected to set new standards in the smartphone industry. Pre-orders for the iPhone have already broken records, with millions of units sold within the first 24 hours.", "https://picsum.photos/600/400?random=4", new DateTime(2025, 2, 25, 1, 2, 45, 168, DateTimeKind.Local).AddTicks(1422), "Apple Launches New iPhone" },
                    { 5, 3, "The stock market has reached an all-time high, driven by strong corporate earnings and positive economic data. Investors are optimistic about the future, with many expecting further gains in the coming months. However, some analysts warn that the market may be overvalued and could be due for a correction. Despite these concerns, the bullish trend shows no signs of slowing down.", "https://picsum.photos/600/400?random=5", new DateTime(2025, 2, 24, 1, 2, 45, 168, DateTimeKind.Local).AddTicks(1424), "Stock Market Hits All-Time High" },
                    { 6, 3, "The government has introduced new tax reforms aimed at boosting small businesses and stimulating economic growth. The reforms include lower corporate tax rates, simplified filing procedures, and incentives for innovation. Small business owners have welcomed the changes, which they say will reduce their financial burden and encourage expansion. Critics, however, argue that the reforms may lead to a reduction in public services.", "https://picsum.photos/600/400?random=6", new DateTime(2025, 2, 23, 1, 2, 45, 168, DateTimeKind.Local).AddTicks(1427), "New Tax Reforms Announced" },
                    { 7, 4, "Scientists have made a significant breakthrough in cancer research, discovering a new treatment that targets cancer cells without harming healthy tissue. The treatment, which uses a combination of immunotherapy and gene editing, has shown promising results in early clinical trials. Researchers believe this could lead to a cure for certain types of cancer within the next decade.", "https://picsum.photos/600/400?random=7", new DateTime(2025, 2, 22, 1, 2, 45, 168, DateTimeKind.Local).AddTicks(1430), "Breakthrough in Cancer Research" },
                    { 8, 4, "A new variant of COVID-19 has been detected, raising concerns among health officials. The variant appears to be more contagious than previous strains, but early data suggests that existing vaccines remain effective. Governments around the world are monitoring the situation closely and considering additional measures to prevent the spread of the virus.", "https://picsum.photos/600/400?random=8", new DateTime(2025, 2, 21, 1, 2, 45, 168, DateTimeKind.Local).AddTicks(1432), "New COVID-19 Variant Detected" },
                    { 9, 5, "The World Cup 2023 has kicked off with thrilling matches and unexpected results. Fans around the world are glued to their screens as their favorite teams compete for the prestigious trophy. The tournament has already seen several upsets, with underdog teams defeating traditional powerhouses. The excitement is expected to build as the competition progresses.", "https://picsum.photos/600/400?random=9", new DateTime(2025, 2, 20, 1, 2, 45, 168, DateTimeKind.Local).AddTicks(1435), "World Cup 2023 Highlights" },
                    { 10, 5, "An athlete has set a new world record in the marathon, finishing the race in under two hours. The incredible feat has stunned the sports world and raised questions about the limits of human endurance. The runner credited their success to a rigorous training regimen and a focus on mental preparation. The record is expected to stand for years to come.", "https://picsum.photos/600/400?random=10", new DateTime(2025, 2, 19, 1, 2, 45, 168, DateTimeKind.Local).AddTicks(1437), "New Record in Marathon" },
                    { 11, 6, "The latest Marvel movie has broken box office records on its opening weekend, grossing over $500 million worldwide. Fans have praised the film for its stunning visuals, gripping storyline, and standout performances. The movie is expected to dominate the box office for weeks to come and has already sparked speculation about future sequels and spin-offs.", "https://picsum.photos/600/400?random=11", new DateTime(2025, 2, 18, 1, 2, 45, 168, DateTimeKind.Local).AddTicks(1440), "New Marvel Movie Release" },
                    { 12, 6, "The Grammy Awards 2023 saw some surprising wins and memorable performances. Artists from various genres were honored for their contributions to music, with several newcomers taking home major awards. The event was a celebration of creativity and diversity, showcasing the best of the music industry. Fans are already looking forward to next year's ceremony.", "https://picsum.photos/600/400?random=12", new DateTime(2025, 2, 17, 1, 2, 45, 168, DateTimeKind.Local).AddTicks(1442), "Grammy Awards 2023 Winners" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Health And Science");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Health & Science");
        }
    }
}
