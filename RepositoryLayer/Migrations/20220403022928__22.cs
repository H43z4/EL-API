using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dues_Assessment_AssessmentId",
                table: "Dues");

            migrationBuilder.DropTable(
                name: "Assessment");

            migrationBuilder.RenameTable(
                name: "TaxType",
                newName: "TaxType",
                newSchema: "Setup");

            migrationBuilder.RenameTable(
                name: "Payment",
                newName: "Payment",
                newSchema: "Core");

            migrationBuilder.RenameTable(
                name: "Dues",
                newName: "Dues",
                newSchema: "Core");

            migrationBuilder.RenameTable(
                name: "Challan",
                newName: "Challan",
                newSchema: "Core");

            migrationBuilder.RenameColumn(
                name: "AssessmentId",
                schema: "Core",
                table: "Dues",
                newName: "AssessmentStateId");

            migrationBuilder.RenameIndex(
                name: "IX_Dues_AssessmentId",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dues_AssessmentState_AssessmentStateId",
                schema: "Core",
                table: "Dues");

            migrationBuilder.DropTable(
                name: "AssessmentState",
                schema: "Core");

            migrationBuilder.RenameTable(
                name: "TaxType",
                schema: "Setup",
                newName: "TaxType");

            migrationBuilder.RenameTable(
                name: "Payment",
                schema: "Core",
                newName: "Payment");

            migrationBuilder.RenameTable(
                name: "Dues",
                schema: "Core",
                newName: "Dues");

            migrationBuilder.RenameTable(
                name: "Challan",
                schema: "Core",
                newName: "Challan");

            migrationBuilder.RenameColumn(
                name: "AssessmentStateId",
                table: "Dues",
                newName: "AssessmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Dues_AssessmentStateId",
                table: "Dues",
                newName: "IX_Dues_AssessmentId");

            migrationBuilder.CreateTable(
                name: "Assessment",
                columns: table => new
                {
                    AssessmentId = table.Column<long>(type: "bigint", nullable: false)
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
                    table.PrimaryKey("PK_Assessment", x => x.AssessmentId);
                    table.ForeignKey(
                        name: "FK_Assessment_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "Application",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_Assessment_AssessmentStatus_AssessmentStatusId",
                        column: x => x.AssessmentStatusId,
                        principalSchema: "Setup",
                        principalTable: "AssessmentStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Assessment_BusinessProcess_BusinessProcessId",
                        column: x => x.BusinessProcessId,
                        principalSchema: "Setup",
                        principalTable: "BusinessProcess",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Assessment_Owner_OwnerId",
                        column: x => x.OwnerId,
                        principalSchema: "Core",
                        principalTable: "Owner",
                        principalColumn: "OwnerId");
                    table.ForeignKey(
                        name: "FK_Assessment_OwnerTaxGroup_OwnerTaxGroupId",
                        column: x => x.OwnerTaxGroupId,
                        principalSchema: "Setup",
                        principalTable: "OwnerTaxGroup",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Assessment_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_Assessment_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalSchema: "Core",
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                    table.ForeignKey(
                        name: "FK_Assessment_VehicleBodyType_VehicleBodyTypeId",
                        column: x => x.VehicleBodyTypeId,
                        principalSchema: "Setup",
                        principalTable: "VehicleBodyType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Assessment_VehicleCategory_VehicleCategoryId",
                        column: x => x.VehicleCategoryId,
                        principalSchema: "Setup",
                        principalTable: "VehicleCategory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Assessment_VehicleClass_VehicleClassId",
                        column: x => x.VehicleClassId,
                        principalSchema: "Setup",
                        principalTable: "VehicleClass",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Assessment_VehicleClassification_VehicleClassificationId",
                        column: x => x.VehicleClassificationId,
                        principalSchema: "Setup",
                        principalTable: "VehicleClassification",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Assessment_VehicleUsage_VehicleUsageId",
                        column: x => x.VehicleUsageId,
                        principalSchema: "Setup",
                        principalTable: "VehicleUsage",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_ApplicationId",
                table: "Assessment",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_AssessmentStatusId",
                table: "Assessment",
                column: "AssessmentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_BusinessProcessId",
                table: "Assessment",
                column: "BusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_CreatedBy",
                table: "Assessment",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_OwnerId",
                table: "Assessment",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_OwnerTaxGroupId",
                table: "Assessment",
                column: "OwnerTaxGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_VehicleBodyTypeId",
                table: "Assessment",
                column: "VehicleBodyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_VehicleCategoryId",
                table: "Assessment",
                column: "VehicleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_VehicleClassId",
                table: "Assessment",
                column: "VehicleClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_VehicleClassificationId",
                table: "Assessment",
                column: "VehicleClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_VehicleId",
                table: "Assessment",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_VehicleUsageId",
                table: "Assessment",
                column: "VehicleUsageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dues_Assessment_AssessmentId",
                table: "Dues",
                column: "AssessmentId",
                principalTable: "Assessment",
                principalColumn: "AssessmentId");
        }
    }
}
