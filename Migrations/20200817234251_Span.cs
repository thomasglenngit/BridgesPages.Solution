using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Architecture.Migrations
{
    public partial class Span : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateOfConstruction",
                table: "Bridges",
                newName: "StartDate");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Bridges",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Bridges",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Bridges",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Architect",
                table: "Bridges",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Bridges",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Span",
                table: "Bridges",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Bridges",
                keyColumn: "BridgeId",
                keyValue: 1,
                columns: new[] { "EndDate", "Span" },
                values: new object[] { new DateTime(1937, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1280 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Bridges");

            migrationBuilder.DropColumn(
                name: "Span",
                table: "Bridges");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Bridges",
                newName: "DateOfConstruction");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Bridges",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Bridges",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Bridges",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Architect",
                table: "Bridges",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
