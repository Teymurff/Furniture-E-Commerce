using Microsoft.EntityFrameworkCore.Migrations;

namespace FurnitureShop.Migrations
{
    public partial class imagesmodified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "MainImage", "ProductId" },
                values: new object[] { "product_1.png", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "MainImage", "ProductId" },
                values: new object[] { "product_1.png", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "MainImage", "ProductId" },
                values: new object[] { "product_1.png", 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "MainImage", "ProductId" },
                values: new object[] { "product_2.png", 2 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "MainImage", "ProductId" },
                values: new object[] { "product_2.png", 2 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "MainImage", "ProductId" },
                values: new object[] { "product_2.png", 2 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "MainImage", "ProductId" },
                values: new object[] { "product_2.png", 2 });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "MainImage", "ProductId" },
                values: new object[,]
                {
                    { 22, "product_6.png", 6 },
                    { 23, "product_6.png", 6 },
                    { 24, "product_6.png", 6 },
                    { 25, "product_7.png", 7 },
                    { 29, "product_8.png", 8 },
                    { 27, "product_7.png", 7 },
                    { 28, "product_7.png", 7 },
                    { 21, "product_6.png", 6 },
                    { 30, "product_8.png", 8 },
                    { 26, "product_7.png", 7 },
                    { 20, "product_5.png", 5 },
                    { 17, "product_5.png", 5 },
                    { 18, "product_5.png", 5 },
                    { 31, "product_8.png", 8 },
                    { 16, "product_4.png", 4 },
                    { 15, "product_4.png", 4 },
                    { 14, "product_4.png", 4 },
                    { 13, "product_4.png", 4 },
                    { 12, "product_3.png", 3 },
                    { 11, "product_3.png", 3 },
                    { 10, "product_3.png", 3 },
                    { 9, "product_3.png", 3 },
                    { 19, "product_5.png", 5 },
                    { 32, "product_8.png", 8 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "MainImage", "ProductId" },
                values: new object[] { "product_2.png", 2 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "MainImage", "ProductId" },
                values: new object[] { "product_3.png", 3 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "MainImage", "ProductId" },
                values: new object[] { "product_4.png", 4 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "MainImage", "ProductId" },
                values: new object[] { "product_5.png", 5 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "MainImage", "ProductId" },
                values: new object[] { "product_6.png", 6 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "MainImage", "ProductId" },
                values: new object[] { "product_7.png", 7 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "MainImage", "ProductId" },
                values: new object[] { "product_8.png", 8 });
        }
    }
}
