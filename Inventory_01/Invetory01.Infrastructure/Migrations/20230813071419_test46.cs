using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Invetory01.Infrastructure.Migrations
{
    public partial class test46 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AddProductTostores_Products_producctsId",
                table: "AddProductTostores");

            migrationBuilder.DropForeignKey(
                name: "FK_AddProductTostores_store_StoreId",
                table: "AddProductTostores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AddProductTostores",
                table: "AddProductTostores");

            migrationBuilder.DropIndex(
                name: "IX_AddProductTostores_producctsId",
                table: "AddProductTostores");

            migrationBuilder.DropIndex(
                name: "IX_AddProductTostores_StoreId",
                table: "AddProductTostores");

            migrationBuilder.DropColumn(
                name: "StoreId",
                table: "AddProductTostores");

            migrationBuilder.DropColumn(
                name: "producctsId",
                table: "AddProductTostores");

            migrationBuilder.RenameTable(
                name: "AddProductTostores",
                newName: "AddProductsToStore");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AddProductsToStore",
                table: "AddProductsToStore",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_AddProductsToStore_productRef",
                table: "AddProductsToStore",
                column: "productRef");

            migrationBuilder.CreateIndex(
                name: "IX_AddProductsToStore_storeRef",
                table: "AddProductsToStore",
                column: "storeRef");

            migrationBuilder.AddForeignKey(
                name: "FK_AddProductsToStore_Products_productRef",
                table: "AddProductsToStore",
                column: "productRef",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AddProductsToStore_store_storeRef",
                table: "AddProductsToStore",
                column: "storeRef",
                principalTable: "store",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AddProductsToStore_Products_productRef",
                table: "AddProductsToStore");

            migrationBuilder.DropForeignKey(
                name: "FK_AddProductsToStore_store_storeRef",
                table: "AddProductsToStore");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AddProductsToStore",
                table: "AddProductsToStore");

            migrationBuilder.DropIndex(
                name: "IX_AddProductsToStore_productRef",
                table: "AddProductsToStore");

            migrationBuilder.DropIndex(
                name: "IX_AddProductsToStore_storeRef",
                table: "AddProductsToStore");

            migrationBuilder.RenameTable(
                name: "AddProductsToStore",
                newName: "AddProductTostores");

            migrationBuilder.AddColumn<long>(
                name: "StoreId",
                table: "AddProductTostores",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "producctsId",
                table: "AddProductTostores",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AddProductTostores",
                table: "AddProductTostores",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_AddProductTostores_producctsId",
                table: "AddProductTostores",
                column: "producctsId");

            migrationBuilder.CreateIndex(
                name: "IX_AddProductTostores_StoreId",
                table: "AddProductTostores",
                column: "StoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_AddProductTostores_Products_producctsId",
                table: "AddProductTostores",
                column: "producctsId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AddProductTostores_store_StoreId",
                table: "AddProductTostores",
                column: "StoreId",
                principalTable: "store",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
