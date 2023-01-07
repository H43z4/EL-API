using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _58 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "AssessmentBaseId",
                schema: "Core",
                table: "Challan",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<long>(
                name: "VehiclePurchaseTypeId",
                schema: "Core",
                table: "AssessmentBase",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Challan_AssessmentBaseId",
                schema: "Core",
                table: "Challan",
                column: "AssessmentBaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Challan_AssessmentBase_AssessmentBaseId",
                schema: "Core",
                table: "Challan",
                column: "AssessmentBaseId",
                principalSchema: "Core",
                principalTable: "AssessmentBase",
                principalColumn: "AssessmentBaseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Challan_AssessmentBase_AssessmentBaseId",
                schema: "Core",
                table: "Challan");

            migrationBuilder.DropIndex(
                name: "IX_Challan_AssessmentBaseId",
                schema: "Core",
                table: "Challan");

            migrationBuilder.DropColumn(
                name: "AssessmentBaseId",
                schema: "Core",
                table: "Challan");

            migrationBuilder.AlterColumn<long>(
                name: "VehiclePurchaseTypeId",
                schema: "Core",
                table: "AssessmentBase",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");
        }
    }
}
