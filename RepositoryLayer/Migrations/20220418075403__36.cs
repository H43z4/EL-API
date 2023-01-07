using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _36 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Application_ApplicationPhaseId_ApplicationStatusId_ApplicationTypeId",
                schema: "Core",
                table: "Application");

            migrationBuilder.CreateIndex(
                name: "IX_Application_ApplicationPhaseId",
                schema: "Core",
                table: "Application",
                column: "ApplicationPhaseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Application_ApplicationPhaseId",
                schema: "Core",
                table: "Application");

            migrationBuilder.CreateIndex(
                name: "IX_Application_ApplicationPhaseId_ApplicationStatusId_ApplicationTypeId",
                schema: "Core",
                table: "Application",
                columns: new[] { "ApplicationPhaseId", "ApplicationStatusId", "ApplicationTypeId" },
                unique: true);
        }
    }
}
