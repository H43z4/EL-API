using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class setup2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CityId",
                schema: "Core",
                table: "PermitIssueApplication",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ProfessionId",
                schema: "Core",
                table: "PermitIssueApplication",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfessionName",
                schema: "Core",
                table: "PermitIssueApplication",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Profession",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profession", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PermitIssueApplication_CityId",
                schema: "Core",
                table: "PermitIssueApplication",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_PermitIssueApplication_DistrictId",
                schema: "Core",
                table: "PermitIssueApplication",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_PermitIssueApplication_ProfessionId",
                schema: "Core",
                table: "PermitIssueApplication",
                column: "ProfessionId");

            migrationBuilder.AddForeignKey(
                name: "FK_PermitIssueApplication_City_CityId",
                schema: "Core",
                table: "PermitIssueApplication",
                column: "CityId",
                principalSchema: "Setup",
                principalTable: "City",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PermitIssueApplication_District_DistrictId",
                schema: "Core",
                table: "PermitIssueApplication",
                column: "DistrictId",
                principalSchema: "Setup",
                principalTable: "District",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PermitIssueApplication_Profession_ProfessionId",
                schema: "Core",
                table: "PermitIssueApplication",
                column: "ProfessionId",
                principalSchema: "Setup",
                principalTable: "Profession",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PermitIssueApplication_City_CityId",
                schema: "Core",
                table: "PermitIssueApplication");

            migrationBuilder.DropForeignKey(
                name: "FK_PermitIssueApplication_District_DistrictId",
                schema: "Core",
                table: "PermitIssueApplication");

            migrationBuilder.DropForeignKey(
                name: "FK_PermitIssueApplication_Profession_ProfessionId",
                schema: "Core",
                table: "PermitIssueApplication");

            migrationBuilder.DropTable(
                name: "Profession",
                schema: "Setup");

            migrationBuilder.DropIndex(
                name: "IX_PermitIssueApplication_CityId",
                schema: "Core",
                table: "PermitIssueApplication");

            migrationBuilder.DropIndex(
                name: "IX_PermitIssueApplication_DistrictId",
                schema: "Core",
                table: "PermitIssueApplication");

            migrationBuilder.DropIndex(
                name: "IX_PermitIssueApplication_ProfessionId",
                schema: "Core",
                table: "PermitIssueApplication");

            migrationBuilder.DropColumn(
                name: "CityId",
                schema: "Core",
                table: "PermitIssueApplication");

            migrationBuilder.DropColumn(
                name: "ProfessionId",
                schema: "Core",
                table: "PermitIssueApplication");

            migrationBuilder.DropColumn(
                name: "ProfessionName",
                schema: "Core",
                table: "PermitIssueApplication");
        }
    }
}
