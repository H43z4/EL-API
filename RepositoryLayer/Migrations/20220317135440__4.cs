using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TempHPA",
                schema: "Core",
                columns: table => new
                {
                    HPAId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    SponserBusinessId = table.Column<long>(type: "bigint", nullable: false),
                    HPADate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HPALetterNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    HPATerms = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    HPATerminatedByUserId = table.Column<long>(type: "bigint", nullable: false),
                    HPATerminationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TempHPA",
                schema: "Core");
        }
    }
}
