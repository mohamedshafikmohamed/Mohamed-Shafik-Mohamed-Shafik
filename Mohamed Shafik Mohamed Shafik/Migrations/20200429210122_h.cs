using Microsoft.EntityFrameworkCore.Migrations;

namespace Mohamed_Shafik_Mohamed_Shafik.Migrations
{
    public partial class h : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "info",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    education = table.Column<string>(nullable: true),
                    job = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_info", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "projects",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    image = table.Column<string>(nullable: true),
                    Discription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projects", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "info",
                columns: new[] { "Id", "Name", "address", "education", "job" },
                values: new object[] { 1, "Mohamed Shafik Mohamed", null, " Pursuing a bachelor ’s degree in computer science at Ain shams university (2017-2021 expected)  GPA : Very Go", "Backend Developer - Asp.net" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "info");

            migrationBuilder.DropTable(
                name: "projects");
        }
    }
}
