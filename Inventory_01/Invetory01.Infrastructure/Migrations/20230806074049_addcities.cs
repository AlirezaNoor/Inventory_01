using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Invetory01.Infrastructure.Migrations
{
    public partial class addcities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "city",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Countryref = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountreisId = table.Column<long>(type: "bigint", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_city", x => x.Id);
                    table.ForeignKey(
                        name: "FK_city_Counnty_CountreisId",
                        column: x => x.CountreisId,
                        principalTable: "Counnty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_city_CountreisId",
                table: "city",
                column: "CountreisId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "city");
        }
    }
}
