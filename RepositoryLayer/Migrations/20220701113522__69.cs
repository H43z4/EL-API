using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _69 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MicroService",
                schema: "Profiling");

            migrationBuilder.CreateTable(
                name: "AddressLog",
                schema: "Core",
                columns: table => new
                {
                    AddressLogId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressId = table.Column<long>(type: "bigint", nullable: false),
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
                    table.PrimaryKey("PK_AddressLog", x => x.AddressLogId);
                    table.ForeignKey(
                        name: "FK_AddressLog_Address_AddressId",
                        column: x => x.AddressId,
                        principalSchema: "Core",
                        principalTable: "Address",
                        principalColumn: "AddressId");
                    table.ForeignKey(
                        name: "FK_AddressLog_AddressType_AddressTypeId",
                        column: x => x.AddressTypeId,
                        principalSchema: "Setup",
                        principalTable: "AddressType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AddressLog_Business_BusinessId",
                        column: x => x.BusinessId,
                        principalSchema: "Core",
                        principalTable: "Business",
                        principalColumn: "BusinessId");
                    table.ForeignKey(
                        name: "FK_AddressLog_District_DistrictId",
                        column: x => x.DistrictId,
                        principalSchema: "Setup",
                        principalTable: "District",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AddressLog_Person_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "Core",
                        principalTable: "Person",
                        principalColumn: "PersonId");
                    table.ForeignKey(
                        name: "FK_AddressLog_Tehsil_TehsilId",
                        column: x => x.TehsilId,
                        principalSchema: "Setup",
                        principalTable: "Tehsil",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AddressLog_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_AddressLog_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "BusinessLog",
                schema: "Core",
                columns: table => new
                {
                    BusinessLogId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessId = table.Column<long>(type: "bigint", nullable: false),
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
                    table.PrimaryKey("PK_BusinessLog", x => x.BusinessLogId);
                    table.ForeignKey(
                        name: "FK_BusinessLog_Business_BusinessId",
                        column: x => x.BusinessId,
                        principalSchema: "Core",
                        principalTable: "Business",
                        principalColumn: "BusinessId");
                    table.ForeignKey(
                        name: "FK_BusinessLog_BusinessSector_BusinessSectorId",
                        column: x => x.BusinessSectorId,
                        principalSchema: "Setup",
                        principalTable: "BusinessSector",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BusinessLog_BusinessStatus_BusinessStatusId",
                        column: x => x.BusinessStatusId,
                        principalSchema: "Setup",
                        principalTable: "BusinessStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BusinessLog_BusinessType_BusinessTypeId",
                        column: x => x.BusinessTypeId,
                        principalSchema: "Setup",
                        principalTable: "BusinessType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BusinessLog_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_BusinessLog_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "HPALog",
                schema: "Core",
                columns: table => new
                {
                    HPALogId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    HPAId = table.Column<long>(type: "bigint", nullable: false),
                    OwnerId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: true),
                    SponserBusinessId = table.Column<long>(type: "bigint", nullable: false),
                    HPADate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HPAStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HPAEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LetterNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LetterDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Terms = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    HPACurrentStatusId = table.Column<long>(type: "bigint", nullable: false),
                    HPAStatusDated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HPALog", x => x.HPALogId);
                    table.ForeignKey(
                        name: "FK_HPALog_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "Application",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_HPALog_Business_SponserBusinessId",
                        column: x => x.SponserBusinessId,
                        principalSchema: "Core",
                        principalTable: "Business",
                        principalColumn: "BusinessId");
                    table.ForeignKey(
                        name: "FK_HPALog_HPA_HPAId",
                        column: x => x.HPAId,
                        principalSchema: "Core",
                        principalTable: "HPA",
                        principalColumn: "HPAId");
                    table.ForeignKey(
                        name: "FK_HPALog_HPAStatus_HPACurrentStatusId",
                        column: x => x.HPACurrentStatusId,
                        principalSchema: "Setup",
                        principalTable: "HPAStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HPALog_Owner_OwnerId",
                        column: x => x.OwnerId,
                        principalSchema: "Core",
                        principalTable: "Owner",
                        principalColumn: "OwnerId");
                    table.ForeignKey(
                        name: "FK_HPALog_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_HPALog_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_HPALog_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalSchema: "Core",
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                });

            migrationBuilder.CreateTable(
                name: "KeeperLog",
                schema: "Core",
                columns: table => new
                {
                    KeeperLogId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KeeperId = table.Column<long>(type: "bigint", nullable: false),
                    OwnerId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleId = table.Column<long>(type: "bigint", nullable: true),
                    KeeperPersonId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeeperLog", x => x.KeeperLogId);
                    table.ForeignKey(
                        name: "FK_KeeperLog_Keeper_KeeperId",
                        column: x => x.KeeperId,
                        principalSchema: "Core",
                        principalTable: "Keeper",
                        principalColumn: "KeeperId");
                    table.ForeignKey(
                        name: "FK_KeeperLog_Owner_OwnerId",
                        column: x => x.OwnerId,
                        principalSchema: "Core",
                        principalTable: "Owner",
                        principalColumn: "OwnerId");
                    table.ForeignKey(
                        name: "FK_KeeperLog_Person_KeeperPersonId",
                        column: x => x.KeeperPersonId,
                        principalSchema: "Core",
                        principalTable: "Person",
                        principalColumn: "PersonId");
                    table.ForeignKey(
                        name: "FK_KeeperLog_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_KeeperLog_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_KeeperLog_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalSchema: "Core",
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                });

            migrationBuilder.CreateTable(
                name: "PersonLog",
                schema: "Core",
                columns: table => new
                {
                    PersonLogId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<long>(type: "bigint", nullable: false),
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
                    table.PrimaryKey("PK_PersonLog", x => x.PersonLogId);
                    table.ForeignKey(
                        name: "FK_PersonLog_Country_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "Setup",
                        principalTable: "Country",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PersonLog_Person_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "Core",
                        principalTable: "Person",
                        principalColumn: "PersonId");
                    table.ForeignKey(
                        name: "FK_PersonLog_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_PersonLog_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "PhoneNumberLog",
                schema: "Core",
                columns: table => new
                {
                    PhoneNumberLogId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumberId = table.Column<long>(type: "bigint", nullable: false),
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
                    table.PrimaryKey("PK_PhoneNumberLog", x => x.PhoneNumberLogId);
                    table.ForeignKey(
                        name: "FK_PhoneNumberLog_Business_BusinessId",
                        column: x => x.BusinessId,
                        principalSchema: "Core",
                        principalTable: "Business",
                        principalColumn: "BusinessId");
                    table.ForeignKey(
                        name: "FK_PhoneNumberLog_Country_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "Setup",
                        principalTable: "Country",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PhoneNumberLog_Person_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "Core",
                        principalTable: "Person",
                        principalColumn: "PersonId");
                    table.ForeignKey(
                        name: "FK_PhoneNumberLog_PhoneNumber_PhoneNumberId",
                        column: x => x.PhoneNumberId,
                        principalSchema: "Core",
                        principalTable: "PhoneNumber",
                        principalColumn: "PhoneNumberId");
                    table.ForeignKey(
                        name: "FK_PhoneNumberLog_PhoneNumberType_PhoneNumberTypeId",
                        column: x => x.PhoneNumberTypeId,
                        principalSchema: "Setup",
                        principalTable: "PhoneNumberType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PhoneNumberLog_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_PhoneNumberLog_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AddressLog_AddressId",
                schema: "Core",
                table: "AddressLog",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_AddressLog_AddressTypeId",
                schema: "Core",
                table: "AddressLog",
                column: "AddressTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AddressLog_BusinessId",
                schema: "Core",
                table: "AddressLog",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_AddressLog_CreatedBy",
                schema: "Core",
                table: "AddressLog",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AddressLog_DistrictId",
                schema: "Core",
                table: "AddressLog",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_AddressLog_ModifiedBy",
                schema: "Core",
                table: "AddressLog",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AddressLog_PersonId",
                schema: "Core",
                table: "AddressLog",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_AddressLog_TehsilId",
                schema: "Core",
                table: "AddressLog",
                column: "TehsilId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessLog_BusinessId",
                schema: "Core",
                table: "BusinessLog",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessLog_BusinessSectorId",
                schema: "Core",
                table: "BusinessLog",
                column: "BusinessSectorId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessLog_BusinessStatusId",
                schema: "Core",
                table: "BusinessLog",
                column: "BusinessStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessLog_BusinessTypeId",
                schema: "Core",
                table: "BusinessLog",
                column: "BusinessTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessLog_CreatedBy",
                schema: "Core",
                table: "BusinessLog",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessLog_ModifiedBy",
                schema: "Core",
                table: "BusinessLog",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_HPALog_ApplicationId",
                schema: "Core",
                table: "HPALog",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_HPALog_CreatedBy",
                schema: "Core",
                table: "HPALog",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_HPALog_HPACurrentStatusId",
                schema: "Core",
                table: "HPALog",
                column: "HPACurrentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_HPALog_HPAId",
                schema: "Core",
                table: "HPALog",
                column: "HPAId");

            migrationBuilder.CreateIndex(
                name: "IX_HPALog_ModifiedBy",
                schema: "Core",
                table: "HPALog",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_HPALog_OwnerId",
                schema: "Core",
                table: "HPALog",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_HPALog_SponserBusinessId",
                schema: "Core",
                table: "HPALog",
                column: "SponserBusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_HPALog_VehicleId",
                schema: "Core",
                table: "HPALog",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_KeeperLog_CreatedBy",
                schema: "Core",
                table: "KeeperLog",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_KeeperLog_KeeperId",
                schema: "Core",
                table: "KeeperLog",
                column: "KeeperId");

            migrationBuilder.CreateIndex(
                name: "IX_KeeperLog_KeeperPersonId",
                schema: "Core",
                table: "KeeperLog",
                column: "KeeperPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_KeeperLog_ModifiedBy",
                schema: "Core",
                table: "KeeperLog",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_KeeperLog_OwnerId",
                schema: "Core",
                table: "KeeperLog",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_KeeperLog_VehicleId",
                schema: "Core",
                table: "KeeperLog",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonLog_CountryId",
                schema: "Core",
                table: "PersonLog",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonLog_CreatedBy",
                schema: "Core",
                table: "PersonLog",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PersonLog_ModifiedBy",
                schema: "Core",
                table: "PersonLog",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PersonLog_PersonId",
                schema: "Core",
                table: "PersonLog",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumberLog_BusinessId",
                schema: "Core",
                table: "PhoneNumberLog",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumberLog_CountryId",
                schema: "Core",
                table: "PhoneNumberLog",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumberLog_CreatedBy",
                schema: "Core",
                table: "PhoneNumberLog",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumberLog_ModifiedBy",
                schema: "Core",
                table: "PhoneNumberLog",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumberLog_PersonId",
                schema: "Core",
                table: "PhoneNumberLog",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumberLog_PhoneNumberId",
                schema: "Core",
                table: "PhoneNumberLog",
                column: "PhoneNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumberLog_PhoneNumberTypeId",
                schema: "Core",
                table: "PhoneNumberLog",
                column: "PhoneNumberTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddressLog",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "BusinessLog",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "HPALog",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "KeeperLog",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "PersonLog",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "PhoneNumberLog",
                schema: "Core");

            migrationBuilder.EnsureSchema(
                name: "Profiling");

            migrationBuilder.CreateTable(
                name: "MicroService",
                schema: "Profiling",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MicroService", x => x.Id);
                });
        }
    }
}
