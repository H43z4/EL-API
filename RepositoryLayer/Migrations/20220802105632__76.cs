using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _76 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "BusinessTableAccessId",
                schema: "Setup",
                table: "BusinessTableAccessLevel",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BusinessTableAccess",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccessLevel = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_BusinessTableAccess", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessTableAccess_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_BusinessTableAccess_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTableAccessLevel_BusinessTableAccessId",
                schema: "Setup",
                table: "BusinessTableAccessLevel",
                column: "BusinessTableAccessId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTableAccess_CreatedBy",
                schema: "Setup",
                table: "BusinessTableAccess",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTableAccess_ModifiedBy",
                schema: "Setup",
                table: "BusinessTableAccess",
                column: "ModifiedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessTableAccessLevel_BusinessTableAccess_BusinessTableAccessId",
                schema: "Setup",
                table: "BusinessTableAccessLevel",
                column: "BusinessTableAccessId",
                principalSchema: "Setup",
                principalTable: "BusinessTableAccess",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BusinessTableAccessLevel_BusinessTableAccess_BusinessTableAccessId",
                schema: "Setup",
                table: "BusinessTableAccessLevel");

            migrationBuilder.DropTable(
                name: "BusinessTableAccess",
                schema: "Setup");

            migrationBuilder.DropIndex(
                name: "IX_BusinessTableAccessLevel_BusinessTableAccessId",
                schema: "Setup",
                table: "BusinessTableAccessLevel");

            migrationBuilder.DropColumn(
                name: "BusinessTableAccessId",
                schema: "Setup",
                table: "BusinessTableAccessLevel");
        }
    }
}
