using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _41 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RoleAppProcessFlow",
                schema: "Auth",
                columns: table => new
                {
                    RoleAppProcessFlowId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    AppProcessFlowId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleAppProcessFlow", x => x.RoleAppProcessFlowId);
                    table.ForeignKey(
                        name: "FK_RoleAppProcessFlow_ApplicationProcessFlow_AppProcessFlowId",
                        column: x => x.AppProcessFlowId,
                        principalSchema: "Setup",
                        principalTable: "ApplicationProcessFlow",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RoleAppProcessFlow_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Auth",
                        principalTable: "Role",
                        principalColumn: "RoleId");
                    table.ForeignKey(
                        name: "FK_RoleAppProcessFlow_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_RoleAppProcessFlow_AppProcessFlowId",
                schema: "Auth",
                table: "RoleAppProcessFlow",
                column: "AppProcessFlowId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleAppProcessFlow_CreatedBy",
                schema: "Auth",
                table: "RoleAppProcessFlow",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_RoleAppProcessFlow_RoleId",
                schema: "Auth",
                table: "RoleAppProcessFlow",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoleAppProcessFlow",
                schema: "Auth");
        }
    }
}
