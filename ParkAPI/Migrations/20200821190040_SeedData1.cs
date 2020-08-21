using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkApi.Migrations
{
    public partial class SeedData1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Description", "ParkName", "Rating", "State", "Type" },
                values: new object[,]
                {
                    { 1, "Crater Lake inspires awe.", "Crater Lake National Park", 5, "Oregon", "National" },
                    { 2, "There are seven developed fee-site campgrounds, managed on a first-come, first-served basis", "Tillamook State Forest", 5, "Oregon", "State" },
                    { 3, "The stunning beauty and abundant wildlife and plants found here have drawn humans to this place for more than 11,000 years", "Grand Teton National Park", 5, "Wyoming", "National" },
                    { 4, "The park comprises wooded country overlooking the Hudson and Piermont Marsh.", "Tallman Mountain State Park", 4, "New York", "State" },
                    { 5, "Come and experience Glacier's pristine forests, alpine meadows, rugged mountains, and spectacular lakes.", "Glacier National Park", 5, "Montana", "National" },
                    { 6, "Crater Lake inspires awe.", "Crater Lake National Park", 5, "Oregon", "National" },
                    { 7, "There are seven developed fee-site campgrounds, managed on a first-come, first-served basis", "Tillamook State Forest", 5, "Oregon", "State" },
                    { 8, "The stunning beauty and abundant wildlife and plants found here have drawn humans to this place for more than 11,000 years", "Grand Teton National Park", 5, "Wyoming", "National" },
                    { 9, "The park comprises wooded country overlooking the Hudson and Piermont Marsh.", "Tallman Mountain State Park", 4, "New York", "State" },
                    { 10, "Come and experience Glacier's pristine forests, alpine meadows, rugged mountains, and spectacular lakes.", "Glacier National Park", 5, "Montana", "National" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 10);
        }
    }
}
