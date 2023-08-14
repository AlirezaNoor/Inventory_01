using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Invetory01.Infrastructure.Migrations
{
    public partial class add3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PUB.Fiscalyear",
                table: "PUB.Fiscalyear");

            migrationBuilder.RenameTable(
                name: "PUB.Fiscalyear",
                newName: "Fiscalyear");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fiscalyear",
                table: "Fiscalyear",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Fiscalyear",
                table: "Fiscalyear");

            migrationBuilder.RenameTable(
                name: "Fiscalyear",
                newName: "PUB.Fiscalyear");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PUB.Fiscalyear",
                table: "PUB.Fiscalyear",
                column: "Id");
        }
    }
}
