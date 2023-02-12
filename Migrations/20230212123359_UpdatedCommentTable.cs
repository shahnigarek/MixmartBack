using Microsoft.EntityFrameworkCore.Migrations;

namespace MixmartBackEnd.Migrations
{
    public partial class UpdatedCommentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAccess",
                table: "Comments",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAccess",
                table: "Comments");
        }
    }
}
