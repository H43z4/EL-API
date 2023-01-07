using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _25 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "AppliedFrom",
                schema: "Setup",
                table: "VehicleClass",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "EngineSizeMax",
                schema: "Setup",
                table: "VehicleClass",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "EngineSizeMin",
                schema: "Setup",
                table: "VehicleClass",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<bool>(
                name: "FitnessDocRequired",
                schema: "Setup",
                table: "VehicleClass",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "LadenWeightMax",
                schema: "Setup",
                table: "VehicleClass",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "LadenWeightMin",
                schema: "Setup",
                table: "VehicleClass",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "RouteTypeId",
                schema: "Setup",
                table: "VehicleClass",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "SeatingCapacityMax",
                schema: "Setup",
                table: "VehicleClass",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "SeatingCapacityMin",
                schema: "Setup",
                table: "VehicleClass",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "UnladenWeightMax",
                schema: "Setup",
                table: "VehicleClass",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "UnladenWeightMin",
                schema: "Setup",
                table: "VehicleClass",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "VehicleBodyTypeId",
                schema: "Setup",
                table: "VehicleClass",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "VehicleCategoryId",
                schema: "Setup",
                table: "VehicleClass",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "VehicleClassificationId",
                schema: "Setup",
                table: "VehicleClass",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "VehicleTypeId",
                schema: "Setup",
                table: "VehicleClass",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "RouteType",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RouteType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RouteType_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "TaxBase",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxBase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaxBase_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "TaxedBusinessProcess",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessProcessId = table.Column<long>(type: "bigint", nullable: false),
                    TaxTypeId = table.Column<long>(type: "bigint", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxedBusinessProcess", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaxedBusinessProcess_BusinessProcess_BusinessProcessId",
                        column: x => x.BusinessProcessId,
                        principalSchema: "Setup",
                        principalTable: "BusinessProcess",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TaxedBusinessProcess_TaxType_TaxTypeId",
                        column: x => x.TaxTypeId,
                        principalSchema: "Setup",
                        principalTable: "TaxType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TaxedBusinessProcess_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleType",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleType_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleClassDetail",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleClassId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleBodyTypeId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleCategoryId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleClassificationId = table.Column<long>(type: "bigint", nullable: false),
                    RouteTypeId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleTypeId = table.Column<long>(type: "bigint", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    EngineSizeMin = table.Column<long>(type: "bigint", nullable: false),
                    EngineSizeMax = table.Column<long>(type: "bigint", nullable: false),
                    SeatingCapacityMin = table.Column<long>(type: "bigint", nullable: false),
                    SeatingCapacityMax = table.Column<long>(type: "bigint", nullable: false),
                    LadenWeightMin = table.Column<long>(type: "bigint", nullable: false),
                    LadenWeightMax = table.Column<long>(type: "bigint", nullable: false),
                    UnladenWeightMin = table.Column<long>(type: "bigint", nullable: false),
                    UnladenWeightMax = table.Column<long>(type: "bigint", nullable: false),
                    FitnessDocRequired = table.Column<bool>(type: "bit", nullable: false),
                    AppliedFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleClassDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleClassDetail_RouteType_RouteTypeId",
                        column: x => x.RouteTypeId,
                        principalTable: "RouteType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleClassDetail_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleClassDetail_VehicleBodyType_VehicleBodyTypeId",
                        column: x => x.VehicleBodyTypeId,
                        principalSchema: "Setup",
                        principalTable: "VehicleBodyType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleClassDetail_VehicleCategory_VehicleCategoryId",
                        column: x => x.VehicleCategoryId,
                        principalSchema: "Setup",
                        principalTable: "VehicleCategory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleClassDetail_VehicleClass_VehicleClassId",
                        column: x => x.VehicleClassId,
                        principalSchema: "Setup",
                        principalTable: "VehicleClass",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleClassDetail_VehicleClassification_VehicleClassificationId",
                        column: x => x.VehicleClassificationId,
                        principalSchema: "Setup",
                        principalTable: "VehicleClassification",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleClassDetail_VehicleType_VehicleTypeId",
                        column: x => x.VehicleTypeId,
                        principalTable: "VehicleType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TaxRate",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleClassId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleClassDetailId = table.Column<long>(type: "bigint", nullable: false),
                    TaxTypeId = table.Column<long>(type: "bigint", nullable: false),
                    TaxBaseId = table.Column<long>(type: "bigint", nullable: false),
                    TaxValue = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
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
                        principalSchema: "Setup",
                        principalTable: "TaxType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TaxRate_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_TaxRate_VehicleClass_VehicleClassId",
                        column: x => x.VehicleClassId,
                        principalSchema: "Setup",
                        principalTable: "VehicleClass",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TaxRate_VehicleClassDetail_VehicleClassDetailId",
                        column: x => x.VehicleClassDetailId,
                        principalTable: "VehicleClassDetail",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClass_RouteTypeId",
                schema: "Setup",
                table: "VehicleClass",
                column: "RouteTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClass_VehicleBodyTypeId",
                schema: "Setup",
                table: "VehicleClass",
                column: "VehicleBodyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClass_VehicleCategoryId",
                schema: "Setup",
                table: "VehicleClass",
                column: "VehicleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClass_VehicleClassificationId",
                schema: "Setup",
                table: "VehicleClass",
                column: "VehicleClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClass_VehicleTypeId",
                schema: "Setup",
                table: "VehicleClass",
                column: "VehicleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RouteType_CreatedBy",
                table: "RouteType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TaxBase_CreatedBy",
                table: "TaxBase",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TaxedBusinessProcess_BusinessProcessId",
                table: "TaxedBusinessProcess",
                column: "BusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxedBusinessProcess_CreatedBy",
                table: "TaxedBusinessProcess",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TaxedBusinessProcess_TaxTypeId",
                table: "TaxedBusinessProcess",
                column: "TaxTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxRate_CreatedBy",
                table: "TaxRate",
                column: "CreatedBy");

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
                name: "IX_VehicleClassDetail_CreatedBy",
                table: "VehicleClassDetail",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClassDetail_RouteTypeId",
                table: "VehicleClassDetail",
                column: "RouteTypeId");

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
                name: "IX_VehicleClassDetail_VehicleTypeId",
                table: "VehicleClassDetail",
                column: "VehicleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleType_CreatedBy",
                table: "VehicleType",
                column: "CreatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleClass_RouteType_RouteTypeId",
                schema: "Setup",
                table: "VehicleClass",
                column: "RouteTypeId",
                principalTable: "RouteType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleClass_VehicleBodyType_VehicleBodyTypeId",
                schema: "Setup",
                table: "VehicleClass",
                column: "VehicleBodyTypeId",
                principalSchema: "Setup",
                principalTable: "VehicleBodyType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleClass_VehicleCategory_VehicleCategoryId",
                schema: "Setup",
                table: "VehicleClass",
                column: "VehicleCategoryId",
                principalSchema: "Setup",
                principalTable: "VehicleCategory",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleClass_VehicleClassification_VehicleClassificationId",
                schema: "Setup",
                table: "VehicleClass",
                column: "VehicleClassificationId",
                principalSchema: "Setup",
                principalTable: "VehicleClassification",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleClass_VehicleType_VehicleTypeId",
                schema: "Setup",
                table: "VehicleClass",
                column: "VehicleTypeId",
                principalTable: "VehicleType",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehicleClass_RouteType_RouteTypeId",
                schema: "Setup",
                table: "VehicleClass");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleClass_VehicleBodyType_VehicleBodyTypeId",
                schema: "Setup",
                table: "VehicleClass");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleClass_VehicleCategory_VehicleCategoryId",
                schema: "Setup",
                table: "VehicleClass");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleClass_VehicleClassification_VehicleClassificationId",
                schema: "Setup",
                table: "VehicleClass");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleClass_VehicleType_VehicleTypeId",
                schema: "Setup",
                table: "VehicleClass");

            migrationBuilder.DropTable(
                name: "TaxedBusinessProcess");

            migrationBuilder.DropTable(
                name: "TaxRate");

            migrationBuilder.DropTable(
                name: "TaxBase");

            migrationBuilder.DropTable(
                name: "VehicleClassDetail");

            migrationBuilder.DropTable(
                name: "RouteType");

            migrationBuilder.DropTable(
                name: "VehicleType");

            migrationBuilder.DropIndex(
                name: "IX_VehicleClass_RouteTypeId",
                schema: "Setup",
                table: "VehicleClass");

            migrationBuilder.DropIndex(
                name: "IX_VehicleClass_VehicleBodyTypeId",
                schema: "Setup",
                table: "VehicleClass");

            migrationBuilder.DropIndex(
                name: "IX_VehicleClass_VehicleCategoryId",
                schema: "Setup",
                table: "VehicleClass");

            migrationBuilder.DropIndex(
                name: "IX_VehicleClass_VehicleClassificationId",
                schema: "Setup",
                table: "VehicleClass");

            migrationBuilder.DropIndex(
                name: "IX_VehicleClass_VehicleTypeId",
                schema: "Setup",
                table: "VehicleClass");

            migrationBuilder.DropColumn(
                name: "AppliedFrom",
                schema: "Setup",
                table: "VehicleClass");

            migrationBuilder.DropColumn(
                name: "EngineSizeMax",
                schema: "Setup",
                table: "VehicleClass");

            migrationBuilder.DropColumn(
                name: "EngineSizeMin",
                schema: "Setup",
                table: "VehicleClass");

            migrationBuilder.DropColumn(
                name: "FitnessDocRequired",
                schema: "Setup",
                table: "VehicleClass");

            migrationBuilder.DropColumn(
                name: "LadenWeightMax",
                schema: "Setup",
                table: "VehicleClass");

            migrationBuilder.DropColumn(
                name: "LadenWeightMin",
                schema: "Setup",
                table: "VehicleClass");

            migrationBuilder.DropColumn(
                name: "RouteTypeId",
                schema: "Setup",
                table: "VehicleClass");

            migrationBuilder.DropColumn(
                name: "SeatingCapacityMax",
                schema: "Setup",
                table: "VehicleClass");

            migrationBuilder.DropColumn(
                name: "SeatingCapacityMin",
                schema: "Setup",
                table: "VehicleClass");

            migrationBuilder.DropColumn(
                name: "UnladenWeightMax",
                schema: "Setup",
                table: "VehicleClass");

            migrationBuilder.DropColumn(
                name: "UnladenWeightMin",
                schema: "Setup",
                table: "VehicleClass");

            migrationBuilder.DropColumn(
                name: "VehicleBodyTypeId",
                schema: "Setup",
                table: "VehicleClass");

            migrationBuilder.DropColumn(
                name: "VehicleCategoryId",
                schema: "Setup",
                table: "VehicleClass");

            migrationBuilder.DropColumn(
                name: "VehicleClassificationId",
                schema: "Setup",
                table: "VehicleClass");

            migrationBuilder.DropColumn(
                name: "VehicleTypeId",
                schema: "Setup",
                table: "VehicleClass");
        }
    }
}
