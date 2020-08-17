using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Architecture.Migrations
{
    public partial class AddBridges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateOfConstruction",
                table: "Bridges",
                newName: "StartDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Bridges",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Length",
                table: "Bridges",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Bridges",
                keyColumn: "BridgeId",
                keyValue: 1,
                columns: new[] { "EndDate", "Length" },
                values: new object[] { new DateTime(1937, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2737 });

            migrationBuilder.InsertData(
                table: "Bridges",
                columns: new[] { "BridgeId", "Architect", "City", "Country", "EndDate", "Length", "Name", "StartDate" },
                values: new object[,]
                {
                    { 2, "Dr. Michel Virlogeux", "Millau", "France", new DateTime(2004, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2460, "Viaduc de Millau", new DateTime(2001, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Dorman Long & Co.", "Sydney", "Australia", new DateTime(1932, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1149, "Sydney Harbor Bridge", new DateTime(1923, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Satoshi Kashima", "Kobe", "Japan", new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3911, "Akashi Kaikyō Bridge", new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Armando Rito", "Lisbon", "Portugal", new DateTime(1998, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12345, "Vasco Da Gama Bridge", new DateTime(1995, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "John Augustus Roebling", "New York City", "USA", new DateTime(1883, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1834, "Brooklyn Bridge", new DateTime(1870, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) }
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

            migrationBuilder.DeleteData(
                table: "Bridges",
                keyColumn: "BridgeId",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Bridges");

            migrationBuilder.DropColumn(
                name: "Length",
                table: "Bridges");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Bridges",
                newName: "DateOfConstruction");
        }
    }
}
