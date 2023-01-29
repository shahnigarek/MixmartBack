using Microsoft.EntityFrameworkCore.Migrations;

namespace MixmartBackEnd.Migrations
{
    public partial class MadedChangesInTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description1",
                table: "WarrantyandServices");

            migrationBuilder.DropColumn(
                name: "Description2",
                table: "WarrantyandServices");

            migrationBuilder.DropColumn(
                name: "Description3",
                table: "WarrantyandServices");

            migrationBuilder.DropColumn(
                name: "Description4",
                table: "WarrantyandServices");

            migrationBuilder.DropColumn(
                name: "Description5",
                table: "WarrantyandServices");

            migrationBuilder.DropColumn(
                name: "Description6",
                table: "WarrantyandServices");

            migrationBuilder.DropColumn(
                name: "Description7",
                table: "WarrantyandServices");

            migrationBuilder.DropColumn(
                name: "Description8",
                table: "WarrantyandServices");

            migrationBuilder.DropColumn(
                name: "Description9",
                table: "WarrantyandServices");

            migrationBuilder.DropColumn(
                name: "Title1",
                table: "WarrantyandServices");

            migrationBuilder.DropColumn(
                name: "Title2",
                table: "WarrantyandServices");

            migrationBuilder.DropColumn(
                name: "Title3",
                table: "WarrantyandServices");

            migrationBuilder.DropColumn(
                name: "Description1",
                table: "TermandConditions");

            migrationBuilder.DropColumn(
                name: "Description2",
                table: "TermandConditions");

            migrationBuilder.DropColumn(
                name: "Description3",
                table: "TermandConditions");

            migrationBuilder.DropColumn(
                name: "Description4",
                table: "TermandConditions");

            migrationBuilder.DropColumn(
                name: "Description5",
                table: "TermandConditions");

            migrationBuilder.DropColumn(
                name: "Description6",
                table: "TermandConditions");

            migrationBuilder.DropColumn(
                name: "Description7",
                table: "TermandConditions");

            migrationBuilder.DropColumn(
                name: "Description8",
                table: "TermandConditions");

            migrationBuilder.DropColumn(
                name: "Title1",
                table: "TermandConditions");

            migrationBuilder.DropColumn(
                name: "Title2",
                table: "TermandConditions");

            migrationBuilder.DropColumn(
                name: "Title3",
                table: "TermandConditions");

            migrationBuilder.DropColumn(
                name: "Title4",
                table: "TermandConditions");

            migrationBuilder.DropColumn(
                name: "Title5",
                table: "TermandConditions");

            migrationBuilder.DropColumn(
                name: "Title6",
                table: "TermandConditions");

            migrationBuilder.DropColumn(
                name: "Description1",
                table: "ShippingMethods");

            migrationBuilder.DropColumn(
                name: "Description10",
                table: "ShippingMethods");

            migrationBuilder.DropColumn(
                name: "Description11",
                table: "ShippingMethods");

            migrationBuilder.DropColumn(
                name: "Description2",
                table: "ShippingMethods");

            migrationBuilder.DropColumn(
                name: "Description3",
                table: "ShippingMethods");

            migrationBuilder.DropColumn(
                name: "Description4",
                table: "ShippingMethods");

            migrationBuilder.DropColumn(
                name: "Description5",
                table: "ShippingMethods");

            migrationBuilder.DropColumn(
                name: "Description6",
                table: "ShippingMethods");

            migrationBuilder.DropColumn(
                name: "Description7",
                table: "ShippingMethods");

            migrationBuilder.DropColumn(
                name: "Description8",
                table: "ShippingMethods");

            migrationBuilder.DropColumn(
                name: "Description9",
                table: "ShippingMethods");

            migrationBuilder.DropColumn(
                name: "Title1",
                table: "ShippingMethods");

            migrationBuilder.DropColumn(
                name: "Title2",
                table: "ShippingMethods");

            migrationBuilder.DropColumn(
                name: "Title3",
                table: "ShippingMethods");

            migrationBuilder.DropColumn(
                name: "Description6",
                table: "PaymentMethods");

            migrationBuilder.DropColumn(
                name: "Description7",
                table: "PaymentMethods");

            migrationBuilder.DropColumn(
                name: "Description8",
                table: "PaymentMethods");

            migrationBuilder.DropColumn(
                name: "Description3",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "Description4",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "Description5",
                table: "Blogs");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "WarrantyandServices",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "WarrantyandServices",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "TermandConditions",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "TermandConditions",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ShippingMethods",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "ShippingMethods",
                maxLength: 255,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "WarrantyandServices");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "WarrantyandServices");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "TermandConditions");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "TermandConditions");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "ShippingMethods");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "ShippingMethods");

            migrationBuilder.AddColumn<string>(
                name: "Description1",
                table: "WarrantyandServices",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description2",
                table: "WarrantyandServices",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description3",
                table: "WarrantyandServices",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description4",
                table: "WarrantyandServices",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description5",
                table: "WarrantyandServices",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description6",
                table: "WarrantyandServices",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description7",
                table: "WarrantyandServices",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description8",
                table: "WarrantyandServices",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description9",
                table: "WarrantyandServices",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title1",
                table: "WarrantyandServices",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title2",
                table: "WarrantyandServices",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title3",
                table: "WarrantyandServices",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description1",
                table: "TermandConditions",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description2",
                table: "TermandConditions",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description3",
                table: "TermandConditions",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description4",
                table: "TermandConditions",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description5",
                table: "TermandConditions",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description6",
                table: "TermandConditions",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description7",
                table: "TermandConditions",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description8",
                table: "TermandConditions",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title1",
                table: "TermandConditions",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title2",
                table: "TermandConditions",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title3",
                table: "TermandConditions",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title4",
                table: "TermandConditions",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title5",
                table: "TermandConditions",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title6",
                table: "TermandConditions",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description1",
                table: "ShippingMethods",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description10",
                table: "ShippingMethods",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description11",
                table: "ShippingMethods",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description2",
                table: "ShippingMethods",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description3",
                table: "ShippingMethods",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description4",
                table: "ShippingMethods",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description5",
                table: "ShippingMethods",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description6",
                table: "ShippingMethods",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description7",
                table: "ShippingMethods",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description8",
                table: "ShippingMethods",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description9",
                table: "ShippingMethods",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title1",
                table: "ShippingMethods",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title2",
                table: "ShippingMethods",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title3",
                table: "ShippingMethods",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description6",
                table: "PaymentMethods",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description7",
                table: "PaymentMethods",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description8",
                table: "PaymentMethods",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description3",
                table: "Blogs",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description4",
                table: "Blogs",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description5",
                table: "Blogs",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);
        }
    }
}
