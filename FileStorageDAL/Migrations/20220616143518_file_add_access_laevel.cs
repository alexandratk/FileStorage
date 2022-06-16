using Microsoft.EntityFrameworkCore.Migrations;

namespace FileStorageDAL.Migrations
{
    public partial class file_add_access_laevel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AccessLevel",
                table: "Files",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessLevel",
                table: "Files");
        }
    }
}
