using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _83 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SeriesNumberPool_SeriesNumberGroup_SeriesNumberGroupId",
                schema: "SRNRPL",
                table: "SeriesNumberPool");

            migrationBuilder.DropForeignKey(
                name: "FK_SeriesNumberSelection_SeriesNumberGroup_SeriesNumberGroupId",
                schema: "SRNRPL",
                table: "SeriesNumberSelection");

            migrationBuilder.DropTable(
                name: "SeriesNumberGroup",
                schema: "SRNRPL");

            migrationBuilder.DropIndex(
                name: "IX_SeriesNumberPool_SeriesNumberGroupId",
                schema: "SRNRPL",
                table: "SeriesNumberPool");

            migrationBuilder.DropColumn(
                name: "SeriesNumberGroupId",
                schema: "SRNRPL",
                table: "SeriesNumberPool");

            migrationBuilder.RenameColumn(
                name: "SeriesNumberGroupId",
                schema: "SRNRPL",
                table: "SeriesNumberSelection",
                newName: "SeriesCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_SeriesNumberSelection_SeriesNumberGroupId",
                schema: "SRNRPL",
                table: "SeriesNumberSelection",
                newName: "IX_SeriesNumberSelection_SeriesCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_SeriesNumberSelection_SeriesCategory_SeriesCategoryId",
                schema: "SRNRPL",
                table: "SeriesNumberSelection",
                column: "SeriesCategoryId",
                principalSchema: "SRNRPL",
                principalTable: "SeriesCategory",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SeriesNumberSelection_SeriesCategory_SeriesCategoryId",
                schema: "SRNRPL",
                table: "SeriesNumberSelection");

            migrationBuilder.RenameColumn(
                name: "SeriesCategoryId",
                schema: "SRNRPL",
                table: "SeriesNumberSelection",
                newName: "SeriesNumberGroupId");

            migrationBuilder.RenameIndex(
                name: "IX_SeriesNumberSelection_SeriesCategoryId",
                schema: "SRNRPL",
                table: "SeriesNumberSelection",
                newName: "IX_SeriesNumberSelection_SeriesNumberGroupId");

            migrationBuilder.AddColumn<long>(
                name: "SeriesNumberGroupId",
                schema: "SRNRPL",
                table: "SeriesNumberPool",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "SeriesNumberGroup",
                schema: "SRNRPL",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeriesNumberGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SeriesNumberGroup_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_SeriesNumberGroup_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumberPool_SeriesNumberGroupId",
                schema: "SRNRPL",
                table: "SeriesNumberPool",
                column: "SeriesNumberGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumberGroup_CreatedBy",
                schema: "SRNRPL",
                table: "SeriesNumberGroup",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumberGroup_ModifiedBy",
                schema: "SRNRPL",
                table: "SeriesNumberGroup",
                column: "ModifiedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_SeriesNumberPool_SeriesNumberGroup_SeriesNumberGroupId",
                schema: "SRNRPL",
                table: "SeriesNumberPool",
                column: "SeriesNumberGroupId",
                principalSchema: "SRNRPL",
                principalTable: "SeriesNumberGroup",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SeriesNumberSelection_SeriesNumberGroup_SeriesNumberGroupId",
                schema: "SRNRPL",
                table: "SeriesNumberSelection",
                column: "SeriesNumberGroupId",
                principalSchema: "SRNRPL",
                principalTable: "SeriesNumberGroup",
                principalColumn: "Id");
        }
    }
}
