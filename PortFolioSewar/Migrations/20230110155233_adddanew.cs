using Microsoft.EntityFrameworkCore.Migrations;

namespace PortFolioSewar.Migrations
{
    public partial class adddanew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "db",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "db",
                table: "Portfolios");
        }
    }
}
