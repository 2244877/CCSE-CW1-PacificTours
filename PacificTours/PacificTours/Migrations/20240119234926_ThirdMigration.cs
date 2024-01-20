using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PacificTours.Migrations
{
    /// <inheritdoc />
    public partial class ThirdMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16489674-ac74-41bc-9537-df1cb45df0cb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4022c594-2a0e-43a8-8ad7-a71ff02857f4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f81608ff-143e-4ca3-a261-c772e5e7f681");

            migrationBuilder.CreateTable(
                name: "hotelbookings",
                columns: table => new
                {
                    Booking_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hotel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Room = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CheckInDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckOutDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hotelbookings", x => x.Booking_Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "134a2acf-206f-409d-b431-2b9f6343d93b", null, "seller", "seller" },
                    { "1dd86b1f-75ee-4d5b-b6f7-f03d107612fa", null, "client", "client" },
                    { "2dcf5eee-ae54-4361-b12e-bb5f92e2f42d", null, "admin", "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "hotelbookings");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "134a2acf-206f-409d-b431-2b9f6343d93b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1dd86b1f-75ee-4d5b-b6f7-f03d107612fa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2dcf5eee-ae54-4361-b12e-bb5f92e2f42d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "16489674-ac74-41bc-9537-df1cb45df0cb", null, "seller", "seller" },
                    { "4022c594-2a0e-43a8-8ad7-a71ff02857f4", null, "admin", "admin" },
                    { "f81608ff-143e-4ca3-a261-c772e5e7f681", null, "client", "client" }
                });
        }
    }
}
