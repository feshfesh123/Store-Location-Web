using Microsoft.EntityFrameworkCore.Migrations;

namespace StoreInfo.Migrations
{
    public partial class MoreDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "Stores",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TimeOpen",
                table: "Stores",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "TimeOpen",
                table: "Stores");
        }
    }
}
