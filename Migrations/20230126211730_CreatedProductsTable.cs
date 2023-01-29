using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MixmartBackEnd.Migrations
{
    public partial class CreatedProductsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
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
                    Image = table.Column<string>(maxLength: 255, nullable: true),
                    Title = table.Column<string>(maxLength: 255, nullable: true),
                    Description1 = table.Column<string>(maxLength: 255, nullable: true),
                    Description2 = table.Column<string>(maxLength: 255, nullable: true),
                    Description3 = table.Column<string>(maxLength: 255, nullable: true),
                    Price = table.Column<double>(nullable: false),
                    DiscountedPrice = table.Column<double>(nullable: false),
                    DiscountPercent = table.Column<double>(nullable: false),
                    FacebookUrl = table.Column<string>(maxLength: 255, nullable: true),
                    TwitterUrl = table.Column<string>(maxLength: 255, nullable: true),
                    LinkedinUrl = table.Column<string>(maxLength: 255, nullable: true),
                    TumblrUrl = table.Column<string>(maxLength: 255, nullable: true),
                    GooglePlusUrl = table.Column<string>(maxLength: 255, nullable: true),
                    PinterestUrl = table.Column<string>(maxLength: 255, nullable: true),
                    EnvelopeUrl = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
