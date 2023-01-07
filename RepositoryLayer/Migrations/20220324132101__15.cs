using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TempAddress",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "TempHPA",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "TempKeeper",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "TempPhoneNumber",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "TempRemarks",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "TempVehicleAuctionInfo",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "TempVehicleDocument",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "TempVehicleImportInfo",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "TempVehiclePurchaseInfo",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "TempBusiness",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "TempPerson",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "TempOwner",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "TempVehicle",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "TempApplication",
                schema: "Core");

            migrationBuilder.AddColumn<long>(
                name: "ApplicationId",
                schema: "Core",
                table: "VehiclePurchaseInfo",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ApplicationId",
                schema: "Core",
                table: "VehicleImportInfo",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ApplicationId",
                schema: "Core",
                table: "VehicleAuctionInfo",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_VehiclePurchaseInfo_ApplicationId",
                schema: "Core",
                table: "VehiclePurchaseInfo",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImportInfo_ApplicationId",
                schema: "Core",
                table: "VehicleImportInfo",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAuctionInfo_ApplicationId",
                schema: "Core",
                table: "VehicleAuctionInfo",
                column: "ApplicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleAuctionInfo_Application_ApplicationId",
                schema: "Core",
                table: "VehicleAuctionInfo",
                column: "ApplicationId",
                principalSchema: "Core",
                principalTable: "Application",
                principalColumn: "ApplicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleImportInfo_Application_ApplicationId",
                schema: "Core",
                table: "VehicleImportInfo",
                column: "ApplicationId",
                principalSchema: "Core",
                principalTable: "Application",
                principalColumn: "ApplicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehiclePurchaseInfo_Application_ApplicationId",
                schema: "Core",
                table: "VehiclePurchaseInfo",
                column: "ApplicationId",
                principalSchema: "Core",
                principalTable: "Application",
                principalColumn: "ApplicationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehicleAuctionInfo_Application_ApplicationId",
                schema: "Core",
                table: "VehicleAuctionInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleImportInfo_Application_ApplicationId",
                schema: "Core",
                table: "VehicleImportInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_VehiclePurchaseInfo_Application_ApplicationId",
                schema: "Core",
                table: "VehiclePurchaseInfo");

            migrationBuilder.DropIndex(
                name: "IX_VehiclePurchaseInfo_ApplicationId",
                schema: "Core",
                table: "VehiclePurchaseInfo");

            migrationBuilder.DropIndex(
                name: "IX_VehicleImportInfo_ApplicationId",
                schema: "Core",
                table: "VehicleImportInfo");

            migrationBuilder.DropIndex(
                name: "IX_VehicleAuctionInfo_ApplicationId",
                schema: "Core",
                table: "VehicleAuctionInfo");

            migrationBuilder.DropColumn(
                name: "ApplicationId",
                schema: "Core",
                table: "VehiclePurchaseInfo");

            migrationBuilder.DropColumn(
                name: "ApplicationId",
                schema: "Core",
                table: "VehicleImportInfo");

            migrationBuilder.DropColumn(
                name: "ApplicationId",
                schema: "Core",
                table: "VehicleAuctionInfo");

            migrationBuilder.CreateTable(
                name: "TempApplication",
                schema: "Core",
                columns: table => new
                {
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationStatusId = table.Column<long>(type: "bigint", nullable: false),
                    ApplicationTypeId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    OwnerGroupId = table.Column<long>(type: "bigint", nullable: true),
                    ReceivedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TempApplication", x => x.ApplicationId);
                    table.ForeignKey(
                        name: "FK_TempApplication_ApplicationStatus_ApplicationStatusId",
                        column: x => x.ApplicationStatusId,
                        principalSchema: "Setup",
                        principalTable: "ApplicationStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempApplication_ApplicationType_ApplicationTypeId",
                        column: x => x.ApplicationTypeId,
                        principalSchema: "Setup",
                        principalTable: "ApplicationType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempApplication_OwnerGroup_OwnerGroupId",
                        column: x => x.OwnerGroupId,
                        principalSchema: "Core",
                        principalTable: "OwnerGroup",
                        principalColumn: "OwnerGroupId");
                    table.ForeignKey(
                        name: "FK_TempApplication_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_TempApplication_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalSchema: "Core",
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                });

            migrationBuilder.CreateTable(
                name: "TempBusiness",
                schema: "Core",
                columns: table => new
                {
                    BusinessId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountPassword = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BusinessRegNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BusinessSectorId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessStatusId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessTypeId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    FTN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NTN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    STN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TempBusiness", x => x.BusinessId);
                    table.ForeignKey(
                        name: "FK_TempBusiness_BusinessSector_BusinessSectorId",
                        column: x => x.BusinessSectorId,
                        principalSchema: "Setup",
                        principalTable: "BusinessSector",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempBusiness_BusinessStatus_BusinessStatusId",
                        column: x => x.BusinessStatusId,
                        principalSchema: "Setup",
                        principalTable: "BusinessStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempBusiness_BusinessType_BusinessTypeId",
                        column: x => x.BusinessTypeId,
                        principalSchema: "Setup",
                        principalTable: "BusinessType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempBusiness_TempApplication_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "TempApplication",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_TempBusiness_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "TempOwner",
                schema: "Core",
                columns: table => new
                {
                    OwnerId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ExistingOwnerId = table.Column<long>(type: "bigint", nullable: false),
                    OwnerTaxGroupId = table.Column<long>(type: "bigint", nullable: false),
                    OwnerTypeId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TempOwner", x => x.OwnerId);
                    table.ForeignKey(
                        name: "FK_TempOwner_OwnerTaxGroup_OwnerTaxGroupId",
                        column: x => x.OwnerTaxGroupId,
                        principalSchema: "Setup",
                        principalTable: "OwnerTaxGroup",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempOwner_OwnerType_OwnerTypeId",
                        column: x => x.OwnerTypeId,
                        principalSchema: "Setup",
                        principalTable: "OwnerType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempOwner_TempApplication_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "TempApplication",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_TempOwner_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "TempPerson",
                schema: "Core",
                columns: table => new
                {
                    PersonId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    CNIC = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    CountryId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    FTN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    FatherHusbandName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NTN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    OldCNIC = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    PersonName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TempPerson", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_TempPerson_Country_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "Setup",
                        principalTable: "Country",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempPerson_TempApplication_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "TempApplication",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_TempPerson_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "TempVehicle",
                schema: "Core",
                columns: table => new
                {
                    VehicleId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    ChasisNo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DistrictId = table.Column<long>(type: "bigint", nullable: false),
                    EngineNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    EngineSize = table.Column<int>(type: "int", nullable: false),
                    HorsePower = table.Column<int>(type: "int", nullable: false),
                    LadenWeight = table.Column<long>(type: "bigint", nullable: false),
                    ManufacturingYear = table.Column<int>(type: "int", nullable: false),
                    NoOfCylinder = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<long>(type: "bigint", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegistrationNo = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
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
                    VehicleRCStatusId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleStatusId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleUsageId = table.Column<long>(type: "bigint", nullable: true),
                    WheelBase = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TempVehicle", x => x.VehicleId);
                    table.ForeignKey(
                        name: "FK_TempVehicle_District_DistrictId",
                        column: x => x.DistrictId,
                        principalSchema: "Setup",
                        principalTable: "District",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempVehicle_TempApplication_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "TempApplication",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_TempVehicle_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_TempVehicle_VehicleBodyConvention_VehicleBodyConventionId",
                        column: x => x.VehicleBodyConventionId,
                        principalSchema: "Setup",
                        principalTable: "VehicleBodyConvention",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempVehicle_VehicleBodyType_VehicleBodyTypeId",
                        column: x => x.VehicleBodyTypeId,
                        principalSchema: "Setup",
                        principalTable: "VehicleBodyType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempVehicle_VehicleCategory_VehicleCategoryId",
                        column: x => x.VehicleCategoryId,
                        principalSchema: "Setup",
                        principalTable: "VehicleCategory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempVehicle_VehicleClass_VehicleClassId",
                        column: x => x.VehicleClassId,
                        principalSchema: "Setup",
                        principalTable: "VehicleClass",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempVehicle_VehicleClassification_VehicleClassificationId",
                        column: x => x.VehicleClassificationId,
                        principalSchema: "Setup",
                        principalTable: "VehicleClassification",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempVehicle_VehicleColor_VehicleColorId",
                        column: x => x.VehicleColorId,
                        principalSchema: "Setup",
                        principalTable: "VehicleColor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempVehicle_VehicleEngineType_VehicleEngineTypeId",
                        column: x => x.VehicleEngineTypeId,
                        principalSchema: "Setup",
                        principalTable: "VehicleEngineType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempVehicle_VehicleFuelType_VehicleFuelTypeId",
                        column: x => x.VehicleFuelTypeId,
                        principalSchema: "Setup",
                        principalTable: "VehicleFuelType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempVehicle_VehicleMake_VehicleMakeId",
                        column: x => x.VehicleMakeId,
                        principalSchema: "Setup",
                        principalTable: "VehicleMake",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempVehicle_VehicleMaker_VehicleMakerId",
                        column: x => x.VehicleMakerId,
                        principalSchema: "Setup",
                        principalTable: "VehicleMaker",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempVehicle_VehiclePurchaseType_VehiclePurchaseTypeId",
                        column: x => x.VehiclePurchaseTypeId,
                        principalSchema: "Setup",
                        principalTable: "VehiclePurchaseType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempVehicle_VehicleRCStatus_VehicleRCStatusId",
                        column: x => x.VehicleRCStatusId,
                        principalSchema: "Setup",
                        principalTable: "VehicleRCStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempVehicle_VehicleStatus_VehicleStatusId",
                        column: x => x.VehicleStatusId,
                        principalSchema: "Setup",
                        principalTable: "VehicleStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempVehicle_VehicleUsage_VehicleUsageId",
                        column: x => x.VehicleUsageId,
                        principalSchema: "Setup",
                        principalTable: "VehicleUsage",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TempAddress",
                schema: "Core",
                columns: table => new
                {
                    AddressId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    AddressTypeId = table.Column<long>(type: "bigint", nullable: false),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessId = table.Column<long>(type: "bigint", nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DistrictId = table.Column<long>(type: "bigint", nullable: false),
                    PersonId = table.Column<long>(type: "bigint", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    TehsilId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TempAddress", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_TempAddress_AddressType_AddressTypeId",
                        column: x => x.AddressTypeId,
                        principalSchema: "Setup",
                        principalTable: "AddressType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempAddress_District_DistrictId",
                        column: x => x.DistrictId,
                        principalSchema: "Setup",
                        principalTable: "District",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempAddress_Tehsil_TehsilId",
                        column: x => x.TehsilId,
                        principalSchema: "Setup",
                        principalTable: "Tehsil",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempAddress_TempApplication_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "TempApplication",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_TempAddress_TempBusiness_BusinessId",
                        column: x => x.BusinessId,
                        principalSchema: "Core",
                        principalTable: "TempBusiness",
                        principalColumn: "BusinessId");
                    table.ForeignKey(
                        name: "FK_TempAddress_TempPerson_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "Core",
                        principalTable: "TempPerson",
                        principalColumn: "PersonId");
                    table.ForeignKey(
                        name: "FK_TempAddress_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "TempKeeper",
                schema: "Core",
                columns: table => new
                {
                    KeeperId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    KeeperBusinessId = table.Column<long>(type: "bigint", nullable: true),
                    KeeperPersonId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TempKeeper", x => x.KeeperId);
                    table.ForeignKey(
                        name: "FK_TempKeeper_TempApplication_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "TempApplication",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_TempKeeper_TempBusiness_KeeperBusinessId",
                        column: x => x.KeeperBusinessId,
                        principalSchema: "Core",
                        principalTable: "TempBusiness",
                        principalColumn: "BusinessId");
                    table.ForeignKey(
                        name: "FK_TempKeeper_TempPerson_KeeperPersonId",
                        column: x => x.KeeperPersonId,
                        principalSchema: "Core",
                        principalTable: "TempPerson",
                        principalColumn: "PersonId");
                    table.ForeignKey(
                        name: "FK_TempKeeper_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_TempKeeper_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalSchema: "Core",
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                });

            migrationBuilder.CreateTable(
                name: "TempPhoneNumber",
                schema: "Core",
                columns: table => new
                {
                    PhoneNumberId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessId = table.Column<long>(type: "bigint", nullable: true),
                    CountryId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    PersonId = table.Column<long>(type: "bigint", nullable: true),
                    PhoneNumberTypeId = table.Column<long>(type: "bigint", nullable: false),
                    PhoneNumberValue = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TempPhoneNumber", x => x.PhoneNumberId);
                    table.ForeignKey(
                        name: "FK_TempPhoneNumber_Country_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "Setup",
                        principalTable: "Country",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempPhoneNumber_PhoneNumberType_PhoneNumberTypeId",
                        column: x => x.PhoneNumberTypeId,
                        principalSchema: "Setup",
                        principalTable: "PhoneNumberType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempPhoneNumber_TempApplication_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "TempApplication",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_TempPhoneNumber_TempBusiness_BusinessId",
                        column: x => x.BusinessId,
                        principalSchema: "Core",
                        principalTable: "TempBusiness",
                        principalColumn: "BusinessId");
                    table.ForeignKey(
                        name: "FK_TempPhoneNumber_TempPerson_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "Core",
                        principalTable: "TempPerson",
                        principalColumn: "PersonId");
                    table.ForeignKey(
                        name: "FK_TempPhoneNumber_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "TempHPA",
                schema: "Core",
                columns: table => new
                {
                    HPAId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HPADate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HPALetterNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    HPATerminatedByUserId = table.Column<long>(type: "bigint", nullable: false),
                    HPATerminationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HPATerms = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SponserBusinessId = table.Column<long>(type: "bigint", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TempHPA", x => x.HPAId);
                    table.ForeignKey(
                        name: "FK_TempHPA_TempApplication_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "TempApplication",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_TempHPA_TempBusiness_SponserBusinessId",
                        column: x => x.SponserBusinessId,
                        principalSchema: "Core",
                        principalTable: "TempBusiness",
                        principalColumn: "BusinessId");
                    table.ForeignKey(
                        name: "FK_TempHPA_TempVehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalSchema: "Core",
                        principalTable: "TempVehicle",
                        principalColumn: "VehicleId");
                    table.ForeignKey(
                        name: "FK_TempHPA_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_TempHPA_User_HPATerminatedByUserId",
                        column: x => x.HPATerminatedByUserId,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "TempRemarks",
                schema: "Core",
                columns: table => new
                {
                    RemarksId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    OwnerId = table.Column<long>(type: "bigint", nullable: true),
                    RemarksStatement = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TempRemarks", x => x.RemarksId);
                    table.ForeignKey(
                        name: "FK_TempRemarks_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Auth",
                        principalTable: "Role",
                        principalColumn: "RoleId");
                    table.ForeignKey(
                        name: "FK_TempRemarks_TempApplication_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "TempApplication",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_TempRemarks_TempOwner_OwnerId",
                        column: x => x.OwnerId,
                        principalSchema: "Core",
                        principalTable: "TempOwner",
                        principalColumn: "OwnerId");
                    table.ForeignKey(
                        name: "FK_TempRemarks_TempVehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalSchema: "Core",
                        principalTable: "TempVehicle",
                        principalColumn: "VehicleId");
                    table.ForeignKey(
                        name: "FK_TempRemarks_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "TempVehicleAuctionInfo",
                schema: "Core",
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
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    VoucherDated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VoucherNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TempVehicleAuctionInfo", x => x.VehicleAuctionInfoId);
                    table.ForeignKey(
                        name: "FK_TempVehicleAuctionInfo_TempApplication_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "TempApplication",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_TempVehicleAuctionInfo_TempVehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalSchema: "Core",
                        principalTable: "TempVehicle",
                        principalColumn: "VehicleId");
                    table.ForeignKey(
                        name: "FK_TempVehicleAuctionInfo_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "TempVehicleDocument",
                schema: "Core",
                columns: table => new
                {
                    VehicleDocumentId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    TotalPages = table.Column<int>(type: "int", nullable: false),
                    VehicleDocumentTypeId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TempVehicleDocument", x => x.VehicleDocumentId);
                    table.ForeignKey(
                        name: "FK_TempVehicleDocument_TempApplication_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "TempApplication",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_TempVehicleDocument_TempVehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalSchema: "Core",
                        principalTable: "TempVehicle",
                        principalColumn: "VehicleId");
                    table.ForeignKey(
                        name: "FK_TempVehicleDocument_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_TempVehicleDocument_VehicleDocumentType_VehicleDocumentTypeId",
                        column: x => x.VehicleDocumentTypeId,
                        principalSchema: "Setup",
                        principalTable: "VehicleDocumentType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TempVehicleImportInfo",
                schema: "Core",
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
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PermitIssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlaceOfIssue = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PortId = table.Column<long>(type: "bigint", nullable: false),
                    SalesTax = table.Column<long>(type: "bigint", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TempVehicleImportInfo", x => x.VehicleImportInfoId);
                    table.ForeignKey(
                        name: "FK_TempVehicleImportInfo_Bank_BankId",
                        column: x => x.BankId,
                        principalSchema: "Setup",
                        principalTable: "Bank",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempVehicleImportInfo_ClearingAgent_ClearingAgentId",
                        column: x => x.ClearingAgentId,
                        principalSchema: "Setup",
                        principalTable: "ClearingAgent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempVehicleImportInfo_Country_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "Setup",
                        principalTable: "Country",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempVehicleImportInfo_CustomCollectorate_CustomCollectorateId",
                        column: x => x.CustomCollectorateId,
                        principalSchema: "Setup",
                        principalTable: "CustomCollectorate",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempVehicleImportInfo_Port_PortId",
                        column: x => x.PortId,
                        principalSchema: "Setup",
                        principalTable: "Port",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempVehicleImportInfo_TempApplication_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "TempApplication",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_TempVehicleImportInfo_TempVehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalSchema: "Core",
                        principalTable: "TempVehicle",
                        principalColumn: "VehicleId");
                    table.ForeignKey(
                        name: "FK_TempVehicleImportInfo_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "TempVehiclePurchaseInfo",
                schema: "Core",
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
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleSchemeId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TempVehiclePurchaseInfo", x => x.VehiclePurchaseInfoId);
                    table.ForeignKey(
                        name: "FK_TempVehiclePurchaseInfo_Dealer_DealerId",
                        column: x => x.DealerId,
                        principalSchema: "Core",
                        principalTable: "Dealer",
                        principalColumn: "DealerId");
                    table.ForeignKey(
                        name: "FK_TempVehiclePurchaseInfo_TempApplication_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "TempApplication",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_TempVehiclePurchaseInfo_TempVehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalSchema: "Core",
                        principalTable: "TempVehicle",
                        principalColumn: "VehicleId");
                    table.ForeignKey(
                        name: "FK_TempVehiclePurchaseInfo_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_TempVehiclePurchaseInfo_VehicleScheme_VehicleSchemeId",
                        column: x => x.VehicleSchemeId,
                        principalSchema: "Setup",
                        principalTable: "VehicleScheme",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TempAddress_AddressTypeId",
                schema: "Core",
                table: "TempAddress",
                column: "AddressTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TempAddress_ApplicationId",
                schema: "Core",
                table: "TempAddress",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_TempAddress_BusinessId",
                schema: "Core",
                table: "TempAddress",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_TempAddress_CreatedBy",
                schema: "Core",
                table: "TempAddress",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TempAddress_DistrictId",
                schema: "Core",
                table: "TempAddress",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_TempAddress_PersonId",
                schema: "Core",
                table: "TempAddress",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_TempAddress_TehsilId",
                schema: "Core",
                table: "TempAddress",
                column: "TehsilId");

            migrationBuilder.CreateIndex(
                name: "IX_TempApplication_ApplicationStatusId",
                schema: "Core",
                table: "TempApplication",
                column: "ApplicationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_TempApplication_ApplicationTypeId",
                schema: "Core",
                table: "TempApplication",
                column: "ApplicationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TempApplication_CreatedBy",
                schema: "Core",
                table: "TempApplication",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TempApplication_OwnerGroupId",
                schema: "Core",
                table: "TempApplication",
                column: "OwnerGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_TempApplication_VehicleId",
                schema: "Core",
                table: "TempApplication",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_TempBusiness_ApplicationId",
                schema: "Core",
                table: "TempBusiness",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_TempBusiness_BusinessSectorId",
                schema: "Core",
                table: "TempBusiness",
                column: "BusinessSectorId");

            migrationBuilder.CreateIndex(
                name: "IX_TempBusiness_BusinessStatusId",
                schema: "Core",
                table: "TempBusiness",
                column: "BusinessStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_TempBusiness_BusinessTypeId",
                schema: "Core",
                table: "TempBusiness",
                column: "BusinessTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TempBusiness_CreatedBy",
                schema: "Core",
                table: "TempBusiness",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TempHPA_ApplicationId",
                schema: "Core",
                table: "TempHPA",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_TempHPA_CreatedBy",
                schema: "Core",
                table: "TempHPA",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TempHPA_HPATerminatedByUserId",
                schema: "Core",
                table: "TempHPA",
                column: "HPATerminatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TempHPA_SponserBusinessId",
                schema: "Core",
                table: "TempHPA",
                column: "SponserBusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_TempHPA_VehicleId",
                schema: "Core",
                table: "TempHPA",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_TempKeeper_ApplicationId",
                schema: "Core",
                table: "TempKeeper",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_TempKeeper_CreatedBy",
                schema: "Core",
                table: "TempKeeper",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TempKeeper_KeeperBusinessId",
                schema: "Core",
                table: "TempKeeper",
                column: "KeeperBusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_TempKeeper_KeeperPersonId",
                schema: "Core",
                table: "TempKeeper",
                column: "KeeperPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_TempKeeper_VehicleId",
                schema: "Core",
                table: "TempKeeper",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_TempOwner_ApplicationId",
                schema: "Core",
                table: "TempOwner",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_TempOwner_CreatedBy",
                schema: "Core",
                table: "TempOwner",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TempOwner_OwnerTaxGroupId",
                schema: "Core",
                table: "TempOwner",
                column: "OwnerTaxGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_TempOwner_OwnerTypeId",
                schema: "Core",
                table: "TempOwner",
                column: "OwnerTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TempPerson_ApplicationId",
                schema: "Core",
                table: "TempPerson",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_TempPerson_CountryId",
                schema: "Core",
                table: "TempPerson",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_TempPerson_CreatedBy",
                schema: "Core",
                table: "TempPerson",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TempPhoneNumber_ApplicationId",
                schema: "Core",
                table: "TempPhoneNumber",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_TempPhoneNumber_BusinessId",
                schema: "Core",
                table: "TempPhoneNumber",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_TempPhoneNumber_CountryId",
                schema: "Core",
                table: "TempPhoneNumber",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_TempPhoneNumber_CreatedBy",
                schema: "Core",
                table: "TempPhoneNumber",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TempPhoneNumber_PersonId",
                schema: "Core",
                table: "TempPhoneNumber",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_TempPhoneNumber_PhoneNumberTypeId",
                schema: "Core",
                table: "TempPhoneNumber",
                column: "PhoneNumberTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TempRemarks_ApplicationId",
                schema: "Core",
                table: "TempRemarks",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_TempRemarks_CreatedBy",
                schema: "Core",
                table: "TempRemarks",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TempRemarks_OwnerId",
                schema: "Core",
                table: "TempRemarks",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_TempRemarks_RoleId",
                schema: "Core",
                table: "TempRemarks",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_TempRemarks_VehicleId",
                schema: "Core",
                table: "TempRemarks",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicle_ApplicationId",
                schema: "Core",
                table: "TempVehicle",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicle_CreatedBy",
                schema: "Core",
                table: "TempVehicle",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicle_DistrictId",
                schema: "Core",
                table: "TempVehicle",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicle_VehicleBodyConventionId",
                schema: "Core",
                table: "TempVehicle",
                column: "VehicleBodyConventionId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicle_VehicleBodyTypeId",
                schema: "Core",
                table: "TempVehicle",
                column: "VehicleBodyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicle_VehicleCategoryId",
                schema: "Core",
                table: "TempVehicle",
                column: "VehicleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicle_VehicleClassId",
                schema: "Core",
                table: "TempVehicle",
                column: "VehicleClassId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicle_VehicleClassificationId",
                schema: "Core",
                table: "TempVehicle",
                column: "VehicleClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicle_VehicleColorId",
                schema: "Core",
                table: "TempVehicle",
                column: "VehicleColorId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicle_VehicleEngineTypeId",
                schema: "Core",
                table: "TempVehicle",
                column: "VehicleEngineTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicle_VehicleFuelTypeId",
                schema: "Core",
                table: "TempVehicle",
                column: "VehicleFuelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicle_VehicleMakeId",
                schema: "Core",
                table: "TempVehicle",
                column: "VehicleMakeId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicle_VehicleMakerId",
                schema: "Core",
                table: "TempVehicle",
                column: "VehicleMakerId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicle_VehiclePurchaseTypeId",
                schema: "Core",
                table: "TempVehicle",
                column: "VehiclePurchaseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicle_VehicleRCStatusId",
                schema: "Core",
                table: "TempVehicle",
                column: "VehicleRCStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicle_VehicleStatusId",
                schema: "Core",
                table: "TempVehicle",
                column: "VehicleStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicle_VehicleUsageId",
                schema: "Core",
                table: "TempVehicle",
                column: "VehicleUsageId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicleAuctionInfo_ApplicationId",
                schema: "Core",
                table: "TempVehicleAuctionInfo",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicleAuctionInfo_CreatedBy",
                schema: "Core",
                table: "TempVehicleAuctionInfo",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicleAuctionInfo_VehicleId",
                schema: "Core",
                table: "TempVehicleAuctionInfo",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicleDocument_ApplicationId",
                schema: "Core",
                table: "TempVehicleDocument",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicleDocument_CreatedBy",
                schema: "Core",
                table: "TempVehicleDocument",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicleDocument_VehicleDocumentTypeId",
                schema: "Core",
                table: "TempVehicleDocument",
                column: "VehicleDocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicleDocument_VehicleId",
                schema: "Core",
                table: "TempVehicleDocument",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicleImportInfo_ApplicationId",
                schema: "Core",
                table: "TempVehicleImportInfo",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicleImportInfo_BankId",
                schema: "Core",
                table: "TempVehicleImportInfo",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicleImportInfo_ClearingAgentId",
                schema: "Core",
                table: "TempVehicleImportInfo",
                column: "ClearingAgentId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicleImportInfo_CountryId",
                schema: "Core",
                table: "TempVehicleImportInfo",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicleImportInfo_CreatedBy",
                schema: "Core",
                table: "TempVehicleImportInfo",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicleImportInfo_CustomCollectorateId",
                schema: "Core",
                table: "TempVehicleImportInfo",
                column: "CustomCollectorateId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicleImportInfo_PortId",
                schema: "Core",
                table: "TempVehicleImportInfo",
                column: "PortId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehicleImportInfo_VehicleId",
                schema: "Core",
                table: "TempVehicleImportInfo",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehiclePurchaseInfo_ApplicationId",
                schema: "Core",
                table: "TempVehiclePurchaseInfo",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehiclePurchaseInfo_CreatedBy",
                schema: "Core",
                table: "TempVehiclePurchaseInfo",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehiclePurchaseInfo_DealerId",
                schema: "Core",
                table: "TempVehiclePurchaseInfo",
                column: "DealerId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehiclePurchaseInfo_VehicleId",
                schema: "Core",
                table: "TempVehiclePurchaseInfo",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_TempVehiclePurchaseInfo_VehicleSchemeId",
                schema: "Core",
                table: "TempVehiclePurchaseInfo",
                column: "VehicleSchemeId");
        }
    }
}
