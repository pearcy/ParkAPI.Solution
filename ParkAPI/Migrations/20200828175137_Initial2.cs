using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkApi.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parks",
                columns: table => new
                {
                    ParkId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ParkName = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Rating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.ParkId);
                });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Description", "ParkName", "Rating", "State", "Type" },
                values: new object[,]
                {
                    { 1, "Crater Lake inspires awe.", "Crater Lake National Park", 5, "Oregon", "National" },
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
                    { 11, "Crater Lake inspires awe.", "Crater Lake National Park", 5, "Oregon", "National" },
                    { 10, "Come and experience Glacier's pristine forests, alpine meadows, rugged mountains, and spectacular lakes.", "Glacier National Park", 5, "Montana", "National" },
                    { 9, "The park comprises wooded country overlooking the Hudson and Piermont Marsh.", "Tallman Mountain State Park", 4, "New York", "State" },
                    { 8, "The stunning beauty and abundant wildlife and plants found here have drawn humans to this place for more than 11,000 years", "Grand Teton National Park", 5, "Wyoming", "National" },
                    { 7, "There are seven developed fee-site campgrounds, managed on a first-come, first-served basis", "Tillamook State Forest", 5, "Oregon", "State" },
                    { 6, "Crater Lake inspires awe.", "Crater Lake National Park", 5, "Oregon", "National" },
                    { 5, "Come and experience Glacier's pristine forests, alpine meadows, rugged mountains, and spectacular lakes.", "Glacier National Park", 5, "Montana", "National" },
                    { 4, "The park comprises wooded country overlooking the Hudson and Piermont Marsh.", "Tallman Mountain State Park", 4, "New York", "State" },
                    { 3, "The stunning beauty and abundant wildlife.", "Grand Teton National Park", 5, "Wyoming", "National" },
                    { 2, "There are seven developed fee-site campgrounds", "Tillamook State Forest", 5, "Oregon", "State" },
                    { 29, "The park comprises wooded country overlooking the Hudson and Piermont Marsh.", "Tallman Mountain State Park", 4, "New York", "State" },
                    { 30, "Come and experience Glacier's pristine forests, alpine meadows, rugged mountains, and spectacular lakes.", "Glacier National Park", 5, "Montana", "National" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parks");
        }
    }
}
