using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_HPAStatus_HPAStatusId",
                schema: "Core",
                table: "Vehicle");

            migrationBuilder.DropTable(
                name: "HPAHistory",
                schema: "Core");

            migrationBuilder.DropIndex(
                name: "IX_Vehicle_HPAStatusId",
                schema: "Core",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "HPAStatusId",
                schema: "Core",
                table: "Vehicle");

            migrationBuilder.CreateTable(
                name: "HPA",
                schema: "Core",
                columns: table => new
                {
                    HPAId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    OwnerId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    SponserBusinessId = table.Column<long>(type: "bigint", nullable: false),
                    HPADate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HPAStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HPAEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LetterNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LetterDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Terms = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    HPACurrentStatusId = table.Column<long>(type: "bigint", nullable: false),
                    HPACurrentStatusDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HPA", x => x.HPAId);
                    table.ForeignKey(
                        name: "FK_HPA_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "Application",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_HPA_Business_SponserBusinessId",
                        column: x => x.SponserBusinessId,
                        principalSchema: "Core",
                        principalTable: "Business",
                        principalColumn: "BusinessId");
                    table.ForeignKey(
                        name: "FK_HPA_HPAStatus_HPACurrentStatusId",
                        column: x => x.HPACurrentStatusId,
                        principalSchema: "Setup",
                        principalTable: "HPAStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HPA_Owner_OwnerId",
                        column: x => x.OwnerId,
                        principalSchema: "Core",
                        principalTable: "Owner",
                        principalColumn: "OwnerId");
                    table.ForeignKey(
                        name: "FK_HPA_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_HPA_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalSchema: "Core",
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                });

            migrationBuilder.CreateTable(
                name: "HPAStatusHistory",
                schema: "Core",
                columns: table => new
                {
                    HPAStatusHistoryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HPAId = table.Column<long>(type: "bigint", nullable: false),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    HPAStatusId = table.Column<long>(type: "bigint", nullable: false),
                    HPAStatusDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HPAStatusHistory", x => x.HPAStatusHistoryId);
                    table.ForeignKey(
                        name: "FK_HPAStatusHistory_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "Application",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_HPAStatusHistory_HPA_HPAId",
                        column: x => x.HPAId,
                        principalSchema: "Core",
                        principalTable: "HPA",
                        principalColumn: "HPAId");
                    table.ForeignKey(
                        name: "FK_HPAStatusHistory_HPAStatus_HPAStatusId",
                        column: x => x.HPAStatusId,
                        principalSchema: "Setup",
                        principalTable: "HPAStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HPAStatusHistory_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_HPA_ApplicationId",
                schema: "Core",
                table: "HPA",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_HPA_CreatedBy",
                schema: "Core",
                table: "HPA",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_HPA_HPACurrentStatusId",
                schema: "Core",
                table: "HPA",
                column: "HPACurrentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_HPA_OwnerId",
                schema: "Core",
                table: "HPA",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_HPA_SponserBusinessId",
                schema: "Core",
                table: "HPA",
                column: "SponserBusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_HPA_VehicleId",
                schema: "Core",
                table: "HPA",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_HPAStatusHistory_ApplicationId",
                schema: "Core",
                table: "HPAStatusHistory",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_HPAStatusHistory_CreatedBy",
                schema: "Core",
                table: "HPAStatusHistory",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_HPAStatusHistory_HPAId",
                schema: "Core",
                table: "HPAStatusHistory",
                column: "HPAId");

            migrationBuilder.CreateIndex(
                name: "IX_HPAStatusHistory_HPAStatusId",
                schema: "Core",
                table: "HPAStatusHistory",
                column: "HPAStatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HPAStatusHistory",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "HPA",
                schema: "Core");

            migrationBuilder.AddColumn<long>(
                name: "HPAStatusId",
                schema: "Core",
                table: "Vehicle",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "HPAHistory",
                schema: "Core",
                columns: table => new
                {
                    HPAHistoryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    HPADate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HPAEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HPAStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HPAStatusDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HPAStatusId = table.Column<long>(type: "bigint", nullable: false),
                    LetterDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LetterNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OwnerId = table.Column<long>(type: "bigint", nullable: false),
                    SponserBusinessId = table.Column<long>(type: "bigint", nullable: false),
                    Terms = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HPAHistory", x => x.HPAHistoryId);
                    table.ForeignKey(
                        name: "FK_HPAHistory_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "Application",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_HPAHistory_Business_SponserBusinessId",
                        column: x => x.SponserBusinessId,
                        principalSchema: "Core",
                        principalTable: "Business",
                        principalColumn: "BusinessId");
                    table.ForeignKey(
                        name: "FK_HPAHistory_HPAStatus_HPAStatusId",
                        column: x => x.HPAStatusId,
                        principalSchema: "Setup",
                        principalTable: "HPAStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HPAHistory_Owner_OwnerId",
                        column: x => x.OwnerId,
                        principalSchema: "Core",
                        principalTable: "Owner",
                        principalColumn: "OwnerId");
                    table.ForeignKey(
                        name: "FK_HPAHistory_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_HPAHistory_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalSchema: "Core",
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_HPAStatusId",
                schema: "Core",
                table: "Vehicle",
                column: "HPAStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_HPAHistory_ApplicationId",
                schema: "Core",
                table: "HPAHistory",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_HPAHistory_CreatedBy",
                schema: "Core",
                table: "HPAHistory",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_HPAHistory_HPAStatusId",
                schema: "Core",
                table: "HPAHistory",
                column: "HPAStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_HPAHistory_OwnerId",
                schema: "Core",
                table: "HPAHistory",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_HPAHistory_SponserBusinessId",
                schema: "Core",
                table: "HPAHistory",
                column: "SponserBusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_HPAHistory_VehicleId",
                schema: "Core",
                table: "HPAHistory",
                column: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_HPAStatus_HPAStatusId",
                schema: "Core",
                table: "Vehicle",
                column: "HPAStatusId",
                principalSchema: "Setup",
                principalTable: "HPAStatus",
                principalColumn: "Id");
        }
    }
}
