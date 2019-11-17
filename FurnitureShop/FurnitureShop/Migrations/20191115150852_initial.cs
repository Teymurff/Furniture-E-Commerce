using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FurnitureShop.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    CategoryImage = table.Column<string>(maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    HasDiscount = table.Column<bool>(nullable: false),
                    DiscountedPrice = table.Column<decimal>(nullable: false),
                    Height = table.Column<int>(nullable: false),
                    Width = table.Column<int>(nullable: false),
                    Length = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MainImage = table.Column<string>(maxLength: 300, nullable: true),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Score = table.Column<decimal>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ratings_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryImage", "Name" },
                values: new object[,]
                {
                    { 1, "bathroom.png", "Bathroom" },
                    { 2, "livingroom.png", "Livingroom" },
                    { 3, "bedroom.png", "Bedroom" },
                    { 4, "kitchen.png", "Kitchen" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DiscountedPrice", "HasDiscount", "Height", "Length", "Name", "Price", "Width" },
                values: new object[,]
                {
                    { 5, 1, 180m, true, 508, 58, "Comfortable Bathroom Chair", 200m, 128 },
                    { 7, 1, 0m, false, 508, 58, "Bathroom Chair", 70m, 128 },
                    { 4, 2, 0m, false, 500, 58, "Livingroom Chair", 250m, 128 },
                    { 6, 3, 0m, false, 508, 58, "Green Bedroom Chair", 160m, 128 },
                    { 1, 4, 100m, true, 508, 58, "Green Kitchen Chair", 150m, 128 },
                    { 2, 4, 90m, true, 408, 40, "Orange Kitchen Chair", 130m, 118 },
                    { 3, 4, 80m, true, 510, 30, "Yellow Kitchen Chair", 100m, 111 },
                    { 8, 4, 140m, true, 508, 58, "Red Kitchen Chair", 170m, 128 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "MainImage", "ProductId" },
                values: new object[,]
                {
                    { 5, "product_5.png", 5 },
                    { 7, "product_7.png", 7 },
                    { 4, "product_4.png", 4 },
                    { 6, "product_6.png", 6 },
                    { 1, "product_1.png", 1 },
                    { 2, "product_2.png", 2 },
                    { 3, "product_3.png", 3 },
                    { 8, "product_8.png", 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Images_ProductId",
                table: "Images",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_ProductId",
                table: "Ratings",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
