using Microsoft.EntityFrameworkCore.Migrations;

namespace Courses_MVC.Migrations
{
    public partial class new16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "captionLink",
                table: "course");

            migrationBuilder.DropColumn(
                name: "link",
                table: "course");

            migrationBuilder.AddColumn<string>(
                name: "captionLink",
                table: "lesson",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "link",
                table: "lesson",
                maxLength: 5000,
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "captionLink",
                table: "lesson");

            migrationBuilder.DropColumn(
                name: "link",
                table: "lesson");

            migrationBuilder.AddColumn<string>(
                name: "captionLink",
                table: "course",
                type: "varchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "link",
                table: "course",
                type: "text",
                maxLength: 5000,
                nullable: false,
                defaultValue: "");
        }
    }
}
