using Microsoft.EntityFrameworkCore.Migrations;

namespace MixmartBackEnd.Migrations
{
    public partial class UpdatedFeaturedTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Featureds");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Featureds");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Featureds",
                type: "nvarchar(2500)",
                maxLength: 2500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Featureds",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);
        }
    }
}
