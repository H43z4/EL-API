using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _67 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Business_BusinessId",
                schema: "Auth",
                table: "User");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_User_District_UserDistrictId",
            //    schema: "Auth",
            //    table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Person_PersonId",
                schema: "Auth",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_User_UserId1",
                schema: "Auth",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_BusinessId",
                schema: "Auth",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_PersonId",
                schema: "Auth",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_UserDistrictId",
                schema: "Auth",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_UserId1",
                schema: "Auth",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_Person_CreatedBy",
                schema: "Core",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Business_CreatedBy",
                schema: "Core",
                table: "Business");

            migrationBuilder.RenameColumn(
                name: "UserId1",
                schema: "Auth",
                table: "User",
                newName: "ModifiedBy");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "VehicleUsage",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "VehicleUsage",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "VehicleType",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "VehicleType",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "VehicleStatus",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "VehicleStatus",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "VehicleScheme",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "VehicleScheme",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "VehicleRouteType",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "VehicleRouteType",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Core",
                table: "VehicleRegistrationHistory",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Core",
                table: "VehicleRegistrationHistory",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "VehicleRCStatus",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "VehicleRCStatus",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "VehiclePurchaseType",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "VehiclePurchaseType",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Core",
                table: "VehiclePurchaseInfo",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Core",
                table: "VehiclePurchaseInfo",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Core",
                table: "VehicleOwnershipHistory",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Core",
                table: "VehicleOwnershipHistory",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "VehicleMaker",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "VehicleMaker",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "VehicleMake",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "VehicleMake",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Core",
                table: "VehicleImportInfo",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Core",
                table: "VehicleImportInfo",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "VehicleFuelType",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "VehicleFuelType",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "VehicleEngineType",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "VehicleEngineType",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "VehicleDocumentType",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "VehicleDocumentType",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Core",
                table: "VehicleDocument",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Core",
                table: "VehicleDocument",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "VehicleColor",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "VehicleColor",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "VehicleClassification",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "VehicleClassification",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "VehicleClassDetail",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "VehicleClassDetail",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "VehicleClass",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "VehicleClass",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "VehicleCategory",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "VehicleCategory",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Core",
                table: "VehicleBusinessProcessHistory",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Core",
                table: "VehicleBusinessProcessHistory",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "VehicleBodyType",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "VehicleBodyType",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "VehicleBodyConvention",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "VehicleBodyConvention",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Core",
                table: "VehicleAuctionInfo",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Core",
                table: "VehicleAuctionInfo",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Core",
                table: "VehicleAdditionalInfo",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Core",
                table: "VehicleAdditionalInfo",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Core",
                table: "Vehicle",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Core",
                table: "Vehicle",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Auth",
                table: "UserType",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Auth",
                table: "UserType",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Auth",
                table: "UserStatus",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Auth",
                table: "UserStatus",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Auth",
                table: "UserRoleHistory",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Auth",
                table: "UserRoleHistory",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Auth",
                table: "UserRole",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Auth",
                table: "UserRole",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Auth",
                table: "User",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "Tehsil",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "Tehsil",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "TaxType",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "TaxType",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "TaxRule",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "TaxRule",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "TaxRate",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "TaxRate",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "TaxBase",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "TaxBase",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Logs",
                table: "SqlExceptionLog",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Logs",
                table: "SqlExceptionLog",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "SRNRPL",
                table: "SeriesType",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "SRNRPL",
                table: "SeriesType",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "SRNRPL",
                table: "SeriesStatusHistory",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "SRNRPL",
                table: "SeriesStatusHistory",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "SRNRPL",
                table: "SeriesStatus",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "SRNRPL",
                table: "SeriesStatus",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "SRNRPL",
                table: "SeriesNumberPool",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "SRNRPL",
                table: "SeriesNumberPool",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "SRNRPL",
                table: "SeriesNumber",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "SRNRPL",
                table: "SeriesNumber",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "SRNRPL",
                table: "SeriesCategory",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "SRNRPL",
                table: "SeriesCategory",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "SRNRPL",
                table: "Series",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "SRNRPL",
                table: "Series",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Auth",
                table: "RoleResourceRightsHistory",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Auth",
                table: "RoleResourceRightsHistory",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Auth",
                table: "RoleResourceRight",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Auth",
                table: "RoleResourceRight",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Auth",
                table: "RoleResource",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Auth",
                table: "RoleResource",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Auth",
                table: "RoleAppProcessFlow",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Auth",
                table: "RoleAppProcessFlow",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Auth",
                table: "Role",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Auth",
                table: "Role",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Auth",
                table: "ResourceTypeRight",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Auth",
                table: "ResourceTypeRight",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Auth",
                table: "ResourceTypeDefaultRight",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Auth",
                table: "ResourceTypeDefaultRight",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Auth",
                table: "ResourceType",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Auth",
                table: "ResourceType",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Auth",
                table: "ResourceController",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Auth",
                table: "ResourceController",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Auth",
                table: "ResourceAction",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Auth",
                table: "ResourceAction",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Auth",
                table: "Resource",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Auth",
                table: "Resource",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Core",
                table: "Remarks",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Core",
                table: "Remarks",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "RegFeePenaltyRate",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "RegFeePenaltyRate",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "Port",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "Port",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "PhoneNumberType",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "PhoneNumberType",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Core",
                table: "PhoneNumber",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Core",
                table: "PhoneNumber",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Core",
                table: "Person",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Core",
                table: "Person",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "PaymentStatus",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "PaymentStatus",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "PaymentMode",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "PaymentMode",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Core",
                table: "Payment",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Core",
                table: "Payment",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "OwnerType",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "OwnerType",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "OwnerTaxGroup",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "OwnerTaxGroup",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "OwnerStatus",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "OwnerStatus",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Core",
                table: "OwnerGroup",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Core",
                table: "OwnerGroup",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Core",
                table: "Owner",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Core",
                table: "Owner",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "OrganizationCategory",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "OrganizationCategory",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Biometric",
                table: "NadraFranchise",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Biometric",
                table: "NadraFranchise",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Core",
                table: "Keeper",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Core",
                table: "Keeper",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Logs",
                table: "HttpRequestLog",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Logs",
                table: "HttpRequestLog",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Core",
                table: "HPAStatusHistory",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Core",
                table: "HPAStatusHistory",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "HPAStatus",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "HPAStatus",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Core",
                table: "HPA",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Core",
                table: "HPA",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Auth",
                table: "GlobalRight",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Auth",
                table: "GlobalRight",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "District",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "District",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Core",
                table: "Dealer",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Core",
                table: "Dealer",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "CustomCollectorate",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "CustomCollectorate",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "Country",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "Country",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "ClearingAgent",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "ClearingAgent",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "ChallanType",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "ChallanType",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "ChallanStatus",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "ChallanStatus",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Core",
                table: "Challan",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Core",
                table: "Challan",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "BusinessType",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "BusinessType",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "BusinessTableAccessLevel",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "BusinessTableAccessLevel",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "BusinessTable",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "BusinessTable",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "BusinessStatus",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "BusinessStatus",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "BusinessSector",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "BusinessSector",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "BusinessRepStatus",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "BusinessRepStatus",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Core",
                table: "BusinessRep",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Core",
                table: "BusinessRep",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "BusinessProFeeTax",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "BusinessProFeeTax",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "BusinessProcess",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "BusinessProcess",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "BusinessPhaseStatus",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "BusinessPhaseStatus",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "BusinessPhase",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "BusinessPhase",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "BusinessEvent",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "BusinessEvent",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Core",
                table: "Business",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Core",
                table: "Business",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Biometric",
                table: "BiometricVerification",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Biometric",
                table: "BiometricVerification",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "Bank",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "Bank",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "SRNRPL",
                table: "AuctionResult",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "SRNRPL",
                table: "AuctionResult",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "AssessmentStatus",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "AssessmentStatus",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Core",
                table: "AssessmentDetail",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Core",
                table: "AssessmentDetail",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Core",
                table: "AssessmentBase",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Core",
                table: "AssessmentBase",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "ApplicationStatus",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "ApplicationStatus",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "ApplicationProcessFlow",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "ApplicationProcessFlow",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Core",
                table: "Application",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Core",
                table: "Application",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "AddressType",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "AddressType",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Core",
                table: "Address",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Core",
                table: "Address",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Setup",
                table: "AccountHead",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                schema: "Setup",
                table: "AccountHead",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VehicleUsage_ModifiedBy",
                schema: "Setup",
                table: "VehicleUsage",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleType_ModifiedBy",
                schema: "Setup",
                table: "VehicleType",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleStatus_ModifiedBy",
                schema: "Setup",
                table: "VehicleStatus",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleScheme_ModifiedBy",
                schema: "Setup",
                table: "VehicleScheme",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleRouteType_ModifiedBy",
                schema: "Setup",
                table: "VehicleRouteType",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleRegistrationHistory_ModifiedBy",
                schema: "Core",
                table: "VehicleRegistrationHistory",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleRCStatus_ModifiedBy",
                schema: "Setup",
                table: "VehicleRCStatus",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehiclePurchaseType_ModifiedBy",
                schema: "Setup",
                table: "VehiclePurchaseType",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehiclePurchaseInfo_ModifiedBy",
                schema: "Core",
                table: "VehiclePurchaseInfo",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleOwnershipHistory_ModifiedBy",
                schema: "Core",
                table: "VehicleOwnershipHistory",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleMaker_ModifiedBy",
                schema: "Setup",
                table: "VehicleMaker",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleMake_ModifiedBy",
                schema: "Setup",
                table: "VehicleMake",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImportInfo_ModifiedBy",
                schema: "Core",
                table: "VehicleImportInfo",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleFuelType_ModifiedBy",
                schema: "Setup",
                table: "VehicleFuelType",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleEngineType_ModifiedBy",
                schema: "Setup",
                table: "VehicleEngineType",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleDocumentType_ModifiedBy",
                schema: "Setup",
                table: "VehicleDocumentType",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleDocument_ModifiedBy",
                schema: "Core",
                table: "VehicleDocument",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleColor_ModifiedBy",
                schema: "Setup",
                table: "VehicleColor",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClassification_ModifiedBy",
                schema: "Setup",
                table: "VehicleClassification",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClassDetail_ModifiedBy",
                schema: "Setup",
                table: "VehicleClassDetail",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClass_ModifiedBy",
                schema: "Setup",
                table: "VehicleClass",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleCategory_ModifiedBy",
                schema: "Setup",
                table: "VehicleCategory",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBusinessProcessHistory_ModifiedBy",
                schema: "Core",
                table: "VehicleBusinessProcessHistory",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBodyType_ModifiedBy",
                schema: "Setup",
                table: "VehicleBodyType",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBodyConvention_ModifiedBy",
                schema: "Setup",
                table: "VehicleBodyConvention",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAuctionInfo_ModifiedBy",
                schema: "Core",
                table: "VehicleAuctionInfo",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAdditionalInfo_ModifiedBy",
                schema: "Core",
                table: "VehicleAdditionalInfo",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_ModifiedBy",
                schema: "Core",
                table: "Vehicle",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserType_ModifiedBy",
                schema: "Auth",
                table: "UserType",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserStatus_ModifiedBy",
                schema: "Auth",
                table: "UserStatus",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleHistory_ModifiedBy",
                schema: "Auth",
                table: "UserRoleHistory",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_ModifiedBy",
                schema: "Auth",
                table: "UserRole",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_User_ModifiedBy",
                schema: "Auth",
                table: "User",
                column: "ModifiedBy",
                unique: true,
                filter: "[ModifiedBy] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Tehsil_ModifiedBy",
                schema: "Setup",
                table: "Tehsil",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TaxType_ModifiedBy",
                schema: "Setup",
                table: "TaxType",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TaxRule_ModifiedBy",
                schema: "Setup",
                table: "TaxRule",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TaxRate_ModifiedBy",
                schema: "Setup",
                table: "TaxRate",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TaxBase_ModifiedBy",
                schema: "Setup",
                table: "TaxBase",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SqlExceptionLog_ModifiedBy",
                schema: "Logs",
                table: "SqlExceptionLog",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesType_ModifiedBy",
                schema: "SRNRPL",
                table: "SeriesType",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesStatusHistory_ModifiedBy",
                schema: "SRNRPL",
                table: "SeriesStatusHistory",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesStatus_ModifiedBy",
                schema: "SRNRPL",
                table: "SeriesStatus",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumberPool_ModifiedBy",
                schema: "SRNRPL",
                table: "SeriesNumberPool",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumber_ModifiedBy",
                schema: "SRNRPL",
                table: "SeriesNumber",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesCategory_ModifiedBy",
                schema: "SRNRPL",
                table: "SeriesCategory",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Series_ModifiedBy",
                schema: "SRNRPL",
                table: "Series",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_RoleResourceRightsHistory_ModifiedBy",
                schema: "Auth",
                table: "RoleResourceRightsHistory",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_RoleResourceRight_ModifiedBy",
                schema: "Auth",
                table: "RoleResourceRight",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_RoleResource_ModifiedBy",
                schema: "Auth",
                table: "RoleResource",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_RoleAppProcessFlow_ModifiedBy",
                schema: "Auth",
                table: "RoleAppProcessFlow",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Role_ModifiedBy",
                schema: "Auth",
                table: "Role",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceTypeRight_ModifiedBy",
                schema: "Auth",
                table: "ResourceTypeRight",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceTypeDefaultRight_ModifiedBy",
                schema: "Auth",
                table: "ResourceTypeDefaultRight",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceType_ModifiedBy",
                schema: "Auth",
                table: "ResourceType",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceController_ModifiedBy",
                schema: "Auth",
                table: "ResourceController",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceAction_ModifiedBy",
                schema: "Auth",
                table: "ResourceAction",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Resource_ModifiedBy",
                schema: "Auth",
                table: "Resource",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Remarks_ModifiedBy",
                schema: "Core",
                table: "Remarks",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_RegFeePenaltyRate_ModifiedBy",
                schema: "Setup",
                table: "RegFeePenaltyRate",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Port_ModifiedBy",
                schema: "Setup",
                table: "Port",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumberType_ModifiedBy",
                schema: "Setup",
                table: "PhoneNumberType",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumber_ModifiedBy",
                schema: "Core",
                table: "PhoneNumber",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Person_CreatedBy",
                schema: "Core",
                table: "Person",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Person_ModifiedBy",
                schema: "Core",
                table: "Person",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentStatus_ModifiedBy",
                schema: "Setup",
                table: "PaymentStatus",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMode_ModifiedBy",
                schema: "Setup",
                table: "PaymentMode",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_ModifiedBy",
                schema: "Core",
                table: "Payment",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerType_ModifiedBy",
                schema: "Setup",
                table: "OwnerType",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerTaxGroup_ModifiedBy",
                schema: "Setup",
                table: "OwnerTaxGroup",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerStatus_ModifiedBy",
                schema: "Setup",
                table: "OwnerStatus",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerGroup_ModifiedBy",
                schema: "Core",
                table: "OwnerGroup",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Owner_ModifiedBy",
                schema: "Core",
                table: "Owner",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationCategory_ModifiedBy",
                schema: "Setup",
                table: "OrganizationCategory",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_NadraFranchise_ModifiedBy",
                schema: "Biometric",
                table: "NadraFranchise",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Keeper_ModifiedBy",
                schema: "Core",
                table: "Keeper",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_HttpRequestLog_ModifiedBy",
                schema: "Logs",
                table: "HttpRequestLog",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_HPAStatusHistory_ModifiedBy",
                schema: "Core",
                table: "HPAStatusHistory",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_HPAStatus_ModifiedBy",
                schema: "Setup",
                table: "HPAStatus",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_HPA_ModifiedBy",
                schema: "Core",
                table: "HPA",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalRight_ModifiedBy",
                schema: "Auth",
                table: "GlobalRight",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_District_ModifiedBy",
                schema: "Setup",
                table: "District",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Dealer_ModifiedBy",
                schema: "Core",
                table: "Dealer",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CustomCollectorate_ModifiedBy",
                schema: "Setup",
                table: "CustomCollectorate",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Country_ModifiedBy",
                schema: "Setup",
                table: "Country",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ClearingAgent_ModifiedBy",
                schema: "Setup",
                table: "ClearingAgent",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ChallanType_ModifiedBy",
                schema: "Setup",
                table: "ChallanType",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ChallanStatus_ModifiedBy",
                schema: "Setup",
                table: "ChallanStatus",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Challan_ModifiedBy",
                schema: "Core",
                table: "Challan",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessType_ModifiedBy",
                schema: "Setup",
                table: "BusinessType",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTableAccessLevel_ModifiedBy",
                schema: "Setup",
                table: "BusinessTableAccessLevel",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTable_ModifiedBy",
                schema: "Setup",
                table: "BusinessTable",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessStatus_ModifiedBy",
                schema: "Setup",
                table: "BusinessStatus",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessSector_ModifiedBy",
                schema: "Setup",
                table: "BusinessSector",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessRepStatus_ModifiedBy",
                schema: "Setup",
                table: "BusinessRepStatus",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessRep_ModifiedBy",
                schema: "Core",
                table: "BusinessRep",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessProFeeTax_ModifiedBy",
                schema: "Setup",
                table: "BusinessProFeeTax",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessProcess_ModifiedBy",
                schema: "Setup",
                table: "BusinessProcess",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessPhaseStatus_ModifiedBy",
                schema: "Setup",
                table: "BusinessPhaseStatus",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessPhase_ModifiedBy",
                schema: "Setup",
                table: "BusinessPhase",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessEvent_ModifiedBy",
                schema: "Setup",
                table: "BusinessEvent",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Business_CreatedBy",
                schema: "Core",
                table: "Business",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Business_ModifiedBy",
                schema: "Core",
                table: "Business",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BiometricVerification_ModifiedBy",
                schema: "Biometric",
                table: "BiometricVerification",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Bank_ModifiedBy",
                schema: "Setup",
                table: "Bank",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AuctionResult_ModifiedBy",
                schema: "SRNRPL",
                table: "AuctionResult",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentStatus_ModifiedBy",
                schema: "Setup",
                table: "AssessmentStatus",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentDetail_ModifiedBy",
                schema: "Core",
                table: "AssessmentDetail",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_ModifiedBy",
                schema: "Core",
                table: "AssessmentBase",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationStatus_ModifiedBy",
                schema: "Setup",
                table: "ApplicationStatus",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationProcessFlow_ModifiedBy",
                schema: "Setup",
                table: "ApplicationProcessFlow",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Application_ModifiedBy",
                schema: "Core",
                table: "Application",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AddressType_ModifiedBy",
                schema: "Setup",
                table: "AddressType",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Address_ModifiedBy",
                schema: "Core",
                table: "Address",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AccountHead_ModifiedBy",
                schema: "Setup",
                table: "AccountHead",
                column: "ModifiedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountHead_User_ModifiedBy",
                schema: "Setup",
                table: "AccountHead",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_User_ModifiedBy",
                schema: "Core",
                table: "Address",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AddressType_User_ModifiedBy",
                schema: "Setup",
                table: "AddressType",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Application_User_ModifiedBy",
                schema: "Core",
                table: "Application",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationProcessFlow_User_ModifiedBy",
                schema: "Setup",
                table: "ApplicationProcessFlow",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationStatus_User_ModifiedBy",
                schema: "Setup",
                table: "ApplicationStatus",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentBase_User_ModifiedBy",
                schema: "Core",
                table: "AssessmentBase",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentDetail_User_ModifiedBy",
                schema: "Core",
                table: "AssessmentDetail",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentStatus_User_ModifiedBy",
                schema: "Setup",
                table: "AssessmentStatus",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AuctionResult_User_ModifiedBy",
                schema: "SRNRPL",
                table: "AuctionResult",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bank_User_ModifiedBy",
                schema: "Setup",
                table: "Bank",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BiometricVerification_User_ModifiedBy",
                schema: "Biometric",
                table: "BiometricVerification",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Business_User_ModifiedBy",
                schema: "Core",
                table: "Business",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessEvent_User_ModifiedBy",
                schema: "Setup",
                table: "BusinessEvent",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessPhase_User_ModifiedBy",
                schema: "Setup",
                table: "BusinessPhase",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessPhaseStatus_User_ModifiedBy",
                schema: "Setup",
                table: "BusinessPhaseStatus",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessProcess_User_ModifiedBy",
                schema: "Setup",
                table: "BusinessProcess",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessProFeeTax_User_ModifiedBy",
                schema: "Setup",
                table: "BusinessProFeeTax",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessRep_User_ModifiedBy",
                schema: "Core",
                table: "BusinessRep",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessRepStatus_User_ModifiedBy",
                schema: "Setup",
                table: "BusinessRepStatus",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessSector_User_ModifiedBy",
                schema: "Setup",
                table: "BusinessSector",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessStatus_User_ModifiedBy",
                schema: "Setup",
                table: "BusinessStatus",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessTable_User_ModifiedBy",
                schema: "Setup",
                table: "BusinessTable",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessTableAccessLevel_User_ModifiedBy",
                schema: "Setup",
                table: "BusinessTableAccessLevel",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessType_User_ModifiedBy",
                schema: "Setup",
                table: "BusinessType",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Challan_User_ModifiedBy",
                schema: "Core",
                table: "Challan",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChallanStatus_User_ModifiedBy",
                schema: "Setup",
                table: "ChallanStatus",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChallanType_User_ModifiedBy",
                schema: "Setup",
                table: "ChallanType",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClearingAgent_User_ModifiedBy",
                schema: "Setup",
                table: "ClearingAgent",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Country_User_ModifiedBy",
                schema: "Setup",
                table: "Country",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomCollectorate_User_ModifiedBy",
                schema: "Setup",
                table: "CustomCollectorate",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dealer_User_ModifiedBy",
                schema: "Core",
                table: "Dealer",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_District_User_ModifiedBy",
                schema: "Setup",
                table: "District",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_GlobalRight_User_ModifiedBy",
                schema: "Auth",
                table: "GlobalRight",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_HPA_User_ModifiedBy",
                schema: "Core",
                table: "HPA",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_HPAStatus_User_ModifiedBy",
                schema: "Setup",
                table: "HPAStatus",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_HPAStatusHistory_User_ModifiedBy",
                schema: "Core",
                table: "HPAStatusHistory",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_HttpRequestLog_User_ModifiedBy",
                schema: "Logs",
                table: "HttpRequestLog",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Keeper_User_ModifiedBy",
                schema: "Core",
                table: "Keeper",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_NadraFranchise_User_ModifiedBy",
                schema: "Biometric",
                table: "NadraFranchise",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrganizationCategory_User_ModifiedBy",
                schema: "Setup",
                table: "OrganizationCategory",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Owner_User_ModifiedBy",
                schema: "Core",
                table: "Owner",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_OwnerGroup_User_ModifiedBy",
                schema: "Core",
                table: "OwnerGroup",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_OwnerStatus_User_ModifiedBy",
                schema: "Setup",
                table: "OwnerStatus",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_OwnerTaxGroup_User_ModifiedBy",
                schema: "Setup",
                table: "OwnerTaxGroup",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_OwnerType_User_ModifiedBy",
                schema: "Setup",
                table: "OwnerType",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_User_ModifiedBy",
                schema: "Core",
                table: "Payment",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMode_User_ModifiedBy",
                schema: "Setup",
                table: "PaymentMode",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentStatus_User_ModifiedBy",
                schema: "Setup",
                table: "PaymentStatus",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_User_ModifiedBy",
                schema: "Core",
                table: "Person",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumber_User_ModifiedBy",
                schema: "Core",
                table: "PhoneNumber",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumberType_User_ModifiedBy",
                schema: "Setup",
                table: "PhoneNumberType",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Port_User_ModifiedBy",
                schema: "Setup",
                table: "Port",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_RegFeePenaltyRate_User_ModifiedBy",
                schema: "Setup",
                table: "RegFeePenaltyRate",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Remarks_User_ModifiedBy",
                schema: "Core",
                table: "Remarks",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Resource_User_ModifiedBy",
                schema: "Auth",
                table: "Resource",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ResourceAction_User_ModifiedBy",
                schema: "Auth",
                table: "ResourceAction",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ResourceController_User_ModifiedBy",
                schema: "Auth",
                table: "ResourceController",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ResourceType_User_ModifiedBy",
                schema: "Auth",
                table: "ResourceType",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ResourceTypeDefaultRight_User_ModifiedBy",
                schema: "Auth",
                table: "ResourceTypeDefaultRight",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ResourceTypeRight_User_ModifiedBy",
                schema: "Auth",
                table: "ResourceTypeRight",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Role_User_ModifiedBy",
                schema: "Auth",
                table: "Role",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleAppProcessFlow_User_ModifiedBy",
                schema: "Auth",
                table: "RoleAppProcessFlow",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleResource_User_ModifiedBy",
                schema: "Auth",
                table: "RoleResource",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleResourceRight_User_ModifiedBy",
                schema: "Auth",
                table: "RoleResourceRight",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleResourceRightsHistory_User_ModifiedBy",
                schema: "Auth",
                table: "RoleResourceRightsHistory",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Series_User_ModifiedBy",
                schema: "SRNRPL",
                table: "Series",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SeriesCategory_User_ModifiedBy",
                schema: "SRNRPL",
                table: "SeriesCategory",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SeriesNumber_User_ModifiedBy",
                schema: "SRNRPL",
                table: "SeriesNumber",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SeriesNumberPool_User_ModifiedBy",
                schema: "SRNRPL",
                table: "SeriesNumberPool",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SeriesStatus_User_ModifiedBy",
                schema: "SRNRPL",
                table: "SeriesStatus",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SeriesStatusHistory_User_ModifiedBy",
                schema: "SRNRPL",
                table: "SeriesStatusHistory",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SeriesType_User_ModifiedBy",
                schema: "SRNRPL",
                table: "SeriesType",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SqlExceptionLog_User_ModifiedBy",
                schema: "Logs",
                table: "SqlExceptionLog",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaxBase_User_ModifiedBy",
                schema: "Setup",
                table: "TaxBase",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaxRate_User_ModifiedBy",
                schema: "Setup",
                table: "TaxRate",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaxRule_User_ModifiedBy",
                schema: "Setup",
                table: "TaxRule",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaxType_User_ModifiedBy",
                schema: "Setup",
                table: "TaxType",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tehsil_User_ModifiedBy",
                schema: "Setup",
                table: "Tehsil",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_User_ModifiedBy",
                schema: "Auth",
                table: "User",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_User_ModifiedBy",
                schema: "Auth",
                table: "UserRole",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoleHistory_User_ModifiedBy",
                schema: "Auth",
                table: "UserRoleHistory",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserStatus_User_ModifiedBy",
                schema: "Auth",
                table: "UserStatus",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserType_User_ModifiedBy",
                schema: "Auth",
                table: "UserType",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_User_ModifiedBy",
                schema: "Core",
                table: "Vehicle",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleAdditionalInfo_User_ModifiedBy",
                schema: "Core",
                table: "VehicleAdditionalInfo",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleAuctionInfo_User_ModifiedBy",
                schema: "Core",
                table: "VehicleAuctionInfo",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleBodyConvention_User_ModifiedBy",
                schema: "Setup",
                table: "VehicleBodyConvention",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleBodyType_User_ModifiedBy",
                schema: "Setup",
                table: "VehicleBodyType",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleBusinessProcessHistory_User_ModifiedBy",
                schema: "Core",
                table: "VehicleBusinessProcessHistory",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleCategory_User_ModifiedBy",
                schema: "Setup",
                table: "VehicleCategory",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleClass_User_ModifiedBy",
                schema: "Setup",
                table: "VehicleClass",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleClassDetail_User_ModifiedBy",
                schema: "Setup",
                table: "VehicleClassDetail",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleClassification_User_ModifiedBy",
                schema: "Setup",
                table: "VehicleClassification",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleColor_User_ModifiedBy",
                schema: "Setup",
                table: "VehicleColor",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleDocument_User_ModifiedBy",
                schema: "Core",
                table: "VehicleDocument",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleDocumentType_User_ModifiedBy",
                schema: "Setup",
                table: "VehicleDocumentType",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleEngineType_User_ModifiedBy",
                schema: "Setup",
                table: "VehicleEngineType",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleFuelType_User_ModifiedBy",
                schema: "Setup",
                table: "VehicleFuelType",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleImportInfo_User_ModifiedBy",
                schema: "Core",
                table: "VehicleImportInfo",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleMake_User_ModifiedBy",
                schema: "Setup",
                table: "VehicleMake",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleMaker_User_ModifiedBy",
                schema: "Setup",
                table: "VehicleMaker",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleOwnershipHistory_User_ModifiedBy",
                schema: "Core",
                table: "VehicleOwnershipHistory",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehiclePurchaseInfo_User_ModifiedBy",
                schema: "Core",
                table: "VehiclePurchaseInfo",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehiclePurchaseType_User_ModifiedBy",
                schema: "Setup",
                table: "VehiclePurchaseType",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleRCStatus_User_ModifiedBy",
                schema: "Setup",
                table: "VehicleRCStatus",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleRegistrationHistory_User_ModifiedBy",
                schema: "Core",
                table: "VehicleRegistrationHistory",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleRouteType_User_ModifiedBy",
                schema: "Setup",
                table: "VehicleRouteType",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleScheme_User_ModifiedBy",
                schema: "Setup",
                table: "VehicleScheme",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleStatus_User_ModifiedBy",
                schema: "Setup",
                table: "VehicleStatus",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleType_User_ModifiedBy",
                schema: "Setup",
                table: "VehicleType",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleUsage_User_ModifiedBy",
                schema: "Setup",
                table: "VehicleUsage",
                column: "ModifiedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountHead_User_ModifiedBy",
                schema: "Setup",
                table: "AccountHead");

            migrationBuilder.DropForeignKey(
                name: "FK_Address_User_ModifiedBy",
                schema: "Core",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_AddressType_User_ModifiedBy",
                schema: "Setup",
                table: "AddressType");

            migrationBuilder.DropForeignKey(
                name: "FK_Application_User_ModifiedBy",
                schema: "Core",
                table: "Application");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationProcessFlow_User_ModifiedBy",
                schema: "Setup",
                table: "ApplicationProcessFlow");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationStatus_User_ModifiedBy",
                schema: "Setup",
                table: "ApplicationStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_AssessmentBase_User_ModifiedBy",
                schema: "Core",
                table: "AssessmentBase");

            migrationBuilder.DropForeignKey(
                name: "FK_AssessmentDetail_User_ModifiedBy",
                schema: "Core",
                table: "AssessmentDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_AssessmentStatus_User_ModifiedBy",
                schema: "Setup",
                table: "AssessmentStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_AuctionResult_User_ModifiedBy",
                schema: "SRNRPL",
                table: "AuctionResult");

            migrationBuilder.DropForeignKey(
                name: "FK_Bank_User_ModifiedBy",
                schema: "Setup",
                table: "Bank");

            migrationBuilder.DropForeignKey(
                name: "FK_BiometricVerification_User_ModifiedBy",
                schema: "Biometric",
                table: "BiometricVerification");

            migrationBuilder.DropForeignKey(
                name: "FK_Business_User_ModifiedBy",
                schema: "Core",
                table: "Business");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessEvent_User_ModifiedBy",
                schema: "Setup",
                table: "BusinessEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessPhase_User_ModifiedBy",
                schema: "Setup",
                table: "BusinessPhase");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessPhaseStatus_User_ModifiedBy",
                schema: "Setup",
                table: "BusinessPhaseStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessProcess_User_ModifiedBy",
                schema: "Setup",
                table: "BusinessProcess");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessProFeeTax_User_ModifiedBy",
                schema: "Setup",
                table: "BusinessProFeeTax");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessRep_User_ModifiedBy",
                schema: "Core",
                table: "BusinessRep");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessRepStatus_User_ModifiedBy",
                schema: "Setup",
                table: "BusinessRepStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessSector_User_ModifiedBy",
                schema: "Setup",
                table: "BusinessSector");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessStatus_User_ModifiedBy",
                schema: "Setup",
                table: "BusinessStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessTable_User_ModifiedBy",
                schema: "Setup",
                table: "BusinessTable");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessTableAccessLevel_User_ModifiedBy",
                schema: "Setup",
                table: "BusinessTableAccessLevel");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessType_User_ModifiedBy",
                schema: "Setup",
                table: "BusinessType");

            migrationBuilder.DropForeignKey(
                name: "FK_Challan_User_ModifiedBy",
                schema: "Core",
                table: "Challan");

            migrationBuilder.DropForeignKey(
                name: "FK_ChallanStatus_User_ModifiedBy",
                schema: "Setup",
                table: "ChallanStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_ChallanType_User_ModifiedBy",
                schema: "Setup",
                table: "ChallanType");

            migrationBuilder.DropForeignKey(
                name: "FK_ClearingAgent_User_ModifiedBy",
                schema: "Setup",
                table: "ClearingAgent");

            migrationBuilder.DropForeignKey(
                name: "FK_Country_User_ModifiedBy",
                schema: "Setup",
                table: "Country");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomCollectorate_User_ModifiedBy",
                schema: "Setup",
                table: "CustomCollectorate");

            migrationBuilder.DropForeignKey(
                name: "FK_Dealer_User_ModifiedBy",
                schema: "Core",
                table: "Dealer");

            migrationBuilder.DropForeignKey(
                name: "FK_District_User_ModifiedBy",
                schema: "Setup",
                table: "District");

            migrationBuilder.DropForeignKey(
                name: "FK_GlobalRight_User_ModifiedBy",
                schema: "Auth",
                table: "GlobalRight");

            migrationBuilder.DropForeignKey(
                name: "FK_HPA_User_ModifiedBy",
                schema: "Core",
                table: "HPA");

            migrationBuilder.DropForeignKey(
                name: "FK_HPAStatus_User_ModifiedBy",
                schema: "Setup",
                table: "HPAStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_HPAStatusHistory_User_ModifiedBy",
                schema: "Core",
                table: "HPAStatusHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_HttpRequestLog_User_ModifiedBy",
                schema: "Logs",
                table: "HttpRequestLog");

            migrationBuilder.DropForeignKey(
                name: "FK_Keeper_User_ModifiedBy",
                schema: "Core",
                table: "Keeper");

            migrationBuilder.DropForeignKey(
                name: "FK_NadraFranchise_User_ModifiedBy",
                schema: "Biometric",
                table: "NadraFranchise");

            migrationBuilder.DropForeignKey(
                name: "FK_OrganizationCategory_User_ModifiedBy",
                schema: "Setup",
                table: "OrganizationCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_Owner_User_ModifiedBy",
                schema: "Core",
                table: "Owner");

            migrationBuilder.DropForeignKey(
                name: "FK_OwnerGroup_User_ModifiedBy",
                schema: "Core",
                table: "OwnerGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_OwnerStatus_User_ModifiedBy",
                schema: "Setup",
                table: "OwnerStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_OwnerTaxGroup_User_ModifiedBy",
                schema: "Setup",
                table: "OwnerTaxGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_OwnerType_User_ModifiedBy",
                schema: "Setup",
                table: "OwnerType");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_User_ModifiedBy",
                schema: "Core",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMode_User_ModifiedBy",
                schema: "Setup",
                table: "PaymentMode");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentStatus_User_ModifiedBy",
                schema: "Setup",
                table: "PaymentStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_User_ModifiedBy",
                schema: "Core",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumber_User_ModifiedBy",
                schema: "Core",
                table: "PhoneNumber");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumberType_User_ModifiedBy",
                schema: "Setup",
                table: "PhoneNumberType");

            migrationBuilder.DropForeignKey(
                name: "FK_Port_User_ModifiedBy",
                schema: "Setup",
                table: "Port");

            migrationBuilder.DropForeignKey(
                name: "FK_RegFeePenaltyRate_User_ModifiedBy",
                schema: "Setup",
                table: "RegFeePenaltyRate");

            migrationBuilder.DropForeignKey(
                name: "FK_Remarks_User_ModifiedBy",
                schema: "Core",
                table: "Remarks");

            migrationBuilder.DropForeignKey(
                name: "FK_Resource_User_ModifiedBy",
                schema: "Auth",
                table: "Resource");

            migrationBuilder.DropForeignKey(
                name: "FK_ResourceAction_User_ModifiedBy",
                schema: "Auth",
                table: "ResourceAction");

            migrationBuilder.DropForeignKey(
                name: "FK_ResourceController_User_ModifiedBy",
                schema: "Auth",
                table: "ResourceController");

            migrationBuilder.DropForeignKey(
                name: "FK_ResourceType_User_ModifiedBy",
                schema: "Auth",
                table: "ResourceType");

            migrationBuilder.DropForeignKey(
                name: "FK_ResourceTypeDefaultRight_User_ModifiedBy",
                schema: "Auth",
                table: "ResourceTypeDefaultRight");

            migrationBuilder.DropForeignKey(
                name: "FK_ResourceTypeRight_User_ModifiedBy",
                schema: "Auth",
                table: "ResourceTypeRight");

            migrationBuilder.DropForeignKey(
                name: "FK_Role_User_ModifiedBy",
                schema: "Auth",
                table: "Role");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleAppProcessFlow_User_ModifiedBy",
                schema: "Auth",
                table: "RoleAppProcessFlow");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleResource_User_ModifiedBy",
                schema: "Auth",
                table: "RoleResource");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleResourceRight_User_ModifiedBy",
                schema: "Auth",
                table: "RoleResourceRight");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleResourceRightsHistory_User_ModifiedBy",
                schema: "Auth",
                table: "RoleResourceRightsHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_Series_User_ModifiedBy",
                schema: "SRNRPL",
                table: "Series");

            migrationBuilder.DropForeignKey(
                name: "FK_SeriesCategory_User_ModifiedBy",
                schema: "SRNRPL",
                table: "SeriesCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_SeriesNumber_User_ModifiedBy",
                schema: "SRNRPL",
                table: "SeriesNumber");

            migrationBuilder.DropForeignKey(
                name: "FK_SeriesNumberPool_User_ModifiedBy",
                schema: "SRNRPL",
                table: "SeriesNumberPool");

            migrationBuilder.DropForeignKey(
                name: "FK_SeriesStatus_User_ModifiedBy",
                schema: "SRNRPL",
                table: "SeriesStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_SeriesStatusHistory_User_ModifiedBy",
                schema: "SRNRPL",
                table: "SeriesStatusHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_SeriesType_User_ModifiedBy",
                schema: "SRNRPL",
                table: "SeriesType");

            migrationBuilder.DropForeignKey(
                name: "FK_SqlExceptionLog_User_ModifiedBy",
                schema: "Logs",
                table: "SqlExceptionLog");

            migrationBuilder.DropForeignKey(
                name: "FK_TaxBase_User_ModifiedBy",
                schema: "Setup",
                table: "TaxBase");

            migrationBuilder.DropForeignKey(
                name: "FK_TaxRate_User_ModifiedBy",
                schema: "Setup",
                table: "TaxRate");

            migrationBuilder.DropForeignKey(
                name: "FK_TaxRule_User_ModifiedBy",
                schema: "Setup",
                table: "TaxRule");

            migrationBuilder.DropForeignKey(
                name: "FK_TaxType_User_ModifiedBy",
                schema: "Setup",
                table: "TaxType");

            migrationBuilder.DropForeignKey(
                name: "FK_Tehsil_User_ModifiedBy",
                schema: "Setup",
                table: "Tehsil");

            migrationBuilder.DropForeignKey(
                name: "FK_User_User_ModifiedBy",
                schema: "Auth",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_User_ModifiedBy",
                schema: "Auth",
                table: "UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoleHistory_User_ModifiedBy",
                schema: "Auth",
                table: "UserRoleHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_UserStatus_User_ModifiedBy",
                schema: "Auth",
                table: "UserStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_UserType_User_ModifiedBy",
                schema: "Auth",
                table: "UserType");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_User_ModifiedBy",
                schema: "Core",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleAdditionalInfo_User_ModifiedBy",
                schema: "Core",
                table: "VehicleAdditionalInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleAuctionInfo_User_ModifiedBy",
                schema: "Core",
                table: "VehicleAuctionInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleBodyConvention_User_ModifiedBy",
                schema: "Setup",
                table: "VehicleBodyConvention");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleBodyType_User_ModifiedBy",
                schema: "Setup",
                table: "VehicleBodyType");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleBusinessProcessHistory_User_ModifiedBy",
                schema: "Core",
                table: "VehicleBusinessProcessHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleCategory_User_ModifiedBy",
                schema: "Setup",
                table: "VehicleCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleClass_User_ModifiedBy",
                schema: "Setup",
                table: "VehicleClass");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleClassDetail_User_ModifiedBy",
                schema: "Setup",
                table: "VehicleClassDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleClassification_User_ModifiedBy",
                schema: "Setup",
                table: "VehicleClassification");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleColor_User_ModifiedBy",
                schema: "Setup",
                table: "VehicleColor");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleDocument_User_ModifiedBy",
                schema: "Core",
                table: "VehicleDocument");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleDocumentType_User_ModifiedBy",
                schema: "Setup",
                table: "VehicleDocumentType");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleEngineType_User_ModifiedBy",
                schema: "Setup",
                table: "VehicleEngineType");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleFuelType_User_ModifiedBy",
                schema: "Setup",
                table: "VehicleFuelType");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleImportInfo_User_ModifiedBy",
                schema: "Core",
                table: "VehicleImportInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleMake_User_ModifiedBy",
                schema: "Setup",
                table: "VehicleMake");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleMaker_User_ModifiedBy",
                schema: "Setup",
                table: "VehicleMaker");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleOwnershipHistory_User_ModifiedBy",
                schema: "Core",
                table: "VehicleOwnershipHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_VehiclePurchaseInfo_User_ModifiedBy",
                schema: "Core",
                table: "VehiclePurchaseInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_VehiclePurchaseType_User_ModifiedBy",
                schema: "Setup",
                table: "VehiclePurchaseType");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleRCStatus_User_ModifiedBy",
                schema: "Setup",
                table: "VehicleRCStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleRegistrationHistory_User_ModifiedBy",
                schema: "Core",
                table: "VehicleRegistrationHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleRouteType_User_ModifiedBy",
                schema: "Setup",
                table: "VehicleRouteType");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleScheme_User_ModifiedBy",
                schema: "Setup",
                table: "VehicleScheme");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleStatus_User_ModifiedBy",
                schema: "Setup",
                table: "VehicleStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleType_User_ModifiedBy",
                schema: "Setup",
                table: "VehicleType");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleUsage_User_ModifiedBy",
                schema: "Setup",
                table: "VehicleUsage");

            migrationBuilder.DropIndex(
                name: "IX_VehicleUsage_ModifiedBy",
                schema: "Setup",
                table: "VehicleUsage");

            migrationBuilder.DropIndex(
                name: "IX_VehicleType_ModifiedBy",
                schema: "Setup",
                table: "VehicleType");

            migrationBuilder.DropIndex(
                name: "IX_VehicleStatus_ModifiedBy",
                schema: "Setup",
                table: "VehicleStatus");

            migrationBuilder.DropIndex(
                name: "IX_VehicleScheme_ModifiedBy",
                schema: "Setup",
                table: "VehicleScheme");

            migrationBuilder.DropIndex(
                name: "IX_VehicleRouteType_ModifiedBy",
                schema: "Setup",
                table: "VehicleRouteType");

            migrationBuilder.DropIndex(
                name: "IX_VehicleRegistrationHistory_ModifiedBy",
                schema: "Core",
                table: "VehicleRegistrationHistory");

            migrationBuilder.DropIndex(
                name: "IX_VehicleRCStatus_ModifiedBy",
                schema: "Setup",
                table: "VehicleRCStatus");

            migrationBuilder.DropIndex(
                name: "IX_VehiclePurchaseType_ModifiedBy",
                schema: "Setup",
                table: "VehiclePurchaseType");

            migrationBuilder.DropIndex(
                name: "IX_VehiclePurchaseInfo_ModifiedBy",
                schema: "Core",
                table: "VehiclePurchaseInfo");

            migrationBuilder.DropIndex(
                name: "IX_VehicleOwnershipHistory_ModifiedBy",
                schema: "Core",
                table: "VehicleOwnershipHistory");

            migrationBuilder.DropIndex(
                name: "IX_VehicleMaker_ModifiedBy",
                schema: "Setup",
                table: "VehicleMaker");

            migrationBuilder.DropIndex(
                name: "IX_VehicleMake_ModifiedBy",
                schema: "Setup",
                table: "VehicleMake");

            migrationBuilder.DropIndex(
                name: "IX_VehicleImportInfo_ModifiedBy",
                schema: "Core",
                table: "VehicleImportInfo");

            migrationBuilder.DropIndex(
                name: "IX_VehicleFuelType_ModifiedBy",
                schema: "Setup",
                table: "VehicleFuelType");

            migrationBuilder.DropIndex(
                name: "IX_VehicleEngineType_ModifiedBy",
                schema: "Setup",
                table: "VehicleEngineType");

            migrationBuilder.DropIndex(
                name: "IX_VehicleDocumentType_ModifiedBy",
                schema: "Setup",
                table: "VehicleDocumentType");

            migrationBuilder.DropIndex(
                name: "IX_VehicleDocument_ModifiedBy",
                schema: "Core",
                table: "VehicleDocument");

            migrationBuilder.DropIndex(
                name: "IX_VehicleColor_ModifiedBy",
                schema: "Setup",
                table: "VehicleColor");

            migrationBuilder.DropIndex(
                name: "IX_VehicleClassification_ModifiedBy",
                schema: "Setup",
                table: "VehicleClassification");

            migrationBuilder.DropIndex(
                name: "IX_VehicleClassDetail_ModifiedBy",
                schema: "Setup",
                table: "VehicleClassDetail");

            migrationBuilder.DropIndex(
                name: "IX_VehicleClass_ModifiedBy",
                schema: "Setup",
                table: "VehicleClass");

            migrationBuilder.DropIndex(
                name: "IX_VehicleCategory_ModifiedBy",
                schema: "Setup",
                table: "VehicleCategory");

            migrationBuilder.DropIndex(
                name: "IX_VehicleBusinessProcessHistory_ModifiedBy",
                schema: "Core",
                table: "VehicleBusinessProcessHistory");

            migrationBuilder.DropIndex(
                name: "IX_VehicleBodyType_ModifiedBy",
                schema: "Setup",
                table: "VehicleBodyType");

            migrationBuilder.DropIndex(
                name: "IX_VehicleBodyConvention_ModifiedBy",
                schema: "Setup",
                table: "VehicleBodyConvention");

            migrationBuilder.DropIndex(
                name: "IX_VehicleAuctionInfo_ModifiedBy",
                schema: "Core",
                table: "VehicleAuctionInfo");

            migrationBuilder.DropIndex(
                name: "IX_VehicleAdditionalInfo_ModifiedBy",
                schema: "Core",
                table: "VehicleAdditionalInfo");

            migrationBuilder.DropIndex(
                name: "IX_Vehicle_ModifiedBy",
                schema: "Core",
                table: "Vehicle");

            migrationBuilder.DropIndex(
                name: "IX_UserType_ModifiedBy",
                schema: "Auth",
                table: "UserType");

            migrationBuilder.DropIndex(
                name: "IX_UserStatus_ModifiedBy",
                schema: "Auth",
                table: "UserStatus");

            migrationBuilder.DropIndex(
                name: "IX_UserRoleHistory_ModifiedBy",
                schema: "Auth",
                table: "UserRoleHistory");

            migrationBuilder.DropIndex(
                name: "IX_UserRole_ModifiedBy",
                schema: "Auth",
                table: "UserRole");

            migrationBuilder.DropIndex(
                name: "IX_User_ModifiedBy",
                schema: "Auth",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_Tehsil_ModifiedBy",
                schema: "Setup",
                table: "Tehsil");

            migrationBuilder.DropIndex(
                name: "IX_TaxType_ModifiedBy",
                schema: "Setup",
                table: "TaxType");

            migrationBuilder.DropIndex(
                name: "IX_TaxRule_ModifiedBy",
                schema: "Setup",
                table: "TaxRule");

            migrationBuilder.DropIndex(
                name: "IX_TaxRate_ModifiedBy",
                schema: "Setup",
                table: "TaxRate");

            migrationBuilder.DropIndex(
                name: "IX_TaxBase_ModifiedBy",
                schema: "Setup",
                table: "TaxBase");

            migrationBuilder.DropIndex(
                name: "IX_SqlExceptionLog_ModifiedBy",
                schema: "Logs",
                table: "SqlExceptionLog");

            migrationBuilder.DropIndex(
                name: "IX_SeriesType_ModifiedBy",
                schema: "SRNRPL",
                table: "SeriesType");

            migrationBuilder.DropIndex(
                name: "IX_SeriesStatusHistory_ModifiedBy",
                schema: "SRNRPL",
                table: "SeriesStatusHistory");

            migrationBuilder.DropIndex(
                name: "IX_SeriesStatus_ModifiedBy",
                schema: "SRNRPL",
                table: "SeriesStatus");

            migrationBuilder.DropIndex(
                name: "IX_SeriesNumberPool_ModifiedBy",
                schema: "SRNRPL",
                table: "SeriesNumberPool");

            migrationBuilder.DropIndex(
                name: "IX_SeriesNumber_ModifiedBy",
                schema: "SRNRPL",
                table: "SeriesNumber");

            migrationBuilder.DropIndex(
                name: "IX_SeriesCategory_ModifiedBy",
                schema: "SRNRPL",
                table: "SeriesCategory");

            migrationBuilder.DropIndex(
                name: "IX_Series_ModifiedBy",
                schema: "SRNRPL",
                table: "Series");

            migrationBuilder.DropIndex(
                name: "IX_RoleResourceRightsHistory_ModifiedBy",
                schema: "Auth",
                table: "RoleResourceRightsHistory");

            migrationBuilder.DropIndex(
                name: "IX_RoleResourceRight_ModifiedBy",
                schema: "Auth",
                table: "RoleResourceRight");

            migrationBuilder.DropIndex(
                name: "IX_RoleResource_ModifiedBy",
                schema: "Auth",
                table: "RoleResource");

            migrationBuilder.DropIndex(
                name: "IX_RoleAppProcessFlow_ModifiedBy",
                schema: "Auth",
                table: "RoleAppProcessFlow");

            migrationBuilder.DropIndex(
                name: "IX_Role_ModifiedBy",
                schema: "Auth",
                table: "Role");

            migrationBuilder.DropIndex(
                name: "IX_ResourceTypeRight_ModifiedBy",
                schema: "Auth",
                table: "ResourceTypeRight");

            migrationBuilder.DropIndex(
                name: "IX_ResourceTypeDefaultRight_ModifiedBy",
                schema: "Auth",
                table: "ResourceTypeDefaultRight");

            migrationBuilder.DropIndex(
                name: "IX_ResourceType_ModifiedBy",
                schema: "Auth",
                table: "ResourceType");

            migrationBuilder.DropIndex(
                name: "IX_ResourceController_ModifiedBy",
                schema: "Auth",
                table: "ResourceController");

            migrationBuilder.DropIndex(
                name: "IX_ResourceAction_ModifiedBy",
                schema: "Auth",
                table: "ResourceAction");

            migrationBuilder.DropIndex(
                name: "IX_Resource_ModifiedBy",
                schema: "Auth",
                table: "Resource");

            migrationBuilder.DropIndex(
                name: "IX_Remarks_ModifiedBy",
                schema: "Core",
                table: "Remarks");

            migrationBuilder.DropIndex(
                name: "IX_RegFeePenaltyRate_ModifiedBy",
                schema: "Setup",
                table: "RegFeePenaltyRate");

            migrationBuilder.DropIndex(
                name: "IX_Port_ModifiedBy",
                schema: "Setup",
                table: "Port");

            migrationBuilder.DropIndex(
                name: "IX_PhoneNumberType_ModifiedBy",
                schema: "Setup",
                table: "PhoneNumberType");

            migrationBuilder.DropIndex(
                name: "IX_PhoneNumber_ModifiedBy",
                schema: "Core",
                table: "PhoneNumber");

            migrationBuilder.DropIndex(
                name: "IX_Person_CreatedBy",
                schema: "Core",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Person_ModifiedBy",
                schema: "Core",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_PaymentStatus_ModifiedBy",
                schema: "Setup",
                table: "PaymentStatus");

            migrationBuilder.DropIndex(
                name: "IX_PaymentMode_ModifiedBy",
                schema: "Setup",
                table: "PaymentMode");

            migrationBuilder.DropIndex(
                name: "IX_Payment_ModifiedBy",
                schema: "Core",
                table: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_OwnerType_ModifiedBy",
                schema: "Setup",
                table: "OwnerType");

            migrationBuilder.DropIndex(
                name: "IX_OwnerTaxGroup_ModifiedBy",
                schema: "Setup",
                table: "OwnerTaxGroup");

            migrationBuilder.DropIndex(
                name: "IX_OwnerStatus_ModifiedBy",
                schema: "Setup",
                table: "OwnerStatus");

            migrationBuilder.DropIndex(
                name: "IX_OwnerGroup_ModifiedBy",
                schema: "Core",
                table: "OwnerGroup");

            migrationBuilder.DropIndex(
                name: "IX_Owner_ModifiedBy",
                schema: "Core",
                table: "Owner");

            migrationBuilder.DropIndex(
                name: "IX_OrganizationCategory_ModifiedBy",
                schema: "Setup",
                table: "OrganizationCategory");

            migrationBuilder.DropIndex(
                name: "IX_NadraFranchise_ModifiedBy",
                schema: "Biometric",
                table: "NadraFranchise");

            migrationBuilder.DropIndex(
                name: "IX_Keeper_ModifiedBy",
                schema: "Core",
                table: "Keeper");

            migrationBuilder.DropIndex(
                name: "IX_HttpRequestLog_ModifiedBy",
                schema: "Logs",
                table: "HttpRequestLog");

            migrationBuilder.DropIndex(
                name: "IX_HPAStatusHistory_ModifiedBy",
                schema: "Core",
                table: "HPAStatusHistory");

            migrationBuilder.DropIndex(
                name: "IX_HPAStatus_ModifiedBy",
                schema: "Setup",
                table: "HPAStatus");

            migrationBuilder.DropIndex(
                name: "IX_HPA_ModifiedBy",
                schema: "Core",
                table: "HPA");

            migrationBuilder.DropIndex(
                name: "IX_GlobalRight_ModifiedBy",
                schema: "Auth",
                table: "GlobalRight");

            migrationBuilder.DropIndex(
                name: "IX_District_ModifiedBy",
                schema: "Setup",
                table: "District");

            migrationBuilder.DropIndex(
                name: "IX_Dealer_ModifiedBy",
                schema: "Core",
                table: "Dealer");

            migrationBuilder.DropIndex(
                name: "IX_CustomCollectorate_ModifiedBy",
                schema: "Setup",
                table: "CustomCollectorate");

            migrationBuilder.DropIndex(
                name: "IX_Country_ModifiedBy",
                schema: "Setup",
                table: "Country");

            migrationBuilder.DropIndex(
                name: "IX_ClearingAgent_ModifiedBy",
                schema: "Setup",
                table: "ClearingAgent");

            migrationBuilder.DropIndex(
                name: "IX_ChallanType_ModifiedBy",
                schema: "Setup",
                table: "ChallanType");

            migrationBuilder.DropIndex(
                name: "IX_ChallanStatus_ModifiedBy",
                schema: "Setup",
                table: "ChallanStatus");

            migrationBuilder.DropIndex(
                name: "IX_Challan_ModifiedBy",
                schema: "Core",
                table: "Challan");

            migrationBuilder.DropIndex(
                name: "IX_BusinessType_ModifiedBy",
                schema: "Setup",
                table: "BusinessType");

            migrationBuilder.DropIndex(
                name: "IX_BusinessTableAccessLevel_ModifiedBy",
                schema: "Setup",
                table: "BusinessTableAccessLevel");

            migrationBuilder.DropIndex(
                name: "IX_BusinessTable_ModifiedBy",
                schema: "Setup",
                table: "BusinessTable");

            migrationBuilder.DropIndex(
                name: "IX_BusinessStatus_ModifiedBy",
                schema: "Setup",
                table: "BusinessStatus");

            migrationBuilder.DropIndex(
                name: "IX_BusinessSector_ModifiedBy",
                schema: "Setup",
                table: "BusinessSector");

            migrationBuilder.DropIndex(
                name: "IX_BusinessRepStatus_ModifiedBy",
                schema: "Setup",
                table: "BusinessRepStatus");

            migrationBuilder.DropIndex(
                name: "IX_BusinessRep_ModifiedBy",
                schema: "Core",
                table: "BusinessRep");

            migrationBuilder.DropIndex(
                name: "IX_BusinessProFeeTax_ModifiedBy",
                schema: "Setup",
                table: "BusinessProFeeTax");

            migrationBuilder.DropIndex(
                name: "IX_BusinessProcess_ModifiedBy",
                schema: "Setup",
                table: "BusinessProcess");

            migrationBuilder.DropIndex(
                name: "IX_BusinessPhaseStatus_ModifiedBy",
                schema: "Setup",
                table: "BusinessPhaseStatus");

            migrationBuilder.DropIndex(
                name: "IX_BusinessPhase_ModifiedBy",
                schema: "Setup",
                table: "BusinessPhase");

            migrationBuilder.DropIndex(
                name: "IX_BusinessEvent_ModifiedBy",
                schema: "Setup",
                table: "BusinessEvent");

            migrationBuilder.DropIndex(
                name: "IX_Business_CreatedBy",
                schema: "Core",
                table: "Business");

            migrationBuilder.DropIndex(
                name: "IX_Business_ModifiedBy",
                schema: "Core",
                table: "Business");

            migrationBuilder.DropIndex(
                name: "IX_BiometricVerification_ModifiedBy",
                schema: "Biometric",
                table: "BiometricVerification");

            migrationBuilder.DropIndex(
                name: "IX_Bank_ModifiedBy",
                schema: "Setup",
                table: "Bank");

            migrationBuilder.DropIndex(
                name: "IX_AuctionResult_ModifiedBy",
                schema: "SRNRPL",
                table: "AuctionResult");

            migrationBuilder.DropIndex(
                name: "IX_AssessmentStatus_ModifiedBy",
                schema: "Setup",
                table: "AssessmentStatus");

            migrationBuilder.DropIndex(
                name: "IX_AssessmentDetail_ModifiedBy",
                schema: "Core",
                table: "AssessmentDetail");

            migrationBuilder.DropIndex(
                name: "IX_AssessmentBase_ModifiedBy",
                schema: "Core",
                table: "AssessmentBase");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationStatus_ModifiedBy",
                schema: "Setup",
                table: "ApplicationStatus");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationProcessFlow_ModifiedBy",
                schema: "Setup",
                table: "ApplicationProcessFlow");

            migrationBuilder.DropIndex(
                name: "IX_Application_ModifiedBy",
                schema: "Core",
                table: "Application");

            migrationBuilder.DropIndex(
                name: "IX_AddressType_ModifiedBy",
                schema: "Setup",
                table: "AddressType");

            migrationBuilder.DropIndex(
                name: "IX_Address_ModifiedBy",
                schema: "Core",
                table: "Address");

            migrationBuilder.DropIndex(
                name: "IX_AccountHead_ModifiedBy",
                schema: "Setup",
                table: "AccountHead");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "VehicleUsage");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "VehicleUsage");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "VehicleType");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "VehicleType");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "VehicleStatus");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "VehicleStatus");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "VehicleScheme");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "VehicleScheme");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "VehicleRouteType");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "VehicleRouteType");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Core",
                table: "VehicleRegistrationHistory");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Core",
                table: "VehicleRegistrationHistory");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "VehicleRCStatus");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "VehicleRCStatus");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "VehiclePurchaseType");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "VehiclePurchaseType");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Core",
                table: "VehiclePurchaseInfo");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Core",
                table: "VehiclePurchaseInfo");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Core",
                table: "VehicleOwnershipHistory");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Core",
                table: "VehicleOwnershipHistory");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "VehicleMaker");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "VehicleMaker");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "VehicleMake");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "VehicleMake");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Core",
                table: "VehicleImportInfo");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Core",
                table: "VehicleImportInfo");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "VehicleFuelType");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "VehicleFuelType");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "VehicleEngineType");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "VehicleEngineType");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "VehicleDocumentType");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "VehicleDocumentType");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Core",
                table: "VehicleDocument");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Core",
                table: "VehicleDocument");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "VehicleColor");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "VehicleColor");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "VehicleClassification");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "VehicleClassification");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "VehicleClassDetail");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "VehicleClassDetail");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "VehicleClass");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "VehicleClass");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "VehicleCategory");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "VehicleCategory");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Core",
                table: "VehicleBusinessProcessHistory");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Core",
                table: "VehicleBusinessProcessHistory");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "VehicleBodyType");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "VehicleBodyType");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "VehicleBodyConvention");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "VehicleBodyConvention");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Core",
                table: "VehicleAuctionInfo");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Core",
                table: "VehicleAuctionInfo");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Core",
                table: "VehicleAdditionalInfo");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Core",
                table: "VehicleAdditionalInfo");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Core",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Core",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Auth",
                table: "UserType");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Auth",
                table: "UserType");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Auth",
                table: "UserStatus");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Auth",
                table: "UserStatus");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Auth",
                table: "UserRoleHistory");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Auth",
                table: "UserRoleHistory");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Auth",
                table: "UserRole");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Auth",
                table: "UserRole");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Auth",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "Tehsil");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "Tehsil");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "TaxType");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "TaxType");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "TaxRule");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "TaxRule");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "TaxRate");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "TaxRate");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "TaxBase");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "TaxBase");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Logs",
                table: "SqlExceptionLog");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Logs",
                table: "SqlExceptionLog");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "SRNRPL",
                table: "SeriesType");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "SRNRPL",
                table: "SeriesType");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "SRNRPL",
                table: "SeriesStatusHistory");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "SRNRPL",
                table: "SeriesStatusHistory");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "SRNRPL",
                table: "SeriesStatus");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "SRNRPL",
                table: "SeriesStatus");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "SRNRPL",
                table: "SeriesNumberPool");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "SRNRPL",
                table: "SeriesNumberPool");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "SRNRPL",
                table: "SeriesNumber");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "SRNRPL",
                table: "SeriesNumber");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "SRNRPL",
                table: "SeriesCategory");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "SRNRPL",
                table: "SeriesCategory");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "SRNRPL",
                table: "Series");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "SRNRPL",
                table: "Series");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Auth",
                table: "RoleResourceRightsHistory");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Auth",
                table: "RoleResourceRightsHistory");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Auth",
                table: "RoleResourceRight");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Auth",
                table: "RoleResourceRight");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Auth",
                table: "RoleResource");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Auth",
                table: "RoleResource");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Auth",
                table: "RoleAppProcessFlow");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Auth",
                table: "RoleAppProcessFlow");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Auth",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Auth",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Auth",
                table: "ResourceTypeRight");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Auth",
                table: "ResourceTypeRight");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Auth",
                table: "ResourceTypeDefaultRight");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Auth",
                table: "ResourceTypeDefaultRight");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Auth",
                table: "ResourceType");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Auth",
                table: "ResourceType");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Auth",
                table: "ResourceController");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Auth",
                table: "ResourceController");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Auth",
                table: "ResourceAction");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Auth",
                table: "ResourceAction");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Auth",
                table: "Resource");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Auth",
                table: "Resource");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Core",
                table: "Remarks");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Core",
                table: "Remarks");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "RegFeePenaltyRate");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "RegFeePenaltyRate");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "Port");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "Port");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "PhoneNumberType");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "PhoneNumberType");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Core",
                table: "PhoneNumber");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Core",
                table: "PhoneNumber");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Core",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Core",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "PaymentStatus");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "PaymentStatus");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "PaymentMode");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "PaymentMode");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Core",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Core",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "OwnerType");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "OwnerType");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "OwnerTaxGroup");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "OwnerTaxGroup");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "OwnerStatus");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "OwnerStatus");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Core",
                table: "OwnerGroup");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Core",
                table: "OwnerGroup");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Core",
                table: "Owner");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Core",
                table: "Owner");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "OrganizationCategory");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "OrganizationCategory");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Biometric",
                table: "NadraFranchise");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Biometric",
                table: "NadraFranchise");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Core",
                table: "Keeper");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Core",
                table: "Keeper");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Logs",
                table: "HttpRequestLog");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Logs",
                table: "HttpRequestLog");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Core",
                table: "HPAStatusHistory");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Core",
                table: "HPAStatusHistory");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "HPAStatus");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "HPAStatus");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Core",
                table: "HPA");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Core",
                table: "HPA");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Auth",
                table: "GlobalRight");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Auth",
                table: "GlobalRight");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "District");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "District");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Core",
                table: "Dealer");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Core",
                table: "Dealer");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "CustomCollectorate");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "CustomCollectorate");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "ClearingAgent");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "ClearingAgent");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "ChallanType");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "ChallanType");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "ChallanStatus");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "ChallanStatus");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Core",
                table: "Challan");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Core",
                table: "Challan");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "BusinessType");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "BusinessType");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "BusinessTableAccessLevel");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "BusinessTableAccessLevel");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "BusinessTable");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "BusinessTable");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "BusinessStatus");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "BusinessStatus");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "BusinessSector");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "BusinessSector");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "BusinessRepStatus");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "BusinessRepStatus");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Core",
                table: "BusinessRep");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Core",
                table: "BusinessRep");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "BusinessProFeeTax");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "BusinessProFeeTax");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "BusinessProcess");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "BusinessProcess");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "BusinessPhaseStatus");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "BusinessPhaseStatus");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "BusinessPhase");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "BusinessPhase");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "BusinessEvent");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "BusinessEvent");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Core",
                table: "Business");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Core",
                table: "Business");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Biometric",
                table: "BiometricVerification");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Biometric",
                table: "BiometricVerification");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "Bank");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "Bank");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "SRNRPL",
                table: "AuctionResult");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "SRNRPL",
                table: "AuctionResult");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "AssessmentStatus");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "AssessmentStatus");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Core",
                table: "AssessmentDetail");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Core",
                table: "AssessmentDetail");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Core",
                table: "AssessmentBase");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Core",
                table: "AssessmentBase");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "ApplicationStatus");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "ApplicationStatus");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "ApplicationProcessFlow");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "ApplicationProcessFlow");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Core",
                table: "Application");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Core",
                table: "Application");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "AddressType");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "AddressType");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Core",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Core",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Setup",
                table: "AccountHead");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Setup",
                table: "AccountHead");

            migrationBuilder.RenameColumn(
                name: "ModifiedBy",
                schema: "Auth",
                table: "User",
                newName: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_User_BusinessId",
                schema: "Auth",
                table: "User",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_User_PersonId",
                schema: "Auth",
                table: "User",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserDistrictId",
                schema: "Auth",
                table: "User",
                column: "UserDistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserId1",
                schema: "Auth",
                table: "User",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Person_CreatedBy",
                schema: "Core",
                table: "Person",
                column: "CreatedBy",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Business_CreatedBy",
                schema: "Core",
                table: "Business",
                column: "CreatedBy",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Business_BusinessId",
                schema: "Auth",
                table: "User",
                column: "BusinessId",
                principalSchema: "Core",
                principalTable: "Business",
                principalColumn: "BusinessId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_User_District_UserDistrictId",
            //    schema: "Auth",
            //    table: "User",
            //    column: "UserDistrictId",
            //    principalSchema: "Setup",
            //    principalTable: "District",
            //    principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Person_PersonId",
                schema: "Auth",
                table: "User",
                column: "PersonId",
                principalSchema: "Core",
                principalTable: "Person",
                principalColumn: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_User_UserId1",
                schema: "Auth",
                table: "User",
                column: "UserId1",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");
        }
    }
}
