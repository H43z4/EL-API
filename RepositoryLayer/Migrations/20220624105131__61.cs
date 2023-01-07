using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _61 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "SellerId",
                schema: "Core",
                table: "Application",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "VehicleOwnershipHistory",
                schema: "Core",
                columns: table => new
                {
                    VehicleOwnershipHistoryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    SellerId = table.Column<long>(type: "bigint", nullable: true),
                    BuyerId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessProcessId = table.Column<long>(type: "bigint", nullable: false),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    EffectedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleOwnershipHistory", x => x.VehicleOwnershipHistoryId);
                    table.ForeignKey(
                        name: "FK_VehicleOwnershipHistory_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "Application",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_VehicleOwnershipHistory_BusinessProcess_BusinessProcessId",
                        column: x => x.BusinessProcessId,
                        principalSchema: "Setup",
                        principalTable: "BusinessProcess",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleOwnershipHistory_Owner_BuyerId",
                        column: x => x.BuyerId,
                        principalSchema: "Core",
                        principalTable: "Owner",
                        principalColumn: "OwnerId");
                    table.ForeignKey(
                        name: "FK_VehicleOwnershipHistory_Owner_SellerId",
                        column: x => x.SellerId,
                        principalSchema: "Core",
                        principalTable: "Owner",
                        principalColumn: "OwnerId");
                    table.ForeignKey(
                        name: "FK_VehicleOwnershipHistory_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleOwnershipHistory_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalSchema: "Core",
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Application_SellerId",
                schema: "Core",
                table: "Application",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleOwnershipHistory_ApplicationId",
                schema: "Core",
                table: "VehicleOwnershipHistory",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleOwnershipHistory_BusinessProcessId",
                schema: "Core",
                table: "VehicleOwnershipHistory",
                column: "BusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleOwnershipHistory_BuyerId",
                schema: "Core",
                table: "VehicleOwnershipHistory",
                column: "BuyerId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleOwnershipHistory_CreatedBy",
                schema: "Core",
                table: "VehicleOwnershipHistory",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleOwnershipHistory_SellerId",
                schema: "Core",
                table: "VehicleOwnershipHistory",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleOwnershipHistory_VehicleId",
                schema: "Core",
                table: "VehicleOwnershipHistory",
                column: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Application_Owner_SellerId",
                schema: "Core",
                table: "Application",
                column: "SellerId",
                principalSchema: "Core",
                principalTable: "Owner",
                principalColumn: "OwnerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Application_Owner_SellerId",
                schema: "Core",
                table: "Application");

            migrationBuilder.DropTable(
                name: "VehicleOwnershipHistory",
                schema: "Core");

            migrationBuilder.DropIndex(
                name: "IX_Application_SellerId",
                schema: "Core",
                table: "Application");

            migrationBuilder.DropColumn(
                name: "SellerId",
                schema: "Core",
                table: "Application");
        }
    }
}
