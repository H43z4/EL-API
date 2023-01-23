using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class newModules : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsExpired",
                table: "BiometricVerification",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsRep",
                table: "BiometricVerification",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "VerificationExpiry",
                table: "BiometricVerification",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BiometricRecords",
                columns: table => new
                {
                    BiometricRecordId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BiometricVerificationId = table.Column<long>(type: "bigint", nullable: false),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    PersonCNIC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonId = table.Column<long>(type: "bigint", nullable: true),
                    IsBuyer = table.Column<bool>(type: "bit", nullable: false),
                    IsRep = table.Column<bool>(type: "bit", nullable: false),
                    NadraFranchiseId = table.Column<long>(type: "bigint", nullable: true),
                    NadraTransId = table.Column<long>(type: "bigint", nullable: true),
                    IsVerified = table.Column<bool>(type: "bit", nullable: true),
                    VerificationReportedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BiometricRecords", x => x.BiometricRecordId);
                    table.ForeignKey(
                        name: "FK_BiometricRecords_BiometricVerification_BiometricVerificationId",
                        column: x => x.BiometricVerificationId,
                        principalTable: "BiometricVerification",
                        principalColumn: "BiometricVerificationId");
                    table.ForeignKey(
                        name: "FK_BiometricRecords_EPRSPerson_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "Core",
                        principalTable: "EPRSPerson",
                        principalColumn: "PersonId");
                    table.ForeignKey(
                        name: "FK_BiometricRecords_NadraFranchise_NadraFranchiseId",
                        column: x => x.NadraFranchiseId,
                        principalTable: "NadraFranchise",
                        principalColumn: "NadraFranchiseId");
                    table.ForeignKey(
                        name: "FK_BiometricRecords_PermitIssueApplication_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "PermitIssueApplication",
                        principalColumn: "ApplicationId");
                });

            migrationBuilder.CreateTable(
                name: "PersonDocuments",
                schema: "Core",
                columns: table => new
                {
                    DocumentId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonId = table.Column<long>(type: "bigint", nullable: true),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonDocuments", x => x.DocumentId);
                    table.ForeignKey(
                        name: "FK_PersonDocuments_EPRSPerson_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "Core",
                        principalTable: "EPRSPerson",
                        principalColumn: "PersonId");
                    table.ForeignKey(
                        name: "FK_PersonDocuments_PermitIssueApplication_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "PermitIssueApplication",
                        principalColumn: "ApplicationId");
                });

            migrationBuilder.CreateTable(
                name: "Representative",
                schema: "Core",
                columns: table => new
                {
                    RepId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    OldCNIC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OldName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    newCNIC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    newName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonId = table.Column<long>(type: "bigint", nullable: true),
                    IsVerified = table.Column<bool>(type: "bit", nullable: true),
                    VerificationReportedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Representative", x => x.RepId);
                    table.ForeignKey(
                        name: "FK_Representative_EPRSPerson_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "Core",
                        principalTable: "EPRSPerson",
                        principalColumn: "PersonId");
                    table.ForeignKey(
                        name: "FK_Representative_PermitIssueApplication_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "PermitIssueApplication",
                        principalColumn: "ApplicationId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BiometricRecords_ApplicationId",
                table: "BiometricRecords",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_BiometricRecords_BiometricVerificationId",
                table: "BiometricRecords",
                column: "BiometricVerificationId");

            migrationBuilder.CreateIndex(
                name: "IX_BiometricRecords_NadraFranchiseId",
                table: "BiometricRecords",
                column: "NadraFranchiseId");

            migrationBuilder.CreateIndex(
                name: "IX_BiometricRecords_PersonId",
                table: "BiometricRecords",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonDocuments_ApplicationId",
                schema: "Core",
                table: "PersonDocuments",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonDocuments_PersonId",
                schema: "Core",
                table: "PersonDocuments",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Representative_ApplicationId",
                schema: "Core",
                table: "Representative",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Representative_PersonId",
                schema: "Core",
                table: "Representative",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BiometricRecords");

            migrationBuilder.DropTable(
                name: "PersonDocuments",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "Representative",
                schema: "Core");

            migrationBuilder.DropColumn(
                name: "IsExpired",
                table: "BiometricVerification");

            migrationBuilder.DropColumn(
                name: "IsRep",
                table: "BiometricVerification");

            migrationBuilder.DropColumn(
                name: "VerificationExpiry",
                table: "BiometricVerification");
        }
    }
}
