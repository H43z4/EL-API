using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TempOwner_Country_CountryId",
                schema: "Core",
                table: "TempOwner");

            migrationBuilder.DropIndex(
                name: "IX_TempOwner_CountryId",
                schema: "Core",
                table: "TempOwner");

            migrationBuilder.DropColumn(
                name: "CNIC",
                schema: "Core",
                table: "TempOwner");

            migrationBuilder.DropColumn(
                name: "CountryId",
                schema: "Core",
                table: "TempOwner");

            migrationBuilder.DropColumn(
                name: "Email",
                schema: "Core",
                table: "TempOwner");

            migrationBuilder.DropColumn(
                name: "FatherHusbandName",
                schema: "Core",
                table: "TempOwner");

            migrationBuilder.DropColumn(
                name: "FullName",
                schema: "Core",
                table: "TempOwner");

            migrationBuilder.DropColumn(
                name: "NTN",
                schema: "Core",
                table: "TempOwner");

            migrationBuilder.DropColumn(
                name: "OldCNIC",
                schema: "Core",
                table: "TempOwner");

            migrationBuilder.AddColumn<long>(
                name: "BusinessId",
                schema: "Core",
                table: "TempPhoneNumber",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PersonId",
                schema: "Core",
                table: "TempPhoneNumber",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "BusinessId",
                schema: "Core",
                table: "TempAddress",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PersonId",
                schema: "Core",
                table: "TempAddress",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TempBusiness",
                schema: "Core",
                columns: table => new
                {
                    BusinessId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
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
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
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
                name: "TempPerson",
                schema: "Core",
                columns: table => new
                {
                    PersonId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    CountryId = table.Column<long>(type: "bigint", nullable: false),
                    PersonName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FatherHusbandName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CNIC = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    OldCNIC = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    NTN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    FTN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_TempPhoneNumber_BusinessId",
                schema: "Core",
                table: "TempPhoneNumber",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_TempPhoneNumber_PersonId",
                schema: "Core",
                table: "TempPhoneNumber",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_TempAddress_BusinessId",
                schema: "Core",
                table: "TempAddress",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_TempAddress_PersonId",
                schema: "Core",
                table: "TempAddress",
                column: "PersonId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_TempAddress_TempBusiness_BusinessId",
                schema: "Core",
                table: "TempAddress",
                column: "BusinessId",
                principalSchema: "Core",
                principalTable: "TempBusiness",
                principalColumn: "BusinessId");

            migrationBuilder.AddForeignKey(
                name: "FK_TempAddress_TempPerson_PersonId",
                schema: "Core",
                table: "TempAddress",
                column: "PersonId",
                principalSchema: "Core",
                principalTable: "TempPerson",
                principalColumn: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_TempPhoneNumber_TempBusiness_BusinessId",
                schema: "Core",
                table: "TempPhoneNumber",
                column: "BusinessId",
                principalSchema: "Core",
                principalTable: "TempBusiness",
                principalColumn: "BusinessId");

            migrationBuilder.AddForeignKey(
                name: "FK_TempPhoneNumber_TempPerson_PersonId",
                schema: "Core",
                table: "TempPhoneNumber",
                column: "PersonId",
                principalSchema: "Core",
                principalTable: "TempPerson",
                principalColumn: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TempAddress_TempBusiness_BusinessId",
                schema: "Core",
                table: "TempAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_TempAddress_TempPerson_PersonId",
                schema: "Core",
                table: "TempAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_TempPhoneNumber_TempBusiness_BusinessId",
                schema: "Core",
                table: "TempPhoneNumber");

            migrationBuilder.DropForeignKey(
                name: "FK_TempPhoneNumber_TempPerson_PersonId",
                schema: "Core",
                table: "TempPhoneNumber");

            migrationBuilder.DropTable(
                name: "TempBusiness",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "TempPerson",
                schema: "Core");

            migrationBuilder.DropIndex(
                name: "IX_TempPhoneNumber_BusinessId",
                schema: "Core",
                table: "TempPhoneNumber");

            migrationBuilder.DropIndex(
                name: "IX_TempPhoneNumber_PersonId",
                schema: "Core",
                table: "TempPhoneNumber");

            migrationBuilder.DropIndex(
                name: "IX_TempAddress_BusinessId",
                schema: "Core",
                table: "TempAddress");

            migrationBuilder.DropIndex(
                name: "IX_TempAddress_PersonId",
                schema: "Core",
                table: "TempAddress");

            migrationBuilder.DropColumn(
                name: "BusinessId",
                schema: "Core",
                table: "TempPhoneNumber");

            migrationBuilder.DropColumn(
                name: "PersonId",
                schema: "Core",
                table: "TempPhoneNumber");

            migrationBuilder.DropColumn(
                name: "BusinessId",
                schema: "Core",
                table: "TempAddress");

            migrationBuilder.DropColumn(
                name: "PersonId",
                schema: "Core",
                table: "TempAddress");

            migrationBuilder.AddColumn<string>(
                name: "CNIC",
                schema: "Core",
                table: "TempOwner",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CountryId",
                schema: "Core",
                table: "TempOwner",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                schema: "Core",
                table: "TempOwner",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FatherHusbandName",
                schema: "Core",
                table: "TempOwner",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                schema: "Core",
                table: "TempOwner",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NTN",
                schema: "Core",
                table: "TempOwner",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OldCNIC",
                schema: "Core",
                table: "TempOwner",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TempOwner_CountryId",
                schema: "Core",
                table: "TempOwner",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_TempOwner_Country_CountryId",
                schema: "Core",
                table: "TempOwner",
                column: "CountryId",
                principalSchema: "Setup",
                principalTable: "Country",
                principalColumn: "Id");
        }
    }
}
