using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _56 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TaxPeriod",
                schema: "Core",
                table: "VehicleAdditionalInfo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsFiler",
                schema: "Core",
                table: "AssessmentBase",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "TaxPeriod",
                schema: "Core",
                table: "AssessmentBase",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "VehiclePurchaseTypeId",
                schema: "Core",
                table: "AssessmentBase",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_VehiclePurchaseTypeId",
                schema: "Core",
                table: "AssessmentBase",
                column: "VehiclePurchaseTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentBase_VehiclePurchaseType_VehiclePurchaseTypeId",
                schema: "Core",
                table: "AssessmentBase",
                column: "VehiclePurchaseTypeId",
                principalSchema: "Setup",
                principalTable: "VehiclePurchaseType",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssessmentBase_VehiclePurchaseType_VehiclePurchaseTypeId",
                schema: "Core",
                table: "AssessmentBase");

            migrationBuilder.DropIndex(
                name: "IX_AssessmentBase_VehiclePurchaseTypeId",
                schema: "Core",
                table: "AssessmentBase");

            migrationBuilder.DropColumn(
                name: "TaxPeriod",
                schema: "Core",
                table: "VehicleAdditionalInfo");

            migrationBuilder.DropColumn(
                name: "IsFiler",
                schema: "Core",
                table: "AssessmentBase");

            migrationBuilder.DropColumn(
                name: "TaxPeriod",
                schema: "Core",
                table: "AssessmentBase");

            migrationBuilder.DropColumn(
                name: "VehiclePurchaseTypeId",
                schema: "Core",
                table: "AssessmentBase");
        }
    }
}
