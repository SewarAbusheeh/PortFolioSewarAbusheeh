using Microsoft.EntityFrameworkCore.Migrations;

namespace PortFolioSewar.Migrations
{
    public partial class addmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ExperienceDesc1",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExperienceDesc2",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExperienceDesc3",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExperienceDesc4",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExperienceDesc5",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HoppyDesc1",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HoppyDesc2",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HoppyDesc3",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HoppyDesc4",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HoppyTitle",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExperienceDesc1",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "ExperienceDesc2",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "ExperienceDesc3",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "ExperienceDesc4",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "ExperienceDesc5",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "HoppyDesc1",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "HoppyDesc2",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "HoppyDesc3",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "HoppyDesc4",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "HoppyTitle",
                table: "Resumes");
        }
    }
}
