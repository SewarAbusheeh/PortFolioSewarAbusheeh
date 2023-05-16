using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortFolioSewar.Migrations
{
    public partial class addtochange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjectDescDate",
                table: "Portfolios");

            migrationBuilder.RenameColumn(
                name: "db",
                table: "Portfolios",
                newName: "ProjectHint");

            migrationBuilder.RenameColumn(
                name: "ProjectDesc",
                table: "Portfolios",
                newName: "ProjectDescription");

            migrationBuilder.RenameColumn(
                name: "PortfolioDesc",
                table: "Portfolios",
                newName: "ProjectDate");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Client",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "Client",
                table: "Portfolios");

            migrationBuilder.RenameColumn(
                name: "ProjectHint",
                table: "Portfolios",
                newName: "db");

            migrationBuilder.RenameColumn(
                name: "ProjectDescription",
                table: "Portfolios",
                newName: "ProjectDesc");

            migrationBuilder.RenameColumn(
                name: "ProjectDate",
                table: "Portfolios",
                newName: "PortfolioDesc");

            migrationBuilder.AddColumn<DateTime>(
                name: "ProjectDescDate",
                table: "Portfolios",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
