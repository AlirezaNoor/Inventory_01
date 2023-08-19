using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Invetory01.Infrastructure.Migrations
{
    public partial class addedinventoryItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InventoryVoucheritemShopping");

            migrationBuilder.CreateTable(
                name: "inventoryVoucherItem",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productsref = table.Column<long>(type: "bigint", nullable: false),
                    unitref = table.Column<long>(type: "bigint", nullable: false),
                    Quntity = table.Column<long>(type: "bigint", nullable: false),
                    Inventoryoucherref = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inventoryVoucherItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_inventoryVoucherItem_InventoryVoucher_Inventoryoucherref",
                        column: x => x.Inventoryoucherref,
                        principalTable: "InventoryVoucher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_inventoryVoucherItem_Products_productsref",
                        column: x => x.productsref,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_inventoryVoucherItem_unit_unitref",
                        column: x => x.unitref,
                        principalTable: "unit",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_inventoryVoucherItem_Inventoryoucherref",
                table: "inventoryVoucherItem",
                column: "Inventoryoucherref");

            migrationBuilder.CreateIndex(
                name: "IX_inventoryVoucherItem_productsref",
                table: "inventoryVoucherItem",
                column: "productsref");

            migrationBuilder.CreateIndex(
                name: "IX_inventoryVoucherItem_unitref",
                table: "inventoryVoucherItem",
                column: "unitref");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "inventoryVoucherItem");

            migrationBuilder.CreateTable(
                name: "InventoryVoucheritemShopping",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InventoryVoucherShoppingId = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Inventoryoucherref = table.Column<long>(type: "bigint", nullable: false),
                    Quntity = table.Column<long>(type: "bigint", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    productsref = table.Column<long>(type: "bigint", nullable: false),
                    unitref = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryVoucheritemShopping", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InventoryVoucheritemShopping_InventoryVoucher_InventoryVoucherShoppingId",
                        column: x => x.InventoryVoucherShoppingId,
                        principalTable: "InventoryVoucher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InventoryVoucheritemShopping_InventoryVoucherShoppingId",
                table: "InventoryVoucheritemShopping",
                column: "InventoryVoucherShoppingId");
        }
    }
}
