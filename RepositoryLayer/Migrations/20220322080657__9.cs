using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Application_OwnerGroup_OwnerGroupId",
                schema: "Core",
                table: "Application");

            migrationBuilder.DropForeignKey(
                name: "FK_Keeper_Business_KeeperBusinessId",
                schema: "Core",
                table: "Keeper");

            migrationBuilder.DropIndex(
                name: "IX_Application_OwnerGroupId",
                schema: "Core",
                table: "Application");

            migrationBuilder.DropColumn(
                name: "OwnerGroupId",
                schema: "Core",
                table: "Application");

            migrationBuilder.RenameColumn(
                name: "FullName",
                schema: "Core",
                table: "Person",
                newName: "PersonName");

            migrationBuilder.RenameColumn(
                name: "KeeperBusinessId",
                schema: "Core",
                table: "Keeper",
                newName: "OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_Keeper_KeeperBusinessId",
                schema: "Core",
                table: "Keeper",
                newName: "IX_Keeper_OwnerId");

            migrationBuilder.AddColumn<long>(
                name: "AnyOtherCost",
                schema: "Core",
                table: "VehicleImportInfo",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<long>(
                name: "OwnerGroupId",
                schema: "Core",
                table: "Remarks",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "VehicleId",
                schema: "Core",
                table: "Application",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "OwnerId",
                schema: "Core",
                table: "Application",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "VehicleDocument",
                schema: "Core",
                columns: table => new
                {
                    VehicleDocumentId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleDocumentTypeId = table.Column<long>(type: "bigint", nullable: false),
                    TotalPages = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleDocument", x => x.VehicleDocumentId);
                    table.ForeignKey(
                        name: "FK_VehicleDocument_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "Application",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_VehicleDocument_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleDocument_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalSchema: "Core",
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                    table.ForeignKey(
                        name: "FK_VehicleDocument_VehicleDocumentType_VehicleDocumentTypeId",
                        column: x => x.VehicleDocumentTypeId,
                        principalSchema: "Setup",
                        principalTable: "VehicleDocumentType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Application_OwnerId",
                schema: "Core",
                table: "Application",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleDocument_ApplicationId",
                schema: "Core",
                table: "VehicleDocument",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleDocument_CreatedBy",
                schema: "Core",
                table: "VehicleDocument",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleDocument_VehicleDocumentTypeId",
                schema: "Core",
                table: "VehicleDocument",
                column: "VehicleDocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleDocument_VehicleId",
                schema: "Core",
                table: "VehicleDocument",
                column: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Application_Owner_OwnerId",
                schema: "Core",
                table: "Application",
                column: "OwnerId",
                principalSchema: "Core",
                principalTable: "Owner",
                principalColumn: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Keeper_Owner_OwnerId",
                schema: "Core",
                table: "Keeper",
                column: "OwnerId",
                principalSchema: "Core",
                principalTable: "Owner",
                principalColumn: "OwnerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Application_Owner_OwnerId",
                schema: "Core",
                table: "Application");

            migrationBuilder.DropForeignKey(
                name: "FK_Keeper_Owner_OwnerId",
                schema: "Core",
                table: "Keeper");

            migrationBuilder.DropTable(
                name: "VehicleDocument",
                schema: "Core");

            migrationBuilder.DropIndex(
                name: "IX_Application_OwnerId",
                schema: "Core",
                table: "Application");

            migrationBuilder.DropColumn(
                name: "AnyOtherCost",
                schema: "Core",
                table: "VehicleImportInfo");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                schema: "Core",
                table: "Application");

            migrationBuilder.RenameColumn(
                name: "PersonName",
                schema: "Core",
                table: "Person",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "OwnerId",
                schema: "Core",
                table: "Keeper",
                newName: "KeeperBusinessId");

            migrationBuilder.RenameIndex(
                name: "IX_Keeper_OwnerId",
                schema: "Core",
                table: "Keeper",
                newName: "IX_Keeper_KeeperBusinessId");

            migrationBuilder.AlterColumn<long>(
                name: "OwnerGroupId",
                schema: "Core",
                table: "Remarks",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "VehicleId",
                schema: "Core",
                table: "Application",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "OwnerGroupId",
                schema: "Core",
                table: "Application",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Application_OwnerGroupId",
                schema: "Core",
                table: "Application",
                column: "OwnerGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Application_OwnerGroup_OwnerGroupId",
                schema: "Core",
                table: "Application",
                column: "OwnerGroupId",
                principalSchema: "Core",
                principalTable: "OwnerGroup",
                principalColumn: "OwnerGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Keeper_Business_KeeperBusinessId",
                schema: "Core",
                table: "Keeper",
                column: "KeeperBusinessId",
                principalSchema: "Core",
                principalTable: "Business",
                principalColumn: "BusinessId");
        }
    }
}
