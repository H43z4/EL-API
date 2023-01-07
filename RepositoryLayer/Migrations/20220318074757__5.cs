using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TempKeeper",
                schema: "Core",
                columns: table => new
                {
                    KeeperId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    KeeperPersonId = table.Column<long>(type: "bigint", nullable: true),
                    KeeperBusinessId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TempKeeper", x => x.KeeperId);
                    table.ForeignKey(
                        name: "FK_TempKeeper_TempApplication_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "TempApplication",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_TempKeeper_TempBusiness_KeeperBusinessId",
                        column: x => x.KeeperBusinessId,
                        principalSchema: "Core",
                        principalTable: "TempBusiness",
                        principalColumn: "BusinessId");
                    table.ForeignKey(
                        name: "FK_TempKeeper_TempPerson_KeeperPersonId",
                        column: x => x.KeeperPersonId,
                        principalSchema: "Core",
                        principalTable: "TempPerson",
                        principalColumn: "PersonId");
                    table.ForeignKey(
                        name: "FK_TempKeeper_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_TempKeeper_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalSchema: "Core",
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TempKeeper_ApplicationId",
                schema: "Core",
                table: "TempKeeper",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_TempKeeper_CreatedBy",
                schema: "Core",
                table: "TempKeeper",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TempKeeper_KeeperBusinessId",
                schema: "Core",
                table: "TempKeeper",
                column: "KeeperBusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_TempKeeper_KeeperPersonId",
                schema: "Core",
                table: "TempKeeper",
                column: "KeeperPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_TempKeeper_VehicleId",
                schema: "Core",
                table: "TempKeeper",
                column: "VehicleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TempKeeper",
                schema: "Core");
        }
    }
}
