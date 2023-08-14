using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Invetory01.Infrastructure.Migrations
{
    public partial class test45 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddProductTostores",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productRef = table.Column<long>(type: "bigint", nullable: false),
                    storeRef = table.Column<long>(type: "bigint", nullable: false),
                    producctsId = table.Column<long>(type: "bigint", nullable: false),
                    StoreId = table.Column<long>(type: "bigint", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddProductTostores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AddProductTostores_Products_producctsId",
                        column: x => x.producctsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AddProductTostores_store_StoreId",
                        column: x => x.StoreId,
                        principalTable: "store",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AddProductTostores_producctsId",
                table: "AddProductTostores",
                column: "producctsId");

            migrationBuilder.CreateIndex(
                name: "IX_AddProductTostores_StoreId",
                table: "AddProductTostores",
                column: "StoreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddProductTostores");
        }
    }
}
