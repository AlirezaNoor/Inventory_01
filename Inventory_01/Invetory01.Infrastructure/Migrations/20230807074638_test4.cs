using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Invetory01.Infrastructure.Migrations
{
    public partial class test4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Costumer",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Countryref = table.Column<long>(type: "bigint", nullable: false),
                    Cityref = table.Column<long>(type: "bigint", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Desciption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Costumer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Costumer_Counnty_Countryref",
                        column: x => x.Countryref,
                        principalTable: "Counnty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Costumer_Countryref",
                table: "Costumer",
                column: "Countryref");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Costumer");
        }
    }
}
