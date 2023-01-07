using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _50 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsBuyer",
                schema: "Biometric",
                table: "BiometricVerification",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "OwnerGroupId",
                schema: "Biometric",
                table: "BiometricVerification",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_BiometricVerification_OwnerGroupId",
                schema: "Biometric",
                table: "BiometricVerification",
                column: "OwnerGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_BiometricVerification_OwnerGroup_OwnerGroupId",
                schema: "Biometric",
                table: "BiometricVerification",
                column: "OwnerGroupId",
                principalSchema: "Core",
                principalTable: "OwnerGroup",
                principalColumn: "OwnerGroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BiometricVerification_OwnerGroup_OwnerGroupId",
                schema: "Biometric",
                table: "BiometricVerification");

            migrationBuilder.DropIndex(
                name: "IX_BiometricVerification_OwnerGroupId",
                schema: "Biometric",
                table: "BiometricVerification");

            migrationBuilder.DropColumn(
                name: "IsBuyer",
                schema: "Biometric",
                table: "BiometricVerification");

            migrationBuilder.DropColumn(
                name: "OwnerGroupId",
                schema: "Biometric",
                table: "BiometricVerification");
        }
    }
}
