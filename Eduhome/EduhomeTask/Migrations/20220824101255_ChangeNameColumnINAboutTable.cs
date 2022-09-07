using Microsoft.EntityFrameworkCore.Migrations;

namespace EduhomeTask.Migrations
{
    public partial class ChangeNameColumnINAboutTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Abouts",
                newName: "Title");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Abouts",
                newName: "Name");
        }
    }
}
