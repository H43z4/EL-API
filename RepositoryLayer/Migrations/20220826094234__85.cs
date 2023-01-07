using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _85 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAuctioned",
                schema: "SRNRPL",
                table: "SeriesNumberPool");

            migrationBuilder.AddColumn<long>(
                name: "SeriesNumberStatusId",
                schema: "SRNRPL",
                table: "SeriesNumberPool",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "AuctionedPrice",
                schema: "SRNRPL",
                table: "SeriesNumberDetail",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "BasePrice",
                schema: "SRNRPL",
                table: "SeriesNumberDetail",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "AuctionStatusId",
                schema: "SRNRPL",
                table: "AuctionSchedule",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "AuctionStatus",
                schema: "SRNRPL",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    table.PrimaryKey("PK_AuctionStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuctionStatus_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_AuctionStatus_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "SeriesNumberStatus",
                schema: "SRNRPL",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    table.PrimaryKey("PK_SeriesNumberStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SeriesNumberStatus_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_SeriesNumberStatus_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumberPool_SeriesNumberStatusId",
                schema: "SRNRPL",
                table: "SeriesNumberPool",
                column: "SeriesNumberStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_AuctionSchedule_AuctionStatusId",
                schema: "SRNRPL",
                table: "AuctionSchedule",
                column: "AuctionStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_AuctionStatus_CreatedBy",
                schema: "SRNRPL",
                table: "AuctionStatus",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AuctionStatus_ModifiedBy",
                schema: "SRNRPL",
                table: "AuctionStatus",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumberStatus_CreatedBy",
                schema: "SRNRPL",
                table: "SeriesNumberStatus",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumberStatus_ModifiedBy",
                schema: "SRNRPL",
                table: "SeriesNumberStatus",
                column: "ModifiedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_AuctionSchedule_AuctionStatus_AuctionStatusId",
                schema: "SRNRPL",
                table: "AuctionSchedule",
                column: "AuctionStatusId",
                principalSchema: "SRNRPL",
                principalTable: "AuctionStatus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SeriesNumberPool_SeriesNumberStatus_SeriesNumberStatusId",
                schema: "SRNRPL",
                table: "SeriesNumberPool",
                column: "SeriesNumberStatusId",
                principalSchema: "SRNRPL",
                principalTable: "SeriesNumberStatus",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuctionSchedule_AuctionStatus_AuctionStatusId",
                schema: "SRNRPL",
                table: "AuctionSchedule");

            migrationBuilder.DropForeignKey(
                name: "FK_SeriesNumberPool_SeriesNumberStatus_SeriesNumberStatusId",
                schema: "SRNRPL",
                table: "SeriesNumberPool");

            migrationBuilder.DropTable(
                name: "AuctionStatus",
                schema: "SRNRPL");

            migrationBuilder.DropTable(
                name: "SeriesNumberStatus",
                schema: "SRNRPL");

            migrationBuilder.DropIndex(
                name: "IX_SeriesNumberPool_SeriesNumberStatusId",
                schema: "SRNRPL",
                table: "SeriesNumberPool");

            migrationBuilder.DropIndex(
                name: "IX_AuctionSchedule_AuctionStatusId",
                schema: "SRNRPL",
                table: "AuctionSchedule");

            migrationBuilder.DropColumn(
                name: "SeriesNumberStatusId",
                schema: "SRNRPL",
                table: "SeriesNumberPool");

            migrationBuilder.DropColumn(
                name: "AuctionedPrice",
                schema: "SRNRPL",
                table: "SeriesNumberDetail");

            migrationBuilder.DropColumn(
                name: "BasePrice",
                schema: "SRNRPL",
                table: "SeriesNumberDetail");

            migrationBuilder.DropColumn(
                name: "AuctionStatusId",
                schema: "SRNRPL",
                table: "AuctionSchedule");

            migrationBuilder.AddColumn<bool>(
                name: "IsAuctioned",
                schema: "SRNRPL",
                table: "SeriesNumberPool",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
