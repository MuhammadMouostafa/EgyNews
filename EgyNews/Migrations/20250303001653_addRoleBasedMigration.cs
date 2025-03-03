using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EgyNews.Migrations
{
    /// <inheritdoc />
    public partial class addRoleBasedMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                value: new DateTime(2025, 3, 1, 1, 51, 4, 406, DateTimeKind.Local).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2025, 3, 2, 1, 51, 4, 406, DateTimeKind.Local).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(2025, 2, 28, 1, 51, 4, 406, DateTimeKind.Local).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishDate",
                value: new DateTime(2025, 2, 27, 1, 51, 4, 406, DateTimeKind.Local).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishDate",
                value: new DateTime(2025, 2, 26, 1, 51, 4, 406, DateTimeKind.Local).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublishDate",
                value: new DateTime(2025, 2, 25, 1, 51, 4, 406, DateTimeKind.Local).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "PublishDate",
                value: new DateTime(2025, 2, 24, 1, 51, 4, 406, DateTimeKind.Local).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "PublishDate",
                value: new DateTime(2025, 2, 23, 1, 51, 4, 406, DateTimeKind.Local).AddTicks(8585));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "PublishDate",
                value: new DateTime(2025, 2, 22, 1, 51, 4, 406, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "PublishDate",
                value: new DateTime(2025, 2, 21, 1, 51, 4, 406, DateTimeKind.Local).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 11,
                column: "PublishDate",
                value: new DateTime(2025, 2, 20, 1, 51, 4, 406, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 12,
                column: "PublishDate",
                value: new DateTime(2025, 2, 19, 1, 51, 4, 406, DateTimeKind.Local).AddTicks(8604));
        }
    }
}
