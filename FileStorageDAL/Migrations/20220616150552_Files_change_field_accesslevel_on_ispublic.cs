using Microsoft.EntityFrameworkCore.Migrations;

namespace FileStorageDAL.Migrations
{
    public partial class Files_change_field_accesslevel_on_ispublic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessLevel",
                table: "Files");

            migrationBuilder.AddColumn<bool>(
                name: "IsPublic",
                table: "Files",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPublic",
                table: "Files");

            migrationBuilder.AddColumn<string>(
                name: "AccessLevel",
                table: "Files",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
