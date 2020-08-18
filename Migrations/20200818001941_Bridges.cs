using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Architecture.Migrations
{
    public partial class Bridges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Bridges",
                columns: new[] { "BridgeId", "Architect", "City", "Country", "EndDate", "Name", "Span", "StartDate" },
                values: new object[,]
                {
                    { 2, "John Bradfield", "Sydney", "AUS", new DateTime(1932, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sydney Harbour", 1149, new DateTime(1928, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Satoshi Kashima", "Kobe, Iwaya", "JPN", new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akashi Kaikyo", 3911, new DateTime(1988, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Dr Michel Virlogeux", "Millau", "FRA", new DateTime(2004, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Millau Viaduct", 2460, new DateTime(2001, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "John Augustus Roebling", "Brooklyn, Manhattan", "USA", new DateTime(1883, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brooklyn", 18334, new DateTime(1869, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bridges",
                keyColumn: "BridgeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Bridges",
                keyColumn: "BridgeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Bridges",
                keyColumn: "BridgeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Bridges",
                keyColumn: "BridgeId",
                keyValue: 5);
        }
    }
}
