using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _59 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "VehicleMakerId",
                schema: "Setup",
                table: "VehicleMake",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VehicleMake_VehicleMakerId",
                schema: "Setup",
                table: "VehicleMake",
                column: "VehicleMakerId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleMake_VehicleMaker_VehicleMakerId",
                schema: "Setup",
                table: "VehicleMake",
                column: "VehicleMakerId",
                principalSchema: "Setup",
                principalTable: "VehicleMaker",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehicleMake_VehicleMaker_VehicleMakerId",
                schema: "Setup",
                table: "VehicleMake");

            migrationBuilder.DropIndex(
                name: "IX_VehicleMake_VehicleMakerId",
                schema: "Setup",
                table: "VehicleMake");

            migrationBuilder.DropColumn(
                name: "VehicleMakerId",
                schema: "Setup",
                table: "VehicleMake");
        }
    }
}
