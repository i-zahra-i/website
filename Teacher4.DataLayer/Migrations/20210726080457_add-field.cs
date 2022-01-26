using Microsoft.EntityFrameworkCore.Migrations;

namespace Teacher4.DataLayer.Migrations
{
    public partial class addfield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DemoFileName",
                table: "Courses",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Courses",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DemoFileName",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Courses");
        }
    }
}
