using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _91 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AdvanceResId",
                schema: "SRNRPL",
                table: "AdvanceReservation",
                newName: "AdvanceReservationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AdvanceReservationId",
                schema: "SRNRPL",
                table: "AdvanceReservation",
                newName: "AdvanceResId");
        }
    }
}
