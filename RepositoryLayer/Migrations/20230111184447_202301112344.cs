using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _202301112344 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "Breakage",
                schema: "Core",
                table: "StockInApplicationDetails",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ProductDautyRate",
                schema: "Core",
                table: "StockInApplicationDetails",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "DriverName",
                schema: "Core",
                table: "StockInApplication",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DautyRate",
                schema: "Setup",
                table: "ProductSize",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RetailPrice",
                schema: "Setup",
                table: "ProductSize",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "VendFee",
                schema: "Setup",
                table: "ProductSize",
                type: "bigint",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Breakage",
                schema: "Core",
                table: "StockInApplicationDetails");

            migrationBuilder.DropColumn(
                name: "ProductDautyRate",
                schema: "Core",
                table: "StockInApplicationDetails");

            migrationBuilder.DropColumn(
                name: "DriverName",
                schema: "Core",
                table: "StockInApplication");

            migrationBuilder.DropColumn(
                name: "DautyRate",
                schema: "Setup",
                table: "ProductSize");

            migrationBuilder.DropColumn(
                name: "RetailPrice",
                schema: "Setup",
                table: "ProductSize");

            migrationBuilder.DropColumn(
                name: "VendFee",
                schema: "Setup",
                table: "ProductSize");
        }
    }
}
