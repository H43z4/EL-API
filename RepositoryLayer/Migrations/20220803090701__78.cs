using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _78 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payment",
                schema: "Core");

            migrationBuilder.EnsureSchema(
                name: "Payments");

            migrationBuilder.RenameTable(
                name: "Challan",
                schema: "Core",
                newName: "Challan",
                newSchema: "Payments");

            migrationBuilder.CreateTable(
                name: "PaymentInfo",
                schema: "Payments",
                columns: table => new
                {
                    PaymentInfoId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChallanId = table.Column<long>(type: "bigint", nullable: false),
                    PaymentModeId = table.Column<long>(type: "bigint", nullable: false),
                    PaymentStatusId = table.Column<long>(type: "bigint", nullable: false),
                    PSId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AmountPaid = table.Column<long>(type: "bigint", nullable: false),
                    PaidOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BankCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CashReceivedBy = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentInfo", x => x.PaymentInfoId);
                    table.ForeignKey(
                        name: "FK_PaymentInfo_Challan_ChallanId",
                        column: x => x.ChallanId,
                        principalSchema: "Payments",
                        principalTable: "Challan",
                        principalColumn: "ChallanId");
                    table.ForeignKey(
                        name: "FK_PaymentInfo_PaymentMode_PaymentModeId",
                        column: x => x.PaymentModeId,
                        principalSchema: "Setup",
                        principalTable: "PaymentMode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PaymentInfo_PaymentStatus_PaymentStatusId",
                        column: x => x.PaymentStatusId,
                        principalSchema: "Setup",
                        principalTable: "PaymentStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PaymentInfo_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_PaymentInfo_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PaymentInfo_ChallanId",
                schema: "Payments",
                table: "PaymentInfo",
                column: "ChallanId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentInfo_CreatedBy",
                schema: "Payments",
                table: "PaymentInfo",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentInfo_ModifiedBy",
                schema: "Payments",
                table: "PaymentInfo",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentInfo_PaymentModeId",
                schema: "Payments",
                table: "PaymentInfo",
                column: "PaymentModeId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentInfo_PaymentStatusId",
                schema: "Payments",
                table: "PaymentInfo",
                column: "PaymentStatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentInfo",
                schema: "Payments");

            migrationBuilder.RenameTable(
                name: "Challan",
                schema: "Payments",
                newName: "Challan",
                newSchema: "Core");

            migrationBuilder.CreateTable(
                name: "Payment",
                schema: "Core",
                columns: table => new
                {
                    PaymentId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AmountPaid = table.Column<long>(type: "bigint", nullable: false),
                    BankCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CashReceivedBy = table.Column<long>(type: "bigint", nullable: true),
                    ChallanId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    PSId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaidOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentModeId = table.Column<long>(type: "bigint", nullable: false),
                    PaymentStatusId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_Payment_Challan_ChallanId",
                        column: x => x.ChallanId,
                        principalSchema: "Core",
                        principalTable: "Challan",
                        principalColumn: "ChallanId");
                    table.ForeignKey(
                        name: "FK_Payment_PaymentMode_PaymentModeId",
                        column: x => x.PaymentModeId,
                        principalSchema: "Setup",
                        principalTable: "PaymentMode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Payment_PaymentStatus_PaymentStatusId",
                        column: x => x.PaymentStatusId,
                        principalSchema: "Setup",
                        principalTable: "PaymentStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Payment_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_Payment_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Payment_ChallanId",
                schema: "Core",
                table: "Payment",
                column: "ChallanId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_CreatedBy",
                schema: "Core",
                table: "Payment",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_ModifiedBy",
                schema: "Core",
                table: "Payment",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_PaymentModeId",
                schema: "Core",
                table: "Payment",
                column: "PaymentModeId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_PaymentStatusId",
                schema: "Core",
                table: "Payment",
                column: "PaymentStatusId");
        }
    }
}
