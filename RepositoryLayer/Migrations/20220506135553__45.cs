using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _45 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "UserDistrictId",
                schema: "Auth",
                table: "User",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_UserDistrictId",
                schema: "Auth",
                table: "User",
                column: "UserDistrictId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_District_UserDistrictId",
                schema: "Auth",
                table: "User",
                column: "UserDistrictId",
                principalSchema: "Setup",
                principalTable: "District",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_District_UserDistrictId",
                schema: "Auth",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_UserDistrictId",
                schema: "Auth",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UserDistrictId",
                schema: "Auth",
                table: "User");
        }
    }
}
