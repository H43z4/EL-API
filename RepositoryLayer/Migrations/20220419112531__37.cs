using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _37 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuctionResult_SeriesNumberPool_SeriesNumberPoolId",
                schema: "SRNRPL",
                table: "AuctionResult");

            migrationBuilder.RenameColumn(
                name: "SeriesNumberPoolId",
                schema: "SRNRPL",
                table: "AuctionResult",
                newName: "SeriesNumberId");

            migrationBuilder.RenameIndex(
                name: "IX_AuctionResult_SeriesNumberPoolId",
                schema: "SRNRPL",
                table: "AuctionResult",
                newName: "IX_AuctionResult_SeriesNumberId");

            migrationBuilder.AddColumn<long>(
                name: "SeriesCategoryId",
                schema: "SRNRPL",
                table: "AuctionResult",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "SeriesId",
                schema: "SRNRPL",
                table: "AuctionResult",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_AuctionResult_SeriesCategoryId_SeriesId_SeriesNumberId",
                schema: "SRNRPL",
                table: "AuctionResult",
                columns: new[] { "SeriesCategoryId", "SeriesId", "SeriesNumberId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AuctionResult_SeriesId",
                schema: "SRNRPL",
                table: "AuctionResult",
                column: "SeriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_AuctionResult_Series_SeriesId",
                schema: "SRNRPL",
                table: "AuctionResult",
                column: "SeriesId",
                principalSchema: "SRNRPL",
                principalTable: "Series",
                principalColumn: "SeriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_AuctionResult_SeriesCategory_SeriesCategoryId",
                schema: "SRNRPL",
                table: "AuctionResult",
                column: "SeriesCategoryId",
                principalSchema: "SRNRPL",
                principalTable: "SeriesCategory",
                principalColumn: "SeriesCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_AuctionResult_SeriesNumber_SeriesNumberId",
                schema: "SRNRPL",
                table: "AuctionResult",
                column: "SeriesNumberId",
                principalSchema: "SRNRPL",
                principalTable: "SeriesNumber",
                principalColumn: "SeriesNumberId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuctionResult_Series_SeriesId",
                schema: "SRNRPL",
                table: "AuctionResult");

            migrationBuilder.DropForeignKey(
                name: "FK_AuctionResult_SeriesCategory_SeriesCategoryId",
                schema: "SRNRPL",
                table: "AuctionResult");

            migrationBuilder.DropForeignKey(
                name: "FK_AuctionResult_SeriesNumber_SeriesNumberId",
                schema: "SRNRPL",
                table: "AuctionResult");

            migrationBuilder.DropIndex(
                name: "IX_AuctionResult_SeriesCategoryId_SeriesId_SeriesNumberId",
                schema: "SRNRPL",
                table: "AuctionResult");

            migrationBuilder.DropIndex(
                name: "IX_AuctionResult_SeriesId",
                schema: "SRNRPL",
                table: "AuctionResult");

            migrationBuilder.DropColumn(
                name: "SeriesCategoryId",
                schema: "SRNRPL",
                table: "AuctionResult");

            migrationBuilder.DropColumn(
                name: "SeriesId",
                schema: "SRNRPL",
                table: "AuctionResult");

            migrationBuilder.RenameColumn(
                name: "SeriesNumberId",
                schema: "SRNRPL",
                table: "AuctionResult",
                newName: "SeriesNumberPoolId");

            migrationBuilder.RenameIndex(
                name: "IX_AuctionResult_SeriesNumberId",
                schema: "SRNRPL",
                table: "AuctionResult",
                newName: "IX_AuctionResult_SeriesNumberPoolId");

            migrationBuilder.AddForeignKey(
                name: "FK_AuctionResult_SeriesNumberPool_SeriesNumberPoolId",
                schema: "SRNRPL",
                table: "AuctionResult",
                column: "SeriesNumberPoolId",
                principalSchema: "SRNRPL",
                principalTable: "SeriesNumberPool",
                principalColumn: "SeriesNumberPoolId");
        }
    }
}
