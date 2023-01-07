using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dues_AssessmentState_AssessmentStateId",
                schema: "Core",
                table: "Dues");

            migrationBuilder.DropTable(
                name: "AssessmentState",
                schema: "Core");

            migrationBuilder.RenameColumn(
                name: "AssessmentStateId",
                schema: "Core",
                table: "Dues",
                newName: "AssessmentBaseId");

            migrationBuilder.RenameIndex(
                name: "IX_Dues_AssessmentStateId",
                schema: "Core",
                table: "Dues",
                newName: "IX_Dues_AssessmentBaseId");

            migrationBuilder.CreateTable(
                name: "AssessmentBase",
                schema: "Core",
                columns: table => new
                {
                    AssessmentBaseId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssessmentStatusId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessProcessId = table.Column<long>(type: "bigint", nullable: false),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: true),
                    OwnerId = table.Column<long>(type: "bigint", nullable: false),
                    OwnerTaxGroupId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleCategoryId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleClassId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleClassificationId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleBodyTypeId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleUsageId = table.Column<long>(type: "bigint", nullable: false),
                    EngineSize = table.Column<int>(type: "int", nullable: false),
                    SeatingCapacity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<long>(type: "bigint", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LadenWeight = table.Column<long>(type: "bigint", nullable: false),
                    UnLadenWeight = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentBase", x => x.AssessmentBaseId);
                    table.ForeignKey(
                        name: "FK_AssessmentBase_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "Application",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_AssessmentBase_AssessmentStatus_AssessmentStatusId",
                        column: x => x.AssessmentStatusId,
                        principalSchema: "Setup",
                        principalTable: "AssessmentStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AssessmentBase_BusinessProcess_BusinessProcessId",
                        column: x => x.BusinessProcessId,
                        principalSchema: "Setup",
                        principalTable: "BusinessProcess",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AssessmentBase_Owner_OwnerId",
                        column: x => x.OwnerId,
                        principalSchema: "Core",
                        principalTable: "Owner",
                        principalColumn: "OwnerId");
                    table.ForeignKey(
                        name: "FK_AssessmentBase_OwnerTaxGroup_OwnerTaxGroupId",
                        column: x => x.OwnerTaxGroupId,
                        principalSchema: "Setup",
                        principalTable: "OwnerTaxGroup",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AssessmentBase_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_AssessmentBase_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalSchema: "Core",
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                    table.ForeignKey(
                        name: "FK_AssessmentBase_VehicleBodyType_VehicleBodyTypeId",
                        column: x => x.VehicleBodyTypeId,
                        principalSchema: "Setup",
                        principalTable: "VehicleBodyType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AssessmentBase_VehicleCategory_VehicleCategoryId",
                        column: x => x.VehicleCategoryId,
                        principalSchema: "Setup",
                        principalTable: "VehicleCategory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AssessmentBase_VehicleClass_VehicleClassId",
                        column: x => x.VehicleClassId,
                        principalSchema: "Setup",
                        principalTable: "VehicleClass",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AssessmentBase_VehicleClassification_VehicleClassificationId",
                        column: x => x.VehicleClassificationId,
                        principalSchema: "Setup",
                        principalTable: "VehicleClassification",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AssessmentBase_VehicleUsage_VehicleUsageId",
                        column: x => x.VehicleUsageId,
                        principalSchema: "Setup",
                        principalTable: "VehicleUsage",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_ApplicationId",
                schema: "Core",
                table: "AssessmentBase",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_AssessmentStatusId",
                schema: "Core",
                table: "AssessmentBase",
                column: "AssessmentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_BusinessProcessId",
                schema: "Core",
                table: "AssessmentBase",
                column: "BusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_CreatedBy",
                schema: "Core",
                table: "AssessmentBase",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_OwnerId",
                schema: "Core",
                table: "AssessmentBase",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_OwnerTaxGroupId",
                schema: "Core",
                table: "AssessmentBase",
                column: "OwnerTaxGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_VehicleBodyTypeId",
                schema: "Core",
                table: "AssessmentBase",
                column: "VehicleBodyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_VehicleCategoryId",
                schema: "Core",
                table: "AssessmentBase",
                column: "VehicleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_VehicleClassId",
                schema: "Core",
                table: "AssessmentBase",
                column: "VehicleClassId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_VehicleClassificationId",
                schema: "Core",
                table: "AssessmentBase",
                column: "VehicleClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_VehicleId",
                schema: "Core",
                table: "AssessmentBase",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_VehicleUsageId",
                schema: "Core",
                table: "AssessmentBase",
                column: "VehicleUsageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dues_AssessmentBase_AssessmentBaseId",
                schema: "Core",
                table: "Dues",
                column: "AssessmentBaseId",
                principalSchema: "Core",
                principalTable: "AssessmentBase",
                principalColumn: "AssessmentBaseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dues_AssessmentBase_AssessmentBaseId",
                schema: "Core",
                table: "Dues");

            migrationBuilder.DropTable(
                name: "AssessmentBase",
                schema: "Core");

            migrationBuilder.RenameColumn(
                name: "AssessmentBaseId",
                schema: "Core",
                table: "Dues",
                newName: "AssessmentStateId");

            migrationBuilder.RenameIndex(
                name: "IX_Dues_AssessmentBaseId",
                schema: "Core",
                table: "Dues",
                newName: "IX_Dues_AssessmentStateId");

            migrationBuilder.CreateTable(
                name: "AssessmentState",
                schema: "Core",
                columns: table => new
                {
                    AssessmentStateId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: true),
                    AssessmentStatusId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessProcessId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    EngineSize = table.Column<int>(type: "int", nullable: false),
                    LadenWeight = table.Column<long>(type: "bigint", nullable: false),
                    OwnerId = table.Column<long>(type: "bigint", nullable: false),
                    OwnerTaxGroupId = table.Column<long>(type: "bigint", nullable: false),
                    Price = table.Column<long>(type: "bigint", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SeatingCapacity = table.Column<int>(type: "int", nullable: false),
                    UnLadenWeight = table.Column<long>(type: "bigint", nullable: false),
                    VehicleBodyTypeId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleCategoryId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleClassId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleClassificationId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleUsageId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentState", x => x.AssessmentStateId);
                    table.ForeignKey(
                        name: "FK_AssessmentState_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "Application",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_AssessmentState_AssessmentStatus_AssessmentStatusId",
                        column: x => x.AssessmentStatusId,
                        principalSchema: "Setup",
                        principalTable: "AssessmentStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AssessmentState_BusinessProcess_BusinessProcessId",
                        column: x => x.BusinessProcessId,
                        principalSchema: "Setup",
                        principalTable: "BusinessProcess",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AssessmentState_Owner_OwnerId",
                        column: x => x.OwnerId,
                        principalSchema: "Core",
                        principalTable: "Owner",
                        principalColumn: "OwnerId");
                    table.ForeignKey(
                        name: "FK_AssessmentState_OwnerTaxGroup_OwnerTaxGroupId",
                        column: x => x.OwnerTaxGroupId,
                        principalSchema: "Setup",
                        principalTable: "OwnerTaxGroup",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AssessmentState_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_AssessmentState_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalSchema: "Core",
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                    table.ForeignKey(
                        name: "FK_AssessmentState_VehicleBodyType_VehicleBodyTypeId",
                        column: x => x.VehicleBodyTypeId,
                        principalSchema: "Setup",
                        principalTable: "VehicleBodyType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AssessmentState_VehicleCategory_VehicleCategoryId",
                        column: x => x.VehicleCategoryId,
                        principalSchema: "Setup",
                        principalTable: "VehicleCategory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AssessmentState_VehicleClass_VehicleClassId",
                        column: x => x.VehicleClassId,
                        principalSchema: "Setup",
                        principalTable: "VehicleClass",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AssessmentState_VehicleClassification_VehicleClassificationId",
                        column: x => x.VehicleClassificationId,
                        principalSchema: "Setup",
                        principalTable: "VehicleClassification",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AssessmentState_VehicleUsage_VehicleUsageId",
                        column: x => x.VehicleUsageId,
                        principalSchema: "Setup",
                        principalTable: "VehicleUsage",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentState_ApplicationId",
                schema: "Core",
                table: "AssessmentState",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentState_AssessmentStatusId",
                schema: "Core",
                table: "AssessmentState",
                column: "AssessmentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentState_BusinessProcessId",
                schema: "Core",
                table: "AssessmentState",
                column: "BusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentState_CreatedBy",
                schema: "Core",
                table: "AssessmentState",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentState_OwnerId",
                schema: "Core",
                table: "AssessmentState",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentState_OwnerTaxGroupId",
                schema: "Core",
                table: "AssessmentState",
                column: "OwnerTaxGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentState_VehicleBodyTypeId",
                schema: "Core",
                table: "AssessmentState",
                column: "VehicleBodyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentState_VehicleCategoryId",
                schema: "Core",
                table: "AssessmentState",
                column: "VehicleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentState_VehicleClassId",
                schema: "Core",
                table: "AssessmentState",
                column: "VehicleClassId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentState_VehicleClassificationId",
                schema: "Core",
                table: "AssessmentState",
                column: "VehicleClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentState_VehicleId",
                schema: "Core",
                table: "AssessmentState",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentState_VehicleUsageId",
                schema: "Core",
                table: "AssessmentState",
                column: "VehicleUsageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dues_AssessmentState_AssessmentStateId",
                schema: "Core",
                table: "Dues",
                column: "AssessmentStateId",
                principalSchema: "Core",
                principalTable: "AssessmentState",
                principalColumn: "AssessmentStateId");
        }
    }
}
