using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Architecture.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bridges",
                columns: table => new
                {
                    BridgeId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Country = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    DateOfConstruction = table.Column<DateTime>(nullable: false),
                    Architect = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bridges", x => x.BridgeId);
                });

            migrationBuilder.InsertData(
                table: "Bridges",
                columns: new[] { "BridgeId", "Architect", "City", "Country", "DateOfConstruction", "Name" },
                values: new object[] { 1, "Joseph Strauss", "San Francisco", "USA", new DateTime(1933, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Golden Gate" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bridges");
        }
    }
}
