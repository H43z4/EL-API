using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _18 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HttpRequestLog_User_CreatedBy",
                schema: "Logs",
                table: "HttpRequestLog");

            migrationBuilder.DropIndex(
                name: "IX_HttpRequestLog_CreatedBy",
                schema: "Logs",
                table: "HttpRequestLog");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_HttpRequestLog_CreatedBy",
                schema: "Logs",
                table: "HttpRequestLog",
                column: "CreatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_HttpRequestLog_User_CreatedBy",
                schema: "Logs",
                table: "HttpRequestLog",
                column: "CreatedBy",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");
        }
    }
}
