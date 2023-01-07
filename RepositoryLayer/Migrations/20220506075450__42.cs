using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _42 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_RoleAppProcessFlow_RoleId",
                schema: "Auth",
                table: "RoleAppProcessFlow");

            migrationBuilder.CreateIndex(
                name: "IX_RoleAppProcessFlow_RoleId_AppProcessFlowId",
                schema: "Auth",
                table: "RoleAppProcessFlow",
                columns: new[] { "RoleId", "AppProcessFlowId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_RoleAppProcessFlow_RoleId_AppProcessFlowId",
                schema: "Auth",
                table: "RoleAppProcessFlow");

            migrationBuilder.CreateIndex(
                name: "IX_RoleAppProcessFlow_RoleId",
                schema: "Auth",
                table: "RoleAppProcessFlow",
                column: "RoleId");
        }
    }
}
