using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _89 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdvancePaymentStatus",
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
                    table.PrimaryKey("PK_AdvancePaymentStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdvancePaymentStatus_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_AdvancePaymentStatus_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "AdvanceReservationStatus",
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
                    table.PrimaryKey("PK_AdvanceReservationStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdvanceReservationStatus_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_AdvanceReservationStatus_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "AdvancePayment",
                schema: "SRNRPL",
                columns: table => new
                {
                    AdvancePaymentId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeriesCategoryId = table.Column<long>(type: "bigint", nullable: false),
                    SeriesId = table.Column<long>(type: "bigint", nullable: false),
                    SeriesNumberId = table.Column<long>(type: "bigint", nullable: false),
                    AdvancePaymentStatusId = table.Column<long>(type: "bigint", nullable: false),
                    ChasisNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BasePrice = table.Column<long>(type: "bigint", nullable: false),
                    PSId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PaidOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BankCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OwnerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CNIC = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    NTN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvancePayment", x => x.AdvancePaymentId);
                    table.ForeignKey(
                        name: "FK_AdvancePayment_AdvancePaymentStatus_AdvancePaymentStatusId",
                        column: x => x.AdvancePaymentStatusId,
                        principalSchema: "SRNRPL",
                        principalTable: "AdvancePaymentStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AdvancePayment_Series_SeriesId",
                        column: x => x.SeriesId,
                        principalSchema: "SRNRPL",
                        principalTable: "Series",
                        principalColumn: "SeriesId");
                    table.ForeignKey(
                        name: "FK_AdvancePayment_SeriesCategory_SeriesCategoryId",
                        column: x => x.SeriesCategoryId,
                        principalSchema: "SRNRPL",
                        principalTable: "SeriesCategory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AdvancePayment_SeriesNumber_SeriesNumberId",
                        column: x => x.SeriesNumberId,
                        principalSchema: "SRNRPL",
                        principalTable: "SeriesNumber",
                        principalColumn: "SeriesNumberId");
                    table.ForeignKey(
                        name: "FK_AdvancePayment_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_AdvancePayment_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "AdvanceReservation",
                schema: "SRNRPL",
                columns: table => new
                {
                    AdvanceReservationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdvanceReservationStatusId = table.Column<long>(type: "bigint", nullable: false),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    SeriesNumberPoolId = table.Column<long>(type: "bigint", nullable: false),
                    ChasisNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ReservePrice = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvanceReservation", x => x.AdvanceReservationId);
                    table.ForeignKey(
                        name: "FK_AdvanceReservation_AdvanceReservationStatus_AdvanceReservationStatusId",
                        column: x => x.AdvanceReservationStatusId,
                        principalSchema: "SRNRPL",
                        principalTable: "AdvanceReservationStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AdvanceReservation_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "Application",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_AdvanceReservation_SeriesNumberPool_SeriesNumberPoolId",
                        column: x => x.SeriesNumberPoolId,
                        principalSchema: "SRNRPL",
                        principalTable: "SeriesNumberPool",
                        principalColumn: "SeriesNumberPoolId");
                    table.ForeignKey(
                        name: "FK_AdvanceReservation_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_AdvanceReservation_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdvancePayment_AdvancePaymentStatusId",
                schema: "SRNRPL",
                table: "AdvancePayment",
                column: "AdvancePaymentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvancePayment_CreatedBy",
                schema: "SRNRPL",
                table: "AdvancePayment",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AdvancePayment_ModifiedBy",
                schema: "SRNRPL",
                table: "AdvancePayment",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AdvancePayment_SeriesCategoryId",
                schema: "SRNRPL",
                table: "AdvancePayment",
                column: "SeriesCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvancePayment_SeriesId",
                schema: "SRNRPL",
                table: "AdvancePayment",
                column: "SeriesId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvancePayment_SeriesNumberId",
                schema: "SRNRPL",
                table: "AdvancePayment",
                column: "SeriesNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvancePaymentStatus_CreatedBy",
                schema: "SRNRPL",
                table: "AdvancePaymentStatus",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AdvancePaymentStatus_ModifiedBy",
                schema: "SRNRPL",
                table: "AdvancePaymentStatus",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AdvanceReservation_AdvanceReservationStatusId",
                schema: "SRNRPL",
                table: "AdvanceReservation",
                column: "AdvanceReservationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvanceReservation_ApplicationId",
                schema: "SRNRPL",
                table: "AdvanceReservation",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvanceReservation_CreatedBy",
                schema: "SRNRPL",
                table: "AdvanceReservation",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AdvanceReservation_ModifiedBy",
                schema: "SRNRPL",
                table: "AdvanceReservation",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AdvanceReservation_SeriesNumberPoolId",
                schema: "SRNRPL",
                table: "AdvanceReservation",
                column: "SeriesNumberPoolId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvanceReservationStatus_CreatedBy",
                schema: "SRNRPL",
                table: "AdvanceReservationStatus",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AdvanceReservationStatus_ModifiedBy",
                schema: "SRNRPL",
                table: "AdvanceReservationStatus",
                column: "ModifiedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdvancePayment",
                schema: "SRNRPL");

            migrationBuilder.DropTable(
                name: "AdvanceReservation",
                schema: "SRNRPL");

            migrationBuilder.DropTable(
                name: "AdvancePaymentStatus",
                schema: "SRNRPL");

            migrationBuilder.DropTable(
                name: "AdvanceReservationStatus",
                schema: "SRNRPL");
        }
    }
}
