using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class MVRS_202301091738 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FullName",
                schema: "Setup",
                table: "EPRSUser",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EPRSUserRole",
                schema: "Setup",
                columns: table => new
                {
                    UserRoleId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EPRSUserRole", x => x.UserRoleId);
                    table.ForeignKey(
                        name: "FK_EPRSUserRole_EPRSRole_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Setup",
                        principalTable: "EPRSRole",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EPRSUserRole_EPRSUser_UserId",
                        column: x => x.UserId,
                        principalSchema: "Setup",
                        principalTable: "EPRSUser",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_EPRSUserRole_RoleId",
                schema: "Setup",
                table: "EPRSUserRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_EPRSUserRole_UserId",
                schema: "Setup",
                table: "EPRSUserRole",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EPRSUserRole",
                schema: "Setup");

            migrationBuilder.DropColumn(
                name: "FullName",
                schema: "Setup",
                table: "EPRSUser");
        }
    }
}
