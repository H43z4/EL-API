using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class EPRS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropForeignKey(
                name: "FK_BiometricVerification_Person_PersonId",
                table: "BiometricVerification");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleAppProcessFlow_ApplicationProcessFlow_AppProcessFlowId",
                table: "RoleAppProcessFlow");

            migrationBuilder.DropTable(
                name: "AccountHead");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "ApplicationProcessFlow");

            migrationBuilder.DropTable(
                name: "AssessmentDetail");

            migrationBuilder.DropTable(
                name: "AuctionResult");

            migrationBuilder.DropTable(
                name: "BusinessProFeeTax");

            migrationBuilder.DropTable(
                name: "BusinessRep");

            migrationBuilder.DropTable(
                name: "BusinessTableAccessLevel");

            migrationBuilder.DropTable(
                name: "HPAStatusHistory");

            migrationBuilder.DropTable(
                name: "Keeper");

            migrationBuilder.DropTable(
                name: "OrganizationCategory");

            migrationBuilder.DropTable(
                name: "OwnerStatus");

            migrationBuilder.DropTable(
                name: "OwnerTaxGroupFees");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "PermitTypes");

            migrationBuilder.DropTable(
                name: "PhoneNumber");

            migrationBuilder.DropTable(
                name: "RegFeePenaltyRate");

            migrationBuilder.DropTable(
                name: "Remarks");

            migrationBuilder.DropTable(
                name: "TaxRate");

            migrationBuilder.DropTable(
                name: "VehicleAdditionalInfo");

            migrationBuilder.DropTable(
                name: "VehicleAuctionInfo");

            migrationBuilder.DropTable(
                name: "VehicleBusinessProcessHistory");

            migrationBuilder.DropTable(
                name: "VehicleDocument");

            migrationBuilder.DropTable(
                name: "VehicleDocumentRequirement");

            migrationBuilder.DropTable(
                name: "VehicleImportInfo");

            migrationBuilder.DropTable(
                name: "VehicleOwnershipHistory");

            migrationBuilder.DropTable(
                name: "VehiclePurchaseInfo");

            migrationBuilder.DropTable(
                name: "VehicleRegistrationHistory");

            migrationBuilder.DropTable(
                name: "AddressType");

            migrationBuilder.DropTable(
                name: "Tehsil");

            migrationBuilder.DropTable(
                name: "BusinessEvent");

            migrationBuilder.DropTable(
                name: "BusinessRepStatus");

            migrationBuilder.DropTable(
                name: "BusinessTable");

            migrationBuilder.DropTable(
                name: "BusinessTableAccess");

            migrationBuilder.DropTable(
                name: "HPA");

            migrationBuilder.DropTable(
                name: "Challan");

            migrationBuilder.DropTable(
                name: "PaymentMode");

            migrationBuilder.DropTable(
                name: "PaymentStatus");

            migrationBuilder.DropTable(
                name: "PhoneNumberType");

            migrationBuilder.DropTable(
                name: "OwnerGroup");

            migrationBuilder.DropTable(
                name: "TaxBase");

            migrationBuilder.DropTable(
                name: "TaxType");

            migrationBuilder.DropTable(
                name: "VehicleRCStatus");

            migrationBuilder.DropTable(
                name: "VehicleDocumentType");

            migrationBuilder.DropTable(
                name: "Bank");

            migrationBuilder.DropTable(
                name: "ClearingAgent");

            migrationBuilder.DropTable(
                name: "CustomCollectorate");

            migrationBuilder.DropTable(
                name: "Port");

            migrationBuilder.DropTable(
                name: "Dealer");

            migrationBuilder.DropTable(
                name: "VehicleScheme");

            migrationBuilder.DropTable(
                name: "SeriesNumberPool");

            migrationBuilder.DropTable(
                name: "HPAStatus");

            migrationBuilder.DropTable(
                name: "AssessmentBase");

            migrationBuilder.DropTable(
                name: "ChallanStatus");

            migrationBuilder.DropTable(
                name: "ChallanType");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "TaxRule");

            migrationBuilder.DropTable(
                name: "Business");

            migrationBuilder.DropTable(
                name: "Series");

            migrationBuilder.DropTable(
                name: "SeriesNumber");

            migrationBuilder.DropTable(
                name: "SeriesNumberStatus");

            migrationBuilder.DropTable(
                name: "Application");

            migrationBuilder.DropTable(
                name: "AssessmentStatus");

            migrationBuilder.DropTable(
                name: "VehicleClassDetail");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "BusinessSector");

            migrationBuilder.DropTable(
                name: "BusinessStatus");

            migrationBuilder.DropTable(
                name: "SeriesCategory");

            migrationBuilder.DropTable(
                name: "SeriesStatus");

            migrationBuilder.DropTable(
                name: "SeriesType");

            migrationBuilder.DropTable(
                name: "ApplicationStatus");

            migrationBuilder.DropTable(
                name: "BusinessPhase");

            migrationBuilder.DropTable(
                name: "BusinessPhaseStatus");

            migrationBuilder.DropTable(
                name: "BusinessProcess");

            migrationBuilder.DropTable(
                name: "Vehicle");

            migrationBuilder.DropTable(
                name: "BusinessType");

            migrationBuilder.DropTable(
                name: "District");

            migrationBuilder.DropTable(
                name: "Owner");

            migrationBuilder.DropTable(
                name: "VehicleBodyConvention");

            migrationBuilder.DropTable(
                name: "VehicleClass");

            migrationBuilder.DropTable(
                name: "VehicleColor");

            migrationBuilder.DropTable(
                name: "VehicleEngineType");

            migrationBuilder.DropTable(
                name: "VehicleFuelType");

            migrationBuilder.DropTable(
                name: "VehicleMake");

            migrationBuilder.DropTable(
                name: "VehiclePurchaseType");

            migrationBuilder.DropTable(
                name: "VehicleStatus");

            migrationBuilder.DropTable(
                name: "VehicleUsage");

            migrationBuilder.DropTable(
                name: "OwnerTaxGroup");

            migrationBuilder.DropTable(
                name: "VehicleBodyType");

            migrationBuilder.DropTable(
                name: "VehicleCategory");

            migrationBuilder.DropTable(
                name: "VehicleClassGroup");

            migrationBuilder.DropTable(
                name: "VehicleClassification");

            migrationBuilder.DropTable(
                name: "VehicleRouteType");

            migrationBuilder.DropTable(
                name: "VehicleType");

            migrationBuilder.DropTable(
                name: "VehicleMaker");

            migrationBuilder.DropTable(
                name: "OwnerType");

            migrationBuilder.DropIndex(
                name: "IX_RoleAppProcessFlow_AppProcessFlowId",
                table: "RoleAppProcessFlow");

            migrationBuilder.EnsureSchema(
                name: "Logs");

            migrationBuilder.RenameTable(
                name: "SqlExceptionLog",
                newName: "SqlExceptionLog",
                newSchema: "Logs");

            migrationBuilder.RenameTable(
                name: "HttpRequestLog",
                newName: "HttpRequestLog",
                newSchema: "Logs");

            migrationBuilder.AlterColumn<float>(
                name: "QuantityInML",
                schema: "Setup",
                table: "ProductSize",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "ProductVendFee",
                schema: "Setup",
                table: "ProductDetail",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Tax",
                schema: "Core",
                table: "OrderMain",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddForeignKey(
                name: "FK_BiometricVerification_EPRSPerson_PersonId",
                table: "BiometricVerification",
                column: "PersonId",
                principalSchema: "Core",
                principalTable: "EPRSPerson",
                principalColumn: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_BiometricVerification_PermitIssueApplication_ApplicationId",
                table: "BiometricVerification",
                column: "ApplicationId",
                principalSchema: "Core",
                principalTable: "PermitIssueApplication",
                principalColumn: "ApplicationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BiometricVerification_EPRSPerson_PersonId",
                table: "BiometricVerification");

            migrationBuilder.DropForeignKey(
                name: "FK_BiometricVerification_PermitIssueApplication_ApplicationId",
                table: "BiometricVerification");

            migrationBuilder.RenameTable(
                name: "SqlExceptionLog",
                schema: "Logs",
                newName: "SqlExceptionLog");

            migrationBuilder.RenameTable(
                name: "HttpRequestLog",
                schema: "Logs",
                newName: "HttpRequestLog");

            migrationBuilder.AlterColumn<decimal>(
                name: "QuantityInML",
                schema: "Setup",
                table: "ProductSize",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "ProductVendFee",
                schema: "Setup",
                table: "ProductDetail",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "Tax",
                schema: "Core",
                table: "OrderMain",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "OwnerGroupId",
                table: "BiometricVerification",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "VehicleId",
                table: "BiometricVerification",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "AccountHead",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountHead", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AddressType",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationStatus",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AssessmentStatus",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bank",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bank", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BusinessEvent",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessEvent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BusinessPhase",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessPhase", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BusinessPhaseStatus",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessPhaseStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BusinessProcess",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessProcess", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BusinessRepStatus",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessRepStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BusinessStatus",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BusinessTable",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BusinessTableAccess",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    AccessLevel = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessTableAccess", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BusinessType",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChallanStatus",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChallanStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChallanType",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChallanType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClearingAgent",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClearingAgent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomCollectorate",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomCollectorate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "District",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_District", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HPAStatus",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HPAStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrganizationCategory",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OwnerStatus",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OwnerStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OwnerType",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OwnerType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMode",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMode", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentStatus",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PermitTypes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermitTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhoneNumberType",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumberType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Port",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Port", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegFeePenaltyRate",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    MaxDays = table.Column<int>(type: "int", nullable: false),
                    MinDays = table.Column<int>(type: "int", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PenaltyRate = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegFeePenaltyRate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SeriesCategory",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeriesCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SeriesNumber",
                columns: table => new
                {
                    SeriesNumberId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    SeriesNumberName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeriesNumber", x => x.SeriesNumberId);
                });

            migrationBuilder.CreateTable(
                name: "SeriesNumberStatus",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeriesNumberStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SeriesStatus",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeriesStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SeriesType",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeriesType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaxBase",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxBase", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaxRule",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxRule", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleBodyConvention",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleBodyConvention", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleBodyType",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleBodyType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleCategory",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleClassGroup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleClassGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleClassification",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleClassification", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleColor",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleColor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleDocumentType",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleDocumentType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleEngineType",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleEngineType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleFuelType",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleFuelType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleMaker",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleMaker", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehiclePurchaseType",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehiclePurchaseType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleRCStatus",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleRCStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleRouteType",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleRouteType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleScheme",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleScheme", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleStatus",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleType",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleUsage",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleUsage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationProcessFlow",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessEventId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessProcessId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CurrentApplicationStatusId = table.Column<long>(type: "bigint", nullable: false),
                    CurrentBusinessPhaseId = table.Column<long>(type: "bigint", nullable: false),
                    CurrentBusinessPhaseStatusId = table.Column<long>(type: "bigint", nullable: false),
                    IsInitialProcessState = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    NextApplicationStatusId = table.Column<long>(type: "bigint", nullable: false),
                    NextBusinessPhaseId = table.Column<long>(type: "bigint", nullable: false),
                    NextBusinessPhaseStatusId = table.Column<long>(type: "bigint", nullable: false),
                    RoleId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationProcessFlow", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationProcessFlow_ApplicationStatus_CurrentApplicationStatusId",
                        column: x => x.CurrentApplicationStatusId,
                        principalTable: "ApplicationStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ApplicationProcessFlow_ApplicationStatus_NextApplicationStatusId",
                        column: x => x.NextApplicationStatusId,
                        principalTable: "ApplicationStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ApplicationProcessFlow_BusinessEvent_BusinessEventId",
                        column: x => x.BusinessEventId,
                        principalTable: "BusinessEvent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ApplicationProcessFlow_BusinessPhase_CurrentBusinessPhaseId",
                        column: x => x.CurrentBusinessPhaseId,
                        principalTable: "BusinessPhase",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ApplicationProcessFlow_BusinessPhase_NextBusinessPhaseId",
                        column: x => x.NextBusinessPhaseId,
                        principalTable: "BusinessPhase",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ApplicationProcessFlow_BusinessPhaseStatus_CurrentBusinessPhaseStatusId",
                        column: x => x.CurrentBusinessPhaseStatusId,
                        principalTable: "BusinessPhaseStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ApplicationProcessFlow_BusinessPhaseStatus_NextBusinessPhaseStatusId",
                        column: x => x.NextBusinessPhaseStatusId,
                        principalTable: "BusinessPhaseStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ApplicationProcessFlow_BusinessProcess_BusinessProcessId",
                        column: x => x.BusinessProcessId,
                        principalTable: "BusinessProcess",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ApplicationProcessFlow_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "RoleId");
                    table.ForeignKey(
                        name: "FK_ApplicationProcessFlow_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_ApplicationProcessFlow_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "BusinessTableAccessLevel",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationStatusId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessPhaseId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessPhaseStatusId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessProcessId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessTableAccessId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessTableId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    RoleId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessTableAccessLevel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessTableAccessLevel_ApplicationStatus_ApplicationStatusId",
                        column: x => x.ApplicationStatusId,
                        principalTable: "ApplicationStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BusinessTableAccessLevel_BusinessPhase_BusinessPhaseId",
                        column: x => x.BusinessPhaseId,
                        principalTable: "BusinessPhase",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BusinessTableAccessLevel_BusinessPhaseStatus_BusinessPhaseStatusId",
                        column: x => x.BusinessPhaseStatusId,
                        principalTable: "BusinessPhaseStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BusinessTableAccessLevel_BusinessProcess_BusinessProcessId",
                        column: x => x.BusinessProcessId,
                        principalTable: "BusinessProcess",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BusinessTableAccessLevel_BusinessTable_BusinessTableId",
                        column: x => x.BusinessTableId,
                        principalTable: "BusinessTable",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BusinessTableAccessLevel_BusinessTableAccess_BusinessTableAccessId",
                        column: x => x.BusinessTableAccessId,
                        principalTable: "BusinessTableAccess",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BusinessTableAccessLevel_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "RoleId");
                    table.ForeignKey(
                        name: "FK_BusinessTableAccessLevel_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_BusinessTableAccessLevel_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "BusinessSector",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    BusinessTypeId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessSector", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessSector_BusinessType_BusinessTypeId",
                        column: x => x.BusinessTypeId,
                        principalTable: "BusinessType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    PersonId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CNIC = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    CountryId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    FTN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    FatherHusbandName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    NTN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    OldCNIC = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    PersonName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_Person_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tehsil",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DistrictId = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tehsil", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tehsil_District_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "District",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OwnerTaxGroup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ITExemptedClause = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    IsIncomeTaxExempted = table.Column<bool>(type: "bit", nullable: false),
                    IsTaxExempted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OwnerTypeId = table.Column<long>(type: "bigint", nullable: false),
                    TaxExemptedClause = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OwnerTaxGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OwnerTaxGroup_OwnerType_OwnerTypeId",
                        column: x => x.OwnerTypeId,
                        principalTable: "OwnerType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    SeriesId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    SeriesCategoryId = table.Column<long>(type: "bigint", nullable: false),
                    SeriesName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SeriesStatusId = table.Column<long>(type: "bigint", nullable: false),
                    SeriesTypeId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.SeriesId);
                    table.ForeignKey(
                        name: "FK_Series_SeriesCategory_SeriesCategoryId",
                        column: x => x.SeriesCategoryId,
                        principalTable: "SeriesCategory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Series_SeriesStatus_SeriesStatusId",
                        column: x => x.SeriesStatusId,
                        principalTable: "SeriesStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Series_SeriesType_SeriesTypeId",
                        column: x => x.SeriesTypeId,
                        principalTable: "SeriesType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TaxType",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    TaxRuleId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaxType_TaxRule_TaxRuleId",
                        column: x => x.TaxRuleId,
                        principalTable: "TaxRule",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VehicleDocumentRequirement",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessProcessId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleDocumentTypeId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleDocumentRequirement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleDocumentRequirement_BusinessProcess_BusinessProcessId",
                        column: x => x.BusinessProcessId,
                        principalTable: "BusinessProcess",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleDocumentRequirement_VehicleDocumentType_VehicleDocumentTypeId",
                        column: x => x.VehicleDocumentTypeId,
                        principalTable: "VehicleDocumentType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VehicleMake",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    VehicleMakerId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleMake", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleMake_VehicleMaker_VehicleMakerId",
                        column: x => x.VehicleMakerId,
                        principalTable: "VehicleMaker",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VehicleClass",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    AppliedFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EngineSizeMax = table.Column<long>(type: "bigint", nullable: false),
                    EngineSizeMin = table.Column<long>(type: "bigint", nullable: false),
                    FitnessDocRequired = table.Column<bool>(type: "bit", nullable: false),
                    LadenWeightMax = table.Column<long>(type: "bigint", nullable: false),
                    LadenWeightMin = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SeatingCapacityMax = table.Column<long>(type: "bigint", nullable: false),
                    SeatingCapacityMin = table.Column<long>(type: "bigint", nullable: false),
                    TaxFrequency = table.Column<int>(type: "int", nullable: false),
                    UnladenWeightMax = table.Column<long>(type: "bigint", nullable: false),
                    UnladenWeightMin = table.Column<long>(type: "bigint", nullable: false),
                    VehicleBodyTypeId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleCategoryId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleClassGroupId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleClassificationId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleRouteTypeId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleTypeId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleClass", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleClass_VehicleBodyType_VehicleBodyTypeId",
                        column: x => x.VehicleBodyTypeId,
                        principalTable: "VehicleBodyType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleClass_VehicleCategory_VehicleCategoryId",
                        column: x => x.VehicleCategoryId,
                        principalTable: "VehicleCategory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleClass_VehicleClassGroup_VehicleClassGroupId",
                        column: x => x.VehicleClassGroupId,
                        principalTable: "VehicleClassGroup",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleClass_VehicleClassification_VehicleClassificationId",
                        column: x => x.VehicleClassificationId,
                        principalTable: "VehicleClassification",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleClass_VehicleRouteType_VehicleRouteTypeId",
                        column: x => x.VehicleRouteTypeId,
                        principalTable: "VehicleRouteType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleClass_VehicleType_VehicleTypeId",
                        column: x => x.VehicleTypeId,
                        principalTable: "VehicleType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Business",
                columns: table => new
                {
                    BusinessId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountPassword = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    BusinessName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BusinessRegNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BusinessSectorId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessStatusId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessTypeId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    FTN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    NTN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    STN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Business", x => x.BusinessId);
                    table.ForeignKey(
                        name: "FK_Business_BusinessSector_BusinessSectorId",
                        column: x => x.BusinessSectorId,
                        principalTable: "BusinessSector",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Business_BusinessStatus_BusinessStatusId",
                        column: x => x.BusinessStatusId,
                        principalTable: "BusinessStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Business_BusinessType_BusinessTypeId",
                        column: x => x.BusinessTypeId,
                        principalTable: "BusinessType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Owner",
                columns: table => new
                {
                    OwnerId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    OwnerTaxGroupId = table.Column<long>(type: "bigint", nullable: false),
                    OwnerTypeId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owner", x => x.OwnerId);
                    table.ForeignKey(
                        name: "FK_Owner_OwnerTaxGroup_OwnerTaxGroupId",
                        column: x => x.OwnerTaxGroupId,
                        principalTable: "OwnerTaxGroup",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Owner_OwnerType_OwnerTypeId",
                        column: x => x.OwnerTypeId,
                        principalTable: "OwnerType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AuctionResult",
                columns: table => new
                {
                    AuctionResultId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    AuctionedValue = table.Column<long>(type: "bigint", nullable: false),
                    CNIC = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    ChasisNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    FatherHusbandName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    NTN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    OwnerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SeriesCategoryId = table.Column<long>(type: "bigint", nullable: false),
                    SeriesId = table.Column<long>(type: "bigint", nullable: false),
                    SeriesNumberId = table.Column<long>(type: "bigint", nullable: false),
                    WinnerAIN = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    WinnerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuctionResult", x => x.AuctionResultId);
                    table.ForeignKey(
                        name: "FK_AuctionResult_Series_SeriesId",
                        column: x => x.SeriesId,
                        principalTable: "Series",
                        principalColumn: "SeriesId");
                    table.ForeignKey(
                        name: "FK_AuctionResult_SeriesCategory_SeriesCategoryId",
                        column: x => x.SeriesCategoryId,
                        principalTable: "SeriesCategory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AuctionResult_SeriesNumber_SeriesNumberId",
                        column: x => x.SeriesNumberId,
                        principalTable: "SeriesNumber",
                        principalColumn: "SeriesNumberId");
                });

            migrationBuilder.CreateTable(
                name: "SeriesNumberPool",
                columns: table => new
                {
                    SeriesNumberPoolId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuctionedPrice = table.Column<long>(type: "bigint", nullable: true),
                    BasePrice = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DistrictId = table.Column<long>(type: "bigint", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsAlloted = table.Column<bool>(type: "bit", nullable: false),
                    IsBlocked = table.Column<bool>(type: "bit", nullable: false),
                    IsReserved = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    RegistrationNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    SeriesCategoryId = table.Column<long>(type: "bigint", nullable: false),
                    SeriesId = table.Column<long>(type: "bigint", nullable: false),
                    SeriesNumberId = table.Column<long>(type: "bigint", nullable: false),
                    SeriesNumberStatusId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeriesNumberPool", x => x.SeriesNumberPoolId);
                    table.ForeignKey(
                        name: "FK_SeriesNumberPool_District_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "District",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SeriesNumberPool_Series_SeriesId",
                        column: x => x.SeriesId,
                        principalTable: "Series",
                        principalColumn: "SeriesId");
                    table.ForeignKey(
                        name: "FK_SeriesNumberPool_SeriesCategory_SeriesCategoryId",
                        column: x => x.SeriesCategoryId,
                        principalTable: "SeriesCategory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SeriesNumberPool_SeriesNumber_SeriesNumberId",
                        column: x => x.SeriesNumberId,
                        principalTable: "SeriesNumber",
                        principalColumn: "SeriesNumberId");
                    table.ForeignKey(
                        name: "FK_SeriesNumberPool_SeriesNumberStatus_SeriesNumberStatusId",
                        column: x => x.SeriesNumberStatusId,
                        principalTable: "SeriesNumberStatus",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BusinessProFeeTax",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    BusinessProcessId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TaxTypeId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessProFeeTax", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessProFeeTax_BusinessProcess_BusinessProcessId",
                        column: x => x.BusinessProcessId,
                        principalTable: "BusinessProcess",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BusinessProFeeTax_TaxType_TaxTypeId",
                        column: x => x.TaxTypeId,
                        principalTable: "TaxType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OwnerTaxGroupFees",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<long>(type: "bigint", nullable: false),
                    AppliedFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OwnerTaxGroupId = table.Column<long>(type: "bigint", nullable: false),
                    TaxTypeId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OwnerTaxGroupFees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OwnerTaxGroupFees_OwnerTaxGroup_OwnerTaxGroupId",
                        column: x => x.OwnerTaxGroupId,
                        principalTable: "OwnerTaxGroup",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OwnerTaxGroupFees_TaxType_TaxTypeId",
                        column: x => x.TaxTypeId,
                        principalTable: "TaxType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VehicleClassDetail",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    AppliedFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EngineSizeMax = table.Column<long>(type: "bigint", nullable: false),
                    EngineSizeMin = table.Column<long>(type: "bigint", nullable: false),
                    FitnessDocRequired = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LadenWeightMax = table.Column<long>(type: "bigint", nullable: false),
                    LadenWeightMin = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SeatingCapacityMax = table.Column<long>(type: "bigint", nullable: false),
                    SeatingCapacityMin = table.Column<long>(type: "bigint", nullable: false),
                    TaxFrequency = table.Column<int>(type: "int", nullable: false),
                    UnladenWeightMax = table.Column<long>(type: "bigint", nullable: false),
                    UnladenWeightMin = table.Column<long>(type: "bigint", nullable: false),
                    VehicleBodyTypeId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleCategoryId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleClassId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleClassificationId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleRouteTypeId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleTypeId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleUsageId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleClassDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleClassDetail_VehicleBodyType_VehicleBodyTypeId",
                        column: x => x.VehicleBodyTypeId,
                        principalTable: "VehicleBodyType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleClassDetail_VehicleCategory_VehicleCategoryId",
                        column: x => x.VehicleCategoryId,
                        principalTable: "VehicleCategory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleClassDetail_VehicleClass_VehicleClassId",
                        column: x => x.VehicleClassId,
                        principalTable: "VehicleClass",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleClassDetail_VehicleClassification_VehicleClassificationId",
                        column: x => x.VehicleClassificationId,
                        principalTable: "VehicleClassification",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleClassDetail_VehicleRouteType_VehicleRouteTypeId",
                        column: x => x.VehicleRouteTypeId,
                        principalTable: "VehicleRouteType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleClassDetail_VehicleType_VehicleTypeId",
                        column: x => x.VehicleTypeId,
                        principalTable: "VehicleType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleClassDetail_VehicleUsage_VehicleUsageId",
                        column: x => x.VehicleUsageId,
                        principalTable: "VehicleUsage",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    AddressId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    AddressTypeId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessId = table.Column<long>(type: "bigint", nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DistrictId = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    PersonId = table.Column<long>(type: "bigint", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    TehsilId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_Address_AddressType_AddressTypeId",
                        column: x => x.AddressTypeId,
                        principalTable: "AddressType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Address_Business_BusinessId",
                        column: x => x.BusinessId,
                        principalTable: "Business",
                        principalColumn: "BusinessId");
                    table.ForeignKey(
                        name: "FK_Address_District_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "District",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Address_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "PersonId");
                    table.ForeignKey(
                        name: "FK_Address_Tehsil_TehsilId",
                        column: x => x.TehsilId,
                        principalTable: "Tehsil",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BusinessRep",
                columns: table => new
                {
                    BusinessRepId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessRepStatusId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsOwner = table.Column<bool>(type: "bit", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    PersonId = table.Column<long>(type: "bigint", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessRep", x => x.BusinessRepId);
                    table.ForeignKey(
                        name: "FK_BusinessRep_Business_BusinessId",
                        column: x => x.BusinessId,
                        principalTable: "Business",
                        principalColumn: "BusinessId");
                    table.ForeignKey(
                        name: "FK_BusinessRep_BusinessRepStatus_BusinessRepStatusId",
                        column: x => x.BusinessRepStatusId,
                        principalTable: "BusinessRepStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BusinessRep_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "PersonId");
                });

            migrationBuilder.CreateTable(
                name: "Dealer",
                columns: table => new
                {
                    DealerId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountPassword = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    BusinessId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dealer", x => x.DealerId);
                    table.ForeignKey(
                        name: "FK_Dealer_Business_BusinessId",
                        column: x => x.BusinessId,
                        principalTable: "Business",
                        principalColumn: "BusinessId");
                });

            migrationBuilder.CreateTable(
                name: "PhoneNumber",
                columns: table => new
                {
                    PhoneNumberId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessId = table.Column<long>(type: "bigint", nullable: true),
                    CountryId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    PersonId = table.Column<long>(type: "bigint", nullable: true),
                    PhoneNumberTypeId = table.Column<long>(type: "bigint", nullable: false),
                    PhoneNumberValue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumber", x => x.PhoneNumberId);
                    table.ForeignKey(
                        name: "FK_PhoneNumber_Business_BusinessId",
                        column: x => x.BusinessId,
                        principalTable: "Business",
                        principalColumn: "BusinessId");
                    table.ForeignKey(
                        name: "FK_PhoneNumber_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PhoneNumber_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "PersonId");
                    table.ForeignKey(
                        name: "FK_PhoneNumber_PhoneNumberType_PhoneNumberTypeId",
                        column: x => x.PhoneNumberTypeId,
                        principalTable: "PhoneNumberType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OwnerGroup",
                columns: table => new
                {
                    OwnerGroupId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    IsFirstGroupMember = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    OwnerId = table.Column<long>(type: "bigint", nullable: false),
                    PersonId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OwnerGroup", x => x.OwnerGroupId);
                    table.ForeignKey(
                        name: "FK_OwnerGroup_Business_BusinessId",
                        column: x => x.BusinessId,
                        principalTable: "Business",
                        principalColumn: "BusinessId");
                    table.ForeignKey(
                        name: "FK_OwnerGroup_Owner_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Owner",
                        principalColumn: "OwnerId");
                    table.ForeignKey(
                        name: "FK_OwnerGroup_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "PersonId");
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    VehicleId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChasisNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    EngineNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    EngineSize = table.Column<int>(type: "int", nullable: false),
                    HorsePower = table.Column<int>(type: "int", nullable: false),
                    LadenWeight = table.Column<long>(type: "bigint", nullable: false),
                    ManufacturingYear = table.Column<int>(type: "int", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    NoOfCylinder = table.Column<int>(type: "int", nullable: false),
                    OwnerId = table.Column<long>(type: "bigint", nullable: false),
                    Price = table.Column<long>(type: "bigint", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RegistrationDistrictId = table.Column<long>(type: "bigint", nullable: false),
                    RegistrationNo = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    SeatingCapacity = table.Column<int>(type: "int", nullable: false),
                    UnLadenWeight = table.Column<long>(type: "bigint", nullable: false),
                    VehicleBodyConventionId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleBodyTypeId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleCategoryId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleClassId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleClassificationId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleColorId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleEngineTypeId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleFuelTypeId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleMakeId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleMakerId = table.Column<long>(type: "bigint", nullable: true),
                    VehiclePurchaseTypeId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleRouteTypeId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleStatusId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleTypeId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleUsageId = table.Column<long>(type: "bigint", nullable: true),
                    WheelBase = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.VehicleId);
                    table.ForeignKey(
                        name: "FK_Vehicle_District_RegistrationDistrictId",
                        column: x => x.RegistrationDistrictId,
                        principalTable: "District",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicle_Owner_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Owner",
                        principalColumn: "OwnerId");
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleBodyConvention_VehicleBodyConventionId",
                        column: x => x.VehicleBodyConventionId,
                        principalTable: "VehicleBodyConvention",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleBodyType_VehicleBodyTypeId",
                        column: x => x.VehicleBodyTypeId,
                        principalTable: "VehicleBodyType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleCategory_VehicleCategoryId",
                        column: x => x.VehicleCategoryId,
                        principalTable: "VehicleCategory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleClass_VehicleClassId",
                        column: x => x.VehicleClassId,
                        principalTable: "VehicleClass",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleClassification_VehicleClassificationId",
                        column: x => x.VehicleClassificationId,
                        principalTable: "VehicleClassification",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleColor_VehicleColorId",
                        column: x => x.VehicleColorId,
                        principalTable: "VehicleColor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleEngineType_VehicleEngineTypeId",
                        column: x => x.VehicleEngineTypeId,
                        principalTable: "VehicleEngineType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleFuelType_VehicleFuelTypeId",
                        column: x => x.VehicleFuelTypeId,
                        principalTable: "VehicleFuelType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleMake_VehicleMakeId",
                        column: x => x.VehicleMakeId,
                        principalTable: "VehicleMake",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleMaker_VehicleMakerId",
                        column: x => x.VehicleMakerId,
                        principalTable: "VehicleMaker",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicle_VehiclePurchaseType_VehiclePurchaseTypeId",
                        column: x => x.VehiclePurchaseTypeId,
                        principalTable: "VehiclePurchaseType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleRouteType_VehicleRouteTypeId",
                        column: x => x.VehicleRouteTypeId,
                        principalTable: "VehicleRouteType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleStatus_VehicleStatusId",
                        column: x => x.VehicleStatusId,
                        principalTable: "VehicleStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleType_VehicleTypeId",
                        column: x => x.VehicleTypeId,
                        principalTable: "VehicleType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleUsage_VehicleUsageId",
                        column: x => x.VehicleUsageId,
                        principalTable: "VehicleUsage",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TaxRate",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TaxBaseId = table.Column<long>(type: "bigint", nullable: false),
                    TaxTypeId = table.Column<long>(type: "bigint", nullable: false),
                    TaxValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VehicleClassDetailId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleClassId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxRate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaxRate_TaxBase_TaxBaseId",
                        column: x => x.TaxBaseId,
                        principalTable: "TaxBase",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TaxRate_TaxType_TaxTypeId",
                        column: x => x.TaxTypeId,
                        principalTable: "TaxType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TaxRate_VehicleClass_VehicleClassId",
                        column: x => x.VehicleClassId,
                        principalTable: "VehicleClass",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TaxRate_VehicleClassDetail_VehicleClassDetailId",
                        column: x => x.VehicleClassDetailId,
                        principalTable: "VehicleClassDetail",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Application",
                columns: table => new
                {
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationStatusId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessPhaseId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessPhaseStatusId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessProcessId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DistrictId = table.Column<long>(type: "bigint", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    OwnerId = table.Column<long>(type: "bigint", nullable: true),
                    ReceivedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SellerId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Application", x => x.ApplicationId);
                    table.ForeignKey(
                        name: "FK_Application_ApplicationStatus_ApplicationStatusId",
                        column: x => x.ApplicationStatusId,
                        principalTable: "ApplicationStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Application_BusinessPhase_BusinessPhaseId",
                        column: x => x.BusinessPhaseId,
                        principalTable: "BusinessPhase",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Application_BusinessPhaseStatus_BusinessPhaseStatusId",
                        column: x => x.BusinessPhaseStatusId,
                        principalTable: "BusinessPhaseStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Application_BusinessProcess_BusinessProcessId",
                        column: x => x.BusinessProcessId,
                        principalTable: "BusinessProcess",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Application_District_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "District",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Application_Owner_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Owner",
                        principalColumn: "OwnerId");
                    table.ForeignKey(
                        name: "FK_Application_Owner_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Owner",
                        principalColumn: "OwnerId");
                    table.ForeignKey(
                        name: "FK_Application_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                });

            migrationBuilder.CreateTable(
                name: "Keeper",
                columns: table => new
                {
                    KeeperId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    KeeperPersonId = table.Column<long>(type: "bigint", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    OwnerId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keeper", x => x.KeeperId);
                    table.ForeignKey(
                        name: "FK_Keeper_Owner_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Owner",
                        principalColumn: "OwnerId");
                    table.ForeignKey(
                        name: "FK_Keeper_Person_KeeperPersonId",
                        column: x => x.KeeperPersonId,
                        principalTable: "Person",
                        principalColumn: "PersonId");
                    table.ForeignKey(
                        name: "FK_Keeper_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleAdditionalInfo",
                columns: table => new
                {
                    VehicleAdditionalInfoId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DateOfFirstRegistration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FitnessCertValidFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FitnessCertValidTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsHPA = table.Column<bool>(type: "bit", nullable: false),
                    IsIncomeTaxExempted = table.Column<bool>(type: "bit", nullable: true),
                    IsTaxExempted = table.Column<bool>(type: "bit", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    RegistrationNoPrice = table.Column<long>(type: "bigint", nullable: false),
                    TaxFrequency = table.Column<int>(type: "int", nullable: false),
                    TaxPaidUpto = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaxPeriod = table.Column<int>(type: "int", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleRCStatusId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleAdditionalInfo", x => x.VehicleAdditionalInfoId);
                    table.ForeignKey(
                        name: "FK_VehicleAdditionalInfo_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                    table.ForeignKey(
                        name: "FK_VehicleAdditionalInfo_VehicleRCStatus_VehicleRCStatusId",
                        column: x => x.VehicleRCStatusId,
                        principalTable: "VehicleRCStatus",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VehicleRegistrationHistory",
                columns: table => new
                {
                    VehicleRegHistoryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegistrationDistrictId = table.Column<long>(type: "bigint", nullable: false),
                    RegistrationNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    SeriesNumberPoolId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleRegistrationHistory", x => x.VehicleRegHistoryId);
                    table.ForeignKey(
                        name: "FK_VehicleRegistrationHistory_District_RegistrationDistrictId",
                        column: x => x.RegistrationDistrictId,
                        principalTable: "District",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleRegistrationHistory_SeriesNumberPool_SeriesNumberPoolId",
                        column: x => x.SeriesNumberPoolId,
                        principalTable: "SeriesNumberPool",
                        principalColumn: "SeriesNumberPoolId");
                    table.ForeignKey(
                        name: "FK_VehicleRegistrationHistory_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                });

            migrationBuilder.CreateTable(
                name: "AssessmentBase",
                columns: table => new
                {
                    AssessmentBaseId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: true),
                    ApplicationReceivedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AssessmentStatusId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessProcessId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DateOfFirstRegistration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DistrictId = table.Column<long>(type: "bigint", nullable: false),
                    EngineSize = table.Column<int>(type: "int", nullable: false),
                    FitnessCertValidFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FitnessCertValidTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsFiler = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    IsHPA = table.Column<bool>(type: "bit", nullable: false),
                    IsIncomeTaxExempted = table.Column<bool>(type: "bit", nullable: true),
                    IsTaxExempted = table.Column<bool>(type: "bit", nullable: true),
                    LadenWeight = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    OwnerId = table.Column<long>(type: "bigint", nullable: false),
                    OwnerTaxGroupId = table.Column<long>(type: "bigint", nullable: false),
                    Price = table.Column<long>(type: "bigint", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RegistrationNo = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    RegistrationNoPrice = table.Column<long>(type: "bigint", nullable: false),
                    SeatingCapacity = table.Column<int>(type: "int", nullable: false),
                    TaxFrequency = table.Column<int>(type: "int", nullable: false),
                    TaxPaidUpto = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaxPeriod = table.Column<int>(type: "int", nullable: false),
                    UnLadenWeight = table.Column<long>(type: "bigint", nullable: false),
                    VehicleBodyTypeId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleCategoryId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleClassDetailId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleClassId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleClassificationId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    VehiclePurchaseTypeId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleStatusId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleUsageId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentBase", x => x.AssessmentBaseId);
                    table.ForeignKey(
                        name: "FK_AssessmentBase_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Application",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_AssessmentBase_AssessmentStatus_AssessmentStatusId",
                        column: x => x.AssessmentStatusId,
                        principalTable: "AssessmentStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AssessmentBase_BusinessProcess_BusinessProcessId",
                        column: x => x.BusinessProcessId,
                        principalTable: "BusinessProcess",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AssessmentBase_District_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "District",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AssessmentBase_Owner_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Owner",
                        principalColumn: "OwnerId");
                    table.ForeignKey(
                        name: "FK_AssessmentBase_OwnerTaxGroup_OwnerTaxGroupId",
                        column: x => x.OwnerTaxGroupId,
                        principalTable: "OwnerTaxGroup",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AssessmentBase_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                    table.ForeignKey(
                        name: "FK_AssessmentBase_VehicleBodyType_VehicleBodyTypeId",
                        column: x => x.VehicleBodyTypeId,
                        principalTable: "VehicleBodyType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AssessmentBase_VehicleCategory_VehicleCategoryId",
                        column: x => x.VehicleCategoryId,
                        principalTable: "VehicleCategory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AssessmentBase_VehicleClass_VehicleClassId",
                        column: x => x.VehicleClassId,
                        principalTable: "VehicleClass",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AssessmentBase_VehicleClassDetail_VehicleClassDetailId",
                        column: x => x.VehicleClassDetailId,
                        principalTable: "VehicleClassDetail",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AssessmentBase_VehicleClassification_VehicleClassificationId",
                        column: x => x.VehicleClassificationId,
                        principalTable: "VehicleClassification",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AssessmentBase_VehiclePurchaseType_VehiclePurchaseTypeId",
                        column: x => x.VehiclePurchaseTypeId,
                        principalTable: "VehiclePurchaseType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AssessmentBase_VehicleStatus_VehicleStatusId",
                        column: x => x.VehicleStatusId,
                        principalTable: "VehicleStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AssessmentBase_VehicleUsage_VehicleUsageId",
                        column: x => x.VehicleUsageId,
                        principalTable: "VehicleUsage",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HPA",
                columns: table => new
                {
                    HPAId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    HPACurrentStatusId = table.Column<long>(type: "bigint", nullable: false),
                    HPADate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HPAEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HPAStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HPAStatusDated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LetterDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LetterNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    OwnerId = table.Column<long>(type: "bigint", nullable: false),
                    SponserBusinessId = table.Column<long>(type: "bigint", nullable: false),
                    Terms = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    VehicleId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HPA", x => x.HPAId);
                    table.ForeignKey(
                        name: "FK_HPA_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Application",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_HPA_Business_SponserBusinessId",
                        column: x => x.SponserBusinessId,
                        principalTable: "Business",
                        principalColumn: "BusinessId");
                    table.ForeignKey(
                        name: "FK_HPA_HPAStatus_HPACurrentStatusId",
                        column: x => x.HPACurrentStatusId,
                        principalTable: "HPAStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HPA_Owner_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Owner",
                        principalColumn: "OwnerId");
                    table.ForeignKey(
                        name: "FK_HPA_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                });

            migrationBuilder.CreateTable(
                name: "Remarks",
                columns: table => new
                {
                    RemarksId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    OwnerGroupId = table.Column<long>(type: "bigint", nullable: true),
                    OwnerId = table.Column<long>(type: "bigint", nullable: true),
                    RemarksStatement = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Remarks", x => x.RemarksId);
                    table.ForeignKey(
                        name: "FK_Remarks_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Application",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_Remarks_Owner_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Owner",
                        principalColumn: "OwnerId");
                    table.ForeignKey(
                        name: "FK_Remarks_OwnerGroup_OwnerGroupId",
                        column: x => x.OwnerGroupId,
                        principalTable: "OwnerGroup",
                        principalColumn: "OwnerGroupId");
                    table.ForeignKey(
                        name: "FK_Remarks_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "RoleId");
                    table.ForeignKey(
                        name: "FK_Remarks_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleAuctionInfo",
                columns: table => new
                {
                    VehicleAuctionInfoId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    BatchNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CategoryNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    LotNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    VoucherDated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VoucherNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleAuctionInfo", x => x.VehicleAuctionInfoId);
                    table.ForeignKey(
                        name: "FK_VehicleAuctionInfo_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Application",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_VehicleAuctionInfo_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleBusinessProcessHistory",
                columns: table => new
                {
                    VehicleBusinessProHistId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessProcessId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DistrictId = table.Column<long>(type: "bigint", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    OwnerId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleBusinessProcessHistory", x => x.VehicleBusinessProHistId);
                    table.ForeignKey(
                        name: "FK_VehicleBusinessProcessHistory_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Application",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_VehicleBusinessProcessHistory_BusinessProcess_BusinessProcessId",
                        column: x => x.BusinessProcessId,
                        principalTable: "BusinessProcess",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleBusinessProcessHistory_District_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "District",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleBusinessProcessHistory_Owner_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Owner",
                        principalColumn: "OwnerId");
                    table.ForeignKey(
                        name: "FK_VehicleBusinessProcessHistory_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleDocument",
                columns: table => new
                {
                    VehicleDocumentId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    FileExtension = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    FilePath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    MIMEType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    TotalPages = table.Column<int>(type: "int", nullable: false),
                    VehicleDocumentTypeId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleDocument", x => x.VehicleDocumentId);
                    table.ForeignKey(
                        name: "FK_VehicleDocument_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Application",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_VehicleDocument_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                    table.ForeignKey(
                        name: "FK_VehicleDocument_VehicleDocumentType_VehicleDocumentTypeId",
                        column: x => x.VehicleDocumentTypeId,
                        principalTable: "VehicleDocumentType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VehicleImportInfo",
                columns: table => new
                {
                    VehicleImportInfoId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnyOtherCost = table.Column<long>(type: "bigint", nullable: false),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    BankId = table.Column<long>(type: "bigint", nullable: false),
                    ClearingAgentId = table.Column<long>(type: "bigint", nullable: false),
                    CountryId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    CustomCollectorateId = table.Column<long>(type: "bigint", nullable: false),
                    CustomDuty = table.Column<long>(type: "bigint", nullable: false),
                    IGMDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IGMNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ImportLicenseFee = table.Column<long>(type: "bigint", nullable: false),
                    ImportPermitNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ImportValue = table.Column<long>(type: "bigint", nullable: false),
                    ImporterAddress = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ImporterName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    IndexNo = table.Column<long>(type: "bigint", nullable: false),
                    Insurrance = table.Column<long>(type: "bigint", nullable: false),
                    LandedCost = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PermitIssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlaceOfIssue = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PortId = table.Column<long>(type: "bigint", nullable: false),
                    SalesTax = table.Column<long>(type: "bigint", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleSchemeId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleImportInfo", x => x.VehicleImportInfoId);
                    table.ForeignKey(
                        name: "FK_VehicleImportInfo_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Application",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_VehicleImportInfo_Bank_BankId",
                        column: x => x.BankId,
                        principalTable: "Bank",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleImportInfo_ClearingAgent_ClearingAgentId",
                        column: x => x.ClearingAgentId,
                        principalTable: "ClearingAgent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleImportInfo_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleImportInfo_CustomCollectorate_CustomCollectorateId",
                        column: x => x.CustomCollectorateId,
                        principalTable: "CustomCollectorate",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleImportInfo_Port_PortId",
                        column: x => x.PortId,
                        principalTable: "Port",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleImportInfo_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                    table.ForeignKey(
                        name: "FK_VehicleImportInfo_VehicleScheme_VehicleSchemeId",
                        column: x => x.VehicleSchemeId,
                        principalTable: "VehicleScheme",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VehicleOwnershipHistory",
                columns: table => new
                {
                    VehicleOwnershipHistoryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessProcessId = table.Column<long>(type: "bigint", nullable: false),
                    BuyerId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    EffectedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    SellerId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleOwnershipHistory", x => x.VehicleOwnershipHistoryId);
                    table.ForeignKey(
                        name: "FK_VehicleOwnershipHistory_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Application",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_VehicleOwnershipHistory_BusinessProcess_BusinessProcessId",
                        column: x => x.BusinessProcessId,
                        principalTable: "BusinessProcess",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleOwnershipHistory_Owner_BuyerId",
                        column: x => x.BuyerId,
                        principalTable: "Owner",
                        principalColumn: "OwnerId");
                    table.ForeignKey(
                        name: "FK_VehicleOwnershipHistory_Owner_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Owner",
                        principalColumn: "OwnerId");
                    table.ForeignKey(
                        name: "FK_VehicleOwnershipHistory_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                });

            migrationBuilder.CreateTable(
                name: "VehiclePurchaseInfo",
                columns: table => new
                {
                    VehiclePurchaseInfoId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    CertificateDated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CertificateNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DealerId = table.Column<long>(type: "bigint", nullable: false),
                    InvoiceDated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InvoiceNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleSchemeId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehiclePurchaseInfo", x => x.VehiclePurchaseInfoId);
                    table.ForeignKey(
                        name: "FK_VehiclePurchaseInfo_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Application",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_VehiclePurchaseInfo_Dealer_DealerId",
                        column: x => x.DealerId,
                        principalTable: "Dealer",
                        principalColumn: "DealerId");
                    table.ForeignKey(
                        name: "FK_VehiclePurchaseInfo_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                    table.ForeignKey(
                        name: "FK_VehiclePurchaseInfo_VehicleScheme_VehicleSchemeId",
                        column: x => x.VehicleSchemeId,
                        principalTable: "VehicleScheme",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AssessmentDetail",
                columns: table => new
                {
                    AssessmentDetailId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssessmentBaseId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    PayableAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxTypeId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentDetail", x => x.AssessmentDetailId);
                    table.ForeignKey(
                        name: "FK_AssessmentDetail_AssessmentBase_AssessmentBaseId",
                        column: x => x.AssessmentBaseId,
                        principalTable: "AssessmentBase",
                        principalColumn: "AssessmentBaseId");
                    table.ForeignKey(
                        name: "FK_AssessmentDetail_TaxType_TaxTypeId",
                        column: x => x.TaxTypeId,
                        principalTable: "TaxType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Challan",
                columns: table => new
                {
                    ChallanId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    AssessmentBaseId = table.Column<long>(type: "bigint", nullable: false),
                    ChallanStatusId = table.Column<long>(type: "bigint", nullable: false),
                    ChallanTypeId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    TotalAmount = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Challan", x => x.ChallanId);
                    table.ForeignKey(
                        name: "FK_Challan_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Application",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_Challan_AssessmentBase_AssessmentBaseId",
                        column: x => x.AssessmentBaseId,
                        principalTable: "AssessmentBase",
                        principalColumn: "AssessmentBaseId");
                    table.ForeignKey(
                        name: "FK_Challan_ChallanStatus_ChallanStatusId",
                        column: x => x.ChallanStatusId,
                        principalTable: "ChallanStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Challan_ChallanType_ChallanTypeId",
                        column: x => x.ChallanTypeId,
                        principalTable: "ChallanType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HPAStatusHistory",
                columns: table => new
                {
                    HPAStatusHistoryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    HPAId = table.Column<long>(type: "bigint", nullable: false),
                    HPAStatusDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HPAStatusId = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HPAStatusHistory", x => x.HPAStatusHistoryId);
                    table.ForeignKey(
                        name: "FK_HPAStatusHistory_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Application",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_HPAStatusHistory_HPA_HPAId",
                        column: x => x.HPAId,
                        principalTable: "HPA",
                        principalColumn: "HPAId");
                    table.ForeignKey(
                        name: "FK_HPAStatusHistory_HPAStatus_HPAStatusId",
                        column: x => x.HPAStatusId,
                        principalTable: "HPAStatus",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    PaymentInfoId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AmountPaid = table.Column<long>(type: "bigint", nullable: false),
                    BankCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CashReceivedBy = table.Column<long>(type: "bigint", nullable: true),
                    ChallanId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    PSId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PaidOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentModeId = table.Column<long>(type: "bigint", nullable: false),
                    PaymentStatusId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.PaymentInfoId);
                    table.ForeignKey(
                        name: "FK_Payment_Challan_ChallanId",
                        column: x => x.ChallanId,
                        principalTable: "Challan",
                        principalColumn: "ChallanId");
                    table.ForeignKey(
                        name: "FK_Payment_PaymentMode_PaymentModeId",
                        column: x => x.PaymentModeId,
                        principalTable: "PaymentMode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Payment_PaymentStatus_PaymentStatusId",
                        column: x => x.PaymentStatusId,
                        principalTable: "PaymentStatus",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_RoleAppProcessFlow_AppProcessFlowId",
                table: "RoleAppProcessFlow",
                column: "AppProcessFlowId");

            migrationBuilder.CreateIndex(
                name: "IX_BiometricVerification_OwnerGroupId",
                table: "BiometricVerification",
                column: "OwnerGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_BiometricVerification_VehicleId",
                table: "BiometricVerification",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_AddressTypeId",
                table: "Address",
                column: "AddressTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_BusinessId",
                table: "Address",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_DistrictId",
                table: "Address",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_PersonId",
                table: "Address",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_TehsilId",
                table: "Address",
                column: "TehsilId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_ApplicationStatusId",
                table: "Application",
                column: "ApplicationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_BusinessPhaseId",
                table: "Application",
                column: "BusinessPhaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_BusinessPhaseStatusId",
                table: "Application",
                column: "BusinessPhaseStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_BusinessProcessId",
                table: "Application",
                column: "BusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_DistrictId",
                table: "Application",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_OwnerId",
                table: "Application",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_SellerId",
                table: "Application",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_VehicleId",
                table: "Application",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationProcessFlow_BusinessEventId",
                table: "ApplicationProcessFlow",
                column: "BusinessEventId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationProcessFlow_BusinessProcessId",
                table: "ApplicationProcessFlow",
                column: "BusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationProcessFlow_CreatedBy",
                table: "ApplicationProcessFlow",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationProcessFlow_CurrentApplicationStatusId",
                table: "ApplicationProcessFlow",
                column: "CurrentApplicationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationProcessFlow_CurrentBusinessPhaseId",
                table: "ApplicationProcessFlow",
                column: "CurrentBusinessPhaseId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationProcessFlow_CurrentBusinessPhaseStatusId",
                table: "ApplicationProcessFlow",
                column: "CurrentBusinessPhaseStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationProcessFlow_ModifiedBy",
                table: "ApplicationProcessFlow",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationProcessFlow_NextApplicationStatusId",
                table: "ApplicationProcessFlow",
                column: "NextApplicationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationProcessFlow_NextBusinessPhaseId",
                table: "ApplicationProcessFlow",
                column: "NextBusinessPhaseId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationProcessFlow_NextBusinessPhaseStatusId",
                table: "ApplicationProcessFlow",
                column: "NextBusinessPhaseStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationProcessFlow_RoleId",
                table: "ApplicationProcessFlow",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_ApplicationId",
                table: "AssessmentBase",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_AssessmentStatusId",
                table: "AssessmentBase",
                column: "AssessmentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_BusinessProcessId",
                table: "AssessmentBase",
                column: "BusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_DistrictId",
                table: "AssessmentBase",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_OwnerId",
                table: "AssessmentBase",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_OwnerTaxGroupId",
                table: "AssessmentBase",
                column: "OwnerTaxGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_VehicleBodyTypeId",
                table: "AssessmentBase",
                column: "VehicleBodyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_VehicleCategoryId",
                table: "AssessmentBase",
                column: "VehicleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_VehicleClassDetailId",
                table: "AssessmentBase",
                column: "VehicleClassDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_VehicleClassId",
                table: "AssessmentBase",
                column: "VehicleClassId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_VehicleClassificationId",
                table: "AssessmentBase",
                column: "VehicleClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_VehicleId",
                table: "AssessmentBase",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_VehiclePurchaseTypeId",
                table: "AssessmentBase",
                column: "VehiclePurchaseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_VehicleStatusId",
                table: "AssessmentBase",
                column: "VehicleStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_VehicleUsageId",
                table: "AssessmentBase",
                column: "VehicleUsageId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentDetail_AssessmentBaseId",
                table: "AssessmentDetail",
                column: "AssessmentBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentDetail_TaxTypeId",
                table: "AssessmentDetail",
                column: "TaxTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AuctionResult_SeriesCategoryId",
                table: "AuctionResult",
                column: "SeriesCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AuctionResult_SeriesId",
                table: "AuctionResult",
                column: "SeriesId");

            migrationBuilder.CreateIndex(
                name: "IX_AuctionResult_SeriesNumberId",
                table: "AuctionResult",
                column: "SeriesNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_Business_BusinessSectorId",
                table: "Business",
                column: "BusinessSectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Business_BusinessStatusId",
                table: "Business",
                column: "BusinessStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Business_BusinessTypeId",
                table: "Business",
                column: "BusinessTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessProFeeTax_BusinessProcessId",
                table: "BusinessProFeeTax",
                column: "BusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessProFeeTax_TaxTypeId",
                table: "BusinessProFeeTax",
                column: "TaxTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessRep_BusinessId",
                table: "BusinessRep",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessRep_BusinessRepStatusId",
                table: "BusinessRep",
                column: "BusinessRepStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessRep_PersonId",
                table: "BusinessRep",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessSector_BusinessTypeId",
                table: "BusinessSector",
                column: "BusinessTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTableAccessLevel_ApplicationStatusId",
                table: "BusinessTableAccessLevel",
                column: "ApplicationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTableAccessLevel_BusinessPhaseId",
                table: "BusinessTableAccessLevel",
                column: "BusinessPhaseId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTableAccessLevel_BusinessPhaseStatusId",
                table: "BusinessTableAccessLevel",
                column: "BusinessPhaseStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTableAccessLevel_BusinessProcessId",
                table: "BusinessTableAccessLevel",
                column: "BusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTableAccessLevel_BusinessTableAccessId",
                table: "BusinessTableAccessLevel",
                column: "BusinessTableAccessId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTableAccessLevel_BusinessTableId",
                table: "BusinessTableAccessLevel",
                column: "BusinessTableId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTableAccessLevel_CreatedBy",
                table: "BusinessTableAccessLevel",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTableAccessLevel_ModifiedBy",
                table: "BusinessTableAccessLevel",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTableAccessLevel_RoleId",
                table: "BusinessTableAccessLevel",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Challan_ApplicationId",
                table: "Challan",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Challan_AssessmentBaseId",
                table: "Challan",
                column: "AssessmentBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Challan_ChallanStatusId",
                table: "Challan",
                column: "ChallanStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Challan_ChallanTypeId",
                table: "Challan",
                column: "ChallanTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Dealer_BusinessId",
                table: "Dealer",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_HPA_ApplicationId",
                table: "HPA",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_HPA_HPACurrentStatusId",
                table: "HPA",
                column: "HPACurrentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_HPA_OwnerId",
                table: "HPA",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_HPA_SponserBusinessId",
                table: "HPA",
                column: "SponserBusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_HPA_VehicleId",
                table: "HPA",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_HPAStatusHistory_ApplicationId",
                table: "HPAStatusHistory",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_HPAStatusHistory_HPAId",
                table: "HPAStatusHistory",
                column: "HPAId");

            migrationBuilder.CreateIndex(
                name: "IX_HPAStatusHistory_HPAStatusId",
                table: "HPAStatusHistory",
                column: "HPAStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Keeper_KeeperPersonId",
                table: "Keeper",
                column: "KeeperPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Keeper_OwnerId",
                table: "Keeper",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Keeper_VehicleId",
                table: "Keeper",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Owner_OwnerTaxGroupId",
                table: "Owner",
                column: "OwnerTaxGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Owner_OwnerTypeId",
                table: "Owner",
                column: "OwnerTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerGroup_BusinessId",
                table: "OwnerGroup",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerGroup_OwnerId",
                table: "OwnerGroup",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerGroup_PersonId",
                table: "OwnerGroup",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerTaxGroup_OwnerTypeId",
                table: "OwnerTaxGroup",
                column: "OwnerTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerTaxGroupFees_OwnerTaxGroupId",
                table: "OwnerTaxGroupFees",
                column: "OwnerTaxGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerTaxGroupFees_TaxTypeId",
                table: "OwnerTaxGroupFees",
                column: "TaxTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_ChallanId",
                table: "Payment",
                column: "ChallanId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_PaymentModeId",
                table: "Payment",
                column: "PaymentModeId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_PaymentStatusId",
                table: "Payment",
                column: "PaymentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_CountryId",
                table: "Person",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumber_BusinessId",
                table: "PhoneNumber",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumber_CountryId",
                table: "PhoneNumber",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumber_PersonId",
                table: "PhoneNumber",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumber_PhoneNumberTypeId",
                table: "PhoneNumber",
                column: "PhoneNumberTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Remarks_ApplicationId",
                table: "Remarks",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Remarks_OwnerGroupId",
                table: "Remarks",
                column: "OwnerGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Remarks_OwnerId",
                table: "Remarks",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Remarks_RoleId",
                table: "Remarks",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Remarks_VehicleId",
                table: "Remarks",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Series_SeriesCategoryId",
                table: "Series",
                column: "SeriesCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Series_SeriesStatusId",
                table: "Series",
                column: "SeriesStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Series_SeriesTypeId",
                table: "Series",
                column: "SeriesTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumberPool_DistrictId",
                table: "SeriesNumberPool",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumberPool_SeriesCategoryId",
                table: "SeriesNumberPool",
                column: "SeriesCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumberPool_SeriesId",
                table: "SeriesNumberPool",
                column: "SeriesId");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumberPool_SeriesNumberId",
                table: "SeriesNumberPool",
                column: "SeriesNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumberPool_SeriesNumberStatusId",
                table: "SeriesNumberPool",
                column: "SeriesNumberStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxRate_TaxBaseId",
                table: "TaxRate",
                column: "TaxBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxRate_TaxTypeId",
                table: "TaxRate",
                column: "TaxTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxRate_VehicleClassDetailId",
                table: "TaxRate",
                column: "VehicleClassDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxRate_VehicleClassId",
                table: "TaxRate",
                column: "VehicleClassId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxType_TaxRuleId",
                table: "TaxType",
                column: "TaxRuleId");

            migrationBuilder.CreateIndex(
                name: "IX_Tehsil_DistrictId",
                table: "Tehsil",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_OwnerId",
                table: "Vehicle",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_RegistrationDistrictId",
                table: "Vehicle",
                column: "RegistrationDistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleBodyConventionId",
                table: "Vehicle",
                column: "VehicleBodyConventionId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleBodyTypeId",
                table: "Vehicle",
                column: "VehicleBodyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleCategoryId",
                table: "Vehicle",
                column: "VehicleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleClassId",
                table: "Vehicle",
                column: "VehicleClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleClassificationId",
                table: "Vehicle",
                column: "VehicleClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleColorId",
                table: "Vehicle",
                column: "VehicleColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleEngineTypeId",
                table: "Vehicle",
                column: "VehicleEngineTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleFuelTypeId",
                table: "Vehicle",
                column: "VehicleFuelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleMakeId",
                table: "Vehicle",
                column: "VehicleMakeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleMakerId",
                table: "Vehicle",
                column: "VehicleMakerId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehiclePurchaseTypeId",
                table: "Vehicle",
                column: "VehiclePurchaseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleRouteTypeId",
                table: "Vehicle",
                column: "VehicleRouteTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleStatusId",
                table: "Vehicle",
                column: "VehicleStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleTypeId",
                table: "Vehicle",
                column: "VehicleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleUsageId",
                table: "Vehicle",
                column: "VehicleUsageId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAdditionalInfo_VehicleId",
                table: "VehicleAdditionalInfo",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAdditionalInfo_VehicleRCStatusId",
                table: "VehicleAdditionalInfo",
                column: "VehicleRCStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAuctionInfo_ApplicationId",
                table: "VehicleAuctionInfo",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAuctionInfo_VehicleId",
                table: "VehicleAuctionInfo",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBusinessProcessHistory_ApplicationId",
                table: "VehicleBusinessProcessHistory",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBusinessProcessHistory_BusinessProcessId",
                table: "VehicleBusinessProcessHistory",
                column: "BusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBusinessProcessHistory_DistrictId",
                table: "VehicleBusinessProcessHistory",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBusinessProcessHistory_OwnerId",
                table: "VehicleBusinessProcessHistory",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBusinessProcessHistory_VehicleId",
                table: "VehicleBusinessProcessHistory",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClass_VehicleBodyTypeId",
                table: "VehicleClass",
                column: "VehicleBodyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClass_VehicleCategoryId",
                table: "VehicleClass",
                column: "VehicleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClass_VehicleClassGroupId",
                table: "VehicleClass",
                column: "VehicleClassGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClass_VehicleClassificationId",
                table: "VehicleClass",
                column: "VehicleClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClass_VehicleRouteTypeId",
                table: "VehicleClass",
                column: "VehicleRouteTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClass_VehicleTypeId",
                table: "VehicleClass",
                column: "VehicleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClassDetail_VehicleBodyTypeId",
                table: "VehicleClassDetail",
                column: "VehicleBodyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClassDetail_VehicleCategoryId",
                table: "VehicleClassDetail",
                column: "VehicleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClassDetail_VehicleClassId",
                table: "VehicleClassDetail",
                column: "VehicleClassId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClassDetail_VehicleClassificationId",
                table: "VehicleClassDetail",
                column: "VehicleClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClassDetail_VehicleRouteTypeId",
                table: "VehicleClassDetail",
                column: "VehicleRouteTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClassDetail_VehicleTypeId",
                table: "VehicleClassDetail",
                column: "VehicleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClassDetail_VehicleUsageId",
                table: "VehicleClassDetail",
                column: "VehicleUsageId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleDocument_ApplicationId",
                table: "VehicleDocument",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleDocument_VehicleDocumentTypeId",
                table: "VehicleDocument",
                column: "VehicleDocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleDocument_VehicleId",
                table: "VehicleDocument",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleDocumentRequirement_BusinessProcessId",
                table: "VehicleDocumentRequirement",
                column: "BusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleDocumentRequirement_VehicleDocumentTypeId",
                table: "VehicleDocumentRequirement",
                column: "VehicleDocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImportInfo_ApplicationId",
                table: "VehicleImportInfo",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImportInfo_BankId",
                table: "VehicleImportInfo",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImportInfo_ClearingAgentId",
                table: "VehicleImportInfo",
                column: "ClearingAgentId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImportInfo_CountryId",
                table: "VehicleImportInfo",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImportInfo_CustomCollectorateId",
                table: "VehicleImportInfo",
                column: "CustomCollectorateId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImportInfo_PortId",
                table: "VehicleImportInfo",
                column: "PortId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImportInfo_VehicleId",
                table: "VehicleImportInfo",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImportInfo_VehicleSchemeId",
                table: "VehicleImportInfo",
                column: "VehicleSchemeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleMake_VehicleMakerId",
                table: "VehicleMake",
                column: "VehicleMakerId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleOwnershipHistory_ApplicationId",
                table: "VehicleOwnershipHistory",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleOwnershipHistory_BusinessProcessId",
                table: "VehicleOwnershipHistory",
                column: "BusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleOwnershipHistory_BuyerId",
                table: "VehicleOwnershipHistory",
                column: "BuyerId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleOwnershipHistory_SellerId",
                table: "VehicleOwnershipHistory",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleOwnershipHistory_VehicleId",
                table: "VehicleOwnershipHistory",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_VehiclePurchaseInfo_ApplicationId",
                table: "VehiclePurchaseInfo",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_VehiclePurchaseInfo_DealerId",
                table: "VehiclePurchaseInfo",
                column: "DealerId");

            migrationBuilder.CreateIndex(
                name: "IX_VehiclePurchaseInfo_VehicleId",
                table: "VehiclePurchaseInfo",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_VehiclePurchaseInfo_VehicleSchemeId",
                table: "VehiclePurchaseInfo",
                column: "VehicleSchemeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleRegistrationHistory_RegistrationDistrictId",
                table: "VehicleRegistrationHistory",
                column: "RegistrationDistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleRegistrationHistory_SeriesNumberPoolId",
                table: "VehicleRegistrationHistory",
                column: "SeriesNumberPoolId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleRegistrationHistory_VehicleId",
                table: "VehicleRegistrationHistory",
                column: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_BiometricVerification_Application_ApplicationId",
                table: "BiometricVerification",
                column: "ApplicationId",
                principalTable: "Application",
                principalColumn: "ApplicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_BiometricVerification_OwnerGroup_OwnerGroupId",
                table: "BiometricVerification",
                column: "OwnerGroupId",
                principalTable: "OwnerGroup",
                principalColumn: "OwnerGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_BiometricVerification_Person_PersonId",
                table: "BiometricVerification",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_BiometricVerification_Vehicle_VehicleId",
                table: "BiometricVerification",
                column: "VehicleId",
                principalTable: "Vehicle",
                principalColumn: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleAppProcessFlow_ApplicationProcessFlow_AppProcessFlowId",
                table: "RoleAppProcessFlow",
                column: "AppProcessFlowId",
                principalTable: "ApplicationProcessFlow",
                principalColumn: "Id");
        }
    }
}
