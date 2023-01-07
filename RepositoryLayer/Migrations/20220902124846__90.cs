using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _90 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AdvanceReservation",
                schema: "SRNRPL",
                table: "AdvanceReservation");

            migrationBuilder.DropColumn(
                name: "AdvanceReservationId",
                schema: "SRNRPL",
                table: "AdvanceReservation");

            migrationBuilder.AddColumn<long>(
                name: "AdvanceResId",
                schema: "SRNRPL",
                table: "AdvanceReservation",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdvanceReservation",
                schema: "SRNRPL",
                table: "AdvanceReservation",
                column: "AdvanceResId");

            migrationBuilder.CreateTable(
                name: "FilerData",
                schema: "Payments",
                columns: table => new
                {
                    FilerDataId = table.Column<long>(type: "bigint", nullable: false)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilerData",
                schema: "Payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdvanceReservation",
                schema: "SRNRPL",
                table: "AdvanceReservation");

            migrationBuilder.DropColumn(
                name: "AdvanceResId",
                schema: "SRNRPL",
                table: "AdvanceReservation");

            migrationBuilder.AddColumn<int>(
                name: "AdvanceReservationId",
                schema: "SRNRPL",
                table: "AdvanceReservation",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdvanceReservation",
                schema: "SRNRPL",
                table: "AdvanceReservation",
                column: "AdvanceReservationId");
        }
    }
}
