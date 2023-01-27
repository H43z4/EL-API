using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class pr2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SponsorCompanyNTN",
                schema: "Core",
                table: "PermitIssueApplication",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SponsorCompanyName",
                schema: "Core",
                table: "PermitIssueApplication",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SponsorPersonCNIC",
                schema: "Core",
                table: "PermitIssueApplication",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SponsorPersonName",
                schema: "Core",
                table: "PermitIssueApplication",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "SponsorTypeID",
                schema: "Core",
                table: "PermitIssueApplication",
                type: "bigint",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SponsorCompanyNTN",
                schema: "Core",
                table: "PermitIssueApplication");

            migrationBuilder.DropColumn(
                name: "SponsorCompanyName",
                schema: "Core",
                table: "PermitIssueApplication");

            migrationBuilder.DropColumn(
                name: "SponsorPersonCNIC",
                schema: "Core",
                table: "PermitIssueApplication");

            migrationBuilder.DropColumn(
                name: "SponsorPersonName",
                schema: "Core",
                table: "PermitIssueApplication");

            migrationBuilder.DropColumn(
                name: "SponsorTypeID",
                schema: "Core",
                table: "PermitIssueApplication");
        }
    }
}
