using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _39 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Application_ApplicationPhase_ApplicationPhaseId",
                schema: "Core",
                table: "Application");

            migrationBuilder.DropForeignKey(
                name: "FK_Application_ApplicationType_ApplicationTypeId",
                schema: "Core",
                table: "Application");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_District_DistrictId",
                schema: "Core",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_VehicleRCStatus_VehicleRCStatusId",
                schema: "Core",
                table: "Vehicle");

            migrationBuilder.DropTable(
                name: "ApplicationPhase",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "ApplicationType",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "Dues",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "TaxedBusinessProcess",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "VehicleTax",
                schema: "Core");

            migrationBuilder.DropColumn(
                name: "FirstRegistrationDate",
                schema: "Core",
                table: "VehicleRegistrationHistory");

            migrationBuilder.RenameColumn(
                name: "TaxPaidUpto",
                schema: "Core",
                table: "VehicleRegistrationHistory",
                newName: "RegistrationDate");

            migrationBuilder.RenameColumn(
                name: "PreviousRegNo",
                schema: "Core",
                table: "VehicleRegistrationHistory",
                newName: "RegistrationNo");

            migrationBuilder.RenameColumn(
                name: "VehicleRCStatusId",
                schema: "Core",
                table: "Vehicle",
                newName: "VehicleTypeId");

            migrationBuilder.RenameColumn(
                name: "DistrictId",
                schema: "Core",
                table: "Vehicle",
                newName: "RegistrationDistrictId");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicle_VehicleRCStatusId",
                schema: "Core",
                table: "Vehicle",
                newName: "IX_Vehicle_VehicleTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicle_DistrictId",
                schema: "Core",
                table: "Vehicle",
                newName: "IX_Vehicle_RegistrationDistrictId");

            migrationBuilder.RenameColumn(
                name: "IsFirstOwner",
                schema: "Core",
                table: "OwnerGroup",
                newName: "IsFirstGroupMember");

            migrationBuilder.RenameColumn(
                name: "HPACurrentStatusDate",
                schema: "Core",
                table: "HPA",
                newName: "HPAStatusDated");

            migrationBuilder.RenameColumn(
                name: "ApplicationTypeId",
                schema: "Core",
                table: "Application",
                newName: "BusinessProcessId");

            migrationBuilder.RenameColumn(
                name: "ApplicationPhaseId",
                schema: "Core",
                table: "Application",
                newName: "BusinessPhaseStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Application_ApplicationTypeId",
                schema: "Core",
                table: "Application",
                newName: "IX_Application_BusinessProcessId");

            migrationBuilder.RenameIndex(
                name: "IX_Application_ApplicationPhaseId",
                schema: "Core",
                table: "Application",
                newName: "IX_Application_BusinessPhaseStatusId");

            migrationBuilder.AddColumn<long>(
                name: "RegistrationDistrictId",
                schema: "Core",
                table: "VehicleRegistrationHistory",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<int>(
                name: "TaxFrequency",
                schema: "Setup",
                table: "VehicleClassDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "VehicleUsageId",
                schema: "Setup",
                table: "VehicleClassDetail",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "VehicleRouteTypeId",
                schema: "Core",
                table: "Vehicle",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Order",
                schema: "Setup",
                table: "TaxType",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "TaxRuleId",
                schema: "Setup",
                table: "TaxType",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ITExemptedClause",
                schema: "Setup",
                table: "OwnerTaxGroup",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsIncomeTaxExempted",
                schema: "Setup",
                table: "OwnerTaxGroup",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsTaxExempted",
                schema: "Setup",
                table: "OwnerTaxGroup",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "TaxExemptedClause",
                schema: "Setup",
                table: "OwnerTaxGroup",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "TotalAmount",
                schema: "Core",
                table: "Challan",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "DistrictId",
                schema: "Core",
                table: "AssessmentBase",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "BusinessPhaseId",
                schema: "Core",
                table: "Application",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "DistrictId",
                schema: "Core",
                table: "Application",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AssessmentDetail",
                schema: "Core",
                columns: table => new
                {
                    AssessmentDetailId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssessmentBaseId = table.Column<long>(type: "bigint", nullable: false),
                    TaxTypeId = table.Column<long>(type: "bigint", nullable: false),
                    ChallanId = table.Column<long>(type: "bigint", nullable: true),
                    PaymentStatusId = table.Column<long>(type: "bigint", nullable: false),
                    PayableAmount = table.Column<long>(type: "bigint", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentDetail", x => x.AssessmentDetailId);
                    table.ForeignKey(
                        name: "FK_AssessmentDetail_AssessmentBase_AssessmentBaseId",
                        column: x => x.AssessmentBaseId,
                        principalSchema: "Core",
                        principalTable: "AssessmentBase",
                        principalColumn: "AssessmentBaseId");
                    table.ForeignKey(
                        name: "FK_AssessmentDetail_Challan_ChallanId",
                        column: x => x.ChallanId,
                        principalSchema: "Core",
                        principalTable: "Challan",
                        principalColumn: "ChallanId");
                    table.ForeignKey(
                        name: "FK_AssessmentDetail_PaymentStatus_PaymentStatusId",
                        column: x => x.PaymentStatusId,
                        principalSchema: "Setup",
                        principalTable: "PaymentStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AssessmentDetail_TaxType_TaxTypeId",
                        column: x => x.TaxTypeId,
                        principalSchema: "Setup",
                        principalTable: "TaxType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AssessmentDetail_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "BusinessPhaseStatus",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessPhaseStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessPhaseStatus_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "BusinessProFeeTax",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessProcessId = table.Column<long>(type: "bigint", nullable: false),
                    TaxTypeId = table.Column<long>(type: "bigint", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessProFeeTax", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessProFeeTax_BusinessProcess_BusinessProcessId",
                        column: x => x.BusinessProcessId,
                        principalSchema: "Setup",
                        principalTable: "BusinessProcess",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BusinessProFeeTax_TaxType_TaxTypeId",
                        column: x => x.TaxTypeId,
                        principalSchema: "Setup",
                        principalTable: "TaxType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BusinessProFeeTax_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "OwnerTaxGroupFees",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerTaxGroupId = table.Column<long>(type: "bigint", nullable: false),
                    TaxTypeId = table.Column<long>(type: "bigint", nullable: false),
                    AppliedFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OwnerTaxGroupFees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OwnerTaxGroupFees_OwnerTaxGroup_OwnerTaxGroupId",
                        column: x => x.OwnerTaxGroupId,
                        principalSchema: "Setup",
                        principalTable: "OwnerTaxGroup",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OwnerTaxGroupFees_TaxType_TaxTypeId",
                        column: x => x.TaxTypeId,
                        principalSchema: "Setup",
                        principalTable: "TaxType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RegFeePenaltyRate",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MinDays = table.Column<int>(type: "int", nullable: false),
                    MaxDays = table.Column<int>(type: "int", nullable: false),
                    PenaltyRate = table.Column<long>(type: "bigint", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegFeePenaltyRate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegFeePenaltyRate_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "TaxRule",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxRule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaxRule_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleAdditionalInfo",
                schema: "Core",
                columns: table => new
                {
                    VehicleAdditionalInfoId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleRCStatusId = table.Column<long>(type: "bigint", nullable: true),
                    TaxFrequency = table.Column<int>(type: "int", nullable: false),
                    IsHPA = table.Column<bool>(type: "bit", nullable: false),
                    IsTaxExempted = table.Column<bool>(type: "bit", nullable: true),
                    IsIncomeTaxExempted = table.Column<bool>(type: "bit", nullable: true),
                    DateOfFirstRegistration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FitnessCertValidFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FitnessCertValidTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaxPaidUpto = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleAdditionalInfo", x => x.VehicleAdditionalInfoId);
                    table.ForeignKey(
                        name: "FK_VehicleAdditionalInfo_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleAdditionalInfo_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalSchema: "Core",
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                    table.ForeignKey(
                        name: "FK_VehicleAdditionalInfo_VehicleRCStatus_VehicleRCStatusId",
                        column: x => x.VehicleRCStatusId,
                        principalSchema: "Setup",
                        principalTable: "VehicleRCStatus",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VehicleBusinessProcessHistory",
                schema: "Core",
                columns: table => new
                {
                    VehicleBusinessProHistId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessProcessId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: true),
                    OwnerId = table.Column<long>(type: "bigint", nullable: true),
                    DistrictId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleBusinessProcessHistory", x => x.VehicleBusinessProHistId);
                    table.ForeignKey(
                        name: "FK_VehicleBusinessProcessHistory_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "Application",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_VehicleBusinessProcessHistory_BusinessProcess_BusinessProcessId",
                        column: x => x.BusinessProcessId,
                        principalSchema: "Setup",
                        principalTable: "BusinessProcess",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleBusinessProcessHistory_District_DistrictId",
                        column: x => x.DistrictId,
                        principalSchema: "Setup",
                        principalTable: "District",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleBusinessProcessHistory_Owner_OwnerId",
                        column: x => x.OwnerId,
                        principalSchema: "Core",
                        principalTable: "Owner",
                        principalColumn: "OwnerId");
                    table.ForeignKey(
                        name: "FK_VehicleBusinessProcessHistory_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleBusinessProcessHistory_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalSchema: "Core",
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_VehicleRegistrationHistory_RegistrationDistrictId",
                schema: "Core",
                table: "VehicleRegistrationHistory",
                column: "RegistrationDistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClassDetail_VehicleUsageId",
                schema: "Setup",
                table: "VehicleClassDetail",
                column: "VehicleUsageId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleRouteTypeId",
                schema: "Core",
                table: "Vehicle",
                column: "VehicleRouteTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxType_TaxRuleId",
                schema: "Setup",
                table: "TaxType",
                column: "TaxRuleId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_DistrictId",
                schema: "Core",
                table: "AssessmentBase",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_BusinessPhaseId",
                schema: "Core",
                table: "Application",
                column: "BusinessPhaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_DistrictId",
                schema: "Core",
                table: "Application",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentDetail_AssessmentBaseId",
                schema: "Core",
                table: "AssessmentDetail",
                column: "AssessmentBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentDetail_ChallanId",
                schema: "Core",
                table: "AssessmentDetail",
                column: "ChallanId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentDetail_CreatedBy",
                schema: "Core",
                table: "AssessmentDetail",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentDetail_PaymentStatusId",
                schema: "Core",
                table: "AssessmentDetail",
                column: "PaymentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentDetail_TaxTypeId",
                schema: "Core",
                table: "AssessmentDetail",
                column: "TaxTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessPhaseStatus_CreatedBy",
                schema: "Setup",
                table: "BusinessPhaseStatus",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessProFeeTax_BusinessProcessId",
                schema: "Setup",
                table: "BusinessProFeeTax",
                column: "BusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessProFeeTax_CreatedBy",
                schema: "Setup",
                table: "BusinessProFeeTax",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessProFeeTax_TaxTypeId",
                schema: "Setup",
                table: "BusinessProFeeTax",
                column: "TaxTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerTaxGroupFees_OwnerTaxGroupId",
                schema: "Setup",
                table: "OwnerTaxGroupFees",
                column: "OwnerTaxGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerTaxGroupFees_TaxTypeId",
                schema: "Setup",
                table: "OwnerTaxGroupFees",
                column: "TaxTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RegFeePenaltyRate_CreatedBy",
                schema: "Setup",
                table: "RegFeePenaltyRate",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TaxRule_CreatedBy",
                schema: "Setup",
                table: "TaxRule",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAdditionalInfo_CreatedBy",
                schema: "Core",
                table: "VehicleAdditionalInfo",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAdditionalInfo_VehicleId",
                schema: "Core",
                table: "VehicleAdditionalInfo",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAdditionalInfo_VehicleRCStatusId",
                schema: "Core",
                table: "VehicleAdditionalInfo",
                column: "VehicleRCStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBusinessProcessHistory_ApplicationId",
                schema: "Core",
                table: "VehicleBusinessProcessHistory",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBusinessProcessHistory_BusinessProcessId",
                schema: "Core",
                table: "VehicleBusinessProcessHistory",
                column: "BusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBusinessProcessHistory_CreatedBy",
                schema: "Core",
                table: "VehicleBusinessProcessHistory",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBusinessProcessHistory_DistrictId",
                schema: "Core",
                table: "VehicleBusinessProcessHistory",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBusinessProcessHistory_OwnerId",
                schema: "Core",
                table: "VehicleBusinessProcessHistory",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBusinessProcessHistory_VehicleId",
                schema: "Core",
                table: "VehicleBusinessProcessHistory",
                column: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Application_BusinessPhase_BusinessPhaseId",
                schema: "Core",
                table: "Application",
                column: "BusinessPhaseId",
                principalSchema: "Setup",
                principalTable: "BusinessPhase",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Application_BusinessPhaseStatus_BusinessPhaseStatusId",
                schema: "Core",
                table: "Application",
                column: "BusinessPhaseStatusId",
                principalSchema: "Setup",
                principalTable: "BusinessPhaseStatus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Application_BusinessProcess_BusinessProcessId",
                schema: "Core",
                table: "Application",
                column: "BusinessProcessId",
                principalSchema: "Setup",
                principalTable: "BusinessProcess",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Application_District_DistrictId",
                schema: "Core",
                table: "Application",
                column: "DistrictId",
                principalSchema: "Setup",
                principalTable: "District",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentBase_District_DistrictId",
                schema: "Core",
                table: "AssessmentBase",
                column: "DistrictId",
                principalSchema: "Setup",
                principalTable: "District",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TaxType_TaxRule_TaxRuleId",
                schema: "Setup",
                table: "TaxType",
                column: "TaxRuleId",
                principalSchema: "Setup",
                principalTable: "TaxRule",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_District_RegistrationDistrictId",
                schema: "Core",
                table: "Vehicle",
                column: "RegistrationDistrictId",
                principalSchema: "Setup",
                principalTable: "District",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_VehicleRouteType_VehicleRouteTypeId",
                schema: "Core",
                table: "Vehicle",
                column: "VehicleRouteTypeId",
                principalSchema: "Setup",
                principalTable: "VehicleRouteType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_VehicleType_VehicleTypeId",
                schema: "Core",
                table: "Vehicle",
                column: "VehicleTypeId",
                principalSchema: "Setup",
                principalTable: "VehicleType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleClassDetail_VehicleUsage_VehicleUsageId",
                schema: "Setup",
                table: "VehicleClassDetail",
                column: "VehicleUsageId",
                principalSchema: "Setup",
                principalTable: "VehicleUsage",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleRegistrationHistory_District_RegistrationDistrictId",
                schema: "Core",
                table: "VehicleRegistrationHistory",
                column: "RegistrationDistrictId",
                principalSchema: "Setup",
                principalTable: "District",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Application_BusinessPhase_BusinessPhaseId",
                schema: "Core",
                table: "Application");

            migrationBuilder.DropForeignKey(
                name: "FK_Application_BusinessPhaseStatus_BusinessPhaseStatusId",
                schema: "Core",
                table: "Application");

            migrationBuilder.DropForeignKey(
                name: "FK_Application_BusinessProcess_BusinessProcessId",
                schema: "Core",
                table: "Application");

            migrationBuilder.DropForeignKey(
                name: "FK_Application_District_DistrictId",
                schema: "Core",
                table: "Application");

            migrationBuilder.DropForeignKey(
                name: "FK_AssessmentBase_District_DistrictId",
                schema: "Core",
                table: "AssessmentBase");

            migrationBuilder.DropForeignKey(
                name: "FK_TaxType_TaxRule_TaxRuleId",
                schema: "Setup",
                table: "TaxType");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_District_RegistrationDistrictId",
                schema: "Core",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_VehicleRouteType_VehicleRouteTypeId",
                schema: "Core",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_VehicleType_VehicleTypeId",
                schema: "Core",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleClassDetail_VehicleUsage_VehicleUsageId",
                schema: "Setup",
                table: "VehicleClassDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleRegistrationHistory_District_RegistrationDistrictId",
                schema: "Core",
                table: "VehicleRegistrationHistory");

            migrationBuilder.DropTable(
                name: "AssessmentDetail",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "BusinessPhaseStatus",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "BusinessProFeeTax",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "OwnerTaxGroupFees",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "RegFeePenaltyRate",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "TaxRule",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "VehicleAdditionalInfo",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "VehicleBusinessProcessHistory",
                schema: "Core");

            migrationBuilder.DropIndex(
                name: "IX_VehicleRegistrationHistory_RegistrationDistrictId",
                schema: "Core",
                table: "VehicleRegistrationHistory");

            migrationBuilder.DropIndex(
                name: "IX_VehicleClassDetail_VehicleUsageId",
                schema: "Setup",
                table: "VehicleClassDetail");

            migrationBuilder.DropIndex(
                name: "IX_Vehicle_VehicleRouteTypeId",
                schema: "Core",
                table: "Vehicle");

            migrationBuilder.DropIndex(
                name: "IX_TaxType_TaxRuleId",
                schema: "Setup",
                table: "TaxType");

            migrationBuilder.DropIndex(
                name: "IX_AssessmentBase_DistrictId",
                schema: "Core",
                table: "AssessmentBase");

            migrationBuilder.DropIndex(
                name: "IX_Application_BusinessPhaseId",
                schema: "Core",
                table: "Application");

            migrationBuilder.DropIndex(
                name: "IX_Application_DistrictId",
                schema: "Core",
                table: "Application");

            migrationBuilder.DropColumn(
                name: "RegistrationDistrictId",
                schema: "Core",
                table: "VehicleRegistrationHistory");

            migrationBuilder.DropColumn(
                name: "TaxFrequency",
                schema: "Setup",
                table: "VehicleClassDetail");

            migrationBuilder.DropColumn(
                name: "VehicleUsageId",
                schema: "Setup",
                table: "VehicleClassDetail");

            migrationBuilder.DropColumn(
                name: "VehicleRouteTypeId",
                schema: "Core",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "Order",
                schema: "Setup",
                table: "TaxType");

            migrationBuilder.DropColumn(
                name: "TaxRuleId",
                schema: "Setup",
                table: "TaxType");

            migrationBuilder.DropColumn(
                name: "ITExemptedClause",
                schema: "Setup",
                table: "OwnerTaxGroup");

            migrationBuilder.DropColumn(
                name: "IsIncomeTaxExempted",
                schema: "Setup",
                table: "OwnerTaxGroup");

            migrationBuilder.DropColumn(
                name: "IsTaxExempted",
                schema: "Setup",
                table: "OwnerTaxGroup");

            migrationBuilder.DropColumn(
                name: "TaxExemptedClause",
                schema: "Setup",
                table: "OwnerTaxGroup");

            migrationBuilder.DropColumn(
                name: "TotalAmount",
                schema: "Core",
                table: "Challan");

            migrationBuilder.DropColumn(
                name: "DistrictId",
                schema: "Core",
                table: "AssessmentBase");

            migrationBuilder.DropColumn(
                name: "BusinessPhaseId",
                schema: "Core",
                table: "Application");

            migrationBuilder.DropColumn(
                name: "DistrictId",
                schema: "Core",
                table: "Application");

            migrationBuilder.RenameColumn(
                name: "RegistrationNo",
                schema: "Core",
                table: "VehicleRegistrationHistory",
                newName: "PreviousRegNo");

            migrationBuilder.RenameColumn(
                name: "RegistrationDate",
                schema: "Core",
                table: "VehicleRegistrationHistory",
                newName: "TaxPaidUpto");

            migrationBuilder.RenameColumn(
                name: "VehicleTypeId",
                schema: "Core",
                table: "Vehicle",
                newName: "VehicleRCStatusId");

            migrationBuilder.RenameColumn(
                name: "RegistrationDistrictId",
                schema: "Core",
                table: "Vehicle",
                newName: "DistrictId");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicle_VehicleTypeId",
                schema: "Core",
                table: "Vehicle",
                newName: "IX_Vehicle_VehicleRCStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicle_RegistrationDistrictId",
                schema: "Core",
                table: "Vehicle",
                newName: "IX_Vehicle_DistrictId");

            migrationBuilder.RenameColumn(
                name: "IsFirstGroupMember",
                schema: "Core",
                table: "OwnerGroup",
                newName: "IsFirstOwner");

            migrationBuilder.RenameColumn(
                name: "HPAStatusDated",
                schema: "Core",
                table: "HPA",
                newName: "HPACurrentStatusDate");

            migrationBuilder.RenameColumn(
                name: "BusinessProcessId",
                schema: "Core",
                table: "Application",
                newName: "ApplicationTypeId");

            migrationBuilder.RenameColumn(
                name: "BusinessPhaseStatusId",
                schema: "Core",
                table: "Application",
                newName: "ApplicationPhaseId");

            migrationBuilder.RenameIndex(
                name: "IX_Application_BusinessProcessId",
                schema: "Core",
                table: "Application",
                newName: "IX_Application_ApplicationTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Application_BusinessPhaseStatusId",
                schema: "Core",
                table: "Application",
                newName: "IX_Application_ApplicationPhaseId");

            migrationBuilder.AddColumn<DateTime>(
                name: "FirstRegistrationDate",
                schema: "Core",
                table: "VehicleRegistrationHistory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "ApplicationPhase",
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
                    table.PrimaryKey("PK_ApplicationPhase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationPhase_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "ApplicationType",
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
                    table.PrimaryKey("PK_ApplicationType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationType_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Dues",
                schema: "Core",
                columns: table => new
                {
                    DuesId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssessmentBaseId = table.Column<long>(type: "bigint", nullable: false),
                    ChallanId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Payable = table.Column<long>(type: "bigint", nullable: false),
                    PaymentStatusId = table.Column<long>(type: "bigint", nullable: false),
                    TaxTypeId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dues", x => x.DuesId);
                    table.ForeignKey(
                        name: "FK_Dues_AssessmentBase_AssessmentBaseId",
                        column: x => x.AssessmentBaseId,
                        principalSchema: "Core",
                        principalTable: "AssessmentBase",
                        principalColumn: "AssessmentBaseId");
                    table.ForeignKey(
                        name: "FK_Dues_Challan_ChallanId",
                        column: x => x.ChallanId,
                        principalSchema: "Core",
                        principalTable: "Challan",
                        principalColumn: "ChallanId");
                    table.ForeignKey(
                        name: "FK_Dues_PaymentStatus_PaymentStatusId",
                        column: x => x.PaymentStatusId,
                        principalSchema: "Setup",
                        principalTable: "PaymentStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Dues_TaxType_TaxTypeId",
                        column: x => x.TaxTypeId,
                        principalSchema: "Setup",
                        principalTable: "TaxType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Dues_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "TaxedBusinessProcess",
                schema: "Setup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    BusinessProcessId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TaxTypeId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxedBusinessProcess", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaxedBusinessProcess_BusinessProcess_BusinessProcessId",
                        column: x => x.BusinessProcessId,
                        principalSchema: "Setup",
                        principalTable: "BusinessProcess",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TaxedBusinessProcess_TaxType_TaxTypeId",
                        column: x => x.TaxTypeId,
                        principalSchema: "Setup",
                        principalTable: "TaxType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TaxedBusinessProcess_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleTax",
                schema: "Core",
                columns: table => new
                {
                    VehicleTaxId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    TaxFrequency = table.Column<long>(type: "bigint", nullable: false),
                    TaxPaidUpto = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaxTypeId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleTax", x => x.VehicleTaxId);
                    table.ForeignKey(
                        name: "FK_VehicleTax_TaxType_TaxTypeId",
                        column: x => x.TaxTypeId,
                        principalSchema: "Setup",
                        principalTable: "TaxType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleTax_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleTax_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalSchema: "Core",
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationPhase_CreatedBy",
                schema: "Setup",
                table: "ApplicationPhase",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationType_CreatedBy",
                schema: "Setup",
                table: "ApplicationType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Dues_AssessmentBaseId",
                schema: "Core",
                table: "Dues",
                column: "AssessmentBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Dues_ChallanId",
                schema: "Core",
                table: "Dues",
                column: "ChallanId");

            migrationBuilder.CreateIndex(
                name: "IX_Dues_CreatedBy",
                schema: "Core",
                table: "Dues",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Dues_PaymentStatusId",
                schema: "Core",
                table: "Dues",
                column: "PaymentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Dues_TaxTypeId",
                schema: "Core",
                table: "Dues",
                column: "TaxTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxedBusinessProcess_BusinessProcessId",
                schema: "Setup",
                table: "TaxedBusinessProcess",
                column: "BusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxedBusinessProcess_CreatedBy",
                schema: "Setup",
                table: "TaxedBusinessProcess",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TaxedBusinessProcess_TaxTypeId",
                schema: "Setup",
                table: "TaxedBusinessProcess",
                column: "TaxTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleTax_CreatedBy",
                schema: "Core",
                table: "VehicleTax",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleTax_TaxTypeId",
                schema: "Core",
                table: "VehicleTax",
                column: "TaxTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleTax_VehicleId",
                schema: "Core",
                table: "VehicleTax",
                column: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Application_ApplicationPhase_ApplicationPhaseId",
                schema: "Core",
                table: "Application",
                column: "ApplicationPhaseId",
                principalSchema: "Setup",
                principalTable: "ApplicationPhase",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Application_ApplicationType_ApplicationTypeId",
                schema: "Core",
                table: "Application",
                column: "ApplicationTypeId",
                principalSchema: "Setup",
                principalTable: "ApplicationType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_District_DistrictId",
                schema: "Core",
                table: "Vehicle",
                column: "DistrictId",
                principalSchema: "Setup",
                principalTable: "District",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_VehicleRCStatus_VehicleRCStatusId",
                schema: "Core",
                table: "Vehicle",
                column: "VehicleRCStatusId",
                principalSchema: "Setup",
                principalTable: "VehicleRCStatus",
                principalColumn: "Id");
        }
    }
}
