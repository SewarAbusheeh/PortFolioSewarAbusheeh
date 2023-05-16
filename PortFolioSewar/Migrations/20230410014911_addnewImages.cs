using Microsoft.EntityFrameworkCore.Migrations;

namespace PortFolioSewar.Migrations
{
    public partial class addnewImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Img2",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Img3",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Img2",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "Img3",
                table: "Portfolios");
        }
    }
}
