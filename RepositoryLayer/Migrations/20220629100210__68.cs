using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _68 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OwnerLog",
                schema: "Core",
                columns: table => new
                {
                    OwnerLogId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerId = table.Column<long>(type: "bigint", nullable: false),
                    OwnerTypeId = table.Column<long>(type: "bigint", nullable: false),
                    OwnerTaxGroupId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OwnerLog", x => x.OwnerLogId);
                    table.ForeignKey(
                        name: "FK_OwnerLog_Owner_OwnerId",
                        column: x => x.OwnerId,
                        principalSchema: "Core",
                        principalTable: "Owner",
                        principalColumn: "OwnerId");
                    table.ForeignKey(
                        name: "FK_OwnerLog_OwnerTaxGroup_OwnerTaxGroupId",
                        column: x => x.OwnerTaxGroupId,
                        principalSchema: "Setup",
                        principalTable: "OwnerTaxGroup",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OwnerLog_OwnerType_OwnerTypeId",
                        column: x => x.OwnerTypeId,
                        principalSchema: "Setup",
                        principalTable: "OwnerType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OwnerLog_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_OwnerLog_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleAdditionalInfoLog",
                schema: "Core",
                columns: table => new
                {
                    VehicleAdditionalInfoLogId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleAdditionalInfoId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleRCStatusId = table.Column<long>(type: "bigint", nullable: true),
                    TaxFrequency = table.Column<int>(type: "int", nullable: false),
                    TaxPeriod = table.Column<int>(type: "int", nullable: false),
                    IsHPA = table.Column<bool>(type: "bit", nullable: false),
                    IsTaxExempted = table.Column<bool>(type: "bit", nullable: true),
                    IsIncomeTaxExempted = table.Column<bool>(type: "bit", nullable: true),
                    DateOfFirstRegistration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FitnessCertValidFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FitnessCertValidTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaxPaidUpto = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RegistrationNoPrice = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleAdditionalInfoLog", x => x.VehicleAdditionalInfoLogId);
                    table.ForeignKey(
                        name: "FK_VehicleAdditionalInfoLog_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleAdditionalInfoLog_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleAdditionalInfoLog_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalSchema: "Core",
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                    table.ForeignKey(
                        name: "FK_VehicleAdditionalInfoLog_VehicleAdditionalInfo_VehicleAdditionalInfoId",
                        column: x => x.VehicleAdditionalInfoId,
                        principalSchema: "Core",
                        principalTable: "VehicleAdditionalInfo",
                        principalColumn: "VehicleAdditionalInfoId");
                    table.ForeignKey(
                        name: "FK_VehicleAdditionalInfoLog_VehicleRCStatus_VehicleRCStatusId",
                        column: x => x.VehicleRCStatusId,
                        principalSchema: "Setup",
                        principalTable: "VehicleRCStatus",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VehicleAuctionInfoLog",
                schema: "Core",
                columns: table => new
                {
                    VehicleAuctionInfoLogId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleAuctionInfoId = table.Column<long>(type: "bigint", nullable: false),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    LotNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BatchNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CategoryNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    VoucherNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    VoucherDated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleAuctionInfoLog", x => x.VehicleAuctionInfoLogId);
                    table.ForeignKey(
                        name: "FK_VehicleAuctionInfoLog_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "Application",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_VehicleAuctionInfoLog_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleAuctionInfoLog_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleAuctionInfoLog_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalSchema: "Core",
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                    table.ForeignKey(
                        name: "FK_VehicleAuctionInfoLog_VehicleAuctionInfo_VehicleAuctionInfoId",
                        column: x => x.VehicleAuctionInfoId,
                        principalSchema: "Core",
                        principalTable: "VehicleAuctionInfo",
                        principalColumn: "VehicleAuctionInfoId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleImportInfoLog",
                schema: "Core",
                columns: table => new
                {
                    VehicleImportInfoLogId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleImportInfoId = table.Column<long>(type: "bigint", nullable: false),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    ImporterName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ImporterAddress = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IGMNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IGMDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IndexNo = table.Column<long>(type: "bigint", nullable: false),
                    PlaceOfIssue = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ImportPermitNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PermitIssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PortId = table.Column<long>(type: "bigint", nullable: false),
                    ClearingAgentId = table.Column<long>(type: "bigint", nullable: false),
                    CustomCollectorateId = table.Column<long>(type: "bigint", nullable: false),
                    CountryId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleSchemeId = table.Column<long>(type: "bigint", nullable: false),
                    ImportValue = table.Column<long>(type: "bigint", nullable: false),
                    CustomDuty = table.Column<long>(type: "bigint", nullable: false),
                    SalesTax = table.Column<long>(type: "bigint", nullable: false),
                    ImportLicenseFee = table.Column<long>(type: "bigint", nullable: false),
                    Insurrance = table.Column<long>(type: "bigint", nullable: false),
                    AnyOtherCost = table.Column<long>(type: "bigint", nullable: false),
                    LandedCost = table.Column<long>(type: "bigint", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BankId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleImportInfoLog", x => x.VehicleImportInfoLogId);
                    table.ForeignKey(
                        name: "FK_VehicleImportInfoLog_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "Application",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_VehicleImportInfoLog_Bank_BankId",
                        column: x => x.BankId,
                        principalSchema: "Setup",
                        principalTable: "Bank",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleImportInfoLog_ClearingAgent_ClearingAgentId",
                        column: x => x.ClearingAgentId,
                        principalSchema: "Setup",
                        principalTable: "ClearingAgent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleImportInfoLog_Country_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "Setup",
                        principalTable: "Country",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleImportInfoLog_CustomCollectorate_CustomCollectorateId",
                        column: x => x.CustomCollectorateId,
                        principalSchema: "Setup",
                        principalTable: "CustomCollectorate",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleImportInfoLog_Port_PortId",
                        column: x => x.PortId,
                        principalSchema: "Setup",
                        principalTable: "Port",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleImportInfoLog_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleImportInfoLog_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleImportInfoLog_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalSchema: "Core",
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                    table.ForeignKey(
                        name: "FK_VehicleImportInfoLog_VehicleImportInfo_VehicleImportInfoId",
                        column: x => x.VehicleImportInfoId,
                        principalSchema: "Core",
                        principalTable: "VehicleImportInfo",
                        principalColumn: "VehicleImportInfoId");
                    table.ForeignKey(
                        name: "FK_VehicleImportInfoLog_VehicleScheme_VehicleSchemeId",
                        column: x => x.VehicleSchemeId,
                        principalSchema: "Setup",
                        principalTable: "VehicleScheme",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VehicleLog",
                schema: "Core",
                columns: table => new
                {
                    VehicleLogId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    RegistrationNo = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RegistrationDistrictId = table.Column<long>(type: "bigint", nullable: false),
                    OwnerId = table.Column<long>(type: "bigint", nullable: false),
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
                    VehicleStatusId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleUsageId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleRouteTypeId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleTypeId = table.Column<long>(type: "bigint", nullable: true),
                    ManufacturingYear = table.Column<int>(type: "int", nullable: false),
                    NoOfCylinder = table.Column<int>(type: "int", nullable: false),
                    EngineSize = table.Column<int>(type: "int", nullable: false),
                    HorsePower = table.Column<int>(type: "int", nullable: false),
                    ChasisNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EngineNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SeatingCapacity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<long>(type: "bigint", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LadenWeight = table.Column<long>(type: "bigint", nullable: false),
                    UnLadenWeight = table.Column<long>(type: "bigint", nullable: false),
                    WheelBase = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleLog", x => x.VehicleLogId);
                    table.ForeignKey(
                        name: "FK_VehicleLog_District_RegistrationDistrictId",
                        column: x => x.RegistrationDistrictId,
                        principalSchema: "Setup",
                        principalTable: "District",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleLog_Owner_OwnerId",
                        column: x => x.OwnerId,
                        principalSchema: "Core",
                        principalTable: "Owner",
                        principalColumn: "OwnerId");
                    table.ForeignKey(
                        name: "FK_VehicleLog_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleLog_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleLog_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalSchema: "Core",
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                    table.ForeignKey(
                        name: "FK_VehicleLog_VehicleBodyConvention_VehicleBodyConventionId",
                        column: x => x.VehicleBodyConventionId,
                        principalSchema: "Setup",
                        principalTable: "VehicleBodyConvention",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleLog_VehicleBodyType_VehicleBodyTypeId",
                        column: x => x.VehicleBodyTypeId,
                        principalSchema: "Setup",
                        principalTable: "VehicleBodyType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleLog_VehicleCategory_VehicleCategoryId",
                        column: x => x.VehicleCategoryId,
                        principalSchema: "Setup",
                        principalTable: "VehicleCategory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleLog_VehicleClass_VehicleClassId",
                        column: x => x.VehicleClassId,
                        principalSchema: "Setup",
                        principalTable: "VehicleClass",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleLog_VehicleClassification_VehicleClassificationId",
                        column: x => x.VehicleClassificationId,
                        principalSchema: "Setup",
                        principalTable: "VehicleClassification",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleLog_VehicleColor_VehicleColorId",
                        column: x => x.VehicleColorId,
                        principalSchema: "Setup",
                        principalTable: "VehicleColor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleLog_VehicleEngineType_VehicleEngineTypeId",
                        column: x => x.VehicleEngineTypeId,
                        principalSchema: "Setup",
                        principalTable: "VehicleEngineType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleLog_VehicleFuelType_VehicleFuelTypeId",
                        column: x => x.VehicleFuelTypeId,
                        principalSchema: "Setup",
                        principalTable: "VehicleFuelType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleLog_VehicleMake_VehicleMakeId",
                        column: x => x.VehicleMakeId,
                        principalSchema: "Setup",
                        principalTable: "VehicleMake",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleLog_VehicleMaker_VehicleMakerId",
                        column: x => x.VehicleMakerId,
                        principalSchema: "Setup",
                        principalTable: "VehicleMaker",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleLog_VehiclePurchaseType_VehiclePurchaseTypeId",
                        column: x => x.VehiclePurchaseTypeId,
                        principalSchema: "Setup",
                        principalTable: "VehiclePurchaseType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleLog_VehicleRouteType_VehicleRouteTypeId",
                        column: x => x.VehicleRouteTypeId,
                        principalSchema: "Setup",
                        principalTable: "VehicleRouteType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleLog_VehicleStatus_VehicleStatusId",
                        column: x => x.VehicleStatusId,
                        principalSchema: "Setup",
                        principalTable: "VehicleStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleLog_VehicleType_VehicleTypeId",
                        column: x => x.VehicleTypeId,
                        principalSchema: "Setup",
                        principalTable: "VehicleType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleLog_VehicleUsage_VehicleUsageId",
                        column: x => x.VehicleUsageId,
                        principalSchema: "Setup",
                        principalTable: "VehicleUsage",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VehiclePurchaseInfoLog",
                schema: "Core",
                columns: table => new
                {
                    VehiclePurchaseInfoLogId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehiclePurchaseInfoId = table.Column<long>(type: "bigint", nullable: false),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleSchemeId = table.Column<long>(type: "bigint", nullable: false),
                    DealerId = table.Column<long>(type: "bigint", nullable: false),
                    CertificateNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CertificateDated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InvoiceNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    InvoiceDated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehiclePurchaseInfoLog", x => x.VehiclePurchaseInfoLogId);
                    table.ForeignKey(
                        name: "FK_VehiclePurchaseInfoLog_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "Application",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_VehiclePurchaseInfoLog_Dealer_DealerId",
                        column: x => x.DealerId,
                        principalSchema: "Core",
                        principalTable: "Dealer",
                        principalColumn: "DealerId");
                    table.ForeignKey(
                        name: "FK_VehiclePurchaseInfoLog_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehiclePurchaseInfoLog_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehiclePurchaseInfoLog_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalSchema: "Core",
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                    table.ForeignKey(
                        name: "FK_VehiclePurchaseInfoLog_VehiclePurchaseInfo_VehiclePurchaseInfoId",
                        column: x => x.VehiclePurchaseInfoId,
                        principalSchema: "Core",
                        principalTable: "VehiclePurchaseInfo",
                        principalColumn: "VehiclePurchaseInfoId");
                    table.ForeignKey(
                        name: "FK_VehiclePurchaseInfoLog_VehicleScheme_VehicleSchemeId",
                        column: x => x.VehicleSchemeId,
                        principalSchema: "Setup",
                        principalTable: "VehicleScheme",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_OwnerLog_CreatedBy",
                schema: "Core",
                table: "OwnerLog",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerLog_ModifiedBy",
                schema: "Core",
                table: "OwnerLog",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerLog_OwnerId",
                schema: "Core",
                table: "OwnerLog",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerLog_OwnerTaxGroupId",
                schema: "Core",
                table: "OwnerLog",
                column: "OwnerTaxGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerLog_OwnerTypeId",
                schema: "Core",
                table: "OwnerLog",
                column: "OwnerTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAdditionalInfoLog_CreatedBy",
                schema: "Core",
                table: "VehicleAdditionalInfoLog",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAdditionalInfoLog_ModifiedBy",
                schema: "Core",
                table: "VehicleAdditionalInfoLog",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAdditionalInfoLog_VehicleAdditionalInfoId",
                schema: "Core",
                table: "VehicleAdditionalInfoLog",
                column: "VehicleAdditionalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAdditionalInfoLog_VehicleId",
                schema: "Core",
                table: "VehicleAdditionalInfoLog",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAdditionalInfoLog_VehicleRCStatusId",
                schema: "Core",
                table: "VehicleAdditionalInfoLog",
                column: "VehicleRCStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAuctionInfoLog_ApplicationId",
                schema: "Core",
                table: "VehicleAuctionInfoLog",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAuctionInfoLog_CreatedBy",
                schema: "Core",
                table: "VehicleAuctionInfoLog",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAuctionInfoLog_ModifiedBy",
                schema: "Core",
                table: "VehicleAuctionInfoLog",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAuctionInfoLog_VehicleAuctionInfoId",
                schema: "Core",
                table: "VehicleAuctionInfoLog",
                column: "VehicleAuctionInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAuctionInfoLog_VehicleId",
                schema: "Core",
                table: "VehicleAuctionInfoLog",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImportInfoLog_ApplicationId",
                schema: "Core",
                table: "VehicleImportInfoLog",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImportInfoLog_BankId",
                schema: "Core",
                table: "VehicleImportInfoLog",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImportInfoLog_ClearingAgentId",
                schema: "Core",
                table: "VehicleImportInfoLog",
                column: "ClearingAgentId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImportInfoLog_CountryId",
                schema: "Core",
                table: "VehicleImportInfoLog",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImportInfoLog_CreatedBy",
                schema: "Core",
                table: "VehicleImportInfoLog",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImportInfoLog_CustomCollectorateId",
                schema: "Core",
                table: "VehicleImportInfoLog",
                column: "CustomCollectorateId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImportInfoLog_ModifiedBy",
                schema: "Core",
                table: "VehicleImportInfoLog",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImportInfoLog_PortId",
                schema: "Core",
                table: "VehicleImportInfoLog",
                column: "PortId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImportInfoLog_VehicleId",
                schema: "Core",
                table: "VehicleImportInfoLog",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImportInfoLog_VehicleImportInfoId",
                schema: "Core",
                table: "VehicleImportInfoLog",
                column: "VehicleImportInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImportInfoLog_VehicleSchemeId",
                schema: "Core",
                table: "VehicleImportInfoLog",
                column: "VehicleSchemeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleLog_CreatedBy",
                schema: "Core",
                table: "VehicleLog",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleLog_ModifiedBy",
                schema: "Core",
                table: "VehicleLog",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleLog_OwnerId",
                schema: "Core",
                table: "VehicleLog",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleLog_RegistrationDistrictId",
                schema: "Core",
                table: "VehicleLog",
                column: "RegistrationDistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleLog_VehicleBodyConventionId",
                schema: "Core",
                table: "VehicleLog",
                column: "VehicleBodyConventionId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleLog_VehicleBodyTypeId",
                schema: "Core",
                table: "VehicleLog",
                column: "VehicleBodyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleLog_VehicleCategoryId",
                schema: "Core",
                table: "VehicleLog",
                column: "VehicleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleLog_VehicleClassId",
                schema: "Core",
                table: "VehicleLog",
                column: "VehicleClassId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleLog_VehicleClassificationId",
                schema: "Core",
                table: "VehicleLog",
                column: "VehicleClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleLog_VehicleColorId",
                schema: "Core",
                table: "VehicleLog",
                column: "VehicleColorId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleLog_VehicleEngineTypeId",
                schema: "Core",
                table: "VehicleLog",
                column: "VehicleEngineTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleLog_VehicleFuelTypeId",
                schema: "Core",
                table: "VehicleLog",
                column: "VehicleFuelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleLog_VehicleId",
                schema: "Core",
                table: "VehicleLog",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleLog_VehicleMakeId",
                schema: "Core",
                table: "VehicleLog",
                column: "VehicleMakeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleLog_VehicleMakerId",
                schema: "Core",
                table: "VehicleLog",
                column: "VehicleMakerId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleLog_VehiclePurchaseTypeId",
                schema: "Core",
                table: "VehicleLog",
                column: "VehiclePurchaseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleLog_VehicleRouteTypeId",
                schema: "Core",
                table: "VehicleLog",
                column: "VehicleRouteTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleLog_VehicleStatusId",
                schema: "Core",
                table: "VehicleLog",
                column: "VehicleStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleLog_VehicleTypeId",
                schema: "Core",
                table: "VehicleLog",
                column: "VehicleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleLog_VehicleUsageId",
                schema: "Core",
                table: "VehicleLog",
                column: "VehicleUsageId");

            migrationBuilder.CreateIndex(
                name: "IX_VehiclePurchaseInfoLog_ApplicationId",
                schema: "Core",
                table: "VehiclePurchaseInfoLog",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_VehiclePurchaseInfoLog_CreatedBy",
                schema: "Core",
                table: "VehiclePurchaseInfoLog",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehiclePurchaseInfoLog_DealerId",
                schema: "Core",
                table: "VehiclePurchaseInfoLog",
                column: "DealerId");

            migrationBuilder.CreateIndex(
                name: "IX_VehiclePurchaseInfoLog_ModifiedBy",
                schema: "Core",
                table: "VehiclePurchaseInfoLog",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehiclePurchaseInfoLog_VehicleId",
                schema: "Core",
                table: "VehiclePurchaseInfoLog",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_VehiclePurchaseInfoLog_VehiclePurchaseInfoId",
                schema: "Core",
                table: "VehiclePurchaseInfoLog",
                column: "VehiclePurchaseInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_VehiclePurchaseInfoLog_VehicleSchemeId",
                schema: "Core",
                table: "VehiclePurchaseInfoLog",
                column: "VehicleSchemeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OwnerLog",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "VehicleAdditionalInfoLog",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "VehicleAuctionInfoLog",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "VehicleImportInfoLog",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "VehicleLog",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "VehiclePurchaseInfoLog",
                schema: "Core");
        }
    }
}
