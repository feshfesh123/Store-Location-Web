using Microsoft.EntityFrameworkCore.Migrations;

namespace StoreInfo.Migrations
{
    public partial class Change : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Longitude",
                table: "Stores",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Latitude",
                table: "Stores",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Longitude",
                table: "Stores",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<string>(
                name: "Latitude",
                table: "Stores",
                nullable: true,
                oldClrType: typeof(double));
        }
    }
}
