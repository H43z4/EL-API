using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _40 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BusinessEvent",
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
                    table.PrimaryKey("PK_BusinessEvent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessEvent_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "ApplicationProcessFlow",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrentBusinessProcessId = table.Column<long>(type: "bigint", nullable: false),
                    CurrentBusinessPhaseId = table.Column<long>(type: "bigint", nullable: false),
                    CurrentBusinessPhaseStatusId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessEventId = table.Column<long>(type: "bigint", nullable: false),
                    NextBusinessProcessId = table.Column<long>(type: "bigint", nullable: false),
                    NextBusinessPhaseId = table.Column<long>(type: "bigint", nullable: false),
                    NextBusinessPhaseStatusId = table.Column<long>(type: "bigint", nullable: false),
                    NextApplicationStatusId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationProcessFlow", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationProcessFlow_ApplicationStatus_NextApplicationStatusId",
                        column: x => x.NextApplicationStatusId,
                        principalSchema: "Setup",
                        principalTable: "ApplicationStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ApplicationProcessFlow_BusinessEvent_BusinessEventId",
                        column: x => x.BusinessEventId,
                        principalSchema: "Setup",
                        principalTable: "BusinessEvent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ApplicationProcessFlow_BusinessPhase_CurrentBusinessPhaseId",
                        column: x => x.CurrentBusinessPhaseId,
                        principalSchema: "Setup",
                        principalTable: "BusinessPhase",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ApplicationProcessFlow_BusinessPhase_NextBusinessPhaseId",
                        column: x => x.NextBusinessPhaseId,
                        principalSchema: "Setup",
                        principalTable: "BusinessPhase",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ApplicationProcessFlow_BusinessPhaseStatus_CurrentBusinessPhaseStatusId",
                        column: x => x.CurrentBusinessPhaseStatusId,
                        principalSchema: "Setup",
                        principalTable: "BusinessPhaseStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ApplicationProcessFlow_BusinessPhaseStatus_NextBusinessPhaseStatusId",
                        column: x => x.NextBusinessPhaseStatusId,
                        principalSchema: "Setup",
                        principalTable: "BusinessPhaseStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ApplicationProcessFlow_BusinessProcess_CurrentBusinessProcessId",
                        column: x => x.CurrentBusinessProcessId,
                        principalSchema: "Setup",
                        principalTable: "BusinessProcess",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ApplicationProcessFlow_BusinessProcess_NextBusinessProcessId",
                        column: x => x.NextBusinessProcessId,
                        principalSchema: "Setup",
                        principalTable: "BusinessProcess",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ApplicationProcessFlow_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationProcessFlow_BusinessEventId",
                schema: "Setup",
                table: "ApplicationProcessFlow",
                column: "BusinessEventId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationProcessFlow_CreatedBy",
                schema: "Setup",
                table: "ApplicationProcessFlow",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationProcessFlow_CurrentBusinessPhaseId",
                schema: "Setup",
                table: "ApplicationProcessFlow",
                column: "CurrentBusinessPhaseId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationProcessFlow_CurrentBusinessPhaseStatusId",
                schema: "Setup",
                table: "ApplicationProcessFlow",
                column: "CurrentBusinessPhaseStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationProcessFlow_CurrentBusinessProcessId",
                schema: "Setup",
                table: "ApplicationProcessFlow",
                column: "CurrentBusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationProcessFlow_NextApplicationStatusId",
                schema: "Setup",
                table: "ApplicationProcessFlow",
                column: "NextApplicationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationProcessFlow_NextBusinessPhaseId",
                schema: "Setup",
                table: "ApplicationProcessFlow",
                column: "NextBusinessPhaseId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationProcessFlow_NextBusinessPhaseStatusId",
                schema: "Setup",
                table: "ApplicationProcessFlow",
                column: "NextBusinessPhaseStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationProcessFlow_NextBusinessProcessId",
                schema: "Setup",
                table: "ApplicationProcessFlow",
                column: "NextBusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessEvent_CreatedBy",
                schema: "Setup",
                table: "BusinessEvent",
                column: "CreatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationProcessFlow",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "BusinessEvent",
                schema: "Setup");
        }
    }
}
