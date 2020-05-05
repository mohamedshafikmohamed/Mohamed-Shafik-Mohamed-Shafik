using Microsoft.EntityFrameworkCore.Migrations;

namespace Mohamed_Shafik_Mohamed_Shafik.Migrations
{
    public partial class hg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "address",
                table: "info");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "address",
                table: "info",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
