using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _82 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SeriesNumber_SeriesCategory_SeriesCategoryId",
                schema: "SRNRPL",
                table: "SeriesNumber");

            migrationBuilder.DropIndex(
                name: "IX_SeriesNumberDetail_SeriesCategoryId",
                schema: "SRNRPL",
                table: "SeriesNumberDetail");

            migrationBuilder.DropIndex(
                name: "IX_SeriesNumber_SeriesCategoryId_SeriesNumberName",
                schema: "SRNRPL",
                table: "SeriesNumber");

            migrationBuilder.DropColumn(
                name: "SeriesCategoryId",
                schema: "SRNRPL",
                table: "SeriesNumber");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumberDetail_SeriesCategoryId_SeriesNumberId",
                schema: "SRNRPL",
                table: "SeriesNumberDetail",
                columns: new[] { "SeriesCategoryId", "SeriesNumberId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumber_SeriesNumberName",
                schema: "SRNRPL",
                table: "SeriesNumber",
                column: "SeriesNumberName",
                unique: true,
                filter: "[SeriesNumberName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_SeriesNumberDetail_SeriesCategoryId_SeriesNumberId",
                schema: "SRNRPL",
                table: "SeriesNumberDetail");

            migrationBuilder.DropIndex(
                name: "IX_SeriesNumber_SeriesNumberName",
                schema: "SRNRPL",
                table: "SeriesNumber");

            migrationBuilder.AddColumn<long>(
                name: "SeriesCategoryId",
                schema: "SRNRPL",
                table: "SeriesNumber",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumberDetail_SeriesCategoryId",
                schema: "SRNRPL",
                table: "SeriesNumberDetail",
                column: "SeriesCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumber_SeriesCategoryId_SeriesNumberName",
                schema: "SRNRPL",
                table: "SeriesNumber",
                columns: new[] { "SeriesCategoryId", "SeriesNumberName" },
                unique: true,
                filter: "[SeriesNumberName] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_SeriesNumber_SeriesCategory_SeriesCategoryId",
                schema: "SRNRPL",
                table: "SeriesNumber",
                column: "SeriesCategoryId",
                principalSchema: "SRNRPL",
                principalTable: "SeriesCategory",
                principalColumn: "Id");
        }
    }
}
