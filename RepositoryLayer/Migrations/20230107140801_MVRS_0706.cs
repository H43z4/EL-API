using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class MVRS_0706 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Setup");

            migrationBuilder.EnsureSchema(
                name: "Core");

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    AddressId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DistrictId = table.Column<long>(type: "bigint", nullable: false),
                    TehsilId = table.Column<long>(type: "bigint", nullable: true),
                    AddressTypeId = table.Column<long>(type: "bigint", nullable: false),
                    PersonId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AddressId);
                });

            migrationBuilder.CreateTable(
                name: "AssessmentBase",
                columns: table => new
                {
                    AssessmentBaseId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistrictId = table.Column<long>(type: "bigint", nullable: false),
                    AssessmentStatusId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessProcessId = table.Column<long>(type: "bigint", nullable: false),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: true),
                    OwnerId = table.Column<long>(type: "bigint", nullable: false),
                    OwnerTaxGroupId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleCategoryId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleClassId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleClassDetailId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleClassificationId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleBodyTypeId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleUsageId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleStatusId = table.Column<long>(type: "bigint", nullable: true),
                    VehiclePurchaseTypeId = table.Column<long>(type: "bigint", nullable: false),
                    EngineSize = table.Column<int>(type: "int", nullable: false),
                    SeatingCapacity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<long>(type: "bigint", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LadenWeight = table.Column<long>(type: "bigint", nullable: false),
                    UnLadenWeight = table.Column<long>(type: "bigint", nullable: false),
                    IsHPA = table.Column<bool>(type: "bit", nullable: false),
                    RegistrationNoPrice = table.Column<long>(type: "bigint", nullable: false),
                    RegistrationNo = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    TaxFrequency = table.Column<int>(type: "int", nullable: false),
                    TaxPaidUpto = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateOfFirstRegistration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsTaxExempted = table.Column<bool>(type: "bit", nullable: true),
                    IsIncomeTaxExempted = table.Column<bool>(type: "bit", nullable: true),
                    FitnessCertValidFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FitnessCertValidTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ApplicationReceivedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsFiler = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    TaxPeriod = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentBase", x => x.AssessmentBaseId);
                });

            migrationBuilder.CreateTable(
                name: "BiometricVerification",
                columns: table => new
                {
                    BiometricVerificationId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    OwnerGroupId = table.Column<long>(type: "bigint", nullable: false),
                    PersonId = table.Column<long>(type: "bigint", nullable: true),
                    IsBuyer = table.Column<bool>(type: "bit", nullable: false),
                    NadraFranchiseId = table.Column<long>(type: "bigint", nullable: true),
                    NadraTransId = table.Column<long>(type: "bigint", nullable: true),
                    IsVerified = table.Column<bool>(type: "bit", nullable: true),
                    VerificationReportedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BiometricVerification", x => x.BiometricVerificationId);
                });

            migrationBuilder.CreateTable(
                name: "Challan",
                columns: table => new
                {
                    ChallanId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    AssessmentBaseId = table.Column<long>(type: "bigint", nullable: false),
                    ChallanTypeId = table.Column<long>(type: "bigint", nullable: false),
                    ChallanStatusId = table.Column<long>(type: "bigint", nullable: false),
                    TotalAmount = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Challan", x => x.ChallanId);
                    table.ForeignKey(
                        name: "FK_Challan_AssessmentBase_AssessmentBaseId",
                        column: x => x.AssessmentBaseId,
                        principalTable: "AssessmentBase",
                        principalColumn: "AssessmentBaseId");
                });

            migrationBuilder.CreateTable(
                name: "HPA",
                columns: table => new
                {
                    HPAId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    OwnerId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: true),
                    SponserBusinessId = table.Column<long>(type: "bigint", nullable: false),
                    HPADate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HPAStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HPAEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LetterNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LetterDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Terms = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    HPACurrentStatusId = table.Column<long>(type: "bigint", nullable: false),
                    HPAStatusDated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HPA", x => x.HPAId);
                });

            migrationBuilder.CreateTable(
                name: "HPAStatusHistory",
                columns: table => new
                {
                    HPAStatusHistoryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HPAId = table.Column<long>(type: "bigint", nullable: false),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    HPAStatusId = table.Column<long>(type: "bigint", nullable: false),
                    HPAStatusDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HPAStatusHistory", x => x.HPAStatusHistoryId);
                    table.ForeignKey(
                        name: "FK_HPAStatusHistory_HPA_HPAId",
                        column: x => x.HPAId,
                        principalTable: "HPA",
                        principalColumn: "HPAId");
                });

            migrationBuilder.CreateTable(
                name: "Remarks",
                columns: table => new
                {
                    RemarksId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    OwnerId = table.Column<long>(type: "bigint", nullable: true),
                    OwnerGroupId = table.Column<long>(type: "bigint", nullable: true),
                    RemarksStatement = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Remarks", x => x.RemarksId);
                });

            migrationBuilder.CreateTable(
                name: "VehicleAuctionInfo",
                columns: table => new
                {
                    VehicleAuctionInfoId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    LotNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BatchNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CategoryNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    VoucherNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    VoucherDated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleAuctionInfo", x => x.VehicleAuctionInfoId);
                });

            migrationBuilder.CreateTable(
                name: "VehicleBusinessProcessHistory",
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
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleBusinessProcessHistory", x => x.VehicleBusinessProHistId);
                });

            migrationBuilder.CreateTable(
                name: "VehicleDocument",
                columns: table => new
                {
                    VehicleDocumentId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleDocumentTypeId = table.Column<long>(type: "bigint", nullable: false),
                    TotalPages = table.Column<int>(type: "int", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    FileExtension = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    MIMEType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    FilePath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleDocument", x => x.VehicleDocumentId);
                });

            migrationBuilder.CreateTable(
                name: "VehicleImportInfo",
                columns: table => new
                {
                    VehicleImportInfoId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    ImporterName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ImporterAddress = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IGMNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IGMDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IndexNo = table.Column<long>(type: "bigint", nullable: false),
                    PlaceOfIssue = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ImportPermitNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PermitIssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PortId = table.Column<long>(type: "bigint", nullable: false),
                    ClearingAgentId = table.Column<long>(type: "bigint", nullable: false),
                    CustomCollectorateId = table.Column<long>(type: "bigint", nullable: false),
                    CountryId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleSchemeId = table.Column<long>(type: "bigint", nullable: false),
                    ImportValue = table.Column<long>(type: "bigint", nullable: false),
                    CustomDuty = table.Column<long>(type: "bigint", nullable: false),
                    SalesTax = table.Column<long>(type: "bigint", nullable: false),
                    ImportLicenseFee = table.Column<long>(type: "bigint", nullable: false),
                    Insurrance = table.Column<long>(type: "bigint", nullable: false),
                    AnyOtherCost = table.Column<long>(type: "bigint", nullable: false),
                    LandedCost = table.Column<long>(type: "bigint", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BankId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleImportInfo", x => x.VehicleImportInfoId);
                });

            migrationBuilder.CreateTable(
                name: "VehicleOwnershipHistory",
                columns: table => new
                {
                    VehicleOwnershipHistoryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    SellerId = table.Column<long>(type: "bigint", nullable: true),
                    BuyerId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessProcessId = table.Column<long>(type: "bigint", nullable: false),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    EffectedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleOwnershipHistory", x => x.VehicleOwnershipHistoryId);
                });

            migrationBuilder.CreateTable(
                name: "VehiclePurchaseInfo",
                columns: table => new
                {
                    VehiclePurchaseInfoId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleSchemeId = table.Column<long>(type: "bigint", nullable: false),
                    DealerId = table.Column<long>(type: "bigint", nullable: false),
                    CertificateNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CertificateDated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InvoiceNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    InvoiceDated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehiclePurchaseInfo", x => x.VehiclePurchaseInfoId);
                });

            migrationBuilder.CreateTable(
                name: "RoleAppProcessFlow",
                columns: table => new
                {
                    RoleAppProcessFlowId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    AppProcessFlowId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleAppProcessFlow", x => x.RoleAppProcessFlowId);
                });

            migrationBuilder.CreateTable(
                name: "Application",
                columns: table => new
                {
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessProcessId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessPhaseId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessPhaseStatusId = table.Column<long>(type: "bigint", nullable: false),
                    ApplicationStatusId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleId = table.Column<long>(type: "bigint", nullable: true),
                    OwnerId = table.Column<long>(type: "bigint", nullable: true),
                    SellerId = table.Column<long>(type: "bigint", nullable: true),
                    DistrictId = table.Column<long>(type: "bigint", nullable: true),
                    ReceivedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Application", x => x.ApplicationId);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationProcessFlow",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsInitialProcessState = table.Column<bool>(type: "bit", nullable: false),
                    BusinessProcessId = table.Column<long>(type: "bigint", nullable: false),
                    CurrentBusinessPhaseId = table.Column<long>(type: "bigint", nullable: false),
                    CurrentBusinessPhaseStatusId = table.Column<long>(type: "bigint", nullable: false),
                    CurrentApplicationStatusId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessEventId = table.Column<long>(type: "bigint", nullable: false),
                    NextBusinessPhaseId = table.Column<long>(type: "bigint", nullable: false),
                    NextBusinessPhaseStatusId = table.Column<long>(type: "bigint", nullable: false),
                    NextApplicationStatusId = table.Column<long>(type: "bigint", nullable: false),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationProcessFlow", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BusinessTableAccessLevel",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessProcessId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessPhaseId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessPhaseStatusId = table.Column<long>(type: "bigint", nullable: false),
                    ApplicationStatusId = table.Column<long>(type: "bigint", nullable: false),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessTableId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessTableAccessId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessTableAccessLevel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PermitIssueApplication",
                schema: "Core",
                columns: table => new
                {
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<long>(type: "bigint", nullable: false),
                    ReceivedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PermitNo = table.Column<long>(type: "bigint", nullable: false),
                    OldPermitNo = table.Column<long>(type: "bigint", nullable: false),
                    DistrictId = table.Column<long>(type: "bigint", nullable: true),
                    PermitTypeId = table.Column<long>(type: "bigint", nullable: false),
                    BioStatus = table.Column<long>(type: "bigint", nullable: false),
                    PermitStatus = table.Column<long>(type: "bigint", nullable: false),
                    ApplicationStatusId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermitIssueApplication", x => x.ApplicationId);
                });

            migrationBuilder.CreateTable(
                name: "AssessmentDetail",
                columns: table => new
                {
                    AssessmentDetailId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssessmentBaseId = table.Column<long>(type: "bigint", nullable: false),
                    TaxTypeId = table.Column<long>(type: "bigint", nullable: false),
                    PayableAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentDetail", x => x.AssessmentDetailId);
                    table.ForeignKey(
                        name: "FK_AssessmentDetail_AssessmentBase_AssessmentBaseId",
                        column: x => x.AssessmentBaseId,
                        principalTable: "AssessmentBase",
                        principalColumn: "AssessmentBaseId");
                });

            migrationBuilder.CreateTable(
                name: "BusinessRep",
                columns: table => new
                {
                    BusinessRepId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessRepStatusId = table.Column<long>(type: "bigint", nullable: false),
                    PersonId = table.Column<long>(type: "bigint", nullable: false),
                    IsOwner = table.Column<bool>(type: "bit", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessRep", x => x.BusinessRepId);
                });

            migrationBuilder.CreateTable(
                name: "Dealer",
                columns: table => new
                {
                    DealerId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessId = table.Column<long>(type: "bigint", nullable: true),
                    AccountPassword = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dealer", x => x.DealerId);
                });

            migrationBuilder.CreateTable(
                name: "OwnerGroup",
                columns: table => new
                {
                    OwnerGroupId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerId = table.Column<long>(type: "bigint", nullable: false),
                    PersonId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessId = table.Column<long>(type: "bigint", nullable: true),
                    IsFirstGroupMember = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OwnerGroup", x => x.OwnerGroupId);
                });

            migrationBuilder.CreateTable(
                name: "PhoneNumber",
                columns: table => new
                {
                    PhoneNumberId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumberValue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CountryId = table.Column<long>(type: "bigint", nullable: false),
                    PhoneNumberTypeId = table.Column<long>(type: "bigint", nullable: false),
                    PersonId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumber", x => x.PhoneNumberId);
                });

            migrationBuilder.CreateTable(
                name: "BusinessProFeeTax",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessProcessId = table.Column<long>(type: "bigint", nullable: false),
                    TaxTypeId = table.Column<long>(type: "bigint", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
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
                    table.PrimaryKey("PK_BusinessProFeeTax", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleDocumentRequirement",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessProcessId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleDocumentTypeId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleDocumentRequirement", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Business",
                columns: table => new
                {
                    BusinessId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessTypeId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessSectorId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessStatusId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessRegNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BusinessName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    NTN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    FTN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    STN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AccountPassword = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Business", x => x.BusinessId);
                });

            migrationBuilder.CreateTable(
                name: "BusinessSector",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessTypeId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_BusinessSector", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    PaymentInfoId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChallanId = table.Column<long>(type: "bigint", nullable: false),
                    PaymentModeId = table.Column<long>(type: "bigint", nullable: false),
                    PaymentStatusId = table.Column<long>(type: "bigint", nullable: false),
                    PSId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AmountPaid = table.Column<long>(type: "bigint", nullable: false),
                    PaidOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BankCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CashReceivedBy = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.PaymentInfoId);
                    table.ForeignKey(
                        name: "FK_Payment_Challan_ChallanId",
                        column: x => x.ChallanId,
                        principalTable: "Challan",
                        principalColumn: "ChallanId");
                });

            migrationBuilder.CreateTable(
                name: "EPRSPerson",
                columns: table => new
                {
                    PersonId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<long>(type: "bigint", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FatherHusbandName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DateofBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CellNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CNIC = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    PassportNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisaExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EPRSPerson", x => x.PersonId);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    PersonId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<long>(type: "bigint", nullable: false),
                    PersonName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FatherHusbandName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CNIC = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    OldCNIC = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    NTN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    FTN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.PersonId);
                });

            migrationBuilder.CreateTable(
                name: "SeriesNumberPool",
                columns: table => new
                {
                    SeriesNumberPoolId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeriesCategoryId = table.Column<long>(type: "bigint", nullable: false),
                    SeriesId = table.Column<long>(type: "bigint", nullable: false),
                    SeriesNumberId = table.Column<long>(type: "bigint", nullable: false),
                    SeriesNumberStatusId = table.Column<long>(type: "bigint", nullable: false),
                    DistrictId = table.Column<long>(type: "bigint", nullable: true),
                    RegistrationNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    BasePrice = table.Column<long>(type: "bigint", nullable: false),
                    AuctionedPrice = table.Column<long>(type: "bigint", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsBlocked = table.Column<bool>(type: "bit", nullable: false),
                    IsReserved = table.Column<bool>(type: "bit", nullable: false),
                    IsAlloted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeriesNumberPool", x => x.SeriesNumberPoolId);
                });

            migrationBuilder.CreateTable(
                name: "Tehsil",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistrictId = table.Column<long>(type: "bigint", nullable: false),
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
                    table.PrimaryKey("PK_Tehsil", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    VehicleId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationNo = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RegistrationDistrictId = table.Column<long>(type: "bigint", nullable: false),
                    OwnerId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleBodyConventionId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleBodyTypeId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleCategoryId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleClassId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleClassificationId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleColorId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleEngineTypeId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleFuelTypeId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleMakeId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleMakerId = table.Column<long>(type: "bigint", nullable: true),
                    VehiclePurchaseTypeId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleStatusId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleUsageId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleRouteTypeId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleTypeId = table.Column<long>(type: "bigint", nullable: true),
                    ManufacturingYear = table.Column<int>(type: "int", nullable: false),
                    NoOfCylinder = table.Column<int>(type: "int", nullable: false),
                    EngineSize = table.Column<int>(type: "int", nullable: false),
                    HorsePower = table.Column<int>(type: "int", nullable: false),
                    ChasisNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EngineNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SeatingCapacity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<long>(type: "bigint", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LadenWeight = table.Column<long>(type: "bigint", nullable: false),
                    UnLadenWeight = table.Column<long>(type: "bigint", nullable: false),
                    WheelBase = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.VehicleId);
                });

            migrationBuilder.CreateTable(
                name: "VehicleRegistrationHistory",
                columns: table => new
                {
                    VehicleRegHistoryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    RegistrationDistrictId = table.Column<long>(type: "bigint", nullable: false),
                    RegistrationNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SeriesNumberPoolId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleRegistrationHistory", x => x.VehicleRegHistoryId);
                    table.ForeignKey(
                        name: "FK_VehicleRegistrationHistory_SeriesNumberPool_SeriesNumberPoolId",
                        column: x => x.SeriesNumberPoolId,
                        principalTable: "SeriesNumberPool",
                        principalColumn: "SeriesNumberPoolId");
                    table.ForeignKey(
                        name: "FK_VehicleRegistrationHistory_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                });

            migrationBuilder.CreateTable(
                name: "ResourceTypeRight",
                columns: table => new
                {
                    RTRightId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResourceTypeId = table.Column<long>(type: "bigint", nullable: false),
                    RTRightName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RTRightNameAbbr = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    RTRightDescription = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    IsGlobalRef = table.Column<bool>(type: "bit", nullable: false),
                    GRightId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourceTypeRight", x => x.RTRightId);
                });

            migrationBuilder.CreateTable(
                name: "Keeper",
                columns: table => new
                {
                    KeeperId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleId = table.Column<long>(type: "bigint", nullable: true),
                    KeeperPersonId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keeper", x => x.KeeperId);
                    table.ForeignKey(
                        name: "FK_Keeper_Person_KeeperPersonId",
                        column: x => x.KeeperPersonId,
                        principalTable: "Person",
                        principalColumn: "PersonId");
                    table.ForeignKey(
                        name: "FK_Keeper_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                });

            migrationBuilder.CreateTable(
                name: "Owner",
                columns: table => new
                {
                    OwnerId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerTypeId = table.Column<long>(type: "bigint", nullable: false),
                    OwnerTaxGroupId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owner", x => x.OwnerId);
                });

            migrationBuilder.CreateTable(
                name: "OwnerTaxGroupFees",
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
                });

            migrationBuilder.CreateTable(
                name: "OwnerTaxGroup",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerTypeId = table.Column<long>(type: "bigint", nullable: false),
                    IsIncomeTaxExempted = table.Column<bool>(type: "bit", nullable: false),
                    IsTaxExempted = table.Column<bool>(type: "bit", nullable: false),
                    ITExemptedClause = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TaxExemptedClause = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
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
                    table.PrimaryKey("PK_OwnerTaxGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PermitApplicationDetail",
                schema: "Core",
                columns: table => new
                {
                    ApplicationDetailId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    PMFLTypeId = table.Column<long>(type: "bigint", nullable: false),
                    BottleSizeId = table.Column<long>(type: "bigint", nullable: false),
                    Quantity = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermitApplicationDetail", x => x.ApplicationDetailId);
                    table.ForeignKey(
                        name: "FK_PermitApplicationDetail_PermitIssueApplication_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "Core",
                        principalTable: "PermitIssueApplication",
                        principalColumn: "ApplicationId");
                });

            migrationBuilder.CreateTable(
                name: "RoleResource",
                columns: table => new
                {
                    RoleResourceId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    ResourceId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleResource", x => x.RoleResourceId);
                });

            migrationBuilder.CreateTable(
                name: "RoleResourceRightsHistory",
                columns: table => new
                {
                    RoleRightsHistoryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    ResourceId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleResourceRightsHistory", x => x.RoleRightsHistoryId);
                });

            migrationBuilder.CreateTable(
                name: "Resource",
                columns: table => new
                {
                    ResourceId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResourceTypeId = table.Column<long>(type: "bigint", nullable: false),
                    ResourceName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ResourceNameAbbr = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ResourceDescription = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    ResourceEndPoint = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false),
                    ControllerId = table.Column<long>(type: "bigint", nullable: true),
                    ActionId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resource", x => x.ResourceId);
                });

            migrationBuilder.CreateTable(
                name: "ResourceTypeDefaultRight",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RTRightId = table.Column<long>(type: "bigint", nullable: false),
                    DefaultRTRightId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourceTypeDefaultRight", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResourceTypeDefaultRight_ResourceTypeRight_DefaultRTRightId",
                        column: x => x.DefaultRTRightId,
                        principalTable: "ResourceTypeRight",
                        principalColumn: "RTRightId");
                    table.ForeignKey(
                        name: "FK_ResourceTypeDefaultRight_ResourceTypeRight_RTRightId",
                        column: x => x.RTRightId,
                        principalTable: "ResourceTypeRight",
                        principalColumn: "RTRightId");
                });

            migrationBuilder.CreateTable(
                name: "RoleResourceRight",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleResourceId = table.Column<long>(type: "bigint", nullable: false),
                    RTRightId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleResourceRight", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleResourceRight_ResourceTypeRight_RTRightId",
                        column: x => x.RTRightId,
                        principalTable: "ResourceTypeRight",
                        principalColumn: "RTRightId");
                    table.ForeignKey(
                        name: "FK_RoleResourceRight_RoleResource_RoleResourceId",
                        column: x => x.RoleResourceId,
                        principalTable: "RoleResource",
                        principalColumn: "RoleResourceId");
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    UserRoleId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    IsTimeBased = table.Column<bool>(type: "bit", nullable: false),
                    ExpiryDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.UserRoleId);
                });

            migrationBuilder.CreateTable(
                name: "UserRoleHistory",
                columns: table => new
                {
                    UserRoleHistoryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    Action = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoleHistory", x => x.UserRoleHistoryId);
                });

            migrationBuilder.CreateTable(
                name: "AuctionResult",
                columns: table => new
                {
                    AuctionResultId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeriesCategoryId = table.Column<long>(type: "bigint", nullable: false),
                    SeriesId = table.Column<long>(type: "bigint", nullable: false),
                    SeriesNumberId = table.Column<long>(type: "bigint", nullable: false),
                    AuctionedValue = table.Column<long>(type: "bigint", nullable: false),
                    WinnerAIN = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ChasisNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OwnerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    WinnerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FatherHusbandName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CNIC = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    NTN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuctionResult", x => x.AuctionResultId);
                });

            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    SeriesId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeriesTypeId = table.Column<long>(type: "bigint", nullable: false),
                    SeriesCategoryId = table.Column<long>(type: "bigint", nullable: false),
                    SeriesStatusId = table.Column<long>(type: "bigint", nullable: false),
                    SeriesName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.SeriesId);
                });

            migrationBuilder.CreateTable(
                name: "TaxRate",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleClassId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleClassDetailId = table.Column<long>(type: "bigint", nullable: false),
                    TaxTypeId = table.Column<long>(type: "bigint", nullable: false),
                    TaxBaseId = table.Column<long>(type: "bigint", nullable: false),
                    TaxValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                    table.PrimaryKey("PK_TaxRate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaxType",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaxRuleId = table.Column<long>(type: "bigint", nullable: true),
                    Order = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_TaxType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountHead",
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
                    table.PrimaryKey("PK_AccountHead", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AddressType",
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
                    table.PrimaryKey("PK_AddressType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationStatus",
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
                    table.PrimaryKey("PK_ApplicationStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AssessmentStatus",
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
                    table.PrimaryKey("PK_AssessmentStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bank",
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
                    table.PrimaryKey("PK_Bank", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BusinessEvent",
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
                    table.PrimaryKey("PK_BusinessEvent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BusinessPhase",
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
                    table.PrimaryKey("PK_BusinessPhase", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BusinessPhaseStatus",
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
                    table.PrimaryKey("PK_BusinessPhaseStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BusinessProcess",
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
                    table.PrimaryKey("PK_BusinessProcess", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BusinessRepStatus",
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
                    table.PrimaryKey("PK_BusinessRepStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BusinessStatus",
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
                    table.PrimaryKey("PK_BusinessStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BusinessTable",
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
                    table.PrimaryKey("PK_BusinessTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BusinessTableAccess",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccessLevel = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_BusinessTableAccess", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BusinessType",
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
                    table.PrimaryKey("PK_BusinessType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChallanStatus",
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
                    table.PrimaryKey("PK_ChallanStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChallanType",
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
                    table.PrimaryKey("PK_ChallanType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClearingAgent",
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
                    table.PrimaryKey("PK_ClearingAgent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
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
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomCollectorate",
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
                    table.PrimaryKey("PK_CustomCollectorate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "District",
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
                    table.PrimaryKey("PK_District", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EPRSPermitTypes",
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
                    table.PrimaryKey("PK_EPRSPermitTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GlobalRight",
                columns: table => new
                {
                    GRightId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GRightName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GRightNameAbbr = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    GRightDescription = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    IsOnResourceLevel = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GlobalRight", x => x.GRightId);
                });

            migrationBuilder.CreateTable(
                name: "HPAStatus",
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
                    table.PrimaryKey("PK_HPAStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HttpRequestLog",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Method = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestHeaders = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResponseHeaders = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestBody = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResponseBody = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResponseStatusCode = table.Column<int>(type: "int", nullable: false),
                    IsExceptionRaised = table.Column<bool>(type: "bit", nullable: false),
                    ExceptionMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StackTrace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TraceId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HttpRequestLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NadraFranchise",
                columns: table => new
                {
                    NadraFranchiseId = table.Column<long>(type: "bigint", nullable: false),
                    FranchiseName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FranchiseShopName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FranchiseCellNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NadraFranchise", x => x.NadraFranchiseId);
                });

            migrationBuilder.CreateTable(
                name: "OrganizationCategory",
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
                    table.PrimaryKey("PK_OrganizationCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OwnerStatus",
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
                    table.PrimaryKey("PK_OwnerStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OwnerType",
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
                    table.PrimaryKey("PK_OwnerType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMode",
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
                    table.PrimaryKey("PK_PaymentMode", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentStatus",
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
                    table.PrimaryKey("PK_PaymentStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PermitTypes",
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
                    table.PrimaryKey("PK_PermitTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhoneNumberType",
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
                    table.PrimaryKey("PK_PhoneNumberType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Port",
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
                    table.PrimaryKey("PK_Port", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegFeePenaltyRate",
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
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegFeePenaltyRate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResourceAction",
                columns: table => new
                {
                    ResourceActionId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActionName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourceAction", x => x.ResourceActionId);
                });

            migrationBuilder.CreateTable(
                name: "ResourceController",
                columns: table => new
                {
                    ResourceControllerId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ControllerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourceController", x => x.ResourceControllerId);
                });

            migrationBuilder.CreateTable(
                name: "ResourceType",
                columns: table => new
                {
                    ResourceTypeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResourceTypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ResourceTypeNameAbbr = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ResourceTypeDescription = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourceType", x => x.ResourceTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RoleNameAbbr = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    RoleDescription = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "SeriesCategory",
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
                    table.PrimaryKey("PK_SeriesCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SeriesNumber",
                columns: table => new
                {
                    SeriesNumberId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeriesNumberName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeriesNumber", x => x.SeriesNumberId);
                });

            migrationBuilder.CreateTable(
                name: "SeriesNumberStatus",
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
                    table.PrimaryKey("PK_SeriesNumberStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SeriesStatus",
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
                    table.PrimaryKey("PK_SeriesStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SeriesType",
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
                    table.PrimaryKey("PK_SeriesType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SqlExceptionLog",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ErrorNumber = table.Column<int>(type: "int", nullable: false),
                    ErrorState = table.Column<int>(type: "int", nullable: false),
                    ErrorSeverity = table.Column<int>(type: "int", nullable: false),
                    ErrorLine = table.Column<int>(type: "int", nullable: false),
                    ErrorProcedure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ErrorMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ErrorDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SqlExceptionLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaxBase",
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
                    table.PrimaryKey("PK_TaxBase", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaxRule",
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
                    table.PrimaryKey("PK_TaxRule", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserStatus",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserType",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessId = table.Column<long>(type: "bigint", nullable: true),
                    UserDistrictId = table.Column<long>(type: "bigint", nullable: true),
                    UserStatusId = table.Column<long>(type: "bigint", nullable: false),
                    UserTypeId = table.Column<long>(type: "bigint", nullable: true),
                    SiteOfficeId = table.Column<long>(type: "bigint", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_User_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_User_UserStatus_UserStatusId",
                        column: x => x.UserStatusId,
                        principalTable: "UserStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_User_UserType_UserTypeId",
                        column: x => x.UserTypeId,
                        principalTable: "UserType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VehicleBodyConvention",
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
                    table.PrimaryKey("PK_VehicleBodyConvention", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleBodyConvention_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleBodyConvention_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleBodyType",
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
                    table.PrimaryKey("PK_VehicleBodyType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleBodyType_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleBodyType_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleCategory",
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
                    table.PrimaryKey("PK_VehicleCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleCategory_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleCategory_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleClassGroup",
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
                    table.PrimaryKey("PK_VehicleClassGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleClassGroup_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleClassGroup_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleClassification",
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
                    table.PrimaryKey("PK_VehicleClassification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleClassification_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleClassification_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleColor",
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
                    table.PrimaryKey("PK_VehicleColor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleColor_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleColor_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleDocumentType",
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
                    table.PrimaryKey("PK_VehicleDocumentType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleDocumentType_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleDocumentType_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleEngineType",
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
                    table.PrimaryKey("PK_VehicleEngineType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleEngineType_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleEngineType_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleFuelType",
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
                    table.PrimaryKey("PK_VehicleFuelType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleFuelType_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleFuelType_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleMaker",
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
                    table.PrimaryKey("PK_VehicleMaker", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleMaker_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleMaker_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "VehiclePurchaseType",
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
                    table.PrimaryKey("PK_VehiclePurchaseType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehiclePurchaseType_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehiclePurchaseType_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleRCStatus",
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
                    table.PrimaryKey("PK_VehicleRCStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleRCStatus_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleRCStatus_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleRouteType",
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
                    table.PrimaryKey("PK_VehicleRouteType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleRouteType_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleRouteType_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleScheme",
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
                    table.PrimaryKey("PK_VehicleScheme", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleScheme_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleScheme_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleStatus",
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
                    table.PrimaryKey("PK_VehicleStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleStatus_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleStatus_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleType",
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
                    table.PrimaryKey("PK_VehicleType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleType_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleType_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleUsage",
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
                    table.PrimaryKey("PK_VehicleUsage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleUsage_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleUsage_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "VehicleMake",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleMakerId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_VehicleMake", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleMake_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleMake_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleMake_VehicleMaker_VehicleMakerId",
                        column: x => x.VehicleMakerId,
                        principalTable: "VehicleMaker",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VehicleAdditionalInfo",
                columns: table => new
                {
                    VehicleAdditionalInfoId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleRCStatusId = table.Column<long>(type: "bigint", nullable: true),
                    TaxFrequency = table.Column<int>(type: "int", nullable: false),
                    TaxPeriod = table.Column<int>(type: "int", nullable: false),
                    IsHPA = table.Column<bool>(type: "bit", nullable: false),
                    IsTaxExempted = table.Column<bool>(type: "bit", nullable: true),
                    IsIncomeTaxExempted = table.Column<bool>(type: "bit", nullable: true),
                    DateOfFirstRegistration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FitnessCertValidFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FitnessCertValidTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaxPaidUpto = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RegistrationNoPrice = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleAdditionalInfo", x => x.VehicleAdditionalInfoId);
                    table.ForeignKey(
                        name: "FK_VehicleAdditionalInfo_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleAdditionalInfo_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleAdditionalInfo_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId");
                    table.ForeignKey(
                        name: "FK_VehicleAdditionalInfo_VehicleRCStatus_VehicleRCStatusId",
                        column: x => x.VehicleRCStatusId,
                        principalTable: "VehicleRCStatus",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VehicleClass",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleBodyTypeId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleCategoryId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleClassificationId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleRouteTypeId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleTypeId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleClassGroupId = table.Column<long>(type: "bigint", nullable: false),
                    EngineSizeMin = table.Column<long>(type: "bigint", nullable: false),
                    EngineSizeMax = table.Column<long>(type: "bigint", nullable: false),
                    SeatingCapacityMin = table.Column<long>(type: "bigint", nullable: false),
                    SeatingCapacityMax = table.Column<long>(type: "bigint", nullable: false),
                    LadenWeightMin = table.Column<long>(type: "bigint", nullable: false),
                    LadenWeightMax = table.Column<long>(type: "bigint", nullable: false),
                    UnladenWeightMin = table.Column<long>(type: "bigint", nullable: false),
                    UnladenWeightMax = table.Column<long>(type: "bigint", nullable: false),
                    FitnessDocRequired = table.Column<bool>(type: "bit", nullable: false),
                    AppliedFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaxFrequency = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_VehicleClass", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleClass_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleClass_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleClass_VehicleBodyType_VehicleBodyTypeId",
                        column: x => x.VehicleBodyTypeId,
                        principalTable: "VehicleBodyType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleClass_VehicleCategory_VehicleCategoryId",
                        column: x => x.VehicleCategoryId,
                        principalTable: "VehicleCategory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleClass_VehicleClassGroup_VehicleClassGroupId",
                        column: x => x.VehicleClassGroupId,
                        principalTable: "VehicleClassGroup",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleClass_VehicleClassification_VehicleClassificationId",
                        column: x => x.VehicleClassificationId,
                        principalTable: "VehicleClassification",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleClass_VehicleRouteType_VehicleRouteTypeId",
                        column: x => x.VehicleRouteTypeId,
                        principalTable: "VehicleRouteType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleClass_VehicleType_VehicleTypeId",
                        column: x => x.VehicleTypeId,
                        principalTable: "VehicleType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VehicleClassDetail",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleClassId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleBodyTypeId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleCategoryId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleClassificationId = table.Column<long>(type: "bigint", nullable: false),
                    VehicleRouteTypeId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleTypeId = table.Column<long>(type: "bigint", nullable: true),
                    VehicleUsageId = table.Column<long>(type: "bigint", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    EngineSizeMin = table.Column<long>(type: "bigint", nullable: false),
                    EngineSizeMax = table.Column<long>(type: "bigint", nullable: false),
                    SeatingCapacityMin = table.Column<long>(type: "bigint", nullable: false),
                    SeatingCapacityMax = table.Column<long>(type: "bigint", nullable: false),
                    LadenWeightMin = table.Column<long>(type: "bigint", nullable: false),
                    LadenWeightMax = table.Column<long>(type: "bigint", nullable: false),
                    UnladenWeightMin = table.Column<long>(type: "bigint", nullable: false),
                    UnladenWeightMax = table.Column<long>(type: "bigint", nullable: false),
                    FitnessDocRequired = table.Column<bool>(type: "bit", nullable: false),
                    AppliedFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaxFrequency = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_VehicleClassDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleClassDetail_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleClassDetail_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_VehicleClassDetail_VehicleBodyType_VehicleBodyTypeId",
                        column: x => x.VehicleBodyTypeId,
                        principalTable: "VehicleBodyType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleClassDetail_VehicleCategory_VehicleCategoryId",
                        column: x => x.VehicleCategoryId,
                        principalTable: "VehicleCategory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleClassDetail_VehicleClass_VehicleClassId",
                        column: x => x.VehicleClassId,
                        principalTable: "VehicleClass",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleClassDetail_VehicleClassification_VehicleClassificationId",
                        column: x => x.VehicleClassificationId,
                        principalTable: "VehicleClassification",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleClassDetail_VehicleRouteType_VehicleRouteTypeId",
                        column: x => x.VehicleRouteTypeId,
                        principalTable: "VehicleRouteType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleClassDetail_VehicleType_VehicleTypeId",
                        column: x => x.VehicleTypeId,
                        principalTable: "VehicleType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleClassDetail_VehicleUsage_VehicleUsageId",
                        column: x => x.VehicleUsageId,
                        principalTable: "VehicleUsage",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccountHead_CreatedBy",
                table: "AccountHead",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AccountHead_ModifiedBy",
                table: "AccountHead",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Address_AddressTypeId",
                table: "Address",
                column: "AddressTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_BusinessId",
                table: "Address",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_CreatedBy",
                table: "Address",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Address_DistrictId",
                table: "Address",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_ModifiedBy",
                table: "Address",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Address_PersonId",
                table: "Address",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_TehsilId",
                table: "Address",
                column: "TehsilId");

            migrationBuilder.CreateIndex(
                name: "IX_AddressType_CreatedBy",
                table: "AddressType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AddressType_ModifiedBy",
                table: "AddressType",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Application_ApplicationStatusId",
                table: "Application",
                column: "ApplicationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_BusinessPhaseId",
                table: "Application",
                column: "BusinessPhaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_BusinessPhaseStatusId",
                table: "Application",
                column: "BusinessPhaseStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_BusinessProcessId",
                table: "Application",
                column: "BusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_CreatedBy",
                table: "Application",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Application_DistrictId",
                table: "Application",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_ModifiedBy",
                table: "Application",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Application_OwnerId",
                table: "Application",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_SellerId",
                table: "Application",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_VehicleId",
                table: "Application",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationProcessFlow_BusinessEventId",
                table: "ApplicationProcessFlow",
                column: "BusinessEventId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationProcessFlow_BusinessProcessId",
                table: "ApplicationProcessFlow",
                column: "BusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationProcessFlow_CreatedBy",
                table: "ApplicationProcessFlow",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationProcessFlow_CurrentApplicationStatusId",
                table: "ApplicationProcessFlow",
                column: "CurrentApplicationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationProcessFlow_CurrentBusinessPhaseId",
                table: "ApplicationProcessFlow",
                column: "CurrentBusinessPhaseId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationProcessFlow_CurrentBusinessPhaseStatusId",
                table: "ApplicationProcessFlow",
                column: "CurrentBusinessPhaseStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationProcessFlow_ModifiedBy",
                table: "ApplicationProcessFlow",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationProcessFlow_NextApplicationStatusId",
                table: "ApplicationProcessFlow",
                column: "NextApplicationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationProcessFlow_NextBusinessPhaseId",
                table: "ApplicationProcessFlow",
                column: "NextBusinessPhaseId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationProcessFlow_NextBusinessPhaseStatusId",
                table: "ApplicationProcessFlow",
                column: "NextBusinessPhaseStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationProcessFlow_RoleId",
                table: "ApplicationProcessFlow",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationStatus_CreatedBy",
                table: "ApplicationStatus",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationStatus_ModifiedBy",
                table: "ApplicationStatus",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_ApplicationId",
                table: "AssessmentBase",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_AssessmentStatusId",
                table: "AssessmentBase",
                column: "AssessmentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_BusinessProcessId",
                table: "AssessmentBase",
                column: "BusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_CreatedBy",
                table: "AssessmentBase",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_DistrictId",
                table: "AssessmentBase",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_ModifiedBy",
                table: "AssessmentBase",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_OwnerId",
                table: "AssessmentBase",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_OwnerTaxGroupId",
                table: "AssessmentBase",
                column: "OwnerTaxGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_VehicleBodyTypeId",
                table: "AssessmentBase",
                column: "VehicleBodyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_VehicleCategoryId",
                table: "AssessmentBase",
                column: "VehicleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_VehicleClassDetailId",
                table: "AssessmentBase",
                column: "VehicleClassDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_VehicleClassId",
                table: "AssessmentBase",
                column: "VehicleClassId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_VehicleClassificationId",
                table: "AssessmentBase",
                column: "VehicleClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_VehicleId",
                table: "AssessmentBase",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_VehiclePurchaseTypeId",
                table: "AssessmentBase",
                column: "VehiclePurchaseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_VehicleStatusId",
                table: "AssessmentBase",
                column: "VehicleStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_VehicleUsageId",
                table: "AssessmentBase",
                column: "VehicleUsageId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentDetail_AssessmentBaseId",
                table: "AssessmentDetail",
                column: "AssessmentBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentDetail_CreatedBy",
                table: "AssessmentDetail",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentDetail_ModifiedBy",
                table: "AssessmentDetail",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentDetail_TaxTypeId",
                table: "AssessmentDetail",
                column: "TaxTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentStatus_CreatedBy",
                table: "AssessmentStatus",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentStatus_ModifiedBy",
                table: "AssessmentStatus",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AuctionResult_CreatedBy",
                table: "AuctionResult",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AuctionResult_ModifiedBy",
                table: "AuctionResult",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AuctionResult_SeriesCategoryId",
                table: "AuctionResult",
                column: "SeriesCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AuctionResult_SeriesId",
                table: "AuctionResult",
                column: "SeriesId");

            migrationBuilder.CreateIndex(
                name: "IX_AuctionResult_SeriesNumberId",
                table: "AuctionResult",
                column: "SeriesNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_Bank_CreatedBy",
                table: "Bank",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Bank_ModifiedBy",
                table: "Bank",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BiometricVerification_ApplicationId",
                table: "BiometricVerification",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_BiometricVerification_CreatedBy",
                table: "BiometricVerification",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BiometricVerification_ModifiedBy",
                table: "BiometricVerification",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BiometricVerification_NadraFranchiseId",
                table: "BiometricVerification",
                column: "NadraFranchiseId");

            migrationBuilder.CreateIndex(
                name: "IX_BiometricVerification_OwnerGroupId",
                table: "BiometricVerification",
                column: "OwnerGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_BiometricVerification_PersonId",
                table: "BiometricVerification",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_BiometricVerification_VehicleId",
                table: "BiometricVerification",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Business_BusinessSectorId",
                table: "Business",
                column: "BusinessSectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Business_BusinessStatusId",
                table: "Business",
                column: "BusinessStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Business_BusinessTypeId",
                table: "Business",
                column: "BusinessTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Business_CreatedBy",
                table: "Business",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Business_ModifiedBy",
                table: "Business",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessEvent_CreatedBy",
                table: "BusinessEvent",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessEvent_ModifiedBy",
                table: "BusinessEvent",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessPhase_CreatedBy",
                table: "BusinessPhase",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessPhase_ModifiedBy",
                table: "BusinessPhase",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessPhaseStatus_CreatedBy",
                table: "BusinessPhaseStatus",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessPhaseStatus_ModifiedBy",
                table: "BusinessPhaseStatus",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessProcess_CreatedBy",
                table: "BusinessProcess",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessProcess_ModifiedBy",
                table: "BusinessProcess",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessProFeeTax_BusinessProcessId",
                table: "BusinessProFeeTax",
                column: "BusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessProFeeTax_CreatedBy",
                table: "BusinessProFeeTax",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessProFeeTax_ModifiedBy",
                table: "BusinessProFeeTax",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessProFeeTax_TaxTypeId",
                table: "BusinessProFeeTax",
                column: "TaxTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessRep_BusinessId",
                table: "BusinessRep",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessRep_BusinessRepStatusId",
                table: "BusinessRep",
                column: "BusinessRepStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessRep_CreatedBy",
                table: "BusinessRep",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessRep_ModifiedBy",
                table: "BusinessRep",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessRep_PersonId",
                table: "BusinessRep",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessRepStatus_CreatedBy",
                table: "BusinessRepStatus",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessRepStatus_ModifiedBy",
                table: "BusinessRepStatus",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessSector_BusinessTypeId",
                table: "BusinessSector",
                column: "BusinessTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessSector_CreatedBy",
                table: "BusinessSector",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessSector_ModifiedBy",
                table: "BusinessSector",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessStatus_CreatedBy",
                table: "BusinessStatus",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessStatus_ModifiedBy",
                table: "BusinessStatus",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTable_CreatedBy",
                table: "BusinessTable",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTable_ModifiedBy",
                table: "BusinessTable",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTableAccess_CreatedBy",
                table: "BusinessTableAccess",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTableAccess_ModifiedBy",
                table: "BusinessTableAccess",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTableAccessLevel_ApplicationStatusId",
                table: "BusinessTableAccessLevel",
                column: "ApplicationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTableAccessLevel_BusinessPhaseId",
                table: "BusinessTableAccessLevel",
                column: "BusinessPhaseId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTableAccessLevel_BusinessPhaseStatusId",
                table: "BusinessTableAccessLevel",
                column: "BusinessPhaseStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTableAccessLevel_BusinessProcessId",
                table: "BusinessTableAccessLevel",
                column: "BusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTableAccessLevel_BusinessTableAccessId",
                table: "BusinessTableAccessLevel",
                column: "BusinessTableAccessId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTableAccessLevel_BusinessTableId",
                table: "BusinessTableAccessLevel",
                column: "BusinessTableId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTableAccessLevel_CreatedBy",
                table: "BusinessTableAccessLevel",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTableAccessLevel_ModifiedBy",
                table: "BusinessTableAccessLevel",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTableAccessLevel_RoleId",
                table: "BusinessTableAccessLevel",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessType_CreatedBy",
                table: "BusinessType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessType_ModifiedBy",
                table: "BusinessType",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Challan_ApplicationId",
                table: "Challan",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Challan_AssessmentBaseId",
                table: "Challan",
                column: "AssessmentBaseId");

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
                name: "IX_Challan_ModifiedBy",
                table: "Challan",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ChallanStatus_CreatedBy",
                table: "ChallanStatus",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ChallanStatus_ModifiedBy",
                table: "ChallanStatus",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ChallanType_CreatedBy",
                table: "ChallanType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ChallanType_ModifiedBy",
                table: "ChallanType",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ClearingAgent_CreatedBy",
                table: "ClearingAgent",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ClearingAgent_ModifiedBy",
                table: "ClearingAgent",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Country_CreatedBy",
                table: "Country",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Country_ModifiedBy",
                table: "Country",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CustomCollectorate_CreatedBy",
                table: "CustomCollectorate",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CustomCollectorate_ModifiedBy",
                table: "CustomCollectorate",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Dealer_BusinessId",
                table: "Dealer",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_Dealer_CreatedBy",
                table: "Dealer",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Dealer_ModifiedBy",
                table: "Dealer",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_District_CreatedBy",
                table: "District",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_District_ModifiedBy",
                table: "District",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_EPRSPermitTypes_CreatedBy",
                schema: "Setup",
                table: "EPRSPermitTypes",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_EPRSPermitTypes_ModifiedBy",
                schema: "Setup",
                table: "EPRSPermitTypes",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_EPRSPerson_CountryId",
                table: "EPRSPerson",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_EPRSPerson_CreatedBy",
                table: "EPRSPerson",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_EPRSPerson_ModifiedBy",
                table: "EPRSPerson",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalRight_CreatedBy",
                table: "GlobalRight",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_GlobalRight_ModifiedBy",
                table: "GlobalRight",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_HPA_ApplicationId",
                table: "HPA",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_HPA_CreatedBy",
                table: "HPA",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_HPA_HPACurrentStatusId",
                table: "HPA",
                column: "HPACurrentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_HPA_ModifiedBy",
                table: "HPA",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_HPA_OwnerId",
                table: "HPA",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_HPA_SponserBusinessId",
                table: "HPA",
                column: "SponserBusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_HPA_VehicleId",
                table: "HPA",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_HPAStatus_CreatedBy",
                table: "HPAStatus",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_HPAStatus_ModifiedBy",
                table: "HPAStatus",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_HPAStatusHistory_ApplicationId",
                table: "HPAStatusHistory",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_HPAStatusHistory_CreatedBy",
                table: "HPAStatusHistory",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_HPAStatusHistory_HPAId",
                table: "HPAStatusHistory",
                column: "HPAId");

            migrationBuilder.CreateIndex(
                name: "IX_HPAStatusHistory_HPAStatusId",
                table: "HPAStatusHistory",
                column: "HPAStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_HPAStatusHistory_ModifiedBy",
                table: "HPAStatusHistory",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_HttpRequestLog_CreatedBy",
                table: "HttpRequestLog",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_HttpRequestLog_ModifiedBy",
                table: "HttpRequestLog",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Keeper_CreatedBy",
                table: "Keeper",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Keeper_KeeperPersonId",
                table: "Keeper",
                column: "KeeperPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Keeper_ModifiedBy",
                table: "Keeper",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Keeper_OwnerId",
                table: "Keeper",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Keeper_VehicleId",
                table: "Keeper",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_NadraFranchise_CreatedBy",
                table: "NadraFranchise",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_NadraFranchise_ModifiedBy",
                table: "NadraFranchise",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationCategory_CreatedBy",
                table: "OrganizationCategory",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationCategory_ModifiedBy",
                table: "OrganizationCategory",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Owner_CreatedBy",
                table: "Owner",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Owner_ModifiedBy",
                table: "Owner",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Owner_OwnerTaxGroupId",
                table: "Owner",
                column: "OwnerTaxGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Owner_OwnerTypeId",
                table: "Owner",
                column: "OwnerTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerGroup_BusinessId",
                table: "OwnerGroup",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerGroup_CreatedBy",
                table: "OwnerGroup",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerGroup_ModifiedBy",
                table: "OwnerGroup",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerGroup_OwnerId",
                table: "OwnerGroup",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerGroup_PersonId",
                table: "OwnerGroup",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerStatus_CreatedBy",
                table: "OwnerStatus",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerStatus_ModifiedBy",
                table: "OwnerStatus",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerTaxGroup_CreatedBy",
                table: "OwnerTaxGroup",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerTaxGroup_ModifiedBy",
                table: "OwnerTaxGroup",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerTaxGroup_OwnerTypeId",
                table: "OwnerTaxGroup",
                column: "OwnerTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerTaxGroupFees_OwnerTaxGroupId",
                table: "OwnerTaxGroupFees",
                column: "OwnerTaxGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerTaxGroupFees_TaxTypeId",
                table: "OwnerTaxGroupFees",
                column: "TaxTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerType_CreatedBy",
                table: "OwnerType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerType_ModifiedBy",
                table: "OwnerType",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_ChallanId",
                table: "Payment",
                column: "ChallanId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_CreatedBy",
                table: "Payment",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_ModifiedBy",
                table: "Payment",
                column: "ModifiedBy");

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
                table: "PaymentMode",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMode_ModifiedBy",
                table: "PaymentMode",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentStatus_CreatedBy",
                table: "PaymentStatus",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentStatus_ModifiedBy",
                table: "PaymentStatus",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PermitApplicationDetail_ApplicationId",
                schema: "Core",
                table: "PermitApplicationDetail",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_PermitApplicationDetail_CreatedBy",
                schema: "Core",
                table: "PermitApplicationDetail",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PermitApplicationDetail_ModifiedBy",
                schema: "Core",
                table: "PermitApplicationDetail",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PermitIssueApplication_ApplicationStatusId",
                schema: "Core",
                table: "PermitIssueApplication",
                column: "ApplicationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PermitIssueApplication_CreatedBy",
                schema: "Core",
                table: "PermitIssueApplication",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PermitIssueApplication_DistrictId",
                schema: "Core",
                table: "PermitIssueApplication",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_PermitIssueApplication_ModifiedBy",
                schema: "Core",
                table: "PermitIssueApplication",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PermitIssueApplication_PermitTypeId",
                schema: "Core",
                table: "PermitIssueApplication",
                column: "PermitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PermitIssueApplication_PersonId",
                schema: "Core",
                table: "PermitIssueApplication",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PermitTypes_CreatedBy",
                table: "PermitTypes",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PermitTypes_ModifiedBy",
                table: "PermitTypes",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Person_CountryId",
                table: "Person",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_CreatedBy",
                table: "Person",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Person_ModifiedBy",
                table: "Person",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumber_BusinessId",
                table: "PhoneNumber",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumber_CountryId",
                table: "PhoneNumber",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumber_CreatedBy",
                table: "PhoneNumber",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumber_ModifiedBy",
                table: "PhoneNumber",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumber_PersonId",
                table: "PhoneNumber",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumber_PhoneNumberTypeId",
                table: "PhoneNumber",
                column: "PhoneNumberTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumberType_CreatedBy",
                table: "PhoneNumberType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumberType_ModifiedBy",
                table: "PhoneNumberType",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Port_CreatedBy",
                table: "Port",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Port_ModifiedBy",
                table: "Port",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_RegFeePenaltyRate_CreatedBy",
                table: "RegFeePenaltyRate",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_RegFeePenaltyRate_ModifiedBy",
                table: "RegFeePenaltyRate",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Remarks_ApplicationId",
                table: "Remarks",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Remarks_CreatedBy",
                table: "Remarks",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Remarks_ModifiedBy",
                table: "Remarks",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Remarks_OwnerGroupId",
                table: "Remarks",
                column: "OwnerGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Remarks_OwnerId",
                table: "Remarks",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Remarks_RoleId",
                table: "Remarks",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Remarks_VehicleId",
                table: "Remarks",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Resource_ActionId",
                table: "Resource",
                column: "ActionId");

            migrationBuilder.CreateIndex(
                name: "IX_Resource_ControllerId",
                table: "Resource",
                column: "ControllerId");

            migrationBuilder.CreateIndex(
                name: "IX_Resource_CreatedBy",
                table: "Resource",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Resource_ModifiedBy",
                table: "Resource",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Resource_ResourceTypeId",
                table: "Resource",
                column: "ResourceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceAction_CreatedBy",
                table: "ResourceAction",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceAction_ModifiedBy",
                table: "ResourceAction",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceController_CreatedBy",
                table: "ResourceController",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceController_ModifiedBy",
                table: "ResourceController",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceType_CreatedBy",
                table: "ResourceType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceType_ModifiedBy",
                table: "ResourceType",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceTypeDefaultRight_CreatedBy",
                table: "ResourceTypeDefaultRight",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceTypeDefaultRight_DefaultRTRightId",
                table: "ResourceTypeDefaultRight",
                column: "DefaultRTRightId");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceTypeDefaultRight_ModifiedBy",
                table: "ResourceTypeDefaultRight",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceTypeDefaultRight_RTRightId",
                table: "ResourceTypeDefaultRight",
                column: "RTRightId");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceTypeRight_CreatedBy",
                table: "ResourceTypeRight",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceTypeRight_GRightId",
                table: "ResourceTypeRight",
                column: "GRightId");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceTypeRight_ModifiedBy",
                table: "ResourceTypeRight",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceTypeRight_ResourceTypeId",
                table: "ResourceTypeRight",
                column: "ResourceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Role_CreatedBy",
                table: "Role",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Role_ModifiedBy",
                table: "Role",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_RoleAppProcessFlow_AppProcessFlowId",
                table: "RoleAppProcessFlow",
                column: "AppProcessFlowId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleAppProcessFlow_CreatedBy",
                table: "RoleAppProcessFlow",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_RoleAppProcessFlow_ModifiedBy",
                table: "RoleAppProcessFlow",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_RoleAppProcessFlow_RoleId",
                table: "RoleAppProcessFlow",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleResource_CreatedBy",
                table: "RoleResource",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_RoleResource_ModifiedBy",
                table: "RoleResource",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_RoleResource_ResourceId",
                table: "RoleResource",
                column: "ResourceId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleResource_RoleId",
                table: "RoleResource",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleResourceRight_CreatedBy",
                table: "RoleResourceRight",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_RoleResourceRight_ModifiedBy",
                table: "RoleResourceRight",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_RoleResourceRight_RoleResourceId",
                table: "RoleResourceRight",
                column: "RoleResourceId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleResourceRight_RTRightId",
                table: "RoleResourceRight",
                column: "RTRightId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleResourceRightsHistory_CreatedBy",
                table: "RoleResourceRightsHistory",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_RoleResourceRightsHistory_ModifiedBy",
                table: "RoleResourceRightsHistory",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_RoleResourceRightsHistory_ResourceId",
                table: "RoleResourceRightsHistory",
                column: "ResourceId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleResourceRightsHistory_RoleId",
                table: "RoleResourceRightsHistory",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Series_CreatedBy",
                table: "Series",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Series_ModifiedBy",
                table: "Series",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Series_SeriesCategoryId",
                table: "Series",
                column: "SeriesCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Series_SeriesStatusId",
                table: "Series",
                column: "SeriesStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Series_SeriesTypeId",
                table: "Series",
                column: "SeriesTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesCategory_CreatedBy",
                table: "SeriesCategory",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesCategory_ModifiedBy",
                table: "SeriesCategory",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumber_CreatedBy",
                table: "SeriesNumber",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumber_ModifiedBy",
                table: "SeriesNumber",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumberPool_CreatedBy",
                table: "SeriesNumberPool",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumberPool_DistrictId",
                table: "SeriesNumberPool",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumberPool_ModifiedBy",
                table: "SeriesNumberPool",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumberPool_SeriesCategoryId",
                table: "SeriesNumberPool",
                column: "SeriesCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumberPool_SeriesId",
                table: "SeriesNumberPool",
                column: "SeriesId");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumberPool_SeriesNumberId",
                table: "SeriesNumberPool",
                column: "SeriesNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumberPool_SeriesNumberStatusId",
                table: "SeriesNumberPool",
                column: "SeriesNumberStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumberStatus_CreatedBy",
                table: "SeriesNumberStatus",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumberStatus_ModifiedBy",
                table: "SeriesNumberStatus",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesStatus_CreatedBy",
                table: "SeriesStatus",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesStatus_ModifiedBy",
                table: "SeriesStatus",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesType_CreatedBy",
                table: "SeriesType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesType_ModifiedBy",
                table: "SeriesType",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SqlExceptionLog_CreatedBy",
                table: "SqlExceptionLog",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SqlExceptionLog_ModifiedBy",
                table: "SqlExceptionLog",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TaxBase_CreatedBy",
                table: "TaxBase",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TaxBase_ModifiedBy",
                table: "TaxBase",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TaxRate_CreatedBy",
                table: "TaxRate",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TaxRate_ModifiedBy",
                table: "TaxRate",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TaxRate_TaxBaseId",
                table: "TaxRate",
                column: "TaxBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxRate_TaxTypeId",
                table: "TaxRate",
                column: "TaxTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxRate_VehicleClassDetailId",
                table: "TaxRate",
                column: "VehicleClassDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxRate_VehicleClassId",
                table: "TaxRate",
                column: "VehicleClassId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxRule_CreatedBy",
                table: "TaxRule",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TaxRule_ModifiedBy",
                table: "TaxRule",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TaxType_CreatedBy",
                table: "TaxType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TaxType_ModifiedBy",
                table: "TaxType",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TaxType_TaxRuleId",
                table: "TaxType",
                column: "TaxRuleId");

            migrationBuilder.CreateIndex(
                name: "IX_Tehsil_CreatedBy",
                table: "Tehsil",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Tehsil_DistrictId",
                table: "Tehsil",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Tehsil_ModifiedBy",
                table: "Tehsil",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_User_ModifiedBy",
                table: "User",
                column: "ModifiedBy",
                unique: true,
                filter: "[ModifiedBy] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserStatusId",
                table: "User",
                column: "UserStatusId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_UserTypeId",
                table: "User",
                column: "UserTypeId",
                unique: true,
                filter: "[UserTypeId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_CreatedBy",
                table: "UserRole",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_ModifiedBy",
                table: "UserRole",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_RoleId",
                table: "UserRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_UserId",
                table: "UserRole",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleHistory_CreatedBy",
                table: "UserRoleHistory",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleHistory_ModifiedBy",
                table: "UserRoleHistory",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleHistory_RoleId",
                table: "UserRoleHistory",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleHistory_UserId",
                table: "UserRoleHistory",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserStatus_ModifiedBy",
                table: "UserStatus",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserType_ModifiedBy",
                table: "UserType",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_CreatedBy",
                table: "Vehicle",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_ModifiedBy",
                table: "Vehicle",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_OwnerId",
                table: "Vehicle",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_RegistrationDistrictId",
                table: "Vehicle",
                column: "RegistrationDistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleBodyConventionId",
                table: "Vehicle",
                column: "VehicleBodyConventionId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleBodyTypeId",
                table: "Vehicle",
                column: "VehicleBodyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleCategoryId",
                table: "Vehicle",
                column: "VehicleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleClassId",
                table: "Vehicle",
                column: "VehicleClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleClassificationId",
                table: "Vehicle",
                column: "VehicleClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleColorId",
                table: "Vehicle",
                column: "VehicleColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleEngineTypeId",
                table: "Vehicle",
                column: "VehicleEngineTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleFuelTypeId",
                table: "Vehicle",
                column: "VehicleFuelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleMakeId",
                table: "Vehicle",
                column: "VehicleMakeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleMakerId",
                table: "Vehicle",
                column: "VehicleMakerId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehiclePurchaseTypeId",
                table: "Vehicle",
                column: "VehiclePurchaseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleRouteTypeId",
                table: "Vehicle",
                column: "VehicleRouteTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleStatusId",
                table: "Vehicle",
                column: "VehicleStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleTypeId",
                table: "Vehicle",
                column: "VehicleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleUsageId",
                table: "Vehicle",
                column: "VehicleUsageId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAdditionalInfo_CreatedBy",
                table: "VehicleAdditionalInfo",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAdditionalInfo_ModifiedBy",
                table: "VehicleAdditionalInfo",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAdditionalInfo_VehicleId",
                table: "VehicleAdditionalInfo",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAdditionalInfo_VehicleRCStatusId",
                table: "VehicleAdditionalInfo",
                column: "VehicleRCStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAuctionInfo_ApplicationId",
                table: "VehicleAuctionInfo",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAuctionInfo_CreatedBy",
                table: "VehicleAuctionInfo",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAuctionInfo_ModifiedBy",
                table: "VehicleAuctionInfo",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAuctionInfo_VehicleId",
                table: "VehicleAuctionInfo",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBodyConvention_CreatedBy",
                table: "VehicleBodyConvention",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBodyConvention_ModifiedBy",
                table: "VehicleBodyConvention",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBodyType_CreatedBy",
                table: "VehicleBodyType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBodyType_ModifiedBy",
                table: "VehicleBodyType",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBusinessProcessHistory_ApplicationId",
                table: "VehicleBusinessProcessHistory",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBusinessProcessHistory_BusinessProcessId",
                table: "VehicleBusinessProcessHistory",
                column: "BusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBusinessProcessHistory_CreatedBy",
                table: "VehicleBusinessProcessHistory",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBusinessProcessHistory_DistrictId",
                table: "VehicleBusinessProcessHistory",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBusinessProcessHistory_ModifiedBy",
                table: "VehicleBusinessProcessHistory",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBusinessProcessHistory_OwnerId",
                table: "VehicleBusinessProcessHistory",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBusinessProcessHistory_VehicleId",
                table: "VehicleBusinessProcessHistory",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleCategory_CreatedBy",
                table: "VehicleCategory",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleCategory_ModifiedBy",
                table: "VehicleCategory",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClass_CreatedBy",
                table: "VehicleClass",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClass_ModifiedBy",
                table: "VehicleClass",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClass_VehicleBodyTypeId",
                table: "VehicleClass",
                column: "VehicleBodyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClass_VehicleCategoryId",
                table: "VehicleClass",
                column: "VehicleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClass_VehicleClassGroupId",
                table: "VehicleClass",
                column: "VehicleClassGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClass_VehicleClassificationId",
                table: "VehicleClass",
                column: "VehicleClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClass_VehicleRouteTypeId",
                table: "VehicleClass",
                column: "VehicleRouteTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClass_VehicleTypeId",
                table: "VehicleClass",
                column: "VehicleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClassDetail_CreatedBy",
                table: "VehicleClassDetail",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClassDetail_ModifiedBy",
                table: "VehicleClassDetail",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClassDetail_VehicleBodyTypeId",
                table: "VehicleClassDetail",
                column: "VehicleBodyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClassDetail_VehicleCategoryId",
                table: "VehicleClassDetail",
                column: "VehicleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClassDetail_VehicleClassId",
                table: "VehicleClassDetail",
                column: "VehicleClassId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClassDetail_VehicleClassificationId",
                table: "VehicleClassDetail",
                column: "VehicleClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClassDetail_VehicleRouteTypeId",
                table: "VehicleClassDetail",
                column: "VehicleRouteTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClassDetail_VehicleTypeId",
                table: "VehicleClassDetail",
                column: "VehicleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClassDetail_VehicleUsageId",
                table: "VehicleClassDetail",
                column: "VehicleUsageId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClassGroup_CreatedBy",
                table: "VehicleClassGroup",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClassGroup_ModifiedBy",
                table: "VehicleClassGroup",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClassification_CreatedBy",
                table: "VehicleClassification",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClassification_ModifiedBy",
                table: "VehicleClassification",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleColor_CreatedBy",
                table: "VehicleColor",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleColor_ModifiedBy",
                table: "VehicleColor",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleDocument_ApplicationId",
                table: "VehicleDocument",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleDocument_CreatedBy",
                table: "VehicleDocument",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleDocument_ModifiedBy",
                table: "VehicleDocument",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleDocument_VehicleDocumentTypeId",
                table: "VehicleDocument",
                column: "VehicleDocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleDocument_VehicleId",
                table: "VehicleDocument",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleDocumentRequirement_BusinessProcessId",
                table: "VehicleDocumentRequirement",
                column: "BusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleDocumentRequirement_VehicleDocumentTypeId",
                table: "VehicleDocumentRequirement",
                column: "VehicleDocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleDocumentType_CreatedBy",
                table: "VehicleDocumentType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleDocumentType_ModifiedBy",
                table: "VehicleDocumentType",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleEngineType_CreatedBy",
                table: "VehicleEngineType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleEngineType_ModifiedBy",
                table: "VehicleEngineType",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleFuelType_CreatedBy",
                table: "VehicleFuelType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleFuelType_ModifiedBy",
                table: "VehicleFuelType",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImportInfo_ApplicationId",
                table: "VehicleImportInfo",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImportInfo_BankId",
                table: "VehicleImportInfo",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImportInfo_ClearingAgentId",
                table: "VehicleImportInfo",
                column: "ClearingAgentId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImportInfo_CountryId",
                table: "VehicleImportInfo",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImportInfo_CreatedBy",
                table: "VehicleImportInfo",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImportInfo_CustomCollectorateId",
                table: "VehicleImportInfo",
                column: "CustomCollectorateId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImportInfo_ModifiedBy",
                table: "VehicleImportInfo",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImportInfo_PortId",
                table: "VehicleImportInfo",
                column: "PortId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImportInfo_VehicleId",
                table: "VehicleImportInfo",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImportInfo_VehicleSchemeId",
                table: "VehicleImportInfo",
                column: "VehicleSchemeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleMake_CreatedBy",
                table: "VehicleMake",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleMake_ModifiedBy",
                table: "VehicleMake",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleMake_VehicleMakerId",
                table: "VehicleMake",
                column: "VehicleMakerId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleMaker_CreatedBy",
                table: "VehicleMaker",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleMaker_ModifiedBy",
                table: "VehicleMaker",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleOwnershipHistory_ApplicationId",
                table: "VehicleOwnershipHistory",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleOwnershipHistory_BusinessProcessId",
                table: "VehicleOwnershipHistory",
                column: "BusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleOwnershipHistory_BuyerId",
                table: "VehicleOwnershipHistory",
                column: "BuyerId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleOwnershipHistory_CreatedBy",
                table: "VehicleOwnershipHistory",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleOwnershipHistory_ModifiedBy",
                table: "VehicleOwnershipHistory",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleOwnershipHistory_SellerId",
                table: "VehicleOwnershipHistory",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleOwnershipHistory_VehicleId",
                table: "VehicleOwnershipHistory",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_VehiclePurchaseInfo_ApplicationId",
                table: "VehiclePurchaseInfo",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_VehiclePurchaseInfo_CreatedBy",
                table: "VehiclePurchaseInfo",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehiclePurchaseInfo_DealerId",
                table: "VehiclePurchaseInfo",
                column: "DealerId");

            migrationBuilder.CreateIndex(
                name: "IX_VehiclePurchaseInfo_ModifiedBy",
                table: "VehiclePurchaseInfo",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehiclePurchaseInfo_VehicleId",
                table: "VehiclePurchaseInfo",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_VehiclePurchaseInfo_VehicleSchemeId",
                table: "VehiclePurchaseInfo",
                column: "VehicleSchemeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehiclePurchaseType_CreatedBy",
                table: "VehiclePurchaseType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehiclePurchaseType_ModifiedBy",
                table: "VehiclePurchaseType",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleRCStatus_CreatedBy",
                table: "VehicleRCStatus",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleRCStatus_ModifiedBy",
                table: "VehicleRCStatus",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleRegistrationHistory_CreatedBy",
                table: "VehicleRegistrationHistory",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleRegistrationHistory_ModifiedBy",
                table: "VehicleRegistrationHistory",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleRegistrationHistory_RegistrationDistrictId",
                table: "VehicleRegistrationHistory",
                column: "RegistrationDistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleRegistrationHistory_SeriesNumberPoolId",
                table: "VehicleRegistrationHistory",
                column: "SeriesNumberPoolId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleRegistrationHistory_VehicleId",
                table: "VehicleRegistrationHistory",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleRouteType_CreatedBy",
                table: "VehicleRouteType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleRouteType_ModifiedBy",
                table: "VehicleRouteType",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleScheme_CreatedBy",
                table: "VehicleScheme",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleScheme_ModifiedBy",
                table: "VehicleScheme",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleStatus_CreatedBy",
                table: "VehicleStatus",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleStatus_ModifiedBy",
                table: "VehicleStatus",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleType_CreatedBy",
                table: "VehicleType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleType_ModifiedBy",
                table: "VehicleType",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleUsage_CreatedBy",
                table: "VehicleUsage",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleUsage_ModifiedBy",
                table: "VehicleUsage",
                column: "ModifiedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_AddressType_AddressTypeId",
                table: "Address",
                column: "AddressTypeId",
                principalTable: "AddressType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Business_BusinessId",
                table: "Address",
                column: "BusinessId",
                principalTable: "Business",
                principalColumn: "BusinessId");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_District_DistrictId",
                table: "Address",
                column: "DistrictId",
                principalTable: "District",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Person_PersonId",
                table: "Address",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Tehsil_TehsilId",
                table: "Address",
                column: "TehsilId",
                principalTable: "Tehsil",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_User_CreatedBy",
                table: "Address",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_User_ModifiedBy",
                table: "Address",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentBase_Application_ApplicationId",
                table: "AssessmentBase",
                column: "ApplicationId",
                principalTable: "Application",
                principalColumn: "ApplicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentBase_AssessmentStatus_AssessmentStatusId",
                table: "AssessmentBase",
                column: "AssessmentStatusId",
                principalTable: "AssessmentStatus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentBase_BusinessProcess_BusinessProcessId",
                table: "AssessmentBase",
                column: "BusinessProcessId",
                principalTable: "BusinessProcess",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentBase_District_DistrictId",
                table: "AssessmentBase",
                column: "DistrictId",
                principalTable: "District",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentBase_Owner_OwnerId",
                table: "AssessmentBase",
                column: "OwnerId",
                principalTable: "Owner",
                principalColumn: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentBase_OwnerTaxGroup_OwnerTaxGroupId",
                table: "AssessmentBase",
                column: "OwnerTaxGroupId",
                principalTable: "OwnerTaxGroup",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentBase_User_CreatedBy",
                table: "AssessmentBase",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentBase_User_ModifiedBy",
                table: "AssessmentBase",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentBase_Vehicle_VehicleId",
                table: "AssessmentBase",
                column: "VehicleId",
                principalTable: "Vehicle",
                principalColumn: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentBase_VehicleBodyType_VehicleBodyTypeId",
                table: "AssessmentBase",
                column: "VehicleBodyTypeId",
                principalTable: "VehicleBodyType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentBase_VehicleCategory_VehicleCategoryId",
                table: "AssessmentBase",
                column: "VehicleCategoryId",
                principalTable: "VehicleCategory",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentBase_VehicleClass_VehicleClassId",
                table: "AssessmentBase",
                column: "VehicleClassId",
                principalTable: "VehicleClass",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentBase_VehicleClassDetail_VehicleClassDetailId",
                table: "AssessmentBase",
                column: "VehicleClassDetailId",
                principalTable: "VehicleClassDetail",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentBase_VehicleClassification_VehicleClassificationId",
                table: "AssessmentBase",
                column: "VehicleClassificationId",
                principalTable: "VehicleClassification",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentBase_VehiclePurchaseType_VehiclePurchaseTypeId",
                table: "AssessmentBase",
                column: "VehiclePurchaseTypeId",
                principalTable: "VehiclePurchaseType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentBase_VehicleStatus_VehicleStatusId",
                table: "AssessmentBase",
                column: "VehicleStatusId",
                principalTable: "VehicleStatus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentBase_VehicleUsage_VehicleUsageId",
                table: "AssessmentBase",
                column: "VehicleUsageId",
                principalTable: "VehicleUsage",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BiometricVerification_Application_ApplicationId",
                table: "BiometricVerification",
                column: "ApplicationId",
                principalTable: "Application",
                principalColumn: "ApplicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_BiometricVerification_NadraFranchise_NadraFranchiseId",
                table: "BiometricVerification",
                column: "NadraFranchiseId",
                principalTable: "NadraFranchise",
                principalColumn: "NadraFranchiseId");

            migrationBuilder.AddForeignKey(
                name: "FK_BiometricVerification_OwnerGroup_OwnerGroupId",
                table: "BiometricVerification",
                column: "OwnerGroupId",
                principalTable: "OwnerGroup",
                principalColumn: "OwnerGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_BiometricVerification_Person_PersonId",
                table: "BiometricVerification",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_BiometricVerification_User_CreatedBy",
                table: "BiometricVerification",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BiometricVerification_User_ModifiedBy",
                table: "BiometricVerification",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BiometricVerification_Vehicle_VehicleId",
                table: "BiometricVerification",
                column: "VehicleId",
                principalTable: "Vehicle",
                principalColumn: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Challan_Application_ApplicationId",
                table: "Challan",
                column: "ApplicationId",
                principalTable: "Application",
                principalColumn: "ApplicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Challan_ChallanStatus_ChallanStatusId",
                table: "Challan",
                column: "ChallanStatusId",
                principalTable: "ChallanStatus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Challan_ChallanType_ChallanTypeId",
                table: "Challan",
                column: "ChallanTypeId",
                principalTable: "ChallanType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Challan_User_CreatedBy",
                table: "Challan",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Challan_User_ModifiedBy",
                table: "Challan",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_HPA_Application_ApplicationId",
                table: "HPA",
                column: "ApplicationId",
                principalTable: "Application",
                principalColumn: "ApplicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_HPA_Business_SponserBusinessId",
                table: "HPA",
                column: "SponserBusinessId",
                principalTable: "Business",
                principalColumn: "BusinessId");

            migrationBuilder.AddForeignKey(
                name: "FK_HPA_HPAStatus_HPACurrentStatusId",
                table: "HPA",
                column: "HPACurrentStatusId",
                principalTable: "HPAStatus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HPA_Owner_OwnerId",
                table: "HPA",
                column: "OwnerId",
                principalTable: "Owner",
                principalColumn: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_HPA_User_CreatedBy",
                table: "HPA",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_HPA_User_ModifiedBy",
                table: "HPA",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_HPA_Vehicle_VehicleId",
                table: "HPA",
                column: "VehicleId",
                principalTable: "Vehicle",
                principalColumn: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_HPAStatusHistory_Application_ApplicationId",
                table: "HPAStatusHistory",
                column: "ApplicationId",
                principalTable: "Application",
                principalColumn: "ApplicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_HPAStatusHistory_HPAStatus_HPAStatusId",
                table: "HPAStatusHistory",
                column: "HPAStatusId",
                principalTable: "HPAStatus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HPAStatusHistory_User_CreatedBy",
                table: "HPAStatusHistory",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_HPAStatusHistory_User_ModifiedBy",
                table: "HPAStatusHistory",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Remarks_Application_ApplicationId",
                table: "Remarks",
                column: "ApplicationId",
                principalTable: "Application",
                principalColumn: "ApplicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Remarks_Owner_OwnerId",
                table: "Remarks",
                column: "OwnerId",
                principalTable: "Owner",
                principalColumn: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Remarks_OwnerGroup_OwnerGroupId",
                table: "Remarks",
                column: "OwnerGroupId",
                principalTable: "OwnerGroup",
                principalColumn: "OwnerGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Remarks_Role_RoleId",
                table: "Remarks",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Remarks_User_CreatedBy",
                table: "Remarks",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Remarks_User_ModifiedBy",
                table: "Remarks",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Remarks_Vehicle_VehicleId",
                table: "Remarks",
                column: "VehicleId",
                principalTable: "Vehicle",
                principalColumn: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleAuctionInfo_Application_ApplicationId",
                table: "VehicleAuctionInfo",
                column: "ApplicationId",
                principalTable: "Application",
                principalColumn: "ApplicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleAuctionInfo_User_CreatedBy",
                table: "VehicleAuctionInfo",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleAuctionInfo_User_ModifiedBy",
                table: "VehicleAuctionInfo",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleAuctionInfo_Vehicle_VehicleId",
                table: "VehicleAuctionInfo",
                column: "VehicleId",
                principalTable: "Vehicle",
                principalColumn: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleBusinessProcessHistory_Application_ApplicationId",
                table: "VehicleBusinessProcessHistory",
                column: "ApplicationId",
                principalTable: "Application",
                principalColumn: "ApplicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleBusinessProcessHistory_BusinessProcess_BusinessProcessId",
                table: "VehicleBusinessProcessHistory",
                column: "BusinessProcessId",
                principalTable: "BusinessProcess",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleBusinessProcessHistory_District_DistrictId",
                table: "VehicleBusinessProcessHistory",
                column: "DistrictId",
                principalTable: "District",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleBusinessProcessHistory_Owner_OwnerId",
                table: "VehicleBusinessProcessHistory",
                column: "OwnerId",
                principalTable: "Owner",
                principalColumn: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleBusinessProcessHistory_User_CreatedBy",
                table: "VehicleBusinessProcessHistory",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleBusinessProcessHistory_User_ModifiedBy",
                table: "VehicleBusinessProcessHistory",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleBusinessProcessHistory_Vehicle_VehicleId",
                table: "VehicleBusinessProcessHistory",
                column: "VehicleId",
                principalTable: "Vehicle",
                principalColumn: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleDocument_Application_ApplicationId",
                table: "VehicleDocument",
                column: "ApplicationId",
                principalTable: "Application",
                principalColumn: "ApplicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleDocument_User_CreatedBy",
                table: "VehicleDocument",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleDocument_User_ModifiedBy",
                table: "VehicleDocument",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleDocument_Vehicle_VehicleId",
                table: "VehicleDocument",
                column: "VehicleId",
                principalTable: "Vehicle",
                principalColumn: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleDocument_VehicleDocumentType_VehicleDocumentTypeId",
                table: "VehicleDocument",
                column: "VehicleDocumentTypeId",
                principalTable: "VehicleDocumentType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleImportInfo_Application_ApplicationId",
                table: "VehicleImportInfo",
                column: "ApplicationId",
                principalTable: "Application",
                principalColumn: "ApplicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleImportInfo_Bank_BankId",
                table: "VehicleImportInfo",
                column: "BankId",
                principalTable: "Bank",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleImportInfo_ClearingAgent_ClearingAgentId",
                table: "VehicleImportInfo",
                column: "ClearingAgentId",
                principalTable: "ClearingAgent",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleImportInfo_Country_CountryId",
                table: "VehicleImportInfo",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleImportInfo_CustomCollectorate_CustomCollectorateId",
                table: "VehicleImportInfo",
                column: "CustomCollectorateId",
                principalTable: "CustomCollectorate",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleImportInfo_Port_PortId",
                table: "VehicleImportInfo",
                column: "PortId",
                principalTable: "Port",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleImportInfo_User_CreatedBy",
                table: "VehicleImportInfo",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleImportInfo_User_ModifiedBy",
                table: "VehicleImportInfo",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleImportInfo_Vehicle_VehicleId",
                table: "VehicleImportInfo",
                column: "VehicleId",
                principalTable: "Vehicle",
                principalColumn: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleImportInfo_VehicleScheme_VehicleSchemeId",
                table: "VehicleImportInfo",
                column: "VehicleSchemeId",
                principalTable: "VehicleScheme",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleOwnershipHistory_Application_ApplicationId",
                table: "VehicleOwnershipHistory",
                column: "ApplicationId",
                principalTable: "Application",
                principalColumn: "ApplicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleOwnershipHistory_BusinessProcess_BusinessProcessId",
                table: "VehicleOwnershipHistory",
                column: "BusinessProcessId",
                principalTable: "BusinessProcess",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleOwnershipHistory_Owner_BuyerId",
                table: "VehicleOwnershipHistory",
                column: "BuyerId",
                principalTable: "Owner",
                principalColumn: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleOwnershipHistory_Owner_SellerId",
                table: "VehicleOwnershipHistory",
                column: "SellerId",
                principalTable: "Owner",
                principalColumn: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleOwnershipHistory_User_CreatedBy",
                table: "VehicleOwnershipHistory",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleOwnershipHistory_User_ModifiedBy",
                table: "VehicleOwnershipHistory",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleOwnershipHistory_Vehicle_VehicleId",
                table: "VehicleOwnershipHistory",
                column: "VehicleId",
                principalTable: "Vehicle",
                principalColumn: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehiclePurchaseInfo_Application_ApplicationId",
                table: "VehiclePurchaseInfo",
                column: "ApplicationId",
                principalTable: "Application",
                principalColumn: "ApplicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehiclePurchaseInfo_Dealer_DealerId",
                table: "VehiclePurchaseInfo",
                column: "DealerId",
                principalTable: "Dealer",
                principalColumn: "DealerId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehiclePurchaseInfo_User_CreatedBy",
                table: "VehiclePurchaseInfo",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehiclePurchaseInfo_User_ModifiedBy",
                table: "VehiclePurchaseInfo",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehiclePurchaseInfo_Vehicle_VehicleId",
                table: "VehiclePurchaseInfo",
                column: "VehicleId",
                principalTable: "Vehicle",
                principalColumn: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehiclePurchaseInfo_VehicleScheme_VehicleSchemeId",
                table: "VehiclePurchaseInfo",
                column: "VehicleSchemeId",
                principalTable: "VehicleScheme",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleAppProcessFlow_ApplicationProcessFlow_AppProcessFlowId",
                table: "RoleAppProcessFlow",
                column: "AppProcessFlowId",
                principalTable: "ApplicationProcessFlow",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleAppProcessFlow_Role_RoleId",
                table: "RoleAppProcessFlow",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleAppProcessFlow_User_CreatedBy",
                table: "RoleAppProcessFlow",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleAppProcessFlow_User_ModifiedBy",
                table: "RoleAppProcessFlow",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Application_ApplicationStatus_ApplicationStatusId",
                table: "Application",
                column: "ApplicationStatusId",
                principalTable: "ApplicationStatus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Application_BusinessPhase_BusinessPhaseId",
                table: "Application",
                column: "BusinessPhaseId",
                principalTable: "BusinessPhase",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Application_BusinessPhaseStatus_BusinessPhaseStatusId",
                table: "Application",
                column: "BusinessPhaseStatusId",
                principalTable: "BusinessPhaseStatus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Application_BusinessProcess_BusinessProcessId",
                table: "Application",
                column: "BusinessProcessId",
                principalTable: "BusinessProcess",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Application_District_DistrictId",
                table: "Application",
                column: "DistrictId",
                principalTable: "District",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Application_Owner_OwnerId",
                table: "Application",
                column: "OwnerId",
                principalTable: "Owner",
                principalColumn: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Application_Owner_SellerId",
                table: "Application",
                column: "SellerId",
                principalTable: "Owner",
                principalColumn: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Application_User_CreatedBy",
                table: "Application",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Application_User_ModifiedBy",
                table: "Application",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Application_Vehicle_VehicleId",
                table: "Application",
                column: "VehicleId",
                principalTable: "Vehicle",
                principalColumn: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationProcessFlow_ApplicationStatus_CurrentApplicationStatusId",
                table: "ApplicationProcessFlow",
                column: "CurrentApplicationStatusId",
                principalTable: "ApplicationStatus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationProcessFlow_ApplicationStatus_NextApplicationStatusId",
                table: "ApplicationProcessFlow",
                column: "NextApplicationStatusId",
                principalTable: "ApplicationStatus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationProcessFlow_BusinessEvent_BusinessEventId",
                table: "ApplicationProcessFlow",
                column: "BusinessEventId",
                principalTable: "BusinessEvent",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationProcessFlow_BusinessPhase_CurrentBusinessPhaseId",
                table: "ApplicationProcessFlow",
                column: "CurrentBusinessPhaseId",
                principalTable: "BusinessPhase",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationProcessFlow_BusinessPhase_NextBusinessPhaseId",
                table: "ApplicationProcessFlow",
                column: "NextBusinessPhaseId",
                principalTable: "BusinessPhase",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationProcessFlow_BusinessPhaseStatus_CurrentBusinessPhaseStatusId",
                table: "ApplicationProcessFlow",
                column: "CurrentBusinessPhaseStatusId",
                principalTable: "BusinessPhaseStatus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationProcessFlow_BusinessPhaseStatus_NextBusinessPhaseStatusId",
                table: "ApplicationProcessFlow",
                column: "NextBusinessPhaseStatusId",
                principalTable: "BusinessPhaseStatus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationProcessFlow_BusinessProcess_BusinessProcessId",
                table: "ApplicationProcessFlow",
                column: "BusinessProcessId",
                principalTable: "BusinessProcess",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationProcessFlow_Role_RoleId",
                table: "ApplicationProcessFlow",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationProcessFlow_User_CreatedBy",
                table: "ApplicationProcessFlow",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationProcessFlow_User_ModifiedBy",
                table: "ApplicationProcessFlow",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessTableAccessLevel_ApplicationStatus_ApplicationStatusId",
                table: "BusinessTableAccessLevel",
                column: "ApplicationStatusId",
                principalTable: "ApplicationStatus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessTableAccessLevel_BusinessPhase_BusinessPhaseId",
                table: "BusinessTableAccessLevel",
                column: "BusinessPhaseId",
                principalTable: "BusinessPhase",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessTableAccessLevel_BusinessPhaseStatus_BusinessPhaseStatusId",
                table: "BusinessTableAccessLevel",
                column: "BusinessPhaseStatusId",
                principalTable: "BusinessPhaseStatus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessTableAccessLevel_BusinessProcess_BusinessProcessId",
                table: "BusinessTableAccessLevel",
                column: "BusinessProcessId",
                principalTable: "BusinessProcess",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessTableAccessLevel_BusinessTable_BusinessTableId",
                table: "BusinessTableAccessLevel",
                column: "BusinessTableId",
                principalTable: "BusinessTable",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessTableAccessLevel_BusinessTableAccess_BusinessTableAccessId",
                table: "BusinessTableAccessLevel",
                column: "BusinessTableAccessId",
                principalTable: "BusinessTableAccess",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessTableAccessLevel_Role_RoleId",
                table: "BusinessTableAccessLevel",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessTableAccessLevel_User_CreatedBy",
                table: "BusinessTableAccessLevel",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessTableAccessLevel_User_ModifiedBy",
                table: "BusinessTableAccessLevel",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PermitIssueApplication_ApplicationStatus_ApplicationStatusId",
                schema: "Core",
                table: "PermitIssueApplication",
                column: "ApplicationStatusId",
                principalTable: "ApplicationStatus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PermitIssueApplication_District_DistrictId",
                schema: "Core",
                table: "PermitIssueApplication",
                column: "DistrictId",
                principalTable: "District",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PermitIssueApplication_EPRSPermitTypes_PermitTypeId",
                schema: "Core",
                table: "PermitIssueApplication",
                column: "PermitTypeId",
                principalSchema: "Setup",
                principalTable: "EPRSPermitTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PermitIssueApplication_EPRSPerson_PersonId",
                schema: "Core",
                table: "PermitIssueApplication",
                column: "PersonId",
                principalTable: "EPRSPerson",
                principalColumn: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_PermitIssueApplication_User_CreatedBy",
                schema: "Core",
                table: "PermitIssueApplication",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PermitIssueApplication_User_ModifiedBy",
                schema: "Core",
                table: "PermitIssueApplication",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentDetail_TaxType_TaxTypeId",
                table: "AssessmentDetail",
                column: "TaxTypeId",
                principalTable: "TaxType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentDetail_User_CreatedBy",
                table: "AssessmentDetail",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentDetail_User_ModifiedBy",
                table: "AssessmentDetail",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessRep_Business_BusinessId",
                table: "BusinessRep",
                column: "BusinessId",
                principalTable: "Business",
                principalColumn: "BusinessId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessRep_BusinessRepStatus_BusinessRepStatusId",
                table: "BusinessRep",
                column: "BusinessRepStatusId",
                principalTable: "BusinessRepStatus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessRep_Person_PersonId",
                table: "BusinessRep",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessRep_User_CreatedBy",
                table: "BusinessRep",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessRep_User_ModifiedBy",
                table: "BusinessRep",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dealer_Business_BusinessId",
                table: "Dealer",
                column: "BusinessId",
                principalTable: "Business",
                principalColumn: "BusinessId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dealer_User_CreatedBy",
                table: "Dealer",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dealer_User_ModifiedBy",
                table: "Dealer",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_OwnerGroup_Business_BusinessId",
                table: "OwnerGroup",
                column: "BusinessId",
                principalTable: "Business",
                principalColumn: "BusinessId");

            migrationBuilder.AddForeignKey(
                name: "FK_OwnerGroup_Owner_OwnerId",
                table: "OwnerGroup",
                column: "OwnerId",
                principalTable: "Owner",
                principalColumn: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_OwnerGroup_Person_PersonId",
                table: "OwnerGroup",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_OwnerGroup_User_CreatedBy",
                table: "OwnerGroup",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_OwnerGroup_User_ModifiedBy",
                table: "OwnerGroup",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumber_Business_BusinessId",
                table: "PhoneNumber",
                column: "BusinessId",
                principalTable: "Business",
                principalColumn: "BusinessId");

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumber_Country_CountryId",
                table: "PhoneNumber",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumber_Person_PersonId",
                table: "PhoneNumber",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumber_PhoneNumberType_PhoneNumberTypeId",
                table: "PhoneNumber",
                column: "PhoneNumberTypeId",
                principalTable: "PhoneNumberType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumber_User_CreatedBy",
                table: "PhoneNumber",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumber_User_ModifiedBy",
                table: "PhoneNumber",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessProFeeTax_BusinessProcess_BusinessProcessId",
                table: "BusinessProFeeTax",
                column: "BusinessProcessId",
                principalTable: "BusinessProcess",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessProFeeTax_TaxType_TaxTypeId",
                table: "BusinessProFeeTax",
                column: "TaxTypeId",
                principalTable: "TaxType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessProFeeTax_User_CreatedBy",
                table: "BusinessProFeeTax",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessProFeeTax_User_ModifiedBy",
                table: "BusinessProFeeTax",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleDocumentRequirement_BusinessProcess_BusinessProcessId",
                table: "VehicleDocumentRequirement",
                column: "BusinessProcessId",
                principalTable: "BusinessProcess",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleDocumentRequirement_VehicleDocumentType_VehicleDocumentTypeId",
                table: "VehicleDocumentRequirement",
                column: "VehicleDocumentTypeId",
                principalTable: "VehicleDocumentType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Business_BusinessSector_BusinessSectorId",
                table: "Business",
                column: "BusinessSectorId",
                principalTable: "BusinessSector",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Business_BusinessStatus_BusinessStatusId",
                table: "Business",
                column: "BusinessStatusId",
                principalTable: "BusinessStatus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Business_BusinessType_BusinessTypeId",
                table: "Business",
                column: "BusinessTypeId",
                principalTable: "BusinessType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Business_User_CreatedBy",
                table: "Business",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Business_User_ModifiedBy",
                table: "Business",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessSector_BusinessType_BusinessTypeId",
                table: "BusinessSector",
                column: "BusinessTypeId",
                principalTable: "BusinessType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessSector_User_CreatedBy",
                table: "BusinessSector",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessSector_User_ModifiedBy",
                table: "BusinessSector",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_PaymentMode_PaymentModeId",
                table: "Payment",
                column: "PaymentModeId",
                principalTable: "PaymentMode",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_PaymentStatus_PaymentStatusId",
                table: "Payment",
                column: "PaymentStatusId",
                principalTable: "PaymentStatus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_User_CreatedBy",
                table: "Payment",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_User_ModifiedBy",
                table: "Payment",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_EPRSPerson_Country_CountryId",
                table: "EPRSPerson",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EPRSPerson_User_CreatedBy",
                table: "EPRSPerson",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_EPRSPerson_User_ModifiedBy",
                table: "EPRSPerson",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Country_CountryId",
                table: "Person",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_User_CreatedBy",
                table: "Person",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_User_ModifiedBy",
                table: "Person",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SeriesNumberPool_District_DistrictId",
                table: "SeriesNumberPool",
                column: "DistrictId",
                principalTable: "District",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SeriesNumberPool_Series_SeriesId",
                table: "SeriesNumberPool",
                column: "SeriesId",
                principalTable: "Series",
                principalColumn: "SeriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_SeriesNumberPool_SeriesCategory_SeriesCategoryId",
                table: "SeriesNumberPool",
                column: "SeriesCategoryId",
                principalTable: "SeriesCategory",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SeriesNumberPool_SeriesNumber_SeriesNumberId",
                table: "SeriesNumberPool",
                column: "SeriesNumberId",
                principalTable: "SeriesNumber",
                principalColumn: "SeriesNumberId");

            migrationBuilder.AddForeignKey(
                name: "FK_SeriesNumberPool_SeriesNumberStatus_SeriesNumberStatusId",
                table: "SeriesNumberPool",
                column: "SeriesNumberStatusId",
                principalTable: "SeriesNumberStatus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SeriesNumberPool_User_CreatedBy",
                table: "SeriesNumberPool",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SeriesNumberPool_User_ModifiedBy",
                table: "SeriesNumberPool",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tehsil_District_DistrictId",
                table: "Tehsil",
                column: "DistrictId",
                principalTable: "District",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tehsil_User_CreatedBy",
                table: "Tehsil",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tehsil_User_ModifiedBy",
                table: "Tehsil",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_District_RegistrationDistrictId",
                table: "Vehicle",
                column: "RegistrationDistrictId",
                principalTable: "District",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Owner_OwnerId",
                table: "Vehicle",
                column: "OwnerId",
                principalTable: "Owner",
                principalColumn: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_User_CreatedBy",
                table: "Vehicle",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_User_ModifiedBy",
                table: "Vehicle",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_VehicleBodyConvention_VehicleBodyConventionId",
                table: "Vehicle",
                column: "VehicleBodyConventionId",
                principalTable: "VehicleBodyConvention",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_VehicleBodyType_VehicleBodyTypeId",
                table: "Vehicle",
                column: "VehicleBodyTypeId",
                principalTable: "VehicleBodyType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_VehicleCategory_VehicleCategoryId",
                table: "Vehicle",
                column: "VehicleCategoryId",
                principalTable: "VehicleCategory",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_VehicleClass_VehicleClassId",
                table: "Vehicle",
                column: "VehicleClassId",
                principalTable: "VehicleClass",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_VehicleClassification_VehicleClassificationId",
                table: "Vehicle",
                column: "VehicleClassificationId",
                principalTable: "VehicleClassification",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_VehicleColor_VehicleColorId",
                table: "Vehicle",
                column: "VehicleColorId",
                principalTable: "VehicleColor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_VehicleEngineType_VehicleEngineTypeId",
                table: "Vehicle",
                column: "VehicleEngineTypeId",
                principalTable: "VehicleEngineType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_VehicleFuelType_VehicleFuelTypeId",
                table: "Vehicle",
                column: "VehicleFuelTypeId",
                principalTable: "VehicleFuelType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_VehicleMake_VehicleMakeId",
                table: "Vehicle",
                column: "VehicleMakeId",
                principalTable: "VehicleMake",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_VehicleMaker_VehicleMakerId",
                table: "Vehicle",
                column: "VehicleMakerId",
                principalTable: "VehicleMaker",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_VehiclePurchaseType_VehiclePurchaseTypeId",
                table: "Vehicle",
                column: "VehiclePurchaseTypeId",
                principalTable: "VehiclePurchaseType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_VehicleRouteType_VehicleRouteTypeId",
                table: "Vehicle",
                column: "VehicleRouteTypeId",
                principalTable: "VehicleRouteType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_VehicleStatus_VehicleStatusId",
                table: "Vehicle",
                column: "VehicleStatusId",
                principalTable: "VehicleStatus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_VehicleType_VehicleTypeId",
                table: "Vehicle",
                column: "VehicleTypeId",
                principalTable: "VehicleType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_VehicleUsage_VehicleUsageId",
                table: "Vehicle",
                column: "VehicleUsageId",
                principalTable: "VehicleUsage",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleRegistrationHistory_District_RegistrationDistrictId",
                table: "VehicleRegistrationHistory",
                column: "RegistrationDistrictId",
                principalTable: "District",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleRegistrationHistory_User_CreatedBy",
                table: "VehicleRegistrationHistory",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleRegistrationHistory_User_ModifiedBy",
                table: "VehicleRegistrationHistory",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ResourceTypeRight_GlobalRight_GRightId",
                table: "ResourceTypeRight",
                column: "GRightId",
                principalTable: "GlobalRight",
                principalColumn: "GRightId");

            migrationBuilder.AddForeignKey(
                name: "FK_ResourceTypeRight_ResourceType_ResourceTypeId",
                table: "ResourceTypeRight",
                column: "ResourceTypeId",
                principalTable: "ResourceType",
                principalColumn: "ResourceTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ResourceTypeRight_User_CreatedBy",
                table: "ResourceTypeRight",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ResourceTypeRight_User_ModifiedBy",
                table: "ResourceTypeRight",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Keeper_Owner_OwnerId",
                table: "Keeper",
                column: "OwnerId",
                principalTable: "Owner",
                principalColumn: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Keeper_User_CreatedBy",
                table: "Keeper",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Keeper_User_ModifiedBy",
                table: "Keeper",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Owner_OwnerTaxGroup_OwnerTaxGroupId",
                table: "Owner",
                column: "OwnerTaxGroupId",
                principalTable: "OwnerTaxGroup",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Owner_OwnerType_OwnerTypeId",
                table: "Owner",
                column: "OwnerTypeId",
                principalTable: "OwnerType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Owner_User_CreatedBy",
                table: "Owner",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Owner_User_ModifiedBy",
                table: "Owner",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_OwnerTaxGroupFees_OwnerTaxGroup_OwnerTaxGroupId",
                table: "OwnerTaxGroupFees",
                column: "OwnerTaxGroupId",
                principalTable: "OwnerTaxGroup",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OwnerTaxGroupFees_TaxType_TaxTypeId",
                table: "OwnerTaxGroupFees",
                column: "TaxTypeId",
                principalTable: "TaxType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OwnerTaxGroup_OwnerType_OwnerTypeId",
                table: "OwnerTaxGroup",
                column: "OwnerTypeId",
                principalTable: "OwnerType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OwnerTaxGroup_User_CreatedBy",
                table: "OwnerTaxGroup",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_OwnerTaxGroup_User_ModifiedBy",
                table: "OwnerTaxGroup",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PermitApplicationDetail_User_CreatedBy",
                schema: "Core",
                table: "PermitApplicationDetail",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PermitApplicationDetail_User_ModifiedBy",
                schema: "Core",
                table: "PermitApplicationDetail",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleResource_Resource_ResourceId",
                table: "RoleResource",
                column: "ResourceId",
                principalTable: "Resource",
                principalColumn: "ResourceId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleResource_Role_RoleId",
                table: "RoleResource",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleResource_User_CreatedBy",
                table: "RoleResource",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleResource_User_ModifiedBy",
                table: "RoleResource",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleResourceRightsHistory_Resource_ResourceId",
                table: "RoleResourceRightsHistory",
                column: "ResourceId",
                principalTable: "Resource",
                principalColumn: "ResourceId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleResourceRightsHistory_Role_RoleId",
                table: "RoleResourceRightsHistory",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleResourceRightsHistory_User_CreatedBy",
                table: "RoleResourceRightsHistory",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleResourceRightsHistory_User_ModifiedBy",
                table: "RoleResourceRightsHistory",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Resource_ResourceAction_ActionId",
                table: "Resource",
                column: "ActionId",
                principalTable: "ResourceAction",
                principalColumn: "ResourceActionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Resource_ResourceController_ControllerId",
                table: "Resource",
                column: "ControllerId",
                principalTable: "ResourceController",
                principalColumn: "ResourceControllerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Resource_ResourceType_ResourceTypeId",
                table: "Resource",
                column: "ResourceTypeId",
                principalTable: "ResourceType",
                principalColumn: "ResourceTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Resource_User_CreatedBy",
                table: "Resource",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Resource_User_ModifiedBy",
                table: "Resource",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ResourceTypeDefaultRight_User_CreatedBy",
                table: "ResourceTypeDefaultRight",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ResourceTypeDefaultRight_User_ModifiedBy",
                table: "ResourceTypeDefaultRight",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleResourceRight_User_CreatedBy",
                table: "RoleResourceRight",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleResourceRight_User_ModifiedBy",
                table: "RoleResourceRight",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_Role_RoleId",
                table: "UserRole",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_User_CreatedBy",
                table: "UserRole",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_User_ModifiedBy",
                table: "UserRole",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_User_UserId",
                table: "UserRole",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoleHistory_Role_RoleId",
                table: "UserRoleHistory",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoleHistory_User_CreatedBy",
                table: "UserRoleHistory",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoleHistory_User_ModifiedBy",
                table: "UserRoleHistory",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoleHistory_User_UserId",
                table: "UserRoleHistory",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AuctionResult_Series_SeriesId",
                table: "AuctionResult",
                column: "SeriesId",
                principalTable: "Series",
                principalColumn: "SeriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_AuctionResult_SeriesCategory_SeriesCategoryId",
                table: "AuctionResult",
                column: "SeriesCategoryId",
                principalTable: "SeriesCategory",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AuctionResult_SeriesNumber_SeriesNumberId",
                table: "AuctionResult",
                column: "SeriesNumberId",
                principalTable: "SeriesNumber",
                principalColumn: "SeriesNumberId");

            migrationBuilder.AddForeignKey(
                name: "FK_AuctionResult_User_CreatedBy",
                table: "AuctionResult",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AuctionResult_User_ModifiedBy",
                table: "AuctionResult",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Series_SeriesCategory_SeriesCategoryId",
                table: "Series",
                column: "SeriesCategoryId",
                principalTable: "SeriesCategory",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Series_SeriesStatus_SeriesStatusId",
                table: "Series",
                column: "SeriesStatusId",
                principalTable: "SeriesStatus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Series_SeriesType_SeriesTypeId",
                table: "Series",
                column: "SeriesTypeId",
                principalTable: "SeriesType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Series_User_CreatedBy",
                table: "Series",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Series_User_ModifiedBy",
                table: "Series",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaxRate_TaxBase_TaxBaseId",
                table: "TaxRate",
                column: "TaxBaseId",
                principalTable: "TaxBase",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TaxRate_TaxType_TaxTypeId",
                table: "TaxRate",
                column: "TaxTypeId",
                principalTable: "TaxType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TaxRate_User_CreatedBy",
                table: "TaxRate",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaxRate_User_ModifiedBy",
                table: "TaxRate",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaxRate_VehicleClass_VehicleClassId",
                table: "TaxRate",
                column: "VehicleClassId",
                principalTable: "VehicleClass",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TaxRate_VehicleClassDetail_VehicleClassDetailId",
                table: "TaxRate",
                column: "VehicleClassDetailId",
                principalTable: "VehicleClassDetail",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TaxType_TaxRule_TaxRuleId",
                table: "TaxType",
                column: "TaxRuleId",
                principalTable: "TaxRule",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TaxType_User_CreatedBy",
                table: "TaxType",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaxType_User_ModifiedBy",
                table: "TaxType",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountHead_User_CreatedBy",
                table: "AccountHead",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountHead_User_ModifiedBy",
                table: "AccountHead",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AddressType_User_CreatedBy",
                table: "AddressType",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AddressType_User_ModifiedBy",
                table: "AddressType",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationStatus_User_CreatedBy",
                table: "ApplicationStatus",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationStatus_User_ModifiedBy",
                table: "ApplicationStatus",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentStatus_User_CreatedBy",
                table: "AssessmentStatus",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentStatus_User_ModifiedBy",
                table: "AssessmentStatus",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bank_User_CreatedBy",
                table: "Bank",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bank_User_ModifiedBy",
                table: "Bank",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessEvent_User_CreatedBy",
                table: "BusinessEvent",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessEvent_User_ModifiedBy",
                table: "BusinessEvent",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessPhase_User_CreatedBy",
                table: "BusinessPhase",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessPhase_User_ModifiedBy",
                table: "BusinessPhase",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessPhaseStatus_User_CreatedBy",
                table: "BusinessPhaseStatus",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessPhaseStatus_User_ModifiedBy",
                table: "BusinessPhaseStatus",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessProcess_User_CreatedBy",
                table: "BusinessProcess",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessProcess_User_ModifiedBy",
                table: "BusinessProcess",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessRepStatus_User_CreatedBy",
                table: "BusinessRepStatus",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessRepStatus_User_ModifiedBy",
                table: "BusinessRepStatus",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessStatus_User_CreatedBy",
                table: "BusinessStatus",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessStatus_User_ModifiedBy",
                table: "BusinessStatus",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessTable_User_CreatedBy",
                table: "BusinessTable",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessTable_User_ModifiedBy",
                table: "BusinessTable",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessTableAccess_User_CreatedBy",
                table: "BusinessTableAccess",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessTableAccess_User_ModifiedBy",
                table: "BusinessTableAccess",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessType_User_CreatedBy",
                table: "BusinessType",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessType_User_ModifiedBy",
                table: "BusinessType",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChallanStatus_User_CreatedBy",
                table: "ChallanStatus",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChallanStatus_User_ModifiedBy",
                table: "ChallanStatus",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChallanType_User_CreatedBy",
                table: "ChallanType",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChallanType_User_ModifiedBy",
                table: "ChallanType",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClearingAgent_User_CreatedBy",
                table: "ClearingAgent",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClearingAgent_User_ModifiedBy",
                table: "ClearingAgent",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Country_User_CreatedBy",
                table: "Country",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Country_User_ModifiedBy",
                table: "Country",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomCollectorate_User_CreatedBy",
                table: "CustomCollectorate",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomCollectorate_User_ModifiedBy",
                table: "CustomCollectorate",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_District_User_CreatedBy",
                table: "District",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_District_User_ModifiedBy",
                table: "District",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_EPRSPermitTypes_User_CreatedBy",
                schema: "Setup",
                table: "EPRSPermitTypes",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_EPRSPermitTypes_User_ModifiedBy",
                schema: "Setup",
                table: "EPRSPermitTypes",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_GlobalRight_User_CreatedBy",
                table: "GlobalRight",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_GlobalRight_User_ModifiedBy",
                table: "GlobalRight",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_HPAStatus_User_CreatedBy",
                table: "HPAStatus",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_HPAStatus_User_ModifiedBy",
                table: "HPAStatus",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_HttpRequestLog_User_CreatedBy",
                table: "HttpRequestLog",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_HttpRequestLog_User_ModifiedBy",
                table: "HttpRequestLog",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_NadraFranchise_User_CreatedBy",
                table: "NadraFranchise",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_NadraFranchise_User_ModifiedBy",
                table: "NadraFranchise",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrganizationCategory_User_CreatedBy",
                table: "OrganizationCategory",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrganizationCategory_User_ModifiedBy",
                table: "OrganizationCategory",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_OwnerStatus_User_CreatedBy",
                table: "OwnerStatus",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_OwnerStatus_User_ModifiedBy",
                table: "OwnerStatus",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_OwnerType_User_CreatedBy",
                table: "OwnerType",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_OwnerType_User_ModifiedBy",
                table: "OwnerType",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMode_User_CreatedBy",
                table: "PaymentMode",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMode_User_ModifiedBy",
                table: "PaymentMode",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentStatus_User_CreatedBy",
                table: "PaymentStatus",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentStatus_User_ModifiedBy",
                table: "PaymentStatus",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PermitTypes_User_CreatedBy",
                table: "PermitTypes",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PermitTypes_User_ModifiedBy",
                table: "PermitTypes",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumberType_User_CreatedBy",
                table: "PhoneNumberType",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumberType_User_ModifiedBy",
                table: "PhoneNumberType",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Port_User_CreatedBy",
                table: "Port",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Port_User_ModifiedBy",
                table: "Port",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_RegFeePenaltyRate_User_CreatedBy",
                table: "RegFeePenaltyRate",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_RegFeePenaltyRate_User_ModifiedBy",
                table: "RegFeePenaltyRate",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ResourceAction_User_CreatedBy",
                table: "ResourceAction",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ResourceAction_User_ModifiedBy",
                table: "ResourceAction",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ResourceController_User_CreatedBy",
                table: "ResourceController",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ResourceController_User_ModifiedBy",
                table: "ResourceController",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ResourceType_User_CreatedBy",
                table: "ResourceType",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ResourceType_User_ModifiedBy",
                table: "ResourceType",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Role_User_CreatedBy",
                table: "Role",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Role_User_ModifiedBy",
                table: "Role",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SeriesCategory_User_CreatedBy",
                table: "SeriesCategory",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SeriesCategory_User_ModifiedBy",
                table: "SeriesCategory",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SeriesNumber_User_CreatedBy",
                table: "SeriesNumber",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SeriesNumber_User_ModifiedBy",
                table: "SeriesNumber",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SeriesNumberStatus_User_CreatedBy",
                table: "SeriesNumberStatus",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SeriesNumberStatus_User_ModifiedBy",
                table: "SeriesNumberStatus",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SeriesStatus_User_CreatedBy",
                table: "SeriesStatus",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SeriesStatus_User_ModifiedBy",
                table: "SeriesStatus",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SeriesType_User_CreatedBy",
                table: "SeriesType",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SeriesType_User_ModifiedBy",
                table: "SeriesType",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SqlExceptionLog_User_CreatedBy",
                table: "SqlExceptionLog",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SqlExceptionLog_User_ModifiedBy",
                table: "SqlExceptionLog",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaxBase_User_CreatedBy",
                table: "TaxBase",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaxBase_User_ModifiedBy",
                table: "TaxBase",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaxRule_User_CreatedBy",
                table: "TaxRule",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaxRule_User_ModifiedBy",
                table: "TaxRule",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserStatus_User_ModifiedBy",
                table: "UserStatus",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserType_User_ModifiedBy",
                table: "UserType",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserStatus_User_ModifiedBy",
                table: "UserStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_UserType_User_ModifiedBy",
                table: "UserType");

            migrationBuilder.DropTable(
                name: "AccountHead");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "AssessmentDetail");

            migrationBuilder.DropTable(
                name: "AuctionResult");

            migrationBuilder.DropTable(
                name: "BiometricVerification");

            migrationBuilder.DropTable(
                name: "BusinessProFeeTax");

            migrationBuilder.DropTable(
                name: "BusinessRep");

            migrationBuilder.DropTable(
                name: "BusinessTableAccessLevel");

            migrationBuilder.DropTable(
                name: "HPAStatusHistory");

            migrationBuilder.DropTable(
                name: "HttpRequestLog");

            migrationBuilder.DropTable(
                name: "Keeper");

            migrationBuilder.DropTable(
                name: "OrganizationCategory");

            migrationBuilder.DropTable(
                name: "OwnerStatus");

            migrationBuilder.DropTable(
                name: "OwnerTaxGroupFees");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "PermitApplicationDetail",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "PermitTypes");

            migrationBuilder.DropTable(
                name: "PhoneNumber");

            migrationBuilder.DropTable(
                name: "RegFeePenaltyRate");

            migrationBuilder.DropTable(
                name: "Remarks");

            migrationBuilder.DropTable(
                name: "ResourceTypeDefaultRight");

            migrationBuilder.DropTable(
                name: "RoleAppProcessFlow");

            migrationBuilder.DropTable(
                name: "RoleResourceRight");

            migrationBuilder.DropTable(
                name: "RoleResourceRightsHistory");

            migrationBuilder.DropTable(
                name: "SqlExceptionLog");

            migrationBuilder.DropTable(
                name: "TaxRate");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "UserRoleHistory");

            migrationBuilder.DropTable(
                name: "VehicleAdditionalInfo");

            migrationBuilder.DropTable(
                name: "VehicleAuctionInfo");

            migrationBuilder.DropTable(
                name: "VehicleBusinessProcessHistory");

            migrationBuilder.DropTable(
                name: "VehicleDocument");

            migrationBuilder.DropTable(
                name: "VehicleDocumentRequirement");

            migrationBuilder.DropTable(
                name: "VehicleImportInfo");

            migrationBuilder.DropTable(
                name: "VehicleOwnershipHistory");

            migrationBuilder.DropTable(
                name: "VehiclePurchaseInfo");

            migrationBuilder.DropTable(
                name: "VehicleRegistrationHistory");

            migrationBuilder.DropTable(
                name: "AddressType");

            migrationBuilder.DropTable(
                name: "Tehsil");

            migrationBuilder.DropTable(
                name: "NadraFranchise");

            migrationBuilder.DropTable(
                name: "BusinessRepStatus");

            migrationBuilder.DropTable(
                name: "BusinessTable");

            migrationBuilder.DropTable(
                name: "BusinessTableAccess");

            migrationBuilder.DropTable(
                name: "HPA");

            migrationBuilder.DropTable(
                name: "Challan");

            migrationBuilder.DropTable(
                name: "PaymentMode");

            migrationBuilder.DropTable(
                name: "PaymentStatus");

            migrationBuilder.DropTable(
                name: "PermitIssueApplication",
                schema: "Core");

            migrationBuilder.DropTable(
                name: "PhoneNumberType");

            migrationBuilder.DropTable(
                name: "OwnerGroup");

            migrationBuilder.DropTable(
                name: "ApplicationProcessFlow");

            migrationBuilder.DropTable(
                name: "ResourceTypeRight");

            migrationBuilder.DropTable(
                name: "RoleResource");

            migrationBuilder.DropTable(
                name: "TaxBase");

            migrationBuilder.DropTable(
                name: "TaxType");

            migrationBuilder.DropTable(
                name: "VehicleRCStatus");

            migrationBuilder.DropTable(
                name: "VehicleDocumentType");

            migrationBuilder.DropTable(
                name: "Bank");

            migrationBuilder.DropTable(
                name: "ClearingAgent");

            migrationBuilder.DropTable(
                name: "CustomCollectorate");

            migrationBuilder.DropTable(
                name: "Port");

            migrationBuilder.DropTable(
                name: "Dealer");

            migrationBuilder.DropTable(
                name: "VehicleScheme");

            migrationBuilder.DropTable(
                name: "SeriesNumberPool");

            migrationBuilder.DropTable(
                name: "HPAStatus");

            migrationBuilder.DropTable(
                name: "AssessmentBase");

            migrationBuilder.DropTable(
                name: "ChallanStatus");

            migrationBuilder.DropTable(
                name: "ChallanType");

            migrationBuilder.DropTable(
                name: "EPRSPermitTypes",
                schema: "Setup");

            migrationBuilder.DropTable(
                name: "EPRSPerson");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "BusinessEvent");

            migrationBuilder.DropTable(
                name: "GlobalRight");

            migrationBuilder.DropTable(
                name: "Resource");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "TaxRule");

            migrationBuilder.DropTable(
                name: "Business");

            migrationBuilder.DropTable(
                name: "Series");

            migrationBuilder.DropTable(
                name: "SeriesNumber");

            migrationBuilder.DropTable(
                name: "SeriesNumberStatus");

            migrationBuilder.DropTable(
                name: "Application");

            migrationBuilder.DropTable(
                name: "AssessmentStatus");

            migrationBuilder.DropTable(
                name: "VehicleClassDetail");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "ResourceAction");

            migrationBuilder.DropTable(
                name: "ResourceController");

            migrationBuilder.DropTable(
                name: "ResourceType");

            migrationBuilder.DropTable(
                name: "BusinessSector");

            migrationBuilder.DropTable(
                name: "BusinessStatus");

            migrationBuilder.DropTable(
                name: "SeriesCategory");

            migrationBuilder.DropTable(
                name: "SeriesStatus");

            migrationBuilder.DropTable(
                name: "SeriesType");

            migrationBuilder.DropTable(
                name: "ApplicationStatus");

            migrationBuilder.DropTable(
                name: "BusinessPhase");

            migrationBuilder.DropTable(
                name: "BusinessPhaseStatus");

            migrationBuilder.DropTable(
                name: "BusinessProcess");

            migrationBuilder.DropTable(
                name: "Vehicle");

            migrationBuilder.DropTable(
                name: "BusinessType");

            migrationBuilder.DropTable(
                name: "District");

            migrationBuilder.DropTable(
                name: "Owner");

            migrationBuilder.DropTable(
                name: "VehicleBodyConvention");

            migrationBuilder.DropTable(
                name: "VehicleClass");

            migrationBuilder.DropTable(
                name: "VehicleColor");

            migrationBuilder.DropTable(
                name: "VehicleEngineType");

            migrationBuilder.DropTable(
                name: "VehicleFuelType");

            migrationBuilder.DropTable(
                name: "VehicleMake");

            migrationBuilder.DropTable(
                name: "VehiclePurchaseType");

            migrationBuilder.DropTable(
                name: "VehicleStatus");

            migrationBuilder.DropTable(
                name: "VehicleUsage");

            migrationBuilder.DropTable(
                name: "OwnerTaxGroup");

            migrationBuilder.DropTable(
                name: "VehicleBodyType");

            migrationBuilder.DropTable(
                name: "VehicleCategory");

            migrationBuilder.DropTable(
                name: "VehicleClassGroup");

            migrationBuilder.DropTable(
                name: "VehicleClassification");

            migrationBuilder.DropTable(
                name: "VehicleRouteType");

            migrationBuilder.DropTable(
                name: "VehicleType");

            migrationBuilder.DropTable(
                name: "VehicleMaker");

            migrationBuilder.DropTable(
                name: "OwnerType");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "UserStatus");

            migrationBuilder.DropTable(
                name: "UserType");
        }
    }
}
