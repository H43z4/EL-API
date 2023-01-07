using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _62 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssessmentDetail_Challan_ChallanId",
                schema: "Core",
                table: "AssessmentDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_AssessmentDetail_PaymentStatus_PaymentStatusId",
                schema: "Core",
                table: "AssessmentDetail");

            migrationBuilder.DropIndex(
                name: "IX_AssessmentDetail_ChallanId",
                schema: "Core",
                table: "AssessmentDetail");

            migrationBuilder.DropIndex(
                name: "IX_AssessmentDetail_PaymentStatusId",
                schema: "Core",
                table: "AssessmentDetail");

            migrationBuilder.DropColumn(
                name: "ChallanId",
                schema: "Core",
                table: "AssessmentDetail");

            migrationBuilder.DropColumn(
                name: "PaymentStatusId",
                schema: "Core",
                table: "AssessmentDetail");

            migrationBuilder.CreateTable(
                name: "SqlExceptionLog",
                schema: "Logs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ErrorNumber = table.Column<int>(type: "int", nullable: false),
                    ErrorState = table.Column<int>(type: "int", nullable: false),
                    ErrorSeverity = table.Column<int>(type: "int", nullable: false),
                    ErrorLine = table.Column<int>(type: "int", nullable: false),
                    ErrorProcedure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ErrorMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ErrorDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SqlExceptionLog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SqlExceptionLog_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SqlExceptionLog_CreatedBy",
                schema: "Logs",
                table: "SqlExceptionLog",
                column: "CreatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SqlExceptionLog",
                schema: "Logs");

            migrationBuilder.AddColumn<long>(
                name: "ChallanId",
                schema: "Core",
                table: "AssessmentDetail",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PaymentStatusId",
                schema: "Core",
                table: "AssessmentDetail",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentDetail_ChallanId",
                schema: "Core",
                table: "AssessmentDetail",
                column: "ChallanId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentDetail_PaymentStatusId",
                schema: "Core",
                table: "AssessmentDetail",
                column: "PaymentStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentDetail_Challan_ChallanId",
                schema: "Core",
                table: "AssessmentDetail",
                column: "ChallanId",
                principalSchema: "Core",
                principalTable: "Challan",
                principalColumn: "ChallanId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentDetail_PaymentStatus_PaymentStatusId",
                schema: "Core",
                table: "AssessmentDetail",
                column: "PaymentStatusId",
                principalSchema: "Setup",
                principalTable: "PaymentStatus",
                principalColumn: "Id");
        }
    }
}
