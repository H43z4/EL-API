using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssessmentStatus",
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
                    table.PrimaryKey("PK_AssessmentStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssessmentStatus_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "BusinessPhase",
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
                    table.PrimaryKey("PK_BusinessPhase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessPhase_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "BusinessProcess",
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
                    table.PrimaryKey("PK_BusinessProcess", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessProcess_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "ChallanStatus",
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
                    table.PrimaryKey("PK_ChallanStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChallanStatus_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "ChallanType",
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
                    table.PrimaryKey("PK_ChallanType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChallanType_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "DuesStatus",
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
                    table.PrimaryKey("PK_DuesStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DuesStatus_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "DuesType",
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
                    table.PrimaryKey("PK_DuesType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DuesType_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "PaymentMode",
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
                    table.PrimaryKey("PK_PaymentMode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentMode_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "PaymentStatus",
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
                    table.PrimaryKey("PK_PaymentStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentStatus_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "TaxType",
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
                    table.PrimaryKey("PK_TaxType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaxType_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Assessment",
                columns: table => new
                {
                    AssessmentId = table.Column<long>(type: "bigint", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Challan",
                columns: table => new
                {
                    ChallanId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    ChallanTypeId = table.Column<long>(type: "bigint", nullable: false),
                    ChallanStatusId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Challan", x => x.ChallanId);
                    table.ForeignKey(
                        name: "FK_Challan_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "Application",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_Challan_ChallanStatus_ChallanStatusId",
                        column: x => x.ChallanStatusId,
                        principalSchema: "Setup",
                        principalTable: "ChallanStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Challan_ChallanType_ChallanTypeId",
                        column: x => x.ChallanTypeId,
                        principalSchema: "Setup",
                        principalTable: "ChallanType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Challan_User_CreatedBy",
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
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    TaxTypeId = table.Column<long>(type: "bigint", nullable: false),
                    TaxFrequency = table.Column<long>(type: "bigint", nullable: false),
                    TaxPaidUpto = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleTax", x => x.VehicleTaxId);
                    table.ForeignKey(
                        name: "FK_VehicleTax_TaxType_TaxTypeId",
                        column: x => x.TaxTypeId,
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

            migrationBuilder.CreateTable(
                name: "Dues",
                columns: table => new
                {
                    DuesId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssessmentId = table.Column<long>(type: "bigint", nullable: false),
                    DuesTypeId = table.Column<long>(type: "bigint", nullable: false),
                    DuesStatusId = table.Column<long>(type: "bigint", nullable: false),
                    ChallanId = table.Column<long>(type: "bigint", nullable: true),
                    PaymentStatusId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dues", x => x.DuesId);
                    table.ForeignKey(
                        name: "FK_Dues_Assessment_AssessmentId",
                        column: x => x.AssessmentId,
                        principalTable: "Assessment",
                        principalColumn: "AssessmentId");
                    table.ForeignKey(
                        name: "FK_Dues_Challan_ChallanId",
                        column: x => x.ChallanId,
                        principalTable: "Challan",
                        principalColumn: "ChallanId");
                    table.ForeignKey(
                        name: "FK_Dues_DuesStatus_DuesStatusId",
                        column: x => x.DuesStatusId,
                        principalSchema: "Setup",
                        principalTable: "DuesStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Dues_DuesType_DuesTypeId",
                        column: x => x.DuesTypeId,
                        principalSchema: "Setup",
                        principalTable: "DuesType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Dues_PaymentStatus_PaymentStatusId",
                        column: x => x.PaymentStatusId,
                        principalSchema: "Setup",
                        principalTable: "PaymentStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Dues_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    PaymentId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChallanId = table.Column<long>(type: "bigint", nullable: false),
                    PaymentModeId = table.Column<long>(type: "bigint", nullable: false),
                    PaymentStatusId = table.Column<long>(type: "bigint", nullable: false),
                    PSId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AmountPaid = table.Column<long>(type: "bigint", nullable: false),
                    PaidOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BankCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CashReceivedBy = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_Payment_Challan_ChallanId",
                        column: x => x.ChallanId,
                        principalTable: "Challan",
                        principalColumn: "ChallanId");
                    table.ForeignKey(
                        name: "FK_Payment_PaymentMode_PaymentModeId",
                        column: x => x.PaymentModeId,
                        principalSchema: "Setup",
                        principalTable: "PaymentMode",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Payment_PaymentStatus_PaymentStatusId",
                        column: x => x.PaymentStatusId,
                        principalSchema: "Setup",
                        principalTable: "PaymentStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Payment_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "UserId");
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

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentStatus_CreatedBy",
                schema: "Setup",
                table: "AssessmentStatus",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessPhase_CreatedBy",
                schema: "Setup",
                table: "BusinessPhase",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessProcess_CreatedBy",
                schema: "Setup",
                table: "BusinessProcess",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Challan_ApplicationId",
                table: "Challan",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Challan_ChallanStatusId",
                table: "Challan",
                column: "ChallanStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Challan_ChallanTypeId",
                table: "Challan",
                column: "ChallanTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Challan_CreatedBy",
                table: "Challan",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ChallanStatus_CreatedBy",
                schema: "Setup",
                table: "ChallanStatus",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ChallanType_CreatedBy",
                schema: "Setup",
                table: "ChallanType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Dues_AssessmentId",
                table: "Dues",
                column: "AssessmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Dues_ChallanId",
                table: "Dues",
                column: "ChallanId");

            migrationBuilder.CreateIndex(
                name: "IX_Dues_CreatedBy",
                table: "Dues",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Dues_DuesStatusId",
                table: "Dues",
                column: "DuesStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Dues_DuesTypeId",
                table: "Dues",
                column: "DuesTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Dues_PaymentStatusId",
                table: "Dues",
                column: "PaymentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_DuesStatus_CreatedBy",
                schema: "Setup",
                table: "DuesStatus",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DuesType_CreatedBy",
                schema: "Setup",
                table: "DuesType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_ChallanId",
                table: "Payment",
                column: "ChallanId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_CreatedBy",
                table: "Payment",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_PaymentModeId",
                table: "Payment",
                column: "PaymentModeId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_PaymentStatusId",
                table: "Payment",
                column: "PaymentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMode_CreatedBy",
                schema: "Setup",
                table: "PaymentMode",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentStatus_CreatedBy",
                schema: "Setup",
                table: "PaymentStatus",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TaxType_CreatedBy",
                table: "TaxType",
                column: "CreatedBy");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BusinessPhase",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "Dues");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "VehicleTax",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "Assessment");

            migrationBuilder.DropTable(
                name: "DuesStatus",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "DuesType",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "Challan");

            migrationBuilder.DropTable(
                name: "PaymentMode",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "PaymentStatus",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "TaxType");

            migrationBuilder.DropTable(
                name: "AssessmentStatus",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "BusinessProcess",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "ChallanStatus",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "ChallanType",
                schema: "Setup");
        }
    }
}
