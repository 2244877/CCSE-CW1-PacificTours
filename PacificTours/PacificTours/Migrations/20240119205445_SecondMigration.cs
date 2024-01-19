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
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a5e24c9-67ad-48b5-b8fb-b3d6d126db5f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ed75e2-1a6c-4987-a0f9-c456cf327955");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f3f2812-9c76-4a0d-abab-996918a6de70");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "16489674-ac74-41bc-9537-df1cb45df0cb", null, "seller", "seller" },
                    { "4022c594-2a0e-43a8-8ad7-a71ff02857f4", null, "admin", "admin" },
                    { "f81608ff-143e-4ca3-a261-c772e5e7f681", null, "client", "client" }
                });

            migrationBuilder.UpdateData(
                table: "hotels",
                keyColumn: "Hotel_Id",
                keyValue: 1,
                columns: new[] { "DoubleRoomPrice", "FamilyRoomPrice", "HotelName", "SingleRoomPrice" },
                values: new object[] { "775", "950", "Hilton London Hotel", "375" });

            migrationBuilder.UpdateData(
                table: "hotels",
                keyColumn: "Hotel_Id",
                keyValue: 2,
                columns: new[] { "DoubleRoomPrice", "FamilyRoomPrice", "HotelName", "SingleRoomPrice" },
                values: new object[] { "500", "900", "London Marriott Hotel", "300" });

            migrationBuilder.InsertData(
                table: "hotels",
                columns: new[] { "Hotel_Id", "DoubleRoomPrice", "FamilyRoomPrice", "HotelName", "SingleRoomPrice" },
                values: new object[,]
                {
                    { 3, "120", "150", "Travelodge Brighton Seafront", "80" },
                    { 4, "400", "520", "Kings Hotel Brighton", "180" },
                    { 5, "400", "520", "Leonardo Hotel Brighton", "180" },
                    { 6, "100", "155", "Nevis Bank Inn, Fort William", "90" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "hotels",
                keyColumn: "Hotel_Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "hotels",
                keyColumn: "Hotel_Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "hotels",
                keyColumn: "Hotel_Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "hotels",
                keyColumn: "Hotel_Id",
                keyValue: 6);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4a5e24c9-67ad-48b5-b8fb-b3d6d126db5f", null, "client", "client" },
                    { "73ed75e2-1a6c-4987-a0f9-c456cf327955", null, "admin", "admin" },
                    { "7f3f2812-9c76-4a0d-abab-996918a6de70", null, "seller", "seller" }
                });

            migrationBuilder.UpdateData(
                table: "hotels",
                keyColumn: "Hotel_Id",
                keyValue: 1,
                columns: new[] { "DoubleRoomPrice", "FamilyRoomPrice", "HotelName", "SingleRoomPrice" },
                values: new object[] { "300", "100", "Hilton", "120" });

            migrationBuilder.UpdateData(
                table: "hotels",
                keyColumn: "Hotel_Id",
                keyValue: 2,
                columns: new[] { "DoubleRoomPrice", "FamilyRoomPrice", "HotelName", "SingleRoomPrice" },
                values: new object[] { "300", "100", "Mariot", "120" });
        }
    }
}
