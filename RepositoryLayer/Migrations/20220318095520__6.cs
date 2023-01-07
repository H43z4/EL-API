using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "TehsilId",
                schema: "Core",
                table: "TempAddress",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TempAddress_TehsilId",
                schema: "Core",
                table: "TempAddress",
                column: "TehsilId");

            migrationBuilder.AddForeignKey(
                name: "FK_TempAddress_Tehsil_TehsilId",
                schema: "Core",
                table: "TempAddress",
                column: "TehsilId",
                principalTable: "Tehsil",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TempAddress_Tehsil_TehsilId",
                schema: "Core",
                table: "TempAddress");

            migrationBuilder.DropIndex(
                name: "IX_TempAddress_TehsilId",
                schema: "Core",
                table: "TempAddress");

            migrationBuilder.DropColumn(
                name: "TehsilId",
                schema: "Core",
                table: "TempAddress");
        }
    }
}
