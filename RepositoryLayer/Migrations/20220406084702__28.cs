using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _28 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dues_DuesStatus_DuesStatusId",
                schema: "Core",
                table: "Dues");

            migrationBuilder.DropTable(
                name: "DuesStatus",
                schema: "Setup");

            migrationBuilder.DropIndex(
                name: "IX_Dues_DuesStatusId",
                schema: "Core",
                table: "Dues");

            migrationBuilder.DropColumn(
                name: "DuesStatusId",
                schema: "Core",
                table: "Dues");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "DuesStatusId",
                schema: "Core",
                table: "Dues",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "DuesStatus",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DuesStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DuesStatus_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dues_DuesStatusId",
                schema: "Core",
                table: "Dues",
                column: "DuesStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_DuesStatus_CreatedBy",
                schema: "Setup",
                table: "DuesStatus",
                column: "CreatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_Dues_DuesStatus_DuesStatusId",
                schema: "Core",
                table: "Dues",
                column: "DuesStatusId",
                principalSchema: "Setup",
                principalTable: "DuesStatus",
                principalColumn: "Id");
        }
    }
}
