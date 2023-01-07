using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _92 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilerData",
                schema: "Payments");

            migrationBuilder.CreateTable(
                name: "ActiveTaxPayer",
                schema: "Payments",
                columns: table => new
                {
                    ActiveTaxPayerId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CNIC = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    NTN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    FTN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    FilerName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActiveTaxPayer", x => x.ActiveTaxPayerId);
                    table.ForeignKey(
                        name: "FK_ActiveTaxPayer_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_ActiveTaxPayer_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActiveTaxPayer_CreatedBy",
                schema: "Payments",
                table: "ActiveTaxPayer",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ActiveTaxPayer_ModifiedBy",
                schema: "Payments",
                table: "ActiveTaxPayer",
                column: "ModifiedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActiveTaxPayer",
                schema: "Payments");

            migrationBuilder.CreateTable(
                name: "FilerData",
                schema: "Payments",
                columns: table => new
                {
                    FilerDataId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CNIC = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    FTN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    FilerName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    NTN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilerData", x => x.FilerDataId);
                    table.ForeignKey(
                        name: "FK_FilerData_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_FilerData_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_FilerData_CreatedBy",
                schema: "Payments",
                table: "FilerData",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FilerData_ModifiedBy",
                schema: "Payments",
                table: "FilerData",
                column: "ModifiedBy");
        }
    }
}
