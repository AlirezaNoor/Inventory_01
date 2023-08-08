using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Invetory01.Infrastructure.Migrations
{
    public partial class addcities2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_city_Counnty_CountreisId",
                table: "city");

            migrationBuilder.DropPrimaryKey(
                name: "PK_city",
                table: "city");

            migrationBuilder.DropIndex(
                name: "IX_city_CountreisId",
                table: "city");

            migrationBuilder.DropColumn(
                name: "CountreisId",
                table: "city");

            migrationBuilder.RenameTable(
                name: "city",
                newName: "City");

            migrationBuilder.AddPrimaryKey(
                name: "PK_City",
                table: "City",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_City_Countryref",
                table: "City",
                column: "Countryref");

            migrationBuilder.AddForeignKey(
                name: "FK_City_Counnty_Countryref",
                table: "City",
                column: "Countryref",
                principalTable: "Counnty",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_City_Counnty_Countryref",
                table: "City");

            migrationBuilder.DropPrimaryKey(
                name: "PK_City",
                table: "City");

            migrationBuilder.DropIndex(
                name: "IX_City_Countryref",
                table: "City");

            migrationBuilder.RenameTable(
                name: "City",
                newName: "city");

            migrationBuilder.AddColumn<long>(
                name: "CountreisId",
                table: "city",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddPrimaryKey(
                name: "PK_city",
                table: "city",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_city_CountreisId",
                table: "city",
                column: "CountreisId");

            migrationBuilder.AddForeignKey(
                name: "FK_city_Counnty_CountreisId",
                table: "city",
                column: "CountreisId",
                principalTable: "Counnty",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
