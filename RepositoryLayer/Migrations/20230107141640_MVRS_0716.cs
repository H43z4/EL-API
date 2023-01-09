using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class MVRS_0716 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "EPRSPerson",
                newName: "EPRSPerson",
                newSchema: "Core");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "EPRSPerson",
                schema: "Core",
                newName: "EPRSPerson");
        }
    }
}
