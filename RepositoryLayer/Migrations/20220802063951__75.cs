using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _75 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SeriesNumberSelection",
                schema: "SRNRPL",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerTypeId = table.Column<long>(type: "bigint", nullable: false),
                    OwnerTaxGroupId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleClassId = table.Column<long>(type: "bigint", nullable: false),
                    SeriesNumberGroupId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeriesNumberSelection", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SeriesNumberSelection_OwnerTaxGroup_OwnerTaxGroupId",
                        column: x => x.OwnerTaxGroupId,
                        principalSchema: "Setup",
                        principalTable: "OwnerTaxGroup",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SeriesNumberSelection_OwnerType_OwnerTypeId",
                        column: x => x.OwnerTypeId,
                        principalSchema: "Setup",
                        principalTable: "OwnerType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SeriesNumberSelection_SeriesNumberGroup_SeriesNumberGroupId",
                        column: x => x.SeriesNumberGroupId,
                        principalSchema: "SRNRPL",
                        principalTable: "SeriesNumberGroup",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SeriesNumberSelection_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_SeriesNumberSelection_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_SeriesNumberSelection_VehicleClass_VehicleClassId",
                        column: x => x.VehicleClassId,
                        principalSchema: "Setup",
                        principalTable: "VehicleClass",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumberSelection_CreatedBy",
                schema: "SRNRPL",
                table: "SeriesNumberSelection",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumberSelection_ModifiedBy",
                schema: "SRNRPL",
                table: "SeriesNumberSelection",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumberSelection_OwnerTaxGroupId",
                schema: "SRNRPL",
                table: "SeriesNumberSelection",
                column: "OwnerTaxGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumberSelection_OwnerTypeId",
                schema: "SRNRPL",
                table: "SeriesNumberSelection",
                column: "OwnerTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumberSelection_SeriesNumberGroupId",
                schema: "SRNRPL",
                table: "SeriesNumberSelection",
                column: "SeriesNumberGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumberSelection_VehicleClassId",
                schema: "SRNRPL",
                table: "SeriesNumberSelection",
                column: "VehicleClassId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SeriesNumberSelection",
                schema: "SRNRPL");
        }
    }
}
