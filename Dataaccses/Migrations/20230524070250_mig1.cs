using Microsoft.EntityFrameworkCore.Migrations;

namespace Dataaccses.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    Aboutid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    title1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactMe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactaPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactaMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectDowlandUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.Aboutid);
                });

            migrationBuilder.CreateTable(
                name: "Homes",
                columns: table => new
                {
                    Homdeid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SocialMedia1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SocialMedia2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SocialMedia3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SocialMedia4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SocialMedia5 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Homes", x => x.Homdeid);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Projectid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Projectid);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    skillid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    skill1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    skill2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    skill3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    skill4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.skillid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Homes");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Skills");
        }
    }
}
