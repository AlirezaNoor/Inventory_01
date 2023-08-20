using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Invetory01.Infrastructure.Migrations
{
    public partial class edited12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "Fisicalyearref",
                table: "InventoryVoucher",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_InventoryVoucher_Fisicalyearref",
                table: "InventoryVoucher",
                column: "Fisicalyearref");

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryVoucher_Fiscalyear_Fisicalyearref",
                table: "InventoryVoucher",
                column: "Fisicalyearref",
                principalTable: "Fiscalyear",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InventoryVoucher_Fiscalyear_Fisicalyearref",
                table: "InventoryVoucher");

            migrationBuilder.DropIndex(
                name: "IX_InventoryVoucher_Fisicalyearref",
                table: "InventoryVoucher");

            migrationBuilder.DropColumn(
                name: "Fisicalyearref",
                table: "InventoryVoucher");
        }
    }
}
