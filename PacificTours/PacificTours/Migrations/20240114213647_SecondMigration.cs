using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PacificTours.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "214b98e2-138a-4ee0-b5db-950c3cc1c984", null, "seller", "seller" },
                    { "53d55a8f-689d-43e7-a3c7-4abf5d61422a", null, "admin", "admin" },
                    { "76c6ab37-8fdf-4122-aec3-9972d4c02006", null, "client", "client" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "214b98e2-138a-4ee0-b5db-950c3cc1c984");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53d55a8f-689d-43e7-a3c7-4abf5d61422a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76c6ab37-8fdf-4122-aec3-9972d4c02006");
        }
    }
}
