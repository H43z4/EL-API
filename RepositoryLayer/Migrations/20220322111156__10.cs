using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ApplicationPhaseId",
                schema: "Core",
                table: "Application",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "ApplicationPhase",
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
                    table.PrimaryKey("PK_ApplicationPhase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationPhase_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Application_ApplicationPhaseId",
                schema: "Core",
                table: "Application",
                column: "ApplicationPhaseId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationPhase_CreatedBy",
                table: "ApplicationPhase",
                column: "CreatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_Application_ApplicationPhase_ApplicationPhaseId",
                schema: "Core",
                table: "Application",
                column: "ApplicationPhaseId",
                principalTable: "ApplicationPhase",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Application_ApplicationPhase_ApplicationPhaseId",
                schema: "Core",
                table: "Application");

            migrationBuilder.DropTable(
                name: "ApplicationPhase");

            migrationBuilder.DropIndex(
                name: "IX_Application_ApplicationPhaseId",
                schema: "Core",
                table: "Application");

            migrationBuilder.DropColumn(
                name: "ApplicationPhaseId",
                schema: "Core",
                table: "Application");
        }
    }
}
