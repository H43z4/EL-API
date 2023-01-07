using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HPAHistory_User_HPATerminatedByUserId",
                schema: "Core",
                table: "HPAHistory");

            migrationBuilder.DropIndex(
                name: "IX_HPAHistory_HPATerminatedByUserId",
                schema: "Core",
                table: "HPAHistory");

            migrationBuilder.DropColumn(
                name: "HPATerminatedByUserId",
                schema: "Core",
                table: "HPAHistory");

            migrationBuilder.RenameColumn(
                name: "HPATerminationDate",
                schema: "Core",
                table: "HPAHistory",
                newName: "HPAStatusDate");

            migrationBuilder.AddColumn<long>(
                name: "HPAStatusId",
                schema: "Core",
                table: "Vehicle",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "HPAStatusId",
                schema: "Core",
                table: "HPAHistory",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "HPAStatus",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HPAStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HPAStatus_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_HPAStatusId",
                schema: "Core",
                table: "Vehicle",
                column: "HPAStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_HPAHistory_HPAStatusId",
                schema: "Core",
                table: "HPAHistory",
                column: "HPAStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_HPAStatus_CreatedBy",
                schema: "Setup",
                table: "HPAStatus",
                column: "CreatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_HPAHistory_HPAStatus_HPAStatusId",
                schema: "Core",
                table: "HPAHistory",
                column: "HPAStatusId",
                principalSchema: "Setup",
                principalTable: "HPAStatus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_HPAStatus_HPAStatusId",
                schema: "Core",
                table: "Vehicle",
                column: "HPAStatusId",
                principalSchema: "Setup",
                principalTable: "HPAStatus",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HPAHistory_HPAStatus_HPAStatusId",
                schema: "Core",
                table: "HPAHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_HPAStatus_HPAStatusId",
                schema: "Core",
                table: "Vehicle");

            migrationBuilder.DropTable(
                name: "HPAStatus",
                schema: "Setup");

            migrationBuilder.DropIndex(
                name: "IX_Vehicle_HPAStatusId",
                schema: "Core",
                table: "Vehicle");

            migrationBuilder.DropIndex(
                name: "IX_HPAHistory_HPAStatusId",
                schema: "Core",
                table: "HPAHistory");

            migrationBuilder.DropColumn(
                name: "HPAStatusId",
                schema: "Core",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "HPAStatusId",
                schema: "Core",
                table: "HPAHistory");

            migrationBuilder.RenameColumn(
                name: "HPAStatusDate",
                schema: "Core",
                table: "HPAHistory",
                newName: "HPATerminationDate");

            migrationBuilder.AddColumn<long>(
                name: "HPATerminatedByUserId",
                schema: "Core",
                table: "HPAHistory",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_HPAHistory_HPATerminatedByUserId",
                schema: "Core",
                table: "HPAHistory",
                column: "HPATerminatedByUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_HPAHistory_User_HPATerminatedByUserId",
                schema: "Core",
                table: "HPAHistory",
                column: "HPATerminatedByUserId",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "UserId");
        }
    }
}
