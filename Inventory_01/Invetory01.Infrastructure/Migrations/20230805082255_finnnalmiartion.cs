using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Invetory01.Infrastructure.Migrations
{
    public partial class finnnalmiartion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    desicription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categores",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CategoryCode = table.Column<long>(type: "bigint", nullable: false),
                    Descirption = table.Column<string>(type: "nvarchar(999)", maxLength: 999, nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Counnty",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegionRegion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Counnty", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "unit",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_unit", x => x.ID);
                });

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
                    subcategoriesref = table.Column<long>(type: "bigint", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CubCategorycode = table.Column<long>(type: "bigint", nullable: false),
                    CategoryRef = table.Column<long>(type: "bigint", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categores_CategoryRef",
                        column: x => x.CategoryRef,
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

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_CategoryRef",
                table: "SubCategories",
                column: "CategoryRef");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Counnty");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "unit");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categores");
        }
    }
}
