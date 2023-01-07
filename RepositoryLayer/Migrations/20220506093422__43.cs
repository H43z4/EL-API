using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _43 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationProcessFlow_BusinessProcess_CurrentBusinessProcessId",
                schema: "Setup",
                table: "ApplicationProcessFlow");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationProcessFlow_BusinessProcess_NextBusinessProcessId",
                schema: "Setup",
                table: "ApplicationProcessFlow");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationProcessFlow_CurrentBusinessProcessId",
                schema: "Setup",
                table: "ApplicationProcessFlow");

            migrationBuilder.DropColumn(
                name: "CurrentBusinessProcessId",
                schema: "Setup",
                table: "ApplicationProcessFlow");

            migrationBuilder.RenameColumn(
                name: "NextBusinessProcessId",
                schema: "Setup",
                table: "ApplicationProcessFlow",
                newName: "BusinessProcessId");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationProcessFlow_NextBusinessProcessId",
                schema: "Setup",
                table: "ApplicationProcessFlow",
                newName: "IX_ApplicationProcessFlow_BusinessProcessId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationProcessFlow_BusinessProcess_BusinessProcessId",
                schema: "Setup",
                table: "ApplicationProcessFlow",
                column: "BusinessProcessId",
                principalSchema: "Setup",
                principalTable: "BusinessProcess",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationProcessFlow_BusinessProcess_BusinessProcessId",
                schema: "Setup",
                table: "ApplicationProcessFlow");

            migrationBuilder.RenameColumn(
                name: "BusinessProcessId",
                schema: "Setup",
                table: "ApplicationProcessFlow",
                newName: "NextBusinessProcessId");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationProcessFlow_BusinessProcessId",
                schema: "Setup",
                table: "ApplicationProcessFlow",
                newName: "IX_ApplicationProcessFlow_NextBusinessProcessId");

            migrationBuilder.AddColumn<long>(
                name: "CurrentBusinessProcessId",
                schema: "Setup",
                table: "ApplicationProcessFlow",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationProcessFlow_CurrentBusinessProcessId",
                schema: "Setup",
                table: "ApplicationProcessFlow",
                column: "CurrentBusinessProcessId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationProcessFlow_BusinessProcess_CurrentBusinessProcessId",
                schema: "Setup",
                table: "ApplicationProcessFlow",
                column: "CurrentBusinessProcessId",
                principalSchema: "Setup",
                principalTable: "BusinessProcess",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationProcessFlow_BusinessProcess_NextBusinessProcessId",
                schema: "Setup",
                table: "ApplicationProcessFlow",
                column: "NextBusinessProcessId",
                principalSchema: "Setup",
                principalTable: "BusinessProcess",
                principalColumn: "Id");
        }
    }
}
