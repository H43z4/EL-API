using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class MVRS_202301091001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "totalAllocation",
                schema: "Core",
                table: "PermitApplicationDetail",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "StockInApplication",
                schema: "Core",
                columns: table => new
                {
                    StockInApplicationId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganisationId = table.Column<long>(type: "bigint", nullable: false),
                    ExcisePassNo = table.Column<long>(type: "bigint", nullable: false),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TransportExportNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConsignmentFromId = table.Column<long>(type: "bigint", nullable: false),
                    PermitNo = table.Column<long>(type: "bigint", nullable: false),
                    PassValidity = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VehicleRegistrationNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SignedByCollector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RateOfDauty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AmountOfDautyLevied = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChNoDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockInApplication", x => x.StockInApplicationId);
                    table.ForeignKey(
                        name: "FK_StockInApplication_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_StockInApplication_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "StockInApplicationDetails",
                schema: "Core",
                columns: table => new
                {
                    ApplicationDetailId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StockInApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    BottleSizeId = table.Column<long>(type: "bigint", nullable: false),
                    Quantity = table.Column<long>(type: "bigint", nullable: false),
                    BulkGallons = table.Column<long>(type: "bigint", nullable: false),
                    StrenghtPercentage = table.Column<long>(type: "bigint", nullable: false),
                    ProofGallons = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockInApplicationDetails", x => x.ApplicationDetailId);
                    table.ForeignKey(
                        name: "FK_StockInApplicationDetails_StockInApplication_StockInApplicationId",
                        column: x => x.StockInApplicationId,
                        principalSchema: "Core",
                        principalTable: "StockInApplication",
                        principalColumn: "StockInApplicationId");
                    table.ForeignKey(
                        name: "FK_StockInApplicationDetails_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_StockInApplicationDetails_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_StockInApplication_CreatedBy",
                schema: "Core",
                table: "StockInApplication",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_StockInApplication_ModifiedBy",
                schema: "Core",
                table: "StockInApplication",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_StockInApplicationDetails_CreatedBy",
                schema: "Core",
                table: "StockInApplicationDetails",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_StockInApplicationDetails_ModifiedBy",
                schema: "Core",
                table: "StockInApplicationDetails",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_StockInApplicationDetails_StockInApplicationId",
                schema: "Core",
                table: "StockInApplicationDetails",
                column: "StockInApplicationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StockInApplicationDetails",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "StockInApplication",
                schema: "Core");

            migrationBuilder.DropColumn(
                name: "totalAllocation",
                schema: "Core",
                table: "PermitApplicationDetail");
        }
    }
}
