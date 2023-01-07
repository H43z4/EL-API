using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _49 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BiometricResult",
                schema: "Biometric");

            migrationBuilder.CreateTable(
                name: "BiometricVerification",
                schema: "Biometric",
                columns: table => new
                {
                    BiometricVerificationId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    PersonId = table.Column<long>(type: "bigint", nullable: true),
                    NadraFranchiseId = table.Column<long>(type: "bigint", nullable: true),
                    NadraTransId = table.Column<long>(type: "bigint", nullable: true),
                    IsVerified = table.Column<bool>(type: "bit", nullable: true),
                    VerificationReportedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BiometricVerification", x => x.BiometricVerificationId);
                    table.ForeignKey(
                        name: "FK_BiometricVerification_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "Application",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_BiometricVerification_NadraFranchise_NadraFranchiseId",
                        column: x => x.NadraFranchiseId,
                        principalSchema: "Biometric",
                        principalTable: "NadraFranchise",
                        principalColumn: "NadraFranchiseId");
                    table.ForeignKey(
                        name: "FK_BiometricVerification_Person_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "Core",
                        principalTable: "Person",
                        principalColumn: "PersonId");
                    table.ForeignKey(
                        name: "FK_BiometricVerification_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_BiometricVerification_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalSchema: "Core",
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BiometricVerification_ApplicationId_PersonId_VehicleId",
                schema: "Biometric",
                table: "BiometricVerification",
                columns: new[] { "ApplicationId", "PersonId", "VehicleId" },
                unique: true,
                filter: "[PersonId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BiometricVerification_CreatedBy",
                schema: "Biometric",
                table: "BiometricVerification",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BiometricVerification_NadraFranchiseId",
                schema: "Biometric",
                table: "BiometricVerification",
                column: "NadraFranchiseId");

            migrationBuilder.CreateIndex(
                name: "IX_BiometricVerification_PersonId",
                schema: "Biometric",
                table: "BiometricVerification",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_BiometricVerification_VehicleId",
                schema: "Biometric",
                table: "BiometricVerification",
                column: "VehicleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BiometricVerification",
                schema: "Biometric");

            migrationBuilder.CreateTable(
                name: "BiometricResult",
                schema: "Biometric",
                columns: table => new
                {
                    BiometricResultId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    BioVerificationResult = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    NadraFranchiseId = table.Column<long>(type: "bigint", nullable: false),
                    NadraTransId = table.Column<long>(type: "bigint", nullable: false),
                    PersonId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    VerificationReportedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BiometricResult", x => x.BiometricResultId);
                    table.ForeignKey(
                        name: "FK_BiometricResult_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "Application",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_BiometricResult_NadraFranchise_NadraFranchiseId",
                        column: x => x.NadraFranchiseId,
                        principalSchema: "Biometric",
                        principalTable: "NadraFranchise",
                        principalColumn: "NadraFranchiseId");
                    table.ForeignKey(
                        name: "FK_BiometricResult_Person_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "Core",
                        principalTable: "Person",
                        principalColumn: "PersonId");
                    table.ForeignKey(
                        name: "FK_BiometricResult_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_BiometricResult_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalSchema: "Core",
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BiometricResult_ApplicationId_PersonId_VehicleId",
                schema: "Biometric",
                table: "BiometricResult",
                columns: new[] { "ApplicationId", "PersonId", "VehicleId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BiometricResult_CreatedBy",
                schema: "Biometric",
                table: "BiometricResult",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BiometricResult_NadraFranchiseId",
                schema: "Biometric",
                table: "BiometricResult",
                column: "NadraFranchiseId");

            migrationBuilder.CreateIndex(
                name: "IX_BiometricResult_PersonId",
                schema: "Biometric",
                table: "BiometricResult",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_BiometricResult_VehicleId",
                schema: "Biometric",
                table: "BiometricResult",
                column: "VehicleId");
        }
    }
}
