using Microsoft.EntityFrameworkCore.Migrations;

namespace Dataaccses.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "descriptio2",
                table: "MyPricings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "descriptio3",
                table: "MyPricings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "descriptio4",
                table: "MyPricings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "descriptio5",
                table: "MyPricings",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "descriptio2",
                table: "MyPricings");

            migrationBuilder.DropColumn(
                name: "descriptio3",
                table: "MyPricings");

            migrationBuilder.DropColumn(
                name: "descriptio4",
                table: "MyPricings");

            migrationBuilder.DropColumn(
                name: "descriptio5",
                table: "MyPricings");
        }
    }
}
