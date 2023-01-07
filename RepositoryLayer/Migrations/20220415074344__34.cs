using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _34 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "OwnerTypeId",
                schema: "Setup",
                table: "OwnerTaxGroup",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<bool>(
                name: "IsFirstOwner",
                schema: "Core",
                table: "OwnerGroup",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_OwnerTaxGroup_OwnerTypeId",
                schema: "Setup",
                table: "OwnerTaxGroup",
                column: "OwnerTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_OwnerTaxGroup_OwnerType_OwnerTypeId",
                schema: "Setup",
                table: "OwnerTaxGroup",
                column: "OwnerTypeId",
                principalSchema: "Setup",
                principalTable: "OwnerType",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OwnerTaxGroup_OwnerType_OwnerTypeId",
                schema: "Setup",
                table: "OwnerTaxGroup");

            migrationBuilder.DropIndex(
                name: "IX_OwnerTaxGroup_OwnerTypeId",
                schema: "Setup",
                table: "OwnerTaxGroup");

            migrationBuilder.DropColumn(
                name: "OwnerTypeId",
                schema: "Setup",
                table: "OwnerTaxGroup");

            migrationBuilder.DropColumn(
                name: "IsFirstOwner",
                schema: "Core",
                table: "OwnerGroup");
        }
    }
}
