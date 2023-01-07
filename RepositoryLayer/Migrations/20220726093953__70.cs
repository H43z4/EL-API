using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _70 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VehicleFileUpload",
                schema: "Core",
                columns: table => new
                {
                    FileUploadId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    FileExtension = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MIMEType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TotalPages = table.Column<int>(type: "int", nullable: false),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleDocumentTypeId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleFileUpload", x => x.FileUploadId);
                    table.ForeignKey(
                        name: "FK_VehicleFileUpload_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "Application",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_VehicleFileUpload_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleFileUpload_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleFileUpload_VehicleDocumentType_VehicleDocumentTypeId",
                        column: x => x.VehicleDocumentTypeId,
                        principalSchema: "Setup",
                        principalTable: "VehicleDocumentType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_VehicleFileUpload_ApplicationId",
                schema: "Core",
                table: "VehicleFileUpload",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleFileUpload_CreatedBy",
                schema: "Core",
                table: "VehicleFileUpload",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleFileUpload_ModifiedBy",
                schema: "Core",
                table: "VehicleFileUpload",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleFileUpload_VehicleDocumentTypeId",
                schema: "Core",
                table: "VehicleFileUpload",
                column: "VehicleDocumentTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VehicleFileUpload",
                schema: "Core");
        }
    }
}
