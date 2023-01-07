using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _87 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "epay");

            migrationBuilder.CreateTable(
                name: "Business",
                schema: "epay",
                columns: table => new
                {
                    BusinessId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessTypeId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessSectorId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessStatusId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessRegNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BusinessName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    NTN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    FTN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    STN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AccountPassword = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Business", x => x.BusinessId);
                    table.ForeignKey(
                        name: "FK_Business_BusinessSector_BusinessSectorId",
                        column: x => x.BusinessSectorId,
                        principalSchema: "Setup",
                        principalTable: "BusinessSector",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Business_BusinessStatus_BusinessStatusId",
                        column: x => x.BusinessStatusId,
                        principalSchema: "Setup",
                        principalTable: "BusinessStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Business_BusinessType_BusinessTypeId",
                        column: x => x.BusinessTypeId,
                        principalSchema: "Setup",
                        principalTable: "BusinessType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Business_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_Business_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Person",
                schema: "epay",
                columns: table => new
                {
                    PersonId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<long>(type: "bigint", nullable: false),
                    PersonName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FatherHusbandName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CNIC = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    OldCNIC = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    NTN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    FTN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_Person_Country_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "Setup",
                        principalTable: "Country",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Person_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_Person_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Address",
                schema: "epay",
                columns: table => new
                {
                    AddressId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DistrictId = table.Column<long>(type: "bigint", nullable: false),
                    TehsilId = table.Column<long>(type: "bigint", nullable: true),
                    AddressTypeId = table.Column<long>(type: "bigint", nullable: false),
                    PersonId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_Address_AddressType_AddressTypeId",
                        column: x => x.AddressTypeId,
                        principalSchema: "Setup",
                        principalTable: "AddressType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Address_Business_BusinessId",
                        column: x => x.BusinessId,
                        principalSchema: "epay",
                        principalTable: "Business",
                        principalColumn: "BusinessId");
                    table.ForeignKey(
                        name: "FK_Address_District_DistrictId",
                        column: x => x.DistrictId,
                        principalSchema: "Setup",
                        principalTable: "District",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Address_Person_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "epay",
                        principalTable: "Person",
                        principalColumn: "PersonId");
                    table.ForeignKey(
                        name: "FK_Address_Tehsil_TehsilId",
                        column: x => x.TehsilId,
                        principalSchema: "Setup",
                        principalTable: "Tehsil",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Address_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_Address_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "PhoneNumber",
                schema: "epay",
                columns: table => new
                {
                    PhoneNumberId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumberValue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CountryId = table.Column<long>(type: "bigint", nullable: false),
                    PhoneNumberTypeId = table.Column<long>(type: "bigint", nullable: false),
                    PersonId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumber", x => x.PhoneNumberId);
                    table.ForeignKey(
                        name: "FK_PhoneNumber_Business_BusinessId",
                        column: x => x.BusinessId,
                        principalSchema: "epay",
                        principalTable: "Business",
                        principalColumn: "BusinessId");
                    table.ForeignKey(
                        name: "FK_PhoneNumber_Country_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "Setup",
                        principalTable: "Country",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PhoneNumber_Person_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "epay",
                        principalTable: "Person",
                        principalColumn: "PersonId");
                    table.ForeignKey(
                        name: "FK_PhoneNumber_PhoneNumberType_PhoneNumberTypeId",
                        column: x => x.PhoneNumberTypeId,
                        principalSchema: "Setup",
                        principalTable: "PhoneNumberType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PhoneNumber_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_PhoneNumber_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Owner",
                schema: "epay",
                columns: table => new
                {
                    OwnerId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    OwnerTypeId = table.Column<long>(type: "bigint", nullable: false),
                    OwnerTaxGroupId = table.Column<long>(type: "bigint", nullable: true),
                    PersonId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessId = table.Column<long>(type: "bigint", nullable: true),
                    IsFirstGroupMember = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owner", x => x.OwnerId);
                    table.ForeignKey(
                        name: "FK_Owner_Business_BusinessId",
                        column: x => x.BusinessId,
                        principalSchema: "epay",
                        principalTable: "Business",
                        principalColumn: "BusinessId");
                    table.ForeignKey(
                        name: "FK_Owner_OwnerTaxGroup_OwnerTaxGroupId",
                        column: x => x.OwnerTaxGroupId,
                        principalSchema: "Setup",
                        principalTable: "OwnerTaxGroup",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Owner_OwnerType_OwnerTypeId",
                        column: x => x.OwnerTypeId,
                        principalSchema: "Setup",
                        principalTable: "OwnerType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Owner_Person_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "epay",
                        principalTable: "Person",
                        principalColumn: "PersonId");
                    table.ForeignKey(
                        name: "FK_Owner_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_Owner_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Application",
                schema: "epay",
                columns: table => new
                {
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegularApplicationId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessProcessId = table.Column<long>(type: "bigint", nullable: false),
                    SellerId = table.Column<long>(type: "bigint", nullable: true),
                    DistrictId = table.Column<long>(type: "bigint", nullable: true),
                    ReceivedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsHPA = table.Column<bool>(type: "bit", nullable: false),
                    PaymentStatusId = table.Column<long>(type: "bigint", nullable: false),
                    PSId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AmountPaid = table.Column<long>(type: "bigint", nullable: false),
                    PaidOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BankCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Application", x => x.ApplicationId);
                    table.ForeignKey(
                        name: "FK_Application_BusinessProcess_BusinessProcessId",
                        column: x => x.BusinessProcessId,
                        principalSchema: "Setup",
                        principalTable: "BusinessProcess",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Application_District_DistrictId",
                        column: x => x.DistrictId,
                        principalSchema: "Setup",
                        principalTable: "District",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Application_Owner_SellerId",
                        column: x => x.SellerId,
                        principalSchema: "epay",
                        principalTable: "Owner",
                        principalColumn: "OwnerId");
                    table.ForeignKey(
                        name: "FK_Application_PaymentStatus_PaymentStatusId",
                        column: x => x.PaymentStatusId,
                        principalSchema: "Setup",
                        principalTable: "PaymentStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Application_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_Application_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                schema: "epay",
                columns: table => new
                {
                    VehicleId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    RegistrationNo = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RegistrationDistrictId = table.Column<long>(type: "bigint", nullable: false),
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
                    table.PrimaryKey("PK_Vehicle", x => x.VehicleId);
                    table.ForeignKey(
                        name: "FK_Vehicle_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "epay",
                        principalTable: "Application",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_Vehicle_District_RegistrationDistrictId",
                        column: x => x.RegistrationDistrictId,
                        principalSchema: "Setup",
                        principalTable: "District",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicle_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_Vehicle_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleBodyConvention_VehicleBodyConventionId",
                        column: x => x.VehicleBodyConventionId,
                        principalSchema: "Setup",
                        principalTable: "VehicleBodyConvention",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleBodyType_VehicleBodyTypeId",
                        column: x => x.VehicleBodyTypeId,
                        principalSchema: "Setup",
                        principalTable: "VehicleBodyType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleCategory_VehicleCategoryId",
                        column: x => x.VehicleCategoryId,
                        principalSchema: "Setup",
                        principalTable: "VehicleCategory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleClass_VehicleClassId",
                        column: x => x.VehicleClassId,
                        principalSchema: "Setup",
                        principalTable: "VehicleClass",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleClassification_VehicleClassificationId",
                        column: x => x.VehicleClassificationId,
                        principalSchema: "Setup",
                        principalTable: "VehicleClassification",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleColor_VehicleColorId",
                        column: x => x.VehicleColorId,
                        principalSchema: "Setup",
                        principalTable: "VehicleColor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleEngineType_VehicleEngineTypeId",
                        column: x => x.VehicleEngineTypeId,
                        principalSchema: "Setup",
                        principalTable: "VehicleEngineType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleFuelType_VehicleFuelTypeId",
                        column: x => x.VehicleFuelTypeId,
                        principalSchema: "Setup",
                        principalTable: "VehicleFuelType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleMake_VehicleMakeId",
                        column: x => x.VehicleMakeId,
                        principalSchema: "Setup",
                        principalTable: "VehicleMake",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleMaker_VehicleMakerId",
                        column: x => x.VehicleMakerId,
                        principalSchema: "Setup",
                        principalTable: "VehicleMaker",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicle_VehiclePurchaseType_VehiclePurchaseTypeId",
                        column: x => x.VehiclePurchaseTypeId,
                        principalSchema: "Setup",
                        principalTable: "VehiclePurchaseType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleRouteType_VehicleRouteTypeId",
                        column: x => x.VehicleRouteTypeId,
                        principalSchema: "Setup",
                        principalTable: "VehicleRouteType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleStatus_VehicleStatusId",
                        column: x => x.VehicleStatusId,
                        principalSchema: "Setup",
                        principalTable: "VehicleStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleType_VehicleTypeId",
                        column: x => x.VehicleTypeId,
                        principalSchema: "Setup",
                        principalTable: "VehicleType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleUsage_VehicleUsageId",
                        column: x => x.VehicleUsageId,
                        principalSchema: "Setup",
                        principalTable: "VehicleUsage",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_AddressTypeId_BusinessId1",
                schema: "epay",
                table: "Address",
                columns: new[] { "AddressTypeId", "BusinessId" },
                unique: true,
                filter: "[BusinessId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Address_AddressTypeId_PersonId1",
                schema: "epay",
                table: "Address",
                columns: new[] { "AddressTypeId", "PersonId" },
                unique: true,
                filter: "[PersonId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Address_BusinessId1",
                schema: "epay",
                table: "Address",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_CreatedBy1",
                schema: "epay",
                table: "Address",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Address_DistrictId1",
                schema: "epay",
                table: "Address",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_ModifiedBy1",
                schema: "epay",
                table: "Address",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Address_PersonId1",
                schema: "epay",
                table: "Address",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_TehsilId1",
                schema: "epay",
                table: "Address",
                column: "TehsilId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_BusinessProcessId1",
                schema: "epay",
                table: "Application",
                column: "BusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_CreatedBy1",
                schema: "epay",
                table: "Application",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Application_DistrictId1",
                schema: "epay",
                table: "Application",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_ModifiedBy1",
                schema: "epay",
                table: "Application",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Application_PaymentStatusId",
                schema: "epay",
                table: "Application",
                column: "PaymentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_SellerId1",
                schema: "epay",
                table: "Application",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_Business_BusinessSectorId1",
                schema: "epay",
                table: "Business",
                column: "BusinessSectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Business_BusinessStatusId1",
                schema: "epay",
                table: "Business",
                column: "BusinessStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Business_BusinessTypeId1",
                schema: "epay",
                table: "Business",
                column: "BusinessTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Business_CreatedBy1",
                schema: "epay",
                table: "Business",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Business_ModifiedBy1",
                schema: "epay",
                table: "Business",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Owner_ApplicationId",
                schema: "epay",
                table: "Owner",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Owner_BusinessId",
                schema: "epay",
                table: "Owner",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_Owner_CreatedBy1",
                schema: "epay",
                table: "Owner",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Owner_ModifiedBy1",
                schema: "epay",
                table: "Owner",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Owner_OwnerTaxGroupId1",
                schema: "epay",
                table: "Owner",
                column: "OwnerTaxGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Owner_OwnerTypeId1",
                schema: "epay",
                table: "Owner",
                column: "OwnerTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Owner_PersonId",
                schema: "epay",
                table: "Owner",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_CountryId1",
                schema: "epay",
                table: "Person",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_CreatedBy1",
                schema: "epay",
                table: "Person",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Person_ModifiedBy1",
                schema: "epay",
                table: "Person",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumber_BusinessId1",
                schema: "epay",
                table: "PhoneNumber",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumber_CountryId1",
                schema: "epay",
                table: "PhoneNumber",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumber_CreatedBy1",
                schema: "epay",
                table: "PhoneNumber",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumber_ModifiedBy1",
                schema: "epay",
                table: "PhoneNumber",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumber_PersonId1",
                schema: "epay",
                table: "PhoneNumber",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumber_PhoneNumberTypeId_BusinessId1",
                schema: "epay",
                table: "PhoneNumber",
                columns: new[] { "PhoneNumberTypeId", "BusinessId" },
                unique: true,
                filter: "[BusinessId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumber_PhoneNumberTypeId_PersonId1",
                schema: "epay",
                table: "PhoneNumber",
                columns: new[] { "PhoneNumberTypeId", "PersonId" },
                unique: true,
                filter: "[PersonId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_ApplicationId",
                schema: "epay",
                table: "Vehicle",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_CreatedBy1",
                schema: "epay",
                table: "Vehicle",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_ModifiedBy1",
                schema: "epay",
                table: "Vehicle",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_RegistrationDistrictId1",
                schema: "epay",
                table: "Vehicle",
                column: "RegistrationDistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleBodyConventionId1",
                schema: "epay",
                table: "Vehicle",
                column: "VehicleBodyConventionId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleBodyTypeId1",
                schema: "epay",
                table: "Vehicle",
                column: "VehicleBodyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleCategoryId1",
                schema: "epay",
                table: "Vehicle",
                column: "VehicleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleClassId1",
                schema: "epay",
                table: "Vehicle",
                column: "VehicleClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleClassificationId1",
                schema: "epay",
                table: "Vehicle",
                column: "VehicleClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleColorId1",
                schema: "epay",
                table: "Vehicle",
                column: "VehicleColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleEngineTypeId1",
                schema: "epay",
                table: "Vehicle",
                column: "VehicleEngineTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleFuelTypeId1",
                schema: "epay",
                table: "Vehicle",
                column: "VehicleFuelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleMakeId",
                schema: "epay",
                table: "Vehicle",
                column: "VehicleMakeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleMakerId1",
                schema: "epay",
                table: "Vehicle",
                column: "VehicleMakerId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehiclePurchaseTypeId1",
                schema: "epay",
                table: "Vehicle",
                column: "VehiclePurchaseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleRouteTypeId1",
                schema: "epay",
                table: "Vehicle",
                column: "VehicleRouteTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleStatusId1",
                schema: "epay",
                table: "Vehicle",
                column: "VehicleStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleTypeId1",
                schema: "epay",
                table: "Vehicle",
                column: "VehicleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleUsageId1",
                schema: "epay",
                table: "Vehicle",
                column: "VehicleUsageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Owner_Application_ApplicationId",
                schema: "epay",
                table: "Owner",
                column: "ApplicationId",
                principalSchema: "epay",
                principalTable: "Application",
                principalColumn: "ApplicationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_AddressType_AddressTypeId",
                schema: "Core",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Address_District_DistrictId",
                schema: "Core",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Address_Tehsil_TehsilId",
                schema: "Core",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Address_User_CreatedBy",
                schema: "Core",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Address_User_ModifiedBy",
                schema: "Core",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Application_BusinessProcess_BusinessProcessId",
                schema: "Core",
                table: "Application");

            migrationBuilder.DropForeignKey(
                name: "FK_Application_District_DistrictId",
                schema: "Core",
                table: "Application");

            migrationBuilder.DropForeignKey(
                name: "FK_Application_User_CreatedBy",
                schema: "Core",
                table: "Application");

            migrationBuilder.DropForeignKey(
                name: "FK_Application_User_ModifiedBy",
                schema: "Core",
                table: "Application");

            migrationBuilder.DropForeignKey(
                name: "FK_Business_BusinessSector_BusinessSectorId",
                schema: "Core",
                table: "Business");

            migrationBuilder.DropForeignKey(
                name: "FK_Business_BusinessStatus_BusinessStatusId",
                schema: "Core",
                table: "Business");

            migrationBuilder.DropForeignKey(
                name: "FK_Business_BusinessType_BusinessTypeId",
                schema: "Core",
                table: "Business");

            migrationBuilder.DropForeignKey(
                name: "FK_Business_User_CreatedBy",
                schema: "Core",
                table: "Business");

            migrationBuilder.DropForeignKey(
                name: "FK_Business_User_ModifiedBy",
                schema: "Core",
                table: "Business");

            migrationBuilder.DropForeignKey(
                name: "FK_Owner_OwnerTaxGroup_OwnerTaxGroupId",
                schema: "Core",
                table: "Owner");

            migrationBuilder.DropForeignKey(
                name: "FK_Owner_OwnerType_OwnerTypeId",
                schema: "Core",
                table: "Owner");

            migrationBuilder.DropForeignKey(
                name: "FK_Owner_User_CreatedBy",
                schema: "Core",
                table: "Owner");

            migrationBuilder.DropForeignKey(
                name: "FK_Owner_User_ModifiedBy",
                schema: "Core",
                table: "Owner");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_Country_CountryId",
                schema: "Core",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_User_CreatedBy",
                schema: "Core",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_User_ModifiedBy",
                schema: "Core",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumber_Country_CountryId",
                schema: "Core",
                table: "PhoneNumber");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumber_PhoneNumberType_PhoneNumberTypeId",
                schema: "Core",
                table: "PhoneNumber");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumber_User_CreatedBy",
                schema: "Core",
                table: "PhoneNumber");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumber_User_ModifiedBy",
                schema: "Core",
                table: "PhoneNumber");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_District_RegistrationDistrictId",
                schema: "Core",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_User_CreatedBy",
                schema: "Core",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_User_ModifiedBy",
                schema: "Core",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_VehicleBodyConvention_VehicleBodyConventionId",
                schema: "Core",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_VehicleBodyType_VehicleBodyTypeId",
                schema: "Core",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_VehicleCategory_VehicleCategoryId",
                schema: "Core",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_VehicleClass_VehicleClassId",
                schema: "Core",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_VehicleClassification_VehicleClassificationId",
                schema: "Core",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_VehicleColor_VehicleColorId",
                schema: "Core",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_VehicleEngineType_VehicleEngineTypeId",
                schema: "Core",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_VehicleFuelType_VehicleFuelTypeId",
                schema: "Core",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_VehicleMake_VehicleMakeId",
                schema: "Core",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_VehicleMaker_VehicleMakerId",
                schema: "Core",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_VehiclePurchaseType_VehiclePurchaseTypeId",
                schema: "Core",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_VehicleRouteType_VehicleRouteTypeId",
                schema: "Core",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_VehicleStatus_VehicleStatusId",
                schema: "Core",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_VehicleType_VehicleTypeId",
                schema: "Core",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_VehicleUsage_VehicleUsageId",
                schema: "Core",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_Owner_Business_BusinessId",
                schema: "epay",
                table: "Owner");

            migrationBuilder.DropForeignKey(
                name: "FK_Owner_Person_PersonId",
                schema: "epay",
                table: "Owner");

            migrationBuilder.DropForeignKey(
                name: "FK_Application_Owner_SellerId",
                schema: "epay",
                table: "Application");

            migrationBuilder.DropTable(
                name: "Address",
                schema: "epay");

            migrationBuilder.DropTable(
                name: "PhoneNumber",
                schema: "epay");

            migrationBuilder.DropTable(
                name: "Vehicle",
                schema: "epay");

            migrationBuilder.DropTable(
                name: "Business",
                schema: "epay");

            migrationBuilder.DropTable(
                name: "Person",
                schema: "epay");

            migrationBuilder.DropTable(
                name: "Owner",
                schema: "epay");

            migrationBuilder.DropTable(
                name: "Application",
                schema: "epay");
        }
    }
}
