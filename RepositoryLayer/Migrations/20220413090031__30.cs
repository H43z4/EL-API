using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _30 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "SeriesNumberPool");

            migrationBuilder.AlterColumn<string>(
                name: "ChasisNo",
                schema: "Core",
                table: "Vehicle",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumberValue",
                schema: "Core",
                table: "PhoneNumber",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.CreateTable(
                name: "SeriesCategory",
                schema: "SeriesNumberPool",
                columns: table => new
                {
                    SeriesCategoryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeriesCategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeriesCategory", x => x.SeriesCategoryId);
                    table.ForeignKey(
                        name: "FK_SeriesCategory_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "SeriesStatus",
                schema: "SeriesNumberPool",
                columns: table => new
                {
                    SeriesStatusId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeriesStatusName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeriesStatus", x => x.SeriesStatusId);
                    table.ForeignKey(
                        name: "FK_SeriesStatus_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "SeriesType",
                schema: "SeriesNumberPool",
                columns: table => new
                {
                    SeriesTypeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeriesTypeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeriesType", x => x.SeriesTypeId);
                    table.ForeignKey(
                        name: "FK_SeriesType_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "SeriesNumber",
                schema: "SeriesNumberPool",
                columns: table => new
                {
                    SeriesNumberId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeriesNumberName = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DefaultBasePrice = table.Column<long>(type: "bigint", nullable: false),
                    CurrentAveragePrice = table.Column<long>(type: "bigint", nullable: false),
                    SeriesCategoryId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeriesNumber", x => x.SeriesNumberId);
                    table.ForeignKey(
                        name: "FK_SeriesNumber_SeriesCategory_SeriesCategoryId",
                        column: x => x.SeriesCategoryId,
                        principalSchema: "SeriesNumberPool",
                        principalTable: "SeriesCategory",
                        principalColumn: "SeriesCategoryId");
                    table.ForeignKey(
                        name: "FK_SeriesNumber_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Series",
                schema: "SeriesNumberPool",
                columns: table => new
                {
                    SeriesId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeriesTypeId = table.Column<long>(type: "bigint", nullable: false),
                    SeriesCategoryId = table.Column<long>(type: "bigint", nullable: false),
                    SeriesStatusId = table.Column<long>(type: "bigint", nullable: false),
                    SeriesName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    RegStartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegEndDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AuctionStartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AuctionEndDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.SeriesId);
                    table.ForeignKey(
                        name: "FK_Series_SeriesCategory_SeriesCategoryId",
                        column: x => x.SeriesCategoryId,
                        principalSchema: "SeriesNumberPool",
                        principalTable: "SeriesCategory",
                        principalColumn: "SeriesCategoryId");
                    table.ForeignKey(
                        name: "FK_Series_SeriesStatus_SeriesStatusId",
                        column: x => x.SeriesStatusId,
                        principalSchema: "SeriesNumberPool",
                        principalTable: "SeriesStatus",
                        principalColumn: "SeriesStatusId");
                    table.ForeignKey(
                        name: "FK_Series_SeriesType_SeriesTypeId",
                        column: x => x.SeriesTypeId,
                        principalSchema: "SeriesNumberPool",
                        principalTable: "SeriesType",
                        principalColumn: "SeriesTypeId");
                    table.ForeignKey(
                        name: "FK_Series_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "SeriesNumberPool",
                schema: "SeriesNumberPool",
                columns: table => new
                {
                    SeriesNumberPoolId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeriesCategoryId = table.Column<long>(type: "bigint", nullable: false),
                    SeriesId = table.Column<long>(type: "bigint", nullable: false),
                    SeriesNumberId = table.Column<long>(type: "bigint", nullable: false),
                    BasePrice = table.Column<long>(type: "bigint", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsBlocked = table.Column<bool>(type: "bit", nullable: false),
                    IsAuctioned = table.Column<bool>(type: "bit", nullable: false),
                    IsReserved = table.Column<bool>(type: "bit", nullable: false),
                    IsAlloted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeriesNumberPool", x => x.SeriesNumberPoolId);
                    table.ForeignKey(
                        name: "FK_SeriesNumberPool_Series_SeriesId",
                        column: x => x.SeriesId,
                        principalSchema: "SeriesNumberPool",
                        principalTable: "Series",
                        principalColumn: "SeriesId");
                    table.ForeignKey(
                        name: "FK_SeriesNumberPool_SeriesCategory_SeriesCategoryId",
                        column: x => x.SeriesCategoryId,
                        principalSchema: "SeriesNumberPool",
                        principalTable: "SeriesCategory",
                        principalColumn: "SeriesCategoryId");
                    table.ForeignKey(
                        name: "FK_SeriesNumberPool_SeriesNumber_SeriesNumberId",
                        column: x => x.SeriesNumberId,
                        principalSchema: "SeriesNumberPool",
                        principalTable: "SeriesNumber",
                        principalColumn: "SeriesNumberId");
                    table.ForeignKey(
                        name: "FK_SeriesNumberPool_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "SeriesStatusHistory",
                schema: "SeriesNumberPool",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeriesId = table.Column<long>(type: "bigint", nullable: false),
                    SeriesStatusId = table.Column<long>(type: "bigint", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeriesStatusHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SeriesStatusHistory_Series_SeriesId",
                        column: x => x.SeriesId,
                        principalSchema: "SeriesNumberPool",
                        principalTable: "Series",
                        principalColumn: "SeriesId");
                    table.ForeignKey(
                        name: "FK_SeriesStatusHistory_SeriesStatus_SeriesStatusId",
                        column: x => x.SeriesStatusId,
                        principalSchema: "SeriesNumberPool",
                        principalTable: "SeriesStatus",
                        principalColumn: "SeriesStatusId");
                    table.ForeignKey(
                        name: "FK_SeriesStatusHistory_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "AuctionResult",
                schema: "SeriesNumberPool",
                columns: table => new
                {
                    AuctionResultId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeriesNumberPoolId = table.Column<long>(type: "bigint", nullable: false),
                    AuctionedValue = table.Column<long>(type: "bigint", nullable: false),
                    WinnerAIN = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ChasisNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OwnerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    WinnerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FatherHusbandName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CNIC = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    NTN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuctionResult", x => x.AuctionResultId);
                    table.ForeignKey(
                        name: "FK_AuctionResult_SeriesNumberPool_SeriesNumberPoolId",
                        column: x => x.SeriesNumberPoolId,
                        principalSchema: "SeriesNumberPool",
                        principalTable: "SeriesNumberPool",
                        principalColumn: "SeriesNumberPoolId");
                    table.ForeignKey(
                        name: "FK_AuctionResult_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuctionResult_CreatedBy",
                schema: "SeriesNumberPool",
                table: "AuctionResult",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AuctionResult_SeriesNumberPoolId",
                schema: "SeriesNumberPool",
                table: "AuctionResult",
                column: "SeriesNumberPoolId");

            migrationBuilder.CreateIndex(
                name: "IX_AuctionResult_WinnerAIN",
                schema: "SeriesNumberPool",
                table: "AuctionResult",
                column: "WinnerAIN",
                unique: true,
                filter: "[WinnerAIN] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Series_CreatedBy",
                schema: "SeriesNumberPool",
                table: "Series",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Series_SeriesCategoryId_SeriesName",
                schema: "SeriesNumberPool",
                table: "Series",
                columns: new[] { "SeriesCategoryId", "SeriesName" },
                unique: true,
                filter: "[SeriesName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Series_SeriesStatusId",
                schema: "SeriesNumberPool",
                table: "Series",
                column: "SeriesStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Series_SeriesTypeId",
                schema: "SeriesNumberPool",
                table: "Series",
                column: "SeriesTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesCategory_CreatedBy",
                schema: "SeriesNumberPool",
                table: "SeriesCategory",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesCategory_SeriesCategoryName",
                schema: "SeriesNumberPool",
                table: "SeriesCategory",
                column: "SeriesCategoryName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumber_CreatedBy",
                schema: "SeriesNumberPool",
                table: "SeriesNumber",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumber_SeriesCategoryId_SeriesNumberName",
                schema: "SeriesNumberPool",
                table: "SeriesNumber",
                columns: new[] { "SeriesCategoryId", "SeriesNumberName" },
                unique: true,
                filter: "[SeriesNumberName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumberPool_CreatedBy",
                schema: "SeriesNumberPool",
                table: "SeriesNumberPool",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumberPool_SeriesCategoryId_SeriesId_SeriesNumberId",
                schema: "SeriesNumberPool",
                table: "SeriesNumberPool",
                columns: new[] { "SeriesCategoryId", "SeriesId", "SeriesNumberId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumberPool_SeriesId",
                schema: "SeriesNumberPool",
                table: "SeriesNumberPool",
                column: "SeriesId");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumberPool_SeriesNumberId",
                schema: "SeriesNumberPool",
                table: "SeriesNumberPool",
                column: "SeriesNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesStatus_CreatedBy",
                schema: "SeriesNumberPool",
                table: "SeriesStatus",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesStatus_SeriesStatusName",
                schema: "SeriesNumberPool",
                table: "SeriesStatus",
                column: "SeriesStatusName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SeriesStatusHistory_CreatedBy",
                schema: "SeriesNumberPool",
                table: "SeriesStatusHistory",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesStatusHistory_SeriesId",
                schema: "SeriesNumberPool",
                table: "SeriesStatusHistory",
                column: "SeriesId");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesStatusHistory_SeriesStatusId",
                schema: "SeriesNumberPool",
                table: "SeriesStatusHistory",
                column: "SeriesStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesType_CreatedBy",
                schema: "SeriesNumberPool",
                table: "SeriesType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesType_SeriesTypeName",
                schema: "SeriesNumberPool",
                table: "SeriesType",
                column: "SeriesTypeName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuctionResult",
                schema: "SeriesNumberPool");

            migrationBuilder.DropTable(
                name: "SeriesStatusHistory",
                schema: "SeriesNumberPool");

            migrationBuilder.DropTable(
                name: "SeriesNumberPool",
                schema: "SeriesNumberPool");

            migrationBuilder.DropTable(
                name: "Series",
                schema: "SeriesNumberPool");

            migrationBuilder.DropTable(
                name: "SeriesNumber",
                schema: "SeriesNumberPool");

            migrationBuilder.DropTable(
                name: "SeriesStatus",
                schema: "SeriesNumberPool");

            migrationBuilder.DropTable(
                name: "SeriesType",
                schema: "SeriesNumberPool");

            migrationBuilder.DropTable(
                name: "SeriesCategory",
                schema: "SeriesNumberPool");

            migrationBuilder.AlterColumn<string>(
                name: "ChasisNo",
                schema: "Core",
                table: "Vehicle",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumberValue",
                schema: "Core",
                table: "PhoneNumber",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
