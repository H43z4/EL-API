using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _72 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationLog",
                schema: "Core",
                columns: table => new
                {
                    ApplicationLogId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessProcessId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessPhaseId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessPhaseStatusId = table.Column<long>(type: "bigint", nullable: false),
                    ApplicationStatusId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: true),
                    OwnerId = table.Column<long>(type: "bigint", nullable: true),
                    SellerId = table.Column<long>(type: "bigint", nullable: true),
                    DistrictId = table.Column<long>(type: "bigint", nullable: true),
                    ReceivedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationLog", x => x.ApplicationLogId);
                    table.ForeignKey(
                        name: "FK_ApplicationLog_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "Application",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_ApplicationLog_ApplicationStatus_ApplicationStatusId",
                        column: x => x.ApplicationStatusId,
                        principalSchema: "Setup",
                        principalTable: "ApplicationStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ApplicationLog_BusinessPhase_BusinessPhaseId",
                        column: x => x.BusinessPhaseId,
                        principalSchema: "Setup",
                        principalTable: "BusinessPhase",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ApplicationLog_BusinessPhaseStatus_BusinessPhaseStatusId",
                        column: x => x.BusinessPhaseStatusId,
                        principalSchema: "Setup",
                        principalTable: "BusinessPhaseStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ApplicationLog_BusinessProcess_BusinessProcessId",
                        column: x => x.BusinessProcessId,
                        principalSchema: "Setup",
                        principalTable: "BusinessProcess",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ApplicationLog_District_DistrictId",
                        column: x => x.DistrictId,
                        principalSchema: "Setup",
                        principalTable: "District",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ApplicationLog_Owner_OwnerId",
                        column: x => x.OwnerId,
                        principalSchema: "Core",
                        principalTable: "Owner",
                        principalColumn: "OwnerId");
                    table.ForeignKey(
                        name: "FK_ApplicationLog_Owner_SellerId",
                        column: x => x.SellerId,
                        principalSchema: "Core",
                        principalTable: "Owner",
                        principalColumn: "OwnerId");
                    table.ForeignKey(
                        name: "FK_ApplicationLog_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_ApplicationLog_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_ApplicationLog_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalSchema: "Core",
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationLog_ApplicationId",
                schema: "Core",
                table: "ApplicationLog",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationLog_ApplicationStatusId",
                schema: "Core",
                table: "ApplicationLog",
                column: "ApplicationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationLog_BusinessPhaseId",
                schema: "Core",
                table: "ApplicationLog",
                column: "BusinessPhaseId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationLog_BusinessPhaseStatusId",
                schema: "Core",
                table: "ApplicationLog",
                column: "BusinessPhaseStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationLog_BusinessProcessId",
                schema: "Core",
                table: "ApplicationLog",
                column: "BusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationLog_CreatedBy",
                schema: "Core",
                table: "ApplicationLog",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationLog_DistrictId",
                schema: "Core",
                table: "ApplicationLog",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationLog_ModifiedBy",
                schema: "Core",
                table: "ApplicationLog",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationLog_OwnerId",
                schema: "Core",
                table: "ApplicationLog",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationLog_SellerId",
                schema: "Core",
                table: "ApplicationLog",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationLog_VehicleId",
                schema: "Core",
                table: "ApplicationLog",
                column: "VehicleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationLog",
                schema: "Core");
        }
    }
}
