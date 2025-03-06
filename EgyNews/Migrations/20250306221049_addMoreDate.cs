using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EgyNews.Migrations
{
    /// <inheritdoc />
    public partial class addMoreDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "052ccfd3-35b6-400f-946f-a170803dd611");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "523256fa-d881-4055-b299-5ed8dd946d0e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe1e5637-10db-4b6d-a47e-558474da6e95");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2025, 3, 5, 0, 10, 46, 155, DateTimeKind.Local).AddTicks(2622));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2025, 3, 6, 0, 10, 46, 155, DateTimeKind.Local).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(2025, 3, 4, 0, 10, 46, 155, DateTimeKind.Local).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishDate",
                value: new DateTime(2025, 3, 3, 0, 10, 46, 155, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishDate",
                value: new DateTime(2025, 3, 2, 0, 10, 46, 155, DateTimeKind.Local).AddTicks(2717));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublishDate",
                value: new DateTime(2025, 3, 1, 0, 10, 46, 155, DateTimeKind.Local).AddTicks(2721));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "PublishDate",
                value: new DateTime(2025, 2, 28, 0, 10, 46, 155, DateTimeKind.Local).AddTicks(2744));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "PublishDate",
                value: new DateTime(2025, 2, 27, 0, 10, 46, 155, DateTimeKind.Local).AddTicks(2749));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "PublishDate",
                value: new DateTime(2025, 2, 26, 0, 10, 46, 155, DateTimeKind.Local).AddTicks(2775));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "PublishDate",
                value: new DateTime(2025, 2, 25, 0, 10, 46, 155, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 11,
                column: "PublishDate",
                value: new DateTime(2025, 2, 24, 0, 10, 46, 155, DateTimeKind.Local).AddTicks(2807));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 12,
                column: "PublishDate",
                value: new DateTime(2025, 2, 23, 0, 10, 46, 155, DateTimeKind.Local).AddTicks(2811));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "ImageUrl", "PublishDate", "Title" },
                values: new object[,]
                {
                    { 13, 1, "High-level diplomatic talks have begun between two neighboring countries...", "https://picsum.photos/600/400?random=13", new DateTime(2025, 3, 4, 0, 10, 46, 155, DateTimeKind.Local).AddTicks(2682), "Diplomatic Talks Between Nations" },
                    { 14, 1, "A new bill aimed at combating climate change has been introduced...", "https://picsum.photos/600/400?random=14", new DateTime(2025, 3, 3, 0, 10, 46, 155, DateTimeKind.Local).AddTicks(2686), "New Legislation on Climate Change" },
                    { 15, 1, "A major political scandal has been uncovered, involving high-ranking officials...", "https://picsum.photos/600/400?random=15", new DateTime(2025, 3, 2, 0, 10, 46, 155, DateTimeKind.Local).AddTicks(2690), "Political Scandal Unveiled" },
                    { 16, 2, "A breakthrough in quantum computing has been achieved...", "https://picsum.photos/600/400?random=16", new DateTime(2025, 3, 1, 0, 10, 46, 155, DateTimeKind.Local).AddTicks(2702), "Quantum Computing Advancements" },
                    { 17, 2, "Experts warn of increasing cybersecurity threats...", "https://picsum.photos/600/400?random=17", new DateTime(2025, 2, 28, 0, 10, 46, 155, DateTimeKind.Local).AddTicks(2705), "Cybersecurity Threats on the Rise" },
                    { 18, 2, "Tech companies have introduced a range of new smart home devices...", "https://picsum.photos/600/400?random=18", new DateTime(2025, 2, 27, 0, 10, 46, 155, DateTimeKind.Local).AddTicks(2709), "New Smart Home Devices" },
                    { 19, 2, "Autonomous vehicles are set to revolutionize transportation...", "https://picsum.photos/600/400?random=19", new DateTime(2025, 2, 26, 0, 10, 46, 155, DateTimeKind.Local).AddTicks(2713), "The Future of Autonomous Vehicles" },
                    { 20, 3, "The IMF has released its latest global economic growth forecast...", "https://picsum.photos/600/400?random=20", new DateTime(2025, 2, 25, 0, 10, 46, 155, DateTimeKind.Local).AddTicks(2725), "Global Economic Growth Forecast" },
                    { 21, 3, "A list of promising startups that are making waves...", "https://picsum.photos/600/400?random=21", new DateTime(2025, 2, 24, 0, 10, 46, 155, DateTimeKind.Local).AddTicks(2729), "Startups to Watch in 2023" },
                    { 22, 3, "Rising inflation is affecting consumer spending habits...", "https://picsum.photos/600/400?random=22", new DateTime(2025, 2, 23, 0, 10, 46, 155, DateTimeKind.Local).AddTicks(2733), "Impact of Inflation on Consumers" },
                    { 23, 3, "Several countries have signed new trade agreements...", "https://picsum.photos/600/400?random=23", new DateTime(2025, 2, 22, 0, 10, 46, 155, DateTimeKind.Local).AddTicks(2736), "New Trade Agreements Signed" },
                    { 24, 3, "Remote work is becoming the new norm for many businesses...", "https://picsum.photos/600/400?random=24", new DateTime(2025, 2, 21, 0, 10, 46, 155, DateTimeKind.Local).AddTicks(2740), "The Rise of Remote Work" },
                    { 25, 4, "Gene therapy is showing promise in treating genetic disorders...", "https://picsum.photos/600/400?random=25", new DateTime(2025, 2, 20, 0, 10, 46, 155, DateTimeKind.Local).AddTicks(2753), "Advances in Gene Therapy" },
                    { 26, 4, "Studies show that meditation can improve mental health...", "https://picsum.photos/600/400?random=26", new DateTime(2025, 2, 19, 0, 10, 46, 155, DateTimeKind.Local).AddTicks(2756), "The Benefits of Meditation" },
                    { 27, 4, "Astronomers have made new discoveries in space...", "https://picsum.photos/600/400?random=27", new DateTime(2025, 2, 18, 0, 10, 46, 155, DateTimeKind.Local).AddTicks(2761), "New Discoveries in Space Exploration" },
                    { 28, 4, "Researchers are developing new vaccine technologies...", "https://picsum.photos/600/400?random=28", new DateTime(2025, 2, 17, 0, 10, 46, 155, DateTimeKind.Local).AddTicks(2765), "The Future of Vaccines" },
                    { 29, 4, "A new campaign aims to raise awareness about mental health...", "https://picsum.photos/600/400?random=29", new DateTime(2025, 2, 16, 0, 10, 46, 155, DateTimeKind.Local).AddTicks(2768), "Mental Health Awareness Campaign" },
                    { 30, 4, "Scientists have developed a new renewable energy source...", "https://picsum.photos/600/400?random=30", new DateTime(2025, 2, 15, 0, 10, 46, 155, DateTimeKind.Local).AddTicks(2772), "Breakthrough in Renewable Energy" },
                    { 31, 5, "Preparations for the 2024 Olympic Games are underway...", "https://picsum.photos/600/400?random=31", new DateTime(2025, 2, 14, 0, 10, 46, 155, DateTimeKind.Local).AddTicks(2782), "Olympic Games 2024 Preparations" },
                    { 32, 5, "Young tennis players are making a name for themselves...", "https://picsum.photos/600/400?random=32", new DateTime(2025, 2, 13, 0, 10, 46, 155, DateTimeKind.Local).AddTicks(2786), "Rising Stars in Tennis" },
                    { 33, 5, "Basketball has evolved significantly over the years...", "https://picsum.photos/600/400?random=33", new DateTime(2025, 2, 12, 0, 10, 46, 155, DateTimeKind.Local).AddTicks(2789), "The Evolution of Basketball" },
                    { 34, 5, "Esports is gaining popularity as a competitive sport...", "https://picsum.photos/600/400?random=34", new DateTime(2025, 2, 11, 0, 10, 46, 155, DateTimeKind.Local).AddTicks(2793), "Esports: The New Frontier" },
                    { 35, 5, "Sports can have a positive impact on mental health...", "https://picsum.photos/600/400?random=35", new DateTime(2025, 2, 10, 0, 10, 46, 155, DateTimeKind.Local).AddTicks(2796), "The Impact of Sports on Mental Health" },
                    { 36, 5, "Football's governing body has introduced new rules...", "https://picsum.photos/600/400?random=36", new DateTime(2025, 2, 9, 0, 10, 46, 155, DateTimeKind.Local).AddTicks(2800), "New Rules in Football" },
                    { 37, 5, "Women are breaking barriers in the world of sports...", "https://picsum.photos/600/400?random=37", new DateTime(2025, 2, 8, 0, 10, 46, 155, DateTimeKind.Local).AddTicks(2803), "The Rise of Women in Sports" },
                    { 38, 6, "Streaming services are changing the entertainment industry...", "https://picsum.photos/600/400?random=38", new DateTime(2025, 2, 7, 0, 10, 46, 155, DateTimeKind.Local).AddTicks(2814), "The Future of Streaming Services" },
                    { 39, 6, "A list of the most anticipated music festivals of the year...", "https://picsum.photos/600/400?random=39", new DateTime(2025, 2, 6, 0, 10, 46, 155, DateTimeKind.Local).AddTicks(2818), "Upcoming Music Festivals" },
                    { 40, 6, "Social media is reshaping how we consume entertainment...", "https://picsum.photos/600/400?random=40", new DateTime(2025, 2, 5, 0, 10, 46, 155, DateTimeKind.Local).AddTicks(2822), "The Impact of Social Media on Entertainment" },
                    { 41, 6, "Broadway is back with a lineup of exciting new shows...", "https://picsum.photos/600/400?random=41", new DateTime(2025, 2, 4, 0, 10, 46, 155, DateTimeKind.Local).AddTicks(2826), "New Broadway Shows to Watch" },
                    { 42, 6, "Independent films are gaining recognition in the industry...", "https://picsum.photos/600/400?random=42", new DateTime(2025, 2, 3, 0, 10, 46, 155, DateTimeKind.Local).AddTicks(2830), "The Rise of Independent Films" },
                    { 43, 6, "Celebrities are setting new fashion trends this season...", "https://picsum.photos/600/400?random=43", new DateTime(2025, 2, 2, 0, 10, 46, 155, DateTimeKind.Local).AddTicks(2834), "Celebrity Fashion Trends" },
                    { 44, 6, "Video games have come a long way since their inception...", "https://picsum.photos/600/400?random=44", new DateTime(2025, 2, 1, 0, 10, 46, 155, DateTimeKind.Local).AddTicks(2837), "The Evolution of Video Games" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "375753ff-4559-4dd2-ad2e-3f3ea65d7182", null, "Blogger", "BLOGGER" },
                    { "8d68ce38-d40c-4e1a-807e-de0e9897183b", null, "Reader", "READER" },
                    { "9a3e767c-cd75-479c-8247-9a71fcfe226e", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "375753ff-4559-4dd2-ad2e-3f3ea65d7182");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d68ce38-d40c-4e1a-807e-de0e9897183b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a3e767c-cd75-479c-8247-9a71fcfe226e");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2025, 3, 1, 2, 16, 51, 845, DateTimeKind.Local).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2025, 3, 2, 2, 16, 51, 845, DateTimeKind.Local).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(2025, 2, 28, 2, 16, 51, 845, DateTimeKind.Local).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishDate",
                value: new DateTime(2025, 2, 27, 2, 16, 51, 845, DateTimeKind.Local).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishDate",
                value: new DateTime(2025, 2, 26, 2, 16, 51, 845, DateTimeKind.Local).AddTicks(8757));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublishDate",
                value: new DateTime(2025, 2, 25, 2, 16, 51, 845, DateTimeKind.Local).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "PublishDate",
                value: new DateTime(2025, 2, 24, 2, 16, 51, 845, DateTimeKind.Local).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "PublishDate",
                value: new DateTime(2025, 2, 23, 2, 16, 51, 845, DateTimeKind.Local).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "PublishDate",
                value: new DateTime(2025, 2, 22, 2, 16, 51, 845, DateTimeKind.Local).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "PublishDate",
                value: new DateTime(2025, 2, 21, 2, 16, 51, 845, DateTimeKind.Local).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 11,
                column: "PublishDate",
                value: new DateTime(2025, 2, 20, 2, 16, 51, 845, DateTimeKind.Local).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 12,
                column: "PublishDate",
                value: new DateTime(2025, 2, 19, 2, 16, 51, 845, DateTimeKind.Local).AddTicks(8776));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "052ccfd3-35b6-400f-946f-a170803dd611", null, "Reader", "READER" },
                    { "523256fa-d881-4055-b299-5ed8dd946d0e", null, "Admin", "ADMIN" },
                    { "fe1e5637-10db-4b6d-a47e-558474da6e95", null, "Blogger", "BLOGGER" }
                });
        }
    }
}
