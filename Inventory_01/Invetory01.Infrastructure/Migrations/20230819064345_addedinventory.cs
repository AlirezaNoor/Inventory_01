using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Invetory01.Infrastructure.Migrations
{
    public partial class addedinventory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InventoryVoucher",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    storeref = table.Column<long>(type: "bigint", nullable: false),
                    nummber = table.Column<long>(type: "bigint", nullable: false),
                    SupplierRef = table.Column<long>(type: "bigint", nullable: false),
                    Dates = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VoucherType = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryVoucher", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InventoryVoucher_store_storeref",
                        column: x => x.storeref,
                        principalTable: "store",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InventoryVoucher_Supplier_SupplierRef",
                        column: x => x.SupplierRef,
                        principalTable: "Supplier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InventoryVoucheritemShopping",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productsref = table.Column<long>(type: "bigint", nullable: false),
                    unitref = table.Column<long>(type: "bigint", nullable: false),
                    Quntity = table.Column<long>(type: "bigint", nullable: false),
                    Inventoryoucherref = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InventoryVoucherShoppingId = table.Column<long>(type: "bigint", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                name: "IX_InventoryVoucher_storeref",
                table: "InventoryVoucher",
                column: "storeref");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryVoucher_SupplierRef",
                table: "InventoryVoucher",
                column: "SupplierRef");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryVoucheritemShopping_InventoryVoucherShoppingId",
                table: "InventoryVoucheritemShopping",
                column: "InventoryVoucherShoppingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InventoryVoucheritemShopping");

            migrationBuilder.DropTable(
                name: "InventoryVoucher");
        }
    }
}
