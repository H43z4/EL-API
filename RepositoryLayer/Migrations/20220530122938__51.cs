using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _51 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "RegistrationNoPrice",
                schema: "Core",
                table: "VehicleAdditionalInfo",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "RegistrationNoPrice",
                schema: "Core",
                table: "AssessmentBase",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RegistrationNoPrice",
                schema: "Core",
                table: "VehicleAdditionalInfo");

            migrationBuilder.DropColumn(
                name: "RegistrationNoPrice",
                schema: "Core",
                table: "AssessmentBase");
        }
    }
}
