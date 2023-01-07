using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _73 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_SeriesType_SeriesTypeName",
                schema: "SRNRPL",
                table: "SeriesType");

            migrationBuilder.DropIndex(
                name: "IX_SeriesStatus_SeriesStatusName",
                schema: "SRNRPL",
                table: "SeriesStatus");

            migrationBuilder.DropIndex(
                name: "IX_SeriesCategory_SeriesCategoryName",
                schema: "SRNRPL",
                table: "SeriesCategory");

            migrationBuilder.DropColumn(
                name: "Abbreviation",
                schema: "Setup",
                table: "BusinessTableAccessLevel");

            migrationBuilder.DropColumn(
                name: "Description",
                schema: "Setup",
                table: "BusinessTableAccessLevel");

            migrationBuilder.DropColumn(
                name: "Name",
                schema: "Setup",
                table: "BusinessTableAccessLevel");

            migrationBuilder.DropColumn(
                name: "Abbreviation",
                schema: "Setup",
                table: "ApplicationProcessFlow");

            migrationBuilder.DropColumn(
                name: "Description",
                schema: "Setup",
                table: "ApplicationProcessFlow");

            migrationBuilder.DropColumn(
                name: "Name",
                schema: "Setup",
                table: "ApplicationProcessFlow");

            migrationBuilder.RenameColumn(
                name: "SeriesTypeName",
                schema: "SRNRPL",
                table: "SeriesType",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "SeriesTypeId",
                schema: "SRNRPL",
                table: "SeriesType",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "SeriesStatusName",
                schema: "SRNRPL",
                table: "SeriesStatus",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "SeriesStatusId",
                schema: "SRNRPL",
                table: "SeriesStatus",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "SeriesCategoryName",
                schema: "SRNRPL",
                table: "SeriesCategory",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "SeriesCategoryId",
                schema: "SRNRPL",
                table: "SeriesCategory",
                newName: "Id");

            migrationBuilder.AddColumn<long>(
                name: "VehicleClassGroupId",
                schema: "Setup",
                table: "VehicleClass",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Abbreviation",
                schema: "SRNRPL",
                table: "SeriesType",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "SRNRPL",
                table: "SeriesType",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Abbreviation",
                schema: "SRNRPL",
                table: "SeriesStatus",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "SRNRPL",
                table: "SeriesStatus",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<long>(
                name: "SeriesNumberGroupId",
                schema: "SRNRPL",
                table: "SeriesNumberPool",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "Abbreviation",
                schema: "SRNRPL",
                table: "SeriesCategory",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "SRNRPL",
                table: "SeriesCategory",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "SeriesNumberGroup",
                schema: "SRNRPL",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeriesNumberGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SeriesNumberGroup_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_SeriesNumberGroup_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleClassGroup",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleClassGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleClassGroup_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleClassGroup_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClass_VehicleClassGroupId",
                schema: "Setup",
                table: "VehicleClass",
                column: "VehicleClassGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumberPool_SeriesNumberGroupId",
                schema: "SRNRPL",
                table: "SeriesNumberPool",
                column: "SeriesNumberGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumberGroup_CreatedBy",
                schema: "SRNRPL",
                table: "SeriesNumberGroup",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumberGroup_ModifiedBy",
                schema: "SRNRPL",
                table: "SeriesNumberGroup",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClassGroup_CreatedBy",
                schema: "Setup",
                table: "VehicleClassGroup",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClassGroup_ModifiedBy",
                schema: "Setup",
                table: "VehicleClassGroup",
                column: "ModifiedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_SeriesNumberPool_SeriesNumberGroup_SeriesNumberGroupId",
                schema: "SRNRPL",
                table: "SeriesNumberPool",
                column: "SeriesNumberGroupId",
                principalSchema: "SRNRPL",
                principalTable: "SeriesNumberGroup",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleClass_VehicleClassGroup_VehicleClassGroupId",
                schema: "Setup",
                table: "VehicleClass",
                column: "VehicleClassGroupId",
                principalSchema: "Setup",
                principalTable: "VehicleClassGroup",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SeriesNumberPool_SeriesNumberGroup_SeriesNumberGroupId",
                schema: "SRNRPL",
                table: "SeriesNumberPool");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleClass_VehicleClassGroup_VehicleClassGroupId",
                schema: "Setup",
                table: "VehicleClass");

            migrationBuilder.DropTable(
                name: "SeriesNumberGroup",
                schema: "SRNRPL");

            migrationBuilder.DropTable(
                name: "VehicleClassGroup",
                schema: "Setup");

            migrationBuilder.DropIndex(
                name: "IX_VehicleClass_VehicleClassGroupId",
                schema: "Setup",
                table: "VehicleClass");

            migrationBuilder.DropIndex(
                name: "IX_SeriesNumberPool_SeriesNumberGroupId",
                schema: "SRNRPL",
                table: "SeriesNumberPool");

            migrationBuilder.DropColumn(
                name: "VehicleClassGroupId",
                schema: "Setup",
                table: "VehicleClass");

            migrationBuilder.DropColumn(
                name: "Abbreviation",
                schema: "SRNRPL",
                table: "SeriesType");

            migrationBuilder.DropColumn(
                name: "Description",
                schema: "SRNRPL",
                table: "SeriesType");

            migrationBuilder.DropColumn(
                name: "Abbreviation",
                schema: "SRNRPL",
                table: "SeriesStatus");

            migrationBuilder.DropColumn(
                name: "Description",
                schema: "SRNRPL",
                table: "SeriesStatus");

            migrationBuilder.DropColumn(
                name: "SeriesNumberGroupId",
                schema: "SRNRPL",
                table: "SeriesNumberPool");

            migrationBuilder.DropColumn(
                name: "Abbreviation",
                schema: "SRNRPL",
                table: "SeriesCategory");

            migrationBuilder.DropColumn(
                name: "Description",
                schema: "SRNRPL",
                table: "SeriesCategory");

            migrationBuilder.RenameColumn(
                name: "Name",
                schema: "SRNRPL",
                table: "SeriesType",
                newName: "SeriesTypeName");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "SRNRPL",
                table: "SeriesType",
                newName: "SeriesTypeId");

            migrationBuilder.RenameColumn(
                name: "Name",
                schema: "SRNRPL",
                table: "SeriesStatus",
                newName: "SeriesStatusName");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "SRNRPL",
                table: "SeriesStatus",
                newName: "SeriesStatusId");

            migrationBuilder.RenameColumn(
                name: "Name",
                schema: "SRNRPL",
                table: "SeriesCategory",
                newName: "SeriesCategoryName");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "SRNRPL",
                table: "SeriesCategory",
                newName: "SeriesCategoryId");

            migrationBuilder.AddColumn<string>(
                name: "Abbreviation",
                schema: "Setup",
                table: "BusinessTableAccessLevel",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "Setup",
                table: "BusinessTableAccessLevel",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                schema: "Setup",
                table: "BusinessTableAccessLevel",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Abbreviation",
                schema: "Setup",
                table: "ApplicationProcessFlow",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "Setup",
                table: "ApplicationProcessFlow",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                schema: "Setup",
                table: "ApplicationProcessFlow",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesType_SeriesTypeName",
                schema: "SRNRPL",
                table: "SeriesType",
                column: "SeriesTypeName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SeriesStatus_SeriesStatusName",
                schema: "SRNRPL",
                table: "SeriesStatus",
                column: "SeriesStatusName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SeriesCategory_SeriesCategoryName",
                schema: "SRNRPL",
                table: "SeriesCategory",
                column: "SeriesCategoryName",
                unique: true);
        }
    }
}
