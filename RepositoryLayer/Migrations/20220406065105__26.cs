using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _26 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehicleClass_RouteType_RouteTypeId",
                schema: "Setup",
                table: "VehicleClass");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleClassDetail_RouteType_RouteTypeId",
                table: "VehicleClassDetail");

            migrationBuilder.DropTable(
                name: "RouteType");

            migrationBuilder.RenameTable(
                name: "VehicleType",
                newName: "VehicleType",
                newSchema: "Setup");

            migrationBuilder.RenameTable(
                name: "VehicleClassDetail",
                newName: "VehicleClassDetail",
                newSchema: "Setup");

            migrationBuilder.RenameTable(
                name: "TaxRate",
                newName: "TaxRate",
                newSchema: "Setup");

            migrationBuilder.RenameTable(
                name: "TaxedBusinessProcess",
                newName: "TaxedBusinessProcess",
                newSchema: "Setup");

            migrationBuilder.RenameTable(
                name: "TaxBase",
                newName: "TaxBase",
                newSchema: "Setup");

            migrationBuilder.RenameColumn(
                name: "RouteTypeId",
                schema: "Setup",
                table: "VehicleClass",
                newName: "VehicleRouteTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleClass_RouteTypeId",
                schema: "Setup",
                table: "VehicleClass",
                newName: "IX_VehicleClass_VehicleRouteTypeId");

            migrationBuilder.RenameColumn(
                name: "RouteTypeId",
                schema: "Setup",
                table: "VehicleClassDetail",
                newName: "VehicleRouteTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleClassDetail_RouteTypeId",
                schema: "Setup",
                table: "VehicleClassDetail",
                newName: "IX_VehicleClassDetail_VehicleRouteTypeId");

            migrationBuilder.CreateTable(
                name: "VehicleRouteType",
                schema: "Setup",
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
                    table.PrimaryKey("PK_VehicleRouteType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleRouteType_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_VehicleRouteType_CreatedBy",
                schema: "Setup",
                table: "VehicleRouteType",
                column: "CreatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleClass_VehicleRouteType_VehicleRouteTypeId",
                schema: "Setup",
                table: "VehicleClass",
                column: "VehicleRouteTypeId",
                principalSchema: "Setup",
                principalTable: "VehicleRouteType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleClassDetail_VehicleRouteType_VehicleRouteTypeId",
                schema: "Setup",
                table: "VehicleClassDetail",
                column: "VehicleRouteTypeId",
                principalSchema: "Setup",
                principalTable: "VehicleRouteType",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehicleClass_VehicleRouteType_VehicleRouteTypeId",
                schema: "Setup",
                table: "VehicleClass");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleClassDetail_VehicleRouteType_VehicleRouteTypeId",
                schema: "Setup",
                table: "VehicleClassDetail");

            migrationBuilder.DropTable(
                name: "VehicleRouteType",
                schema: "Setup");

            migrationBuilder.RenameTable(
                name: "VehicleType",
                schema: "Setup",
                newName: "VehicleType");

            migrationBuilder.RenameTable(
                name: "VehicleClassDetail",
                schema: "Setup",
                newName: "VehicleClassDetail");

            migrationBuilder.RenameTable(
                name: "TaxRate",
                schema: "Setup",
                newName: "TaxRate");

            migrationBuilder.RenameTable(
                name: "TaxedBusinessProcess",
                schema: "Setup",
                newName: "TaxedBusinessProcess");

            migrationBuilder.RenameTable(
                name: "TaxBase",
                schema: "Setup",
                newName: "TaxBase");

            migrationBuilder.RenameColumn(
                name: "VehicleRouteTypeId",
                schema: "Setup",
                table: "VehicleClass",
                newName: "RouteTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleClass_VehicleRouteTypeId",
                schema: "Setup",
                table: "VehicleClass",
                newName: "IX_VehicleClass_RouteTypeId");

            migrationBuilder.RenameColumn(
                name: "VehicleRouteTypeId",
                table: "VehicleClassDetail",
                newName: "RouteTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleClassDetail_VehicleRouteTypeId",
                table: "VehicleClassDetail",
                newName: "IX_VehicleClassDetail_RouteTypeId");

            migrationBuilder.CreateTable(
                name: "RouteType",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_RouteType_CreatedBy",
                table: "RouteType",
                column: "CreatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleClass_RouteType_RouteTypeId",
                schema: "Setup",
                table: "VehicleClass",
                column: "RouteTypeId",
                principalTable: "RouteType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleClassDetail_RouteType_RouteTypeId",
                table: "VehicleClassDetail",
                column: "RouteTypeId",
                principalTable: "RouteType",
                principalColumn: "Id");
        }
    }
}
