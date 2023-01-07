using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _77 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_BusinessTableAccessLevel_ApplicationStatusId_BusinessPhaseId_BusinessPhaseStatusId_BusinessProcessId_BusinessTableId_RoleId_~",
                schema: "Setup",
                table: "BusinessTableAccessLevel");

            migrationBuilder.DropColumn(
                name: "AccessLevel",
                schema: "Setup",
                table: "BusinessTableAccessLevel");

            migrationBuilder.AlterColumn<long>(
                name: "BusinessTableAccessId",
                schema: "Setup",
                table: "BusinessTableAccessLevel",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTableAccessLevel_ApplicationStatusId_BusinessPhaseId_BusinessPhaseStatusId_BusinessProcessId_BusinessTableId_RoleId_~",
                schema: "Setup",
                table: "BusinessTableAccessLevel",
                columns: new[] { "ApplicationStatusId", "BusinessPhaseId", "BusinessPhaseStatusId", "BusinessProcessId", "BusinessTableId", "RoleId", "BusinessTableAccessId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_BusinessTableAccessLevel_ApplicationStatusId_BusinessPhaseId_BusinessPhaseStatusId_BusinessProcessId_BusinessTableId_RoleId_~",
                schema: "Setup",
                table: "BusinessTableAccessLevel");

            migrationBuilder.AlterColumn<long>(
                name: "BusinessTableAccessId",
                schema: "Setup",
                table: "BusinessTableAccessLevel",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "AccessLevel",
                schema: "Setup",
                table: "BusinessTableAccessLevel",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTableAccessLevel_ApplicationStatusId_BusinessPhaseId_BusinessPhaseStatusId_BusinessProcessId_BusinessTableId_RoleId_~",
                schema: "Setup",
                table: "BusinessTableAccessLevel",
                columns: new[] { "ApplicationStatusId", "BusinessPhaseId", "BusinessPhaseStatusId", "BusinessProcessId", "BusinessTableId", "RoleId", "AccessLevel" },
                unique: true);
        }
    }
}
