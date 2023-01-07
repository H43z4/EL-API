using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TempAddress_TempOwner_OwnerId",
                schema: "Core",
                table: "TempAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_TempPhoneNumber_TempOwner_OwnerId",
                schema: "Core",
                table: "TempPhoneNumber");

            migrationBuilder.DropIndex(
                name: "IX_TempPhoneNumber_OwnerId",
                schema: "Core",
                table: "TempPhoneNumber");

            migrationBuilder.DropIndex(
                name: "IX_TempAddress_OwnerId",
                schema: "Core",
                table: "TempAddress");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                schema: "Core",
                table: "TempPhoneNumber");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                schema: "Core",
                table: "TempAddress");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "OwnerId",
                schema: "Core",
                table: "TempPhoneNumber",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "OwnerId",
                schema: "Core",
                table: "TempAddress",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_TempPhoneNumber_OwnerId",
                schema: "Core",
                table: "TempPhoneNumber",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_TempAddress_OwnerId",
                schema: "Core",
                table: "TempAddress",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_TempAddress_TempOwner_OwnerId",
                schema: "Core",
                table: "TempAddress",
                column: "OwnerId",
                principalSchema: "Core",
                principalTable: "TempOwner",
                principalColumn: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_TempPhoneNumber_TempOwner_OwnerId",
                schema: "Core",
                table: "TempPhoneNumber",
                column: "OwnerId",
                principalSchema: "Core",
                principalTable: "TempOwner",
                principalColumn: "OwnerId");
        }
    }
}
