using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MixmartBackEnd.Migrations
{
    public partial class CreatedBCategoryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogCategory_Categories_CategoryId",
                table: "BlogCategory");

            migrationBuilder.DropIndex(
                name: "IX_BlogCategory_CategoryId",
                table: "BlogCategory");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "BlogCategory");

            migrationBuilder.AddColumn<int>(
                name: "BCategoryId",
                table: "BlogCategory",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BCategories", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogCategory_BCategoryId",
                table: "BlogCategory",
                column: "BCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogCategory_BCategories_BCategoryId",
                table: "BlogCategory",
                column: "BCategoryId",
                principalTable: "BCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogCategory_BCategories_BCategoryId",
                table: "BlogCategory");

            migrationBuilder.DropTable(
                name: "BCategories");

            migrationBuilder.DropIndex(
                name: "IX_BlogCategory_BCategoryId",
                table: "BlogCategory");

            migrationBuilder.DropColumn(
                name: "BCategoryId",
                table: "BlogCategory");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "BlogCategory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BlogCategory_CategoryId",
                table: "BlogCategory",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogCategory_Categories_CategoryId",
                table: "BlogCategory",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
