using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _86 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SeriesAssignment",
                schema: "SRNRPL",
                columns: table => new
                {
                    SeriesAssignmentId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeriesCategoryId = table.Column<long>(type: "bigint", nullable: false),
                    SeriesId = table.Column<long>(type: "bigint", nullable: false),
                    SeriesConsumerId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeriesAssignment", x => x.SeriesAssignmentId);
                    table.ForeignKey(
                        name: "FK_SeriesAssignment_Series_SeriesId",
                        column: x => x.SeriesId,
                        principalSchema: "SRNRPL",
                        principalTable: "Series",
                        principalColumn: "SeriesId");
                    table.ForeignKey(
                        name: "FK_SeriesAssignment_SeriesCategory_SeriesCategoryId",
                        column: x => x.SeriesCategoryId,
                        principalSchema: "SRNRPL",
                        principalTable: "SeriesCategory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SeriesAssignment_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_SeriesAssignment_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_SeriesAssignment_User_SeriesConsumerId",
                        column: x => x.SeriesConsumerId,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SeriesAssignment_CreatedBy",
                schema: "SRNRPL",
                table: "SeriesAssignment",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesAssignment_ModifiedBy",
                schema: "SRNRPL",
                table: "SeriesAssignment",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesAssignment_SeriesCategoryId",
                schema: "SRNRPL",
                table: "SeriesAssignment",
                column: "SeriesCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesAssignment_SeriesConsumerId",
                schema: "SRNRPL",
                table: "SeriesAssignment",
                column: "SeriesConsumerId");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesAssignment_SeriesId_SeriesConsumerId",
                schema: "SRNRPL",
                table: "SeriesAssignment",
                columns: new[] { "SeriesId", "SeriesConsumerId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SeriesAssignment",
                schema: "SRNRPL");
        }
    }
}
