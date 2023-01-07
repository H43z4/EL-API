using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _81 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentAveragePrice",
                schema: "SRNRPL",
                table: "SeriesNumber");

            migrationBuilder.DropColumn(
                name: "DefaultBasePrice",
                schema: "SRNRPL",
                table: "SeriesNumber");

            migrationBuilder.AddColumn<long>(
                name: "AuctionedPrice",
                schema: "SRNRPL",
                table: "SeriesNumberPool",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SeriesNumberDetail",
                schema: "SRNRPL",
                columns: table => new
                {
                    SeriesNumberDetailId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeriesCategoryId = table.Column<long>(type: "bigint", nullable: false),
                    SeriesNumberId = table.Column<long>(type: "bigint", nullable: false),
                    IsAttractive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeriesNumberDetail", x => x.SeriesNumberDetailId);
                    table.ForeignKey(
                        name: "FK_SeriesNumberDetail_SeriesCategory_SeriesCategoryId",
                        column: x => x.SeriesCategoryId,
                        principalSchema: "SRNRPL",
                        principalTable: "SeriesCategory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SeriesNumberDetail_SeriesNumber_SeriesNumberId",
                        column: x => x.SeriesNumberId,
                        principalSchema: "SRNRPL",
                        principalTable: "SeriesNumber",
                        principalColumn: "SeriesNumberId");
                    table.ForeignKey(
                        name: "FK_SeriesNumberDetail_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_SeriesNumberDetail_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumberDetail_CreatedBy",
                schema: "SRNRPL",
                table: "SeriesNumberDetail",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumberDetail_ModifiedBy",
                schema: "SRNRPL",
                table: "SeriesNumberDetail",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumberDetail_SeriesCategoryId",
                schema: "SRNRPL",
                table: "SeriesNumberDetail",
                column: "SeriesCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumberDetail_SeriesNumberId",
                schema: "SRNRPL",
                table: "SeriesNumberDetail",
                column: "SeriesNumberId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SeriesNumberDetail",
                schema: "SRNRPL");

            migrationBuilder.DropColumn(
                name: "AuctionedPrice",
                schema: "SRNRPL",
                table: "SeriesNumberPool");

            migrationBuilder.AddColumn<long>(
                name: "CurrentAveragePrice",
                schema: "SRNRPL",
                table: "SeriesNumber",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "DefaultBasePrice",
                schema: "SRNRPL",
                table: "SeriesNumber",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
