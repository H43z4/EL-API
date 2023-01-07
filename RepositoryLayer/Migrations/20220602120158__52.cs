using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _52 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ApplicationReceivedAt",
                schema: "Core",
                table: "AssessmentBase",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfFirstRegistration",
                schema: "Core",
                table: "AssessmentBase",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FitnessCertValidFrom",
                schema: "Core",
                table: "AssessmentBase",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FitnessCertValidTo",
                schema: "Core",
                table: "AssessmentBase",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsIncomeTaxExempted",
                schema: "Core",
                table: "AssessmentBase",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsTaxExempted",
                schema: "Core",
                table: "AssessmentBase",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RegistrationDate",
                schema: "Core",
                table: "AssessmentBase",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RegistrationNo",
                schema: "Core",
                table: "AssessmentBase",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TaxFrequency",
                schema: "Core",
                table: "AssessmentBase",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "TaxPaidUpto",
                schema: "Core",
                table: "AssessmentBase",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "VehicleStatusId",
                schema: "Core",
                table: "AssessmentBase",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_VehicleStatusId",
                schema: "Core",
                table: "AssessmentBase",
                column: "VehicleStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentBase_VehicleStatus_VehicleStatusId",
                schema: "Core",
                table: "AssessmentBase",
                column: "VehicleStatusId",
                principalSchema: "Setup",
                principalTable: "VehicleStatus",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssessmentBase_VehicleStatus_VehicleStatusId",
                schema: "Core",
                table: "AssessmentBase");

            migrationBuilder.DropIndex(
                name: "IX_AssessmentBase_VehicleStatusId",
                schema: "Core",
                table: "AssessmentBase");

            migrationBuilder.DropColumn(
                name: "ApplicationReceivedAt",
                schema: "Core",
                table: "AssessmentBase");

            migrationBuilder.DropColumn(
                name: "DateOfFirstRegistration",
                schema: "Core",
                table: "AssessmentBase");

            migrationBuilder.DropColumn(
                name: "FitnessCertValidFrom",
                schema: "Core",
                table: "AssessmentBase");

            migrationBuilder.DropColumn(
                name: "FitnessCertValidTo",
                schema: "Core",
                table: "AssessmentBase");

            migrationBuilder.DropColumn(
                name: "IsIncomeTaxExempted",
                schema: "Core",
                table: "AssessmentBase");

            migrationBuilder.DropColumn(
                name: "IsTaxExempted",
                schema: "Core",
                table: "AssessmentBase");

            migrationBuilder.DropColumn(
                name: "RegistrationDate",
                schema: "Core",
                table: "AssessmentBase");

            migrationBuilder.DropColumn(
                name: "RegistrationNo",
                schema: "Core",
                table: "AssessmentBase");

            migrationBuilder.DropColumn(
                name: "TaxFrequency",
                schema: "Core",
                table: "AssessmentBase");

            migrationBuilder.DropColumn(
                name: "TaxPaidUpto",
                schema: "Core",
                table: "AssessmentBase");

            migrationBuilder.DropColumn(
                name: "VehicleStatusId",
                schema: "Core",
                table: "AssessmentBase");
        }
    }
}
