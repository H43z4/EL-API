using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _48 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Biometric");

            migrationBuilder.CreateTable(
                name: "NadraFranchise",
                schema: "Biometric",
                columns: table => new
                {
                    NadraFranchiseId = table.Column<long>(type: "bigint", nullable: false),
                    FranchiseName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FranchiseShopName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FranchiseCellNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NadraFranchise", x => x.NadraFranchiseId);
                    table.ForeignKey(
                        name: "FK_NadraFranchise_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "BiometricResult",
                schema: "Biometric",
                columns: table => new
                {
                    BiometricResultId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    PersonId = table.Column<long>(type: "bigint", nullable: false),
                    NadraFranchiseId = table.Column<long>(type: "bigint", nullable: false),
                    NadraTransId = table.Column<long>(type: "bigint", nullable: false),
                    BioVerificationResult = table.Column<bool>(type: "bit", nullable: false),
                    VerificationReportedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_NadraFranchise_CreatedBy",
                schema: "Biometric",
                table: "NadraFranchise",
                column: "CreatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BiometricResult",
                schema: "Biometric");

            migrationBuilder.DropTable(
                name: "NadraFranchise",
                schema: "Biometric");
        }
    }
}
