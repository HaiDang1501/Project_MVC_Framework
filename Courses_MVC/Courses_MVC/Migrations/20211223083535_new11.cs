using Microsoft.EntityFrameworkCore.Migrations;

namespace Courses_MVC.Migrations
{
    public partial class new11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "lesson",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "userId",
                table: "exercise",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(767)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "input",
                table: "exercise",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "output",
                table: "exercise",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.DropColumn(
                name: "input",
                table: "exercise");

            migrationBuilder.DropColumn(
                name: "output",
                table: "exercise");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "lesson",
                type: "text",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "userId",
                table: "exercise",
                type: "varchar(767)",
                nullable: true,
                oldClrType: typeof(string));

            
        }
    }
}
