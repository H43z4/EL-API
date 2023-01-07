using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Tehsil",
                newName: "Tehsil",
                newSchema: "Setup");

            migrationBuilder.RenameTable(
                name: "ApplicationPhase",
                newName: "ApplicationPhase",
                newSchema: "Setup");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Tehsil",
                schema: "Setup",
                newName: "Tehsil");

            migrationBuilder.RenameTable(
                name: "ApplicationPhase",
                schema: "Setup",
                newName: "ApplicationPhase");
        }
    }
}
