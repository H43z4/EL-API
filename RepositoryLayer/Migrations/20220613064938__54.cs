using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _54 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "VehicleSchemeId",
                schema: "Core",
                table: "VehicleImportInfo",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImportInfo_VehicleSchemeId",
                schema: "Core",
                table: "VehicleImportInfo",
                column: "VehicleSchemeId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleImportInfo_VehicleScheme_VehicleSchemeId",
                schema: "Core",
                table: "VehicleImportInfo",
                column: "VehicleSchemeId",
                principalSchema: "Setup",
                principalTable: "VehicleScheme",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehicleImportInfo_VehicleScheme_VehicleSchemeId",
                schema: "Core",
                table: "VehicleImportInfo");

            migrationBuilder.DropIndex(
                name: "IX_VehicleImportInfo_VehicleSchemeId",
                schema: "Core",
                table: "VehicleImportInfo");

            migrationBuilder.DropColumn(
                name: "VehicleSchemeId",
                schema: "Core",
                table: "VehicleImportInfo");
        }
    }
}
