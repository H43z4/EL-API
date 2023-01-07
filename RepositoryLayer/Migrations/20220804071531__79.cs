using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _79 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "SeriesNumberPoolId",
                schema: "Core",
                table: "VehicleRegistrationHistory",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "DistrictId",
                schema: "SRNRPL",
                table: "SeriesNumberPool",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PSId",
                schema: "Payments",
                table: "PaymentInfo",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BankCode",
                schema: "Payments",
                table: "PaymentInfo",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VehicleRegistrationHistory_SeriesNumberPoolId",
                schema: "Core",
                table: "VehicleRegistrationHistory",
                column: "SeriesNumberPoolId");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumberPool_DistrictId",
                schema: "SRNRPL",
                table: "SeriesNumberPool",
                column: "DistrictId");

            migrationBuilder.AddForeignKey(
                name: "FK_SeriesNumberPool_District_DistrictId",
                schema: "SRNRPL",
                table: "SeriesNumberPool",
                column: "DistrictId",
                principalSchema: "Setup",
                principalTable: "District",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleRegistrationHistory_SeriesNumberPool_SeriesNumberPoolId",
                schema: "Core",
                table: "VehicleRegistrationHistory",
                column: "SeriesNumberPoolId",
                principalSchema: "SRNRPL",
                principalTable: "SeriesNumberPool",
                principalColumn: "SeriesNumberPoolId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SeriesNumberPool_District_DistrictId",
                schema: "SRNRPL",
                table: "SeriesNumberPool");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleRegistrationHistory_SeriesNumberPool_SeriesNumberPoolId",
                schema: "Core",
                table: "VehicleRegistrationHistory");

            migrationBuilder.DropIndex(
                name: "IX_VehicleRegistrationHistory_SeriesNumberPoolId",
                schema: "Core",
                table: "VehicleRegistrationHistory");

            migrationBuilder.DropIndex(
                name: "IX_SeriesNumberPool_DistrictId",
                schema: "SRNRPL",
                table: "SeriesNumberPool");

            migrationBuilder.DropColumn(
                name: "SeriesNumberPoolId",
                schema: "Core",
                table: "VehicleRegistrationHistory");

            migrationBuilder.DropColumn(
                name: "DistrictId",
                schema: "SRNRPL",
                table: "SeriesNumberPool");

            migrationBuilder.AlterColumn<string>(
                name: "PSId",
                schema: "Payments",
                table: "PaymentInfo",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BankCode",
                schema: "Payments",
                table: "PaymentInfo",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);
        }
    }
}
