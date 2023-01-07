using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _65 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "RoleId",
                schema: "Setup",
                table: "ApplicationProcessFlow",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BusinessTable",
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
                    table.PrimaryKey("PK_BusinessTable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessTable_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "BusinessTableAccessLevel",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessProcessId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessPhaseId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessPhaseStatusId = table.Column<long>(type: "bigint", nullable: false),
                    ApplicationStatusId = table.Column<long>(type: "bigint", nullable: false),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessTableId = table.Column<long>(type: "bigint", nullable: false),
                    AccessLevel = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessTableAccessLevel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessTableAccessLevel_ApplicationStatus_ApplicationStatusId",
                        column: x => x.ApplicationStatusId,
                        principalSchema: "Setup",
                        principalTable: "ApplicationStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BusinessTableAccessLevel_BusinessPhase_BusinessPhaseId",
                        column: x => x.BusinessPhaseId,
                        principalSchema: "Setup",
                        principalTable: "BusinessPhase",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BusinessTableAccessLevel_BusinessPhaseStatus_BusinessPhaseStatusId",
                        column: x => x.BusinessPhaseStatusId,
                        principalSchema: "Setup",
                        principalTable: "BusinessPhaseStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BusinessTableAccessLevel_BusinessProcess_BusinessProcessId",
                        column: x => x.BusinessProcessId,
                        principalSchema: "Setup",
                        principalTable: "BusinessProcess",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BusinessTableAccessLevel_BusinessTable_BusinessTableId",
                        column: x => x.BusinessTableId,
                        principalSchema: "Setup",
                        principalTable: "BusinessTable",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BusinessTableAccessLevel_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Auth",
                        principalTable: "Role",
                        principalColumn: "RoleId");
                    table.ForeignKey(
                        name: "FK_BusinessTableAccessLevel_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationProcessFlow_RoleId",
                schema: "Setup",
                table: "ApplicationProcessFlow",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTable_CreatedBy",
                schema: "Setup",
                table: "BusinessTable",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTableAccessLevel_ApplicationStatusId_BusinessPhaseId_BusinessPhaseStatusId_BusinessProcessId_BusinessTableId_RoleId_~",
                schema: "Setup",
                table: "BusinessTableAccessLevel",
                columns: new[] { "ApplicationStatusId", "BusinessPhaseId", "BusinessPhaseStatusId", "BusinessProcessId", "BusinessTableId", "RoleId", "AccessLevel" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTableAccessLevel_BusinessPhaseId",
                schema: "Setup",
                table: "BusinessTableAccessLevel",
                column: "BusinessPhaseId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTableAccessLevel_BusinessPhaseStatusId",
                schema: "Setup",
                table: "BusinessTableAccessLevel",
                column: "BusinessPhaseStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTableAccessLevel_BusinessProcessId",
                schema: "Setup",
                table: "BusinessTableAccessLevel",
                column: "BusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTableAccessLevel_BusinessTableId",
                schema: "Setup",
                table: "BusinessTableAccessLevel",
                column: "BusinessTableId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTableAccessLevel_CreatedBy",
                schema: "Setup",
                table: "BusinessTableAccessLevel",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTableAccessLevel_RoleId",
                schema: "Setup",
                table: "BusinessTableAccessLevel",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationProcessFlow_Role_RoleId",
                schema: "Setup",
                table: "ApplicationProcessFlow",
                column: "RoleId",
                principalSchema: "Auth",
                principalTable: "Role",
                principalColumn: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationProcessFlow_Role_RoleId",
                schema: "Setup",
                table: "ApplicationProcessFlow");

            migrationBuilder.DropTable(
                name: "BusinessTableAccessLevel",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "BusinessTable",
                schema: "Setup");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationProcessFlow_RoleId",
                schema: "Setup",
                table: "ApplicationProcessFlow");

            migrationBuilder.DropColumn(
                name: "RoleId",
                schema: "Setup",
                table: "ApplicationProcessFlow");
        }
    }
}
