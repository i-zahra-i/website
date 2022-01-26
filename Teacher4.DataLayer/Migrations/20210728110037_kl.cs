using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Teacher4.DataLayer.Migrations
{
    public partial class kl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "EpisodeTime",
                table: "CourseEpisodes",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "EpisodeTime",
                table: "CourseEpisodes",
                nullable: true,
                oldClrType: typeof(TimeSpan));
        }
    }
}
