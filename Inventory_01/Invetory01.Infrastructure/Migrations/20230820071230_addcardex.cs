using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Invetory01.Infrastructure.Migrations
{
    public partial class addcardex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cardex",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    storeref = table.Column<long>(type: "bigint", nullable: false),
                    propductsref = table.Column<long>(type: "bigint", nullable: false),
                    transactiondate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    vorodkhoroj = table.Column<long>(type: "bigint", nullable: false),
                    Quantity = table.Column<long>(type: "bigint", nullable: false),
                    productsId = table.Column<long>(type: "bigint", nullable: false),
                    storeId = table.Column<long>(type: "bigint", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cardex", x => x.Id);
                    table.ForeignKey(
                        name: "FK_cardex_Products_productsId",
                        column: x => x.productsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cardex_store_storeId",
                        column: x => x.storeId,
                        principalTable: "store",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cardex_productsId",
                table: "cardex",
                column: "productsId");

            migrationBuilder.CreateIndex(
                name: "IX_cardex_storeId",
                table: "cardex",
                column: "storeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cardex");
        }
    }
}
