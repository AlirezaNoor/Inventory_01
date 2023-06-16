using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Invetory01.Infrastructure.Migrations
{
    public partial class la55s : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    categoriesref = table.Column<long>(type: "bigint", nullable: false),
                    brand = table.Column<long>(type: "bigint", nullable: false),
                    unitref = table.Column<long>(type: "bigint", nullable: false),
                    Sku = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Qty = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    minmuimQty = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tax = table.Column<long>(type: "bigint", nullable: false),
                    Discuont = table.Column<long>(type: "bigint", nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    statuse = table.Column<long>(type: "bigint", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_brand",
                        column: x => x.brand,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Categores_categoriesref",
                        column: x => x.categoriesref,
                        principalTable: "Categores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_brand",
                table: "Products",
                column: "brand");

            migrationBuilder.CreateIndex(
                name: "IX_Products_categoriesref",
                table: "Products",
                column: "categoriesref");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
