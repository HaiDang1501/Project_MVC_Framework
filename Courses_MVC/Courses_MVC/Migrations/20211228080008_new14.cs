using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace Courses_MVC.Migrations
{
    public partial class new14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_comment",
                table: "comment");

            migrationBuilder.AddColumn<int>(
                name: "cmtId",
                table: "comment",
                nullable: false,
                defaultValue: 0)
                .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_comment",
                table: "comment",
                columns: new[] { "courseId", "userId", "cmtId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_comment",
                table: "comment");

            migrationBuilder.DropColumn(
                name: "cmtId",
                table: "comment");

            migrationBuilder.AddPrimaryKey(
                name: "PK_comment",
                table: "comment",
                columns: new[] { "courseId", "userId" });
        }
    }
}
