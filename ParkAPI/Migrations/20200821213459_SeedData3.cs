using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkApi.Migrations
{
    public partial class SeedData3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Description", "ParkName", "Rating", "State", "Type" },
                values: new object[,]
                {
                    { 11, "Crater Lake inspires awe.", "Crater Lake National Park", 5, "Oregon", "National" },
                    { 28, "The stunning beauty and abundant wildlife and plants found here have drawn humans to this place for more than 11,000 years", "Grand Teton National Park", 5, "Wyoming", "National" },
                    { 27, "There are seven developed fee-site campgrounds, managed on a first-come, first-served basis", "Tillamook State Forest", 5, "Oregon", "State" },
                    { 26, "Crater Lake inspires awe.", "Crater Lake National Park", 5, "Oregon", "National" },
                    { 25, "Come and experience Glacier's pristine forests, alpine meadows, rugged mountains, and spectacular lakes.", "Glacier National Park", 5, "Montana", "National" },
                    { 24, "The park comprises wooded country overlooking the Hudson and Piermont Marsh.", "Tallman Mountain State Park", 4, "New York", "State" },
                    { 23, "The stunning beauty and abundant wildlife and plants found here have drawn humans to this place for more than 11,000 years", "Grand Teton National Park", 5, "Wyoming", "National" },
                    { 22, "There are seven developed fee-site campgrounds, managed on a first-come, first-served basis", "Tillamook State Forest", 5, "Oregon", "State" },
                    { 21, "Crater Lake inspires awe.", "Crater Lake National Park", 5, "Oregon", "National" },
                    { 20, "Come and experience Glacier's pristine forests, alpine meadows, rugged mountains, and spectacular lakes.", "Glacier National Park", 5, "Montana", "National" },
                    { 19, "The park comprises wooded country overlooking the Hudson and Piermont Marsh.", "Tallman Mountain State Park", 4, "New York", "State" },
                    { 18, "The stunning beauty and abundant wildlife and plants found here have drawn humans to this place for more than 11,000 years", "Grand Teton National Park", 5, "Wyoming", "National" },
                    { 17, "There are seven developed fee-site campgrounds, managed on a first-come, first-served basis", "Tillamook State Forest", 5, "Oregon", "State" },
                    { 16, "Crater Lake inspires awe.", "Crater Lake National Park", 5, "Oregon", "National" },
                    { 15, "Come and experience Glacier's pristine forests, alpine meadows, rugged mountains, and spectacular lakes.", "Glacier National Park", 5, "Montana", "National" },
                    { 14, "The park comprises wooded country overlooking the Hudson and Piermont Marsh.", "Tallman Mountain State Park", 4, "New York", "State" },
                    { 13, "The stunning beauty and abundant wildlife and plants found here have drawn humans to this place for more than 11,000 years", "Grand Teton National Park", 5, "Wyoming", "National" },
                    { 12, "There are seven developed fee-site campgrounds, managed on a first-come, first-served basis", "Tillamook State Forest", 5, "Oregon", "State" },
                    { 29, "The park comprises wooded country overlooking the Hudson and Piermont Marsh.", "Tallman Mountain State Park", 4, "New York", "State" },
                    { 30, "Come and experience Glacier's pristine forests, alpine meadows, rugged mountains, and spectacular lakes.", "Glacier National Park", 5, "Montana", "National" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 30);
        }
    }
}
