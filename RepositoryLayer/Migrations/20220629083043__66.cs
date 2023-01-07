using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _66 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropIndex(
            //    name: "IX_ApplicationProcessFlow_CurrentApplicationStatusId",
            //    schema: "Setup",
            //    table: "ApplicationProcessFlow");

            migrationBuilder.AlterColumn<long>(
                name: "RoleId",
                schema: "Setup",
                table: "ApplicationProcessFlow",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationProcessFlow_CurrentApplicationStatusId_CurrentBusinessPhaseId_CurrentBusinessPhaseStatusId_BusinessProcessId_Role~",
                schema: "Setup",
                table: "ApplicationProcessFlow",
                columns: new[] { "CurrentApplicationStatusId", "CurrentBusinessPhaseId", "CurrentBusinessPhaseStatusId", "BusinessProcessId", "RoleId", "BusinessEventId", "NextApplicationStatusId", "NextBusinessPhaseId", "NextBusinessPhaseStatusId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ApplicationProcessFlow_CurrentApplicationStatusId_CurrentBusinessPhaseId_CurrentBusinessPhaseStatusId_BusinessProcessId_Role~",
                schema: "Setup",
                table: "ApplicationProcessFlow");

            migrationBuilder.AlterColumn<long>(
                name: "RoleId",
                schema: "Setup",
                table: "ApplicationProcessFlow",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ApplicationProcessFlow_CurrentApplicationStatusId",
            //    schema: "Setup",
            //    table: "ApplicationProcessFlow",
            //    column: "CurrentApplicationStatusId");
        }
    }
}
