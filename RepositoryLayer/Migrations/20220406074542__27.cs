using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _27 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dues_DuesType_DuesTypeId",
                schema: "Core",
                table: "Dues");

            migrationBuilder.DropTable(
                name: "DuesType",
                schema: "Setup");

            migrationBuilder.RenameColumn(
                name: "DuesTypeId",
                schema: "Core",
                table: "Dues",
                newName: "TaxTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Dues_DuesTypeId",
                schema: "Core",
                table: "Dues",
                newName: "IX_Dues_TaxTypeId");

            migrationBuilder.AddColumn<bool>(
                name: "IsHPA",
                schema: "Core",
                table: "AssessmentBase",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "VehicleClassDetailId",
                schema: "Core",
                table: "AssessmentBase",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_VehicleClassDetailId",
                schema: "Core",
                table: "AssessmentBase",
                column: "VehicleClassDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentBase_VehicleClassDetail_VehicleClassDetailId",
                schema: "Core",
                table: "AssessmentBase",
                column: "VehicleClassDetailId",
                principalSchema: "Setup",
                principalTable: "VehicleClassDetail",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Dues_TaxType_TaxTypeId",
                schema: "Core",
                table: "Dues",
                column: "TaxTypeId",
                principalSchema: "Setup",
                principalTable: "TaxType",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssessmentBase_VehicleClassDetail_VehicleClassDetailId",
                schema: "Core",
                table: "AssessmentBase");

            migrationBuilder.DropForeignKey(
                name: "FK_Dues_TaxType_TaxTypeId",
                schema: "Core",
                table: "Dues");

            migrationBuilder.DropIndex(
                name: "IX_AssessmentBase_VehicleClassDetailId",
                schema: "Core",
                table: "AssessmentBase");

            migrationBuilder.DropColumn(
                name: "IsHPA",
                schema: "Core",
                table: "AssessmentBase");

            migrationBuilder.DropColumn(
                name: "VehicleClassDetailId",
                schema: "Core",
                table: "AssessmentBase");

            migrationBuilder.RenameColumn(
                name: "TaxTypeId",
                schema: "Core",
                table: "Dues",
                newName: "DuesTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Dues_TaxTypeId",
                schema: "Core",
                table: "Dues",
                newName: "IX_Dues_DuesTypeId");

            migrationBuilder.CreateTable(
                name: "DuesType",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DuesType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DuesType_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DuesType_CreatedBy",
                schema: "Setup",
                table: "DuesType",
                column: "CreatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_Dues_DuesType_DuesTypeId",
                schema: "Core",
                table: "Dues",
                column: "DuesTypeId",
                principalSchema: "Setup",
                principalTable: "DuesType",
                principalColumn: "Id");
        }
    }
}
