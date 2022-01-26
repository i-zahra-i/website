using Microsoft.EntityFrameworkCore.Migrations;

namespace Teacher4.DataLayer.Migrations
{
    public partial class commentRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "CourseComments",
                maxLength: 700,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 700,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "CourseComments",
                maxLength: 700,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 700);
        }
    }
}
