using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _88 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Application_Owner_SellerId",
                schema: "epay",
                table: "Application");

            migrationBuilder.DropIndex(
                name: "IX_Application_SellerId1",
                schema: "epay",
                table: "Application");

            migrationBuilder.DropColumn(
                name: "SellerId",
                schema: "epay",
                table: "Application");

            migrationBuilder.AddColumn<long>(
                name: "SiteOfficeId",
                schema: "Auth",
                table: "User",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "SiteOfficeId",
                schema: "epay",
                table: "Application",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "SiteOffice",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistrictId = table.Column<long>(type: "bigint", nullable: false),
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
                    table.PrimaryKey("PK_SiteOffice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SiteOffice_District_DistrictId",
                        column: x => x.DistrictId,
                        principalSchema: "Setup",
                        principalTable: "District",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SiteOffice_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_SiteOffice_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Application_SiteOfficeId",
                schema: "epay",
                table: "Application",
                column: "SiteOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_SiteOffice_CreatedBy",
                table: "SiteOffice",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SiteOffice_DistrictId",
                table: "SiteOffice",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_SiteOffice_ModifiedBy",
                table: "SiteOffice",
                column: "ModifiedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_Application_SiteOffice_SiteOfficeId",
                schema: "epay",
                table: "Application",
                column: "SiteOfficeId",
                principalTable: "SiteOffice",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Application_SiteOffice_SiteOfficeId",
                schema: "epay",
                table: "Application");

            migrationBuilder.DropTable(
                name: "SiteOffice");

            migrationBuilder.DropIndex(
                name: "IX_Application_SiteOfficeId",
                schema: "epay",
                table: "Application");

            migrationBuilder.DropColumn(
                name: "SiteOfficeId",
                schema: "Auth",
                table: "User");

            migrationBuilder.DropColumn(
                name: "SiteOfficeId",
                schema: "epay",
                table: "Application");

            migrationBuilder.AddColumn<long>(
                name: "SellerId",
                schema: "epay",
                table: "Application",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Application_SellerId1",
                schema: "epay",
                table: "Application",
                column: "SellerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Application_Owner_SellerId",
                schema: "epay",
                table: "Application",
                column: "SellerId",
                principalSchema: "epay",
                principalTable: "Owner",
                principalColumn: "OwnerId");
        }
    }
}
