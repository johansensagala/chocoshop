using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ChocoShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    ImageFileName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageFileName", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Snickers is a chocolate bar made by the American company Mars, Incorporated, consisting of nougat topped with caramel and peanuts that is encased in milk chocolate.", "Snickers.jpeg", "Snickers", 73.000m },
                    { 2, "Milky Way is a brand of chocolate-covered confectionery bar manufactured and marketed by Mars, Incorporated. The Milky Way bar is made of nougat, topped with caramel and covered with milk chocolate.", "Milkyway.jpg", "Milky Way", 30.000m },
                    { 3, "Bounty is a coconut-filled, chocolate-enrobed candy bar manufactured by Mars, Incorporated, introduced in 1951 in the United Kingdom and Canada. Bounty has a coconut filling, enrobed with milk chocolate (in a blue wrapper) or dark chocolate (in a red wrapper) and is usually sold as two small bars wrapped in one package.", "Bounty.jpg", "Bounty", 32.000m },
                    { 4, "Mars, commonly known as Mars bar, is the name of two varieties of chocolate bar produced by Mars, Incorporated. A delicious fusion of chocolate, caramel and nougat.", "Mars.jpg", "Mars", 13.000m },
                    { 5, "Twix is a caramel shortbread chocolate bar made by Mars, Inc., consisting of a biscuit applied with other confectionery toppings and coatings (most frequently caramel and milk chocolate). Twix are packaged with one, two or four bars in a wrapper.", "Twix.jpg", "Twix", 17.000m },
                    { 6, "Kinder Maxi is a milk chocolate bar with a soft tasty milky filling that gives you the pleasure and taste of when you were a child.", "Kindermaxi.jpg", "Kinder Maxi", 13.000m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
