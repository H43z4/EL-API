using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _47 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_User_CreatedBy",
                schema: "Core",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Business_User_CreatedBy",
                schema: "Core",
                table: "Business");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_User_CreatedBy",
                schema: "Core",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumber_User_CreatedBy",
                schema: "Core",
                table: "PhoneNumber");

            migrationBuilder.DropIndex(
                name: "IX_PhoneNumber_CreatedBy",
                schema: "Core",
                table: "PhoneNumber");

            migrationBuilder.DropIndex(
                name: "IX_Person_CreatedBy",
                schema: "Core",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Business_CreatedBy",
                schema: "Core",
                table: "Business");

            migrationBuilder.DropIndex(
                name: "IX_Address_CreatedBy",
                schema: "Core",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "UserStatusDescription",
                schema: "Auth",
                table: "UserStatus");

            migrationBuilder.DropColumn(
                name: "UserStatusName",
                schema: "Auth",
                table: "UserStatus");

            migrationBuilder.DropColumn(
                name: "UserStatusNameAbbr",
                schema: "Auth",
                table: "UserStatus");

            migrationBuilder.DropColumn(
                name: "Address",
                schema: "Auth",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CNIC",
                schema: "Auth",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Email",
                schema: "Auth",
                table: "User");

            migrationBuilder.DropColumn(
                name: "FullName",
                schema: "Auth",
                table: "User");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                schema: "Auth",
                table: "User");

            migrationBuilder.EnsureSchema(
                name: "Profiling");

            migrationBuilder.RenameColumn(
                name: "UserStatusId",
                schema: "Auth",
                table: "UserStatus",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                schema: "Core",
                table: "PhoneNumber",
                newName: "MicroServiceUserId");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                schema: "Core",
                table: "Person",
                newName: "MicroServiceUserId");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                schema: "Core",
                table: "Business",
                newName: "MicroServiceUserId");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                schema: "Core",
                table: "Address",
                newName: "MicroServiceUserId");

            migrationBuilder.AddColumn<DateTime>(
                name: "RegistrationDate",
                schema: "Core",
                table: "Vehicle",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Abbreviation",
                schema: "Auth",
                table: "UserStatus",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "Auth",
                table: "UserStatus",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                schema: "Auth",
                table: "UserStatus",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<long>(
                name: "UserDistrictId",
                schema: "Auth",
                table: "User",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "BusinessId",
                schema: "Auth",
                table: "User",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PersonId",
                schema: "Auth",
                table: "User",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UserTypeId",
                schema: "Auth",
                table: "User",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "MicroServiceId",
                schema: "Core",
                table: "PhoneNumber",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "MicroServiceId",
                schema: "Core",
                table: "Person",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "MicroServiceId",
                schema: "Core",
                table: "Business",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "MicroServiceId",
                schema: "Core",
                table: "Address",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MicroService",
                schema: "Profiling",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MicroService", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserType",
                schema: "Auth",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserType", x => x.Id);
                });

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
                name: "IX_User_UserName",
                schema: "Auth",
                table: "User",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_UserTypeId",
                schema: "Auth",
                table: "User",
                column: "UserTypeId",
                unique: true,
                filter: "[UserTypeId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumber_MicroServiceId",
                schema: "Core",
                table: "PhoneNumber",
                column: "MicroServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_MicroServiceId",
                schema: "Core",
                table: "Person",
                column: "MicroServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Business_MicroServiceId",
                schema: "Core",
                table: "Business",
                column: "MicroServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_MicroServiceId",
                schema: "Core",
                table: "Address",
                column: "MicroServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_MicroService_MicroServiceId",
                schema: "Core",
                table: "Address",
                column: "MicroServiceId",
                principalSchema: "Profiling",
                principalTable: "MicroService",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Business_MicroService_MicroServiceId",
                schema: "Core",
                table: "Business",
                column: "MicroServiceId",
                principalSchema: "Profiling",
                principalTable: "MicroService",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_MicroService_MicroServiceId",
                schema: "Core",
                table: "Person",
                column: "MicroServiceId",
                principalSchema: "Profiling",
                principalTable: "MicroService",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumber_MicroService_MicroServiceId",
                schema: "Core",
                table: "PhoneNumber",
                column: "MicroServiceId",
                principalSchema: "Profiling",
                principalTable: "MicroService",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Business_BusinessId",
                schema: "Auth",
                table: "User",
                column: "BusinessId",
                principalSchema: "Core",
                principalTable: "Business",
                principalColumn: "BusinessId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Person_PersonId",
                schema: "Auth",
                table: "User",
                column: "PersonId",
                principalSchema: "Core",
                principalTable: "Person",
                principalColumn: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_UserType_UserTypeId",
                schema: "Auth",
                table: "User",
                column: "UserTypeId",
                principalSchema: "Auth",
                principalTable: "UserType",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_MicroService_MicroServiceId",
                schema: "Core",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Business_MicroService_MicroServiceId",
                schema: "Core",
                table: "Business");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_MicroService_MicroServiceId",
                schema: "Core",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumber_MicroService_MicroServiceId",
                schema: "Core",
                table: "PhoneNumber");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Business_BusinessId",
                schema: "Auth",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Person_PersonId",
                schema: "Auth",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_UserType_UserTypeId",
                schema: "Auth",
                table: "User");

            migrationBuilder.DropTable(
                name: "MicroService",
                schema: "Profiling");

            migrationBuilder.DropTable(
                name: "UserType",
                schema: "Auth");

            migrationBuilder.DropIndex(
                name: "IX_User_BusinessId",
                schema: "Auth",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_PersonId",
                schema: "Auth",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_UserName",
                schema: "Auth",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_UserTypeId",
                schema: "Auth",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_PhoneNumber_MicroServiceId",
                schema: "Core",
                table: "PhoneNumber");

            migrationBuilder.DropIndex(
                name: "IX_Person_MicroServiceId",
                schema: "Core",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Business_MicroServiceId",
                schema: "Core",
                table: "Business");

            migrationBuilder.DropIndex(
                name: "IX_Address_MicroServiceId",
                schema: "Core",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "RegistrationDate",
                schema: "Core",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "Abbreviation",
                schema: "Auth",
                table: "UserStatus");

            migrationBuilder.DropColumn(
                name: "Description",
                schema: "Auth",
                table: "UserStatus");

            migrationBuilder.DropColumn(
                name: "Name",
                schema: "Auth",
                table: "UserStatus");

            migrationBuilder.DropColumn(
                name: "BusinessId",
                schema: "Auth",
                table: "User");

            migrationBuilder.DropColumn(
                name: "PersonId",
                schema: "Auth",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UserTypeId",
                schema: "Auth",
                table: "User");

            migrationBuilder.DropColumn(
                name: "MicroServiceId",
                schema: "Core",
                table: "PhoneNumber");

            migrationBuilder.DropColumn(
                name: "MicroServiceId",
                schema: "Core",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "MicroServiceId",
                schema: "Core",
                table: "Business");

            migrationBuilder.DropColumn(
                name: "MicroServiceId",
                schema: "Core",
                table: "Address");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "Auth",
                table: "UserStatus",
                newName: "UserStatusId");

            migrationBuilder.RenameColumn(
                name: "MicroServiceUserId",
                schema: "Core",
                table: "PhoneNumber",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "MicroServiceUserId",
                schema: "Core",
                table: "Person",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "MicroServiceUserId",
                schema: "Core",
                table: "Business",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "MicroServiceUserId",
                schema: "Core",
                table: "Address",
                newName: "CreatedBy");

            migrationBuilder.AddColumn<string>(
                name: "UserStatusDescription",
                schema: "Auth",
                table: "UserStatus",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserStatusName",
                schema: "Auth",
                table: "UserStatus",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserStatusNameAbbr",
                schema: "Auth",
                table: "UserStatus",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "UserDistrictId",
                schema: "Auth",
                table: "User",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                schema: "Auth",
                table: "User",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CNIC",
                schema: "Auth",
                table: "User",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                schema: "Auth",
                table: "User",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                schema: "Auth",
                table: "User",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                schema: "Auth",
                table: "User",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumber_CreatedBy",
                schema: "Core",
                table: "PhoneNumber",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Person_CreatedBy",
                schema: "Core",
                table: "Person",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Business_CreatedBy",
                schema: "Core",
                table: "Business",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Address_CreatedBy",
                schema: "Core",
                table: "Address",
                column: "CreatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_User_CreatedBy",
                schema: "Core",
                table: "Address",
                column: "CreatedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Business_User_CreatedBy",
                schema: "Core",
                table: "Business",
                column: "CreatedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_User_CreatedBy",
                schema: "Core",
                table: "Person",
                column: "CreatedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumber_User_CreatedBy",
                schema: "Core",
                table: "PhoneNumber",
                column: "CreatedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");
        }
    }
}
