using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _60 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CurrentApplicationStatusId",
                schema: "Setup",
                table: "ApplicationProcessFlow",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationProcessFlow_CurrentApplicationStatusId",
                schema: "Setup",
                table: "ApplicationProcessFlow",
                column: "CurrentApplicationStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationProcessFlow_ApplicationStatus_CurrentApplicationStatusId",
                schema: "Setup",
                table: "ApplicationProcessFlow",
                column: "CurrentApplicationStatusId",
                principalSchema: "Setup",
                principalTable: "ApplicationStatus",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationProcessFlow_ApplicationStatus_CurrentApplicationStatusId",
                schema: "Setup",
                table: "ApplicationProcessFlow");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationProcessFlow_CurrentApplicationStatusId",
                schema: "Setup",
                table: "ApplicationProcessFlow");

            migrationBuilder.DropColumn(
                name: "CurrentApplicationStatusId",
                schema: "Setup",
                table: "ApplicationProcessFlow");
        }
    }
}
