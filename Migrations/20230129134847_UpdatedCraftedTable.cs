using Microsoft.EntityFrameworkCore.Migrations;

namespace MixmartBackEnd.Migrations
{
    public partial class UpdatedCraftedTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductCount2",
                table: "Crafteds",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductCount3",
                table: "Crafteds",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Title2",
                table: "Crafteds",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title3",
                table: "Crafteds",
                maxLength: 255,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductCount2",
                table: "Crafteds");

            migrationBuilder.DropColumn(
                name: "ProductCount3",
                table: "Crafteds");

            migrationBuilder.DropColumn(
                name: "Title2",
                table: "Crafteds");

            migrationBuilder.DropColumn(
                name: "Title3",
                table: "Crafteds");
        }
    }
}
