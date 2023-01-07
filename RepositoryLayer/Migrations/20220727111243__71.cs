using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _71 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VehicleArticle",
                schema: "Setup",
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
                    table.PrimaryKey("PK_VehicleArticle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleArticle_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleArticle_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleArticleDelivery",
                schema: "Core",
                columns: table => new
                {
                    ArticleDeliveryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FatherName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CNIC = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleArticleId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleArticleDelivery", x => x.ArticleDeliveryId);
                    table.ForeignKey(
                        name: "FK_VehicleArticleDelivery_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "Application",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_VehicleArticleDelivery_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleArticleDelivery_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleArticleDelivery_VehicleArticle_VehicleArticleId",
                        column: x => x.VehicleArticleId,
                        principalSchema: "Setup",
                        principalTable: "VehicleArticle",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_VehicleArticle_CreatedBy",
                schema: "Setup",
                table: "VehicleArticle",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleArticle_ModifiedBy",
                schema: "Setup",
                table: "VehicleArticle",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleArticleDelivery_ApplicationId",
                schema: "Core",
                table: "VehicleArticleDelivery",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleArticleDelivery_CreatedBy",
                schema: "Core",
                table: "VehicleArticleDelivery",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleArticleDelivery_ModifiedBy",
                schema: "Core",
                table: "VehicleArticleDelivery",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleArticleDelivery_VehicleArticleId",
                schema: "Core",
                table: "VehicleArticleDelivery",
                column: "VehicleArticleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VehicleArticleDelivery",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "VehicleArticle",
                schema: "Setup");
        }
    }
}
