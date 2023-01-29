using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MixmartBackEnd.Migrations
{
    public partial class CreatedPaymentMethodTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PaymentMethods",
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
                    Description1 = table.Column<string>(maxLength: 255, nullable: true),
                    Description2 = table.Column<string>(maxLength: 255, nullable: true),
                    Description3 = table.Column<string>(maxLength: 255, nullable: true),
                    Description4 = table.Column<string>(maxLength: 255, nullable: true),
                    Description5 = table.Column<string>(maxLength: 255, nullable: true),
                    Description6 = table.Column<string>(maxLength: 255, nullable: true),
                    Description7 = table.Column<string>(maxLength: 255, nullable: true),
                    Description8 = table.Column<string>(maxLength: 255, nullable: true),
                    Question1 = table.Column<string>(maxLength: 255, nullable: true),
                    Question2 = table.Column<string>(maxLength: 255, nullable: true),
                    Question3 = table.Column<string>(maxLength: 255, nullable: true),
                    Image = table.Column<string>(maxLength: 255, nullable: true),
                    PaymentOptions = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentMethods");
        }
    }
}
