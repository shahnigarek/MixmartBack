using Microsoft.EntityFrameworkCore.Migrations;

namespace MixmartBackEnd.Migrations
{
    public partial class CreatedRelationBettweenTeamandPosition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PositionId",
                table: "Teams",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_PositionId",
                table: "Teams",
                column: "PositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Positions_PositionId",
                table: "Teams",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Positions_PositionId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_PositionId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "PositionId",
                table: "Teams");
        }
    }
}
