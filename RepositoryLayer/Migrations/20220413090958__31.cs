using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _31 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "SRNRPL");

            migrationBuilder.RenameTable(
                name: "SeriesType",
                schema: "SeriesNumberPool",
                newName: "SeriesType",
                newSchema: "SRNRPL");

            migrationBuilder.RenameTable(
                name: "SeriesStatusHistory",
                schema: "SeriesNumberPool",
                newName: "SeriesStatusHistory",
                newSchema: "SRNRPL");

            migrationBuilder.RenameTable(
                name: "SeriesStatus",
                schema: "SeriesNumberPool",
                newName: "SeriesStatus",
                newSchema: "SRNRPL");

            migrationBuilder.RenameTable(
                name: "SeriesNumberPool",
                schema: "SeriesNumberPool",
                newName: "SeriesNumberPool",
                newSchema: "SRNRPL");

            migrationBuilder.RenameTable(
                name: "SeriesNumber",
                schema: "SeriesNumberPool",
                newName: "SeriesNumber",
                newSchema: "SRNRPL");

            migrationBuilder.RenameTable(
                name: "SeriesCategory",
                schema: "SeriesNumberPool",
                newName: "SeriesCategory",
                newSchema: "SRNRPL");

            migrationBuilder.RenameTable(
                name: "Series",
                schema: "SeriesNumberPool",
                newName: "Series",
                newSchema: "SRNRPL");

            migrationBuilder.RenameTable(
                name: "AuctionResult",
                schema: "SeriesNumberPool",
                newName: "AuctionResult",
                newSchema: "SRNRPL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "SeriesNumberPool");

            migrationBuilder.RenameTable(
                name: "SeriesType",
                schema: "SRNRPL",
                newName: "SeriesType",
                newSchema: "SeriesNumberPool");

            migrationBuilder.RenameTable(
                name: "SeriesStatusHistory",
                schema: "SRNRPL",
                newName: "SeriesStatusHistory",
                newSchema: "SeriesNumberPool");

            migrationBuilder.RenameTable(
                name: "SeriesStatus",
                schema: "SRNRPL",
                newName: "SeriesStatus",
                newSchema: "SeriesNumberPool");

            migrationBuilder.RenameTable(
                name: "SeriesNumberPool",
                schema: "SRNRPL",
                newName: "SeriesNumberPool",
                newSchema: "SeriesNumberPool");

            migrationBuilder.RenameTable(
                name: "SeriesNumber",
                schema: "SRNRPL",
                newName: "SeriesNumber",
                newSchema: "SeriesNumberPool");

            migrationBuilder.RenameTable(
                name: "SeriesCategory",
                schema: "SRNRPL",
                newName: "SeriesCategory",
                newSchema: "SeriesNumberPool");

            migrationBuilder.RenameTable(
                name: "Series",
                schema: "SRNRPL",
                newName: "Series",
                newSchema: "SeriesNumberPool");

            migrationBuilder.RenameTable(
                name: "AuctionResult",
                schema: "SRNRPL",
                newName: "AuctionResult",
                newSchema: "SeriesNumberPool");
        }
    }
}
