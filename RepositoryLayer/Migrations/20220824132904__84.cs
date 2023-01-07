using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _84 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SeriesStatusHistory",
                schema: "SRNRPL");

            migrationBuilder.DropColumn(
                name: "AuctionEndDateTime",
                schema: "SRNRPL",
                table: "Series");

            migrationBuilder.DropColumn(
                name: "AuctionStartDateTime",
                schema: "SRNRPL",
                table: "Series");

            migrationBuilder.DropColumn(
                name: "RegEndDateTime",
                schema: "SRNRPL",
                table: "Series");

            migrationBuilder.DropColumn(
                name: "RegStartDateTime",
                schema: "SRNRPL",
                table: "Series");

            migrationBuilder.CreateTable(
                name: "AuctionSchedule",
                schema: "SRNRPL",
                columns: table => new
                {
                    AuctionScheduleId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeriesId = table.Column<long>(type: "bigint", nullable: false),
                    RegStartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegEndDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AuctionStartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AuctionEndDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuctionSchedule", x => x.AuctionScheduleId);
                    table.ForeignKey(
                        name: "FK_AuctionSchedule_Series_SeriesId",
                        column: x => x.SeriesId,
                        principalSchema: "SRNRPL",
                        principalTable: "Series",
                        principalColumn: "SeriesId");
                    table.ForeignKey(
                        name: "FK_AuctionSchedule_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_AuctionSchedule_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuctionSchedule_CreatedBy",
                schema: "SRNRPL",
                table: "AuctionSchedule",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AuctionSchedule_ModifiedBy",
                schema: "SRNRPL",
                table: "AuctionSchedule",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AuctionSchedule_SeriesId",
                schema: "SRNRPL",
                table: "AuctionSchedule",
                column: "SeriesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuctionSchedule",
                schema: "SRNRPL");

            migrationBuilder.AddColumn<DateTime>(
                name: "AuctionEndDateTime",
                schema: "SRNRPL",
                table: "Series",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "AuctionStartDateTime",
                schema: "SRNRPL",
                table: "Series",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "RegEndDateTime",
                schema: "SRNRPL",
                table: "Series",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "RegStartDateTime",
                schema: "SRNRPL",
                table: "Series",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "SeriesStatusHistory",
                schema: "SRNRPL",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comments = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    SeriesId = table.Column<long>(type: "bigint", nullable: false),
                    SeriesStatusId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeriesStatusHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SeriesStatusHistory_Series_SeriesId",
                        column: x => x.SeriesId,
                        principalSchema: "SRNRPL",
                        principalTable: "Series",
                        principalColumn: "SeriesId");
                    table.ForeignKey(
                        name: "FK_SeriesStatusHistory_SeriesStatus_SeriesStatusId",
                        column: x => x.SeriesStatusId,
                        principalSchema: "SRNRPL",
                        principalTable: "SeriesStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SeriesStatusHistory_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_SeriesStatusHistory_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SeriesStatusHistory_CreatedBy",
                schema: "SRNRPL",
                table: "SeriesStatusHistory",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesStatusHistory_ModifiedBy",
                schema: "SRNRPL",
                table: "SeriesStatusHistory",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesStatusHistory_SeriesId",
                schema: "SRNRPL",
                table: "SeriesStatusHistory",
                column: "SeriesId");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesStatusHistory_SeriesStatusId",
                schema: "SRNRPL",
                table: "SeriesStatusHistory",
                column: "SeriesStatusId");
        }
    }
}
