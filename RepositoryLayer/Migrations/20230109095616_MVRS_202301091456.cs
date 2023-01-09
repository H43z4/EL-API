using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class MVRS_202301091456 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountHead_User_CreatedBy",
                table: "AccountHead");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountHead_User_ModifiedBy",
                table: "AccountHead");

            migrationBuilder.DropForeignKey(
                name: "FK_Address_User_CreatedBy",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Address_User_ModifiedBy",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_AddressType_User_CreatedBy",
                table: "AddressType");

            migrationBuilder.DropForeignKey(
                name: "FK_AddressType_User_ModifiedBy",
                table: "AddressType");

            migrationBuilder.DropForeignKey(
                name: "FK_Application_User_CreatedBy",
                table: "Application");

            migrationBuilder.DropForeignKey(
                name: "FK_Application_User_ModifiedBy",
                table: "Application");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationStatus_User_CreatedBy",
                table: "ApplicationStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationStatus_User_ModifiedBy",
                table: "ApplicationStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_AssessmentBase_User_CreatedBy",
                table: "AssessmentBase");

            migrationBuilder.DropForeignKey(
                name: "FK_AssessmentBase_User_ModifiedBy",
                table: "AssessmentBase");

            migrationBuilder.DropForeignKey(
                name: "FK_AssessmentDetail_User_CreatedBy",
                table: "AssessmentDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_AssessmentDetail_User_ModifiedBy",
                table: "AssessmentDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_AssessmentStatus_User_CreatedBy",
                table: "AssessmentStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_AssessmentStatus_User_ModifiedBy",
                table: "AssessmentStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_AuctionResult_User_CreatedBy",
                table: "AuctionResult");

            migrationBuilder.DropForeignKey(
                name: "FK_AuctionResult_User_ModifiedBy",
                table: "AuctionResult");

            migrationBuilder.DropForeignKey(
                name: "FK_Bank_User_CreatedBy",
                table: "Bank");

            migrationBuilder.DropForeignKey(
                name: "FK_Bank_User_ModifiedBy",
                table: "Bank");

            migrationBuilder.DropForeignKey(
                name: "FK_BiometricVerification_User_CreatedBy",
                table: "BiometricVerification");

            migrationBuilder.DropForeignKey(
                name: "FK_BiometricVerification_User_ModifiedBy",
                table: "BiometricVerification");

            migrationBuilder.DropForeignKey(
                name: "FK_Business_User_CreatedBy",
                table: "Business");

            migrationBuilder.DropForeignKey(
                name: "FK_Business_User_ModifiedBy",
                table: "Business");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessEvent_User_CreatedBy",
                table: "BusinessEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessEvent_User_ModifiedBy",
                table: "BusinessEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessPhase_User_CreatedBy",
                table: "BusinessPhase");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessPhase_User_ModifiedBy",
                table: "BusinessPhase");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessPhaseStatus_User_CreatedBy",
                table: "BusinessPhaseStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessPhaseStatus_User_ModifiedBy",
                table: "BusinessPhaseStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessProcess_User_CreatedBy",
                table: "BusinessProcess");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessProcess_User_ModifiedBy",
                table: "BusinessProcess");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessProFeeTax_User_CreatedBy",
                table: "BusinessProFeeTax");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessProFeeTax_User_ModifiedBy",
                table: "BusinessProFeeTax");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessRep_User_CreatedBy",
                table: "BusinessRep");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessRep_User_ModifiedBy",
                table: "BusinessRep");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessRepStatus_User_CreatedBy",
                table: "BusinessRepStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessRepStatus_User_ModifiedBy",
                table: "BusinessRepStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessSector_User_CreatedBy",
                table: "BusinessSector");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessSector_User_ModifiedBy",
                table: "BusinessSector");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessStatus_User_CreatedBy",
                table: "BusinessStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessStatus_User_ModifiedBy",
                table: "BusinessStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessTable_User_CreatedBy",
                table: "BusinessTable");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessTable_User_ModifiedBy",
                table: "BusinessTable");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessTableAccess_User_CreatedBy",
                table: "BusinessTableAccess");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessTableAccess_User_ModifiedBy",
                table: "BusinessTableAccess");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessType_User_CreatedBy",
                table: "BusinessType");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessType_User_ModifiedBy",
                table: "BusinessType");

            migrationBuilder.DropForeignKey(
                name: "FK_Challan_User_CreatedBy",
                table: "Challan");

            migrationBuilder.DropForeignKey(
                name: "FK_Challan_User_ModifiedBy",
                table: "Challan");

            migrationBuilder.DropForeignKey(
                name: "FK_ChallanStatus_User_CreatedBy",
                table: "ChallanStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_ChallanStatus_User_ModifiedBy",
                table: "ChallanStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_ChallanType_User_CreatedBy",
                table: "ChallanType");

            migrationBuilder.DropForeignKey(
                name: "FK_ChallanType_User_ModifiedBy",
                table: "ChallanType");

            migrationBuilder.DropForeignKey(
                name: "FK_ClearingAgent_User_CreatedBy",
                table: "ClearingAgent");

            migrationBuilder.DropForeignKey(
                name: "FK_ClearingAgent_User_ModifiedBy",
                table: "ClearingAgent");

            migrationBuilder.DropForeignKey(
                name: "FK_Country_User_CreatedBy",
                table: "Country");

            migrationBuilder.DropForeignKey(
                name: "FK_Country_User_ModifiedBy",
                table: "Country");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomCollectorate_User_CreatedBy",
                table: "CustomCollectorate");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomCollectorate_User_ModifiedBy",
                table: "CustomCollectorate");

            migrationBuilder.DropForeignKey(
                name: "FK_Dealer_User_CreatedBy",
                table: "Dealer");

            migrationBuilder.DropForeignKey(
                name: "FK_Dealer_User_ModifiedBy",
                table: "Dealer");

            migrationBuilder.DropForeignKey(
                name: "FK_District_User_CreatedBy",
                table: "District");

            migrationBuilder.DropForeignKey(
                name: "FK_District_User_ModifiedBy",
                table: "District");

            migrationBuilder.DropForeignKey(
                name: "FK_EPRSPermitTypes_User_CreatedBy",
                schema: "Setup",
                table: "EPRSPermitTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_EPRSPermitTypes_User_ModifiedBy",
                schema: "Setup",
                table: "EPRSPermitTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_EPRSPerson_Country_CountryId",
                schema: "Core",
                table: "EPRSPerson");

            migrationBuilder.DropForeignKey(
                name: "FK_EPRSPerson_User_CreatedBy",
                schema: "Core",
                table: "EPRSPerson");

            migrationBuilder.DropForeignKey(
                name: "FK_EPRSPerson_User_ModifiedBy",
                schema: "Core",
                table: "EPRSPerson");

            migrationBuilder.DropForeignKey(
                name: "FK_GlobalRight_User_CreatedBy",
                table: "GlobalRight");

            migrationBuilder.DropForeignKey(
                name: "FK_GlobalRight_User_ModifiedBy",
                table: "GlobalRight");

            migrationBuilder.DropForeignKey(
                name: "FK_HPA_User_CreatedBy",
                table: "HPA");

            migrationBuilder.DropForeignKey(
                name: "FK_HPA_User_ModifiedBy",
                table: "HPA");

            migrationBuilder.DropForeignKey(
                name: "FK_HPAStatus_User_CreatedBy",
                table: "HPAStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_HPAStatus_User_ModifiedBy",
                table: "HPAStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_HPAStatusHistory_User_CreatedBy",
                table: "HPAStatusHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_HPAStatusHistory_User_ModifiedBy",
                table: "HPAStatusHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_HttpRequestLog_User_CreatedBy",
                table: "HttpRequestLog");

            migrationBuilder.DropForeignKey(
                name: "FK_HttpRequestLog_User_ModifiedBy",
                table: "HttpRequestLog");

            migrationBuilder.DropForeignKey(
                name: "FK_Keeper_User_CreatedBy",
                table: "Keeper");

            migrationBuilder.DropForeignKey(
                name: "FK_Keeper_User_ModifiedBy",
                table: "Keeper");

            migrationBuilder.DropForeignKey(
                name: "FK_NadraFranchise_User_CreatedBy",
                table: "NadraFranchise");

            migrationBuilder.DropForeignKey(
                name: "FK_NadraFranchise_User_ModifiedBy",
                table: "NadraFranchise");

            migrationBuilder.DropForeignKey(
                name: "FK_OrganizationCategory_User_CreatedBy",
                table: "OrganizationCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_OrganizationCategory_User_ModifiedBy",
                table: "OrganizationCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_Owner_User_CreatedBy",
                table: "Owner");

            migrationBuilder.DropForeignKey(
                name: "FK_Owner_User_ModifiedBy",
                table: "Owner");

            migrationBuilder.DropForeignKey(
                name: "FK_OwnerGroup_User_CreatedBy",
                table: "OwnerGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_OwnerGroup_User_ModifiedBy",
                table: "OwnerGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_OwnerStatus_User_CreatedBy",
                table: "OwnerStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_OwnerStatus_User_ModifiedBy",
                table: "OwnerStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_OwnerTaxGroup_User_CreatedBy",
                table: "OwnerTaxGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_OwnerTaxGroup_User_ModifiedBy",
                table: "OwnerTaxGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_OwnerType_User_CreatedBy",
                table: "OwnerType");

            migrationBuilder.DropForeignKey(
                name: "FK_OwnerType_User_ModifiedBy",
                table: "OwnerType");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_User_CreatedBy",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_User_ModifiedBy",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMode_User_CreatedBy",
                table: "PaymentMode");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMode_User_ModifiedBy",
                table: "PaymentMode");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentStatus_User_CreatedBy",
                table: "PaymentStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentStatus_User_ModifiedBy",
                table: "PaymentStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_PermitApplicationDetail_User_CreatedBy",
                schema: "Core",
                table: "PermitApplicationDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_PermitApplicationDetail_User_ModifiedBy",
                schema: "Core",
                table: "PermitApplicationDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_PermitIssueApplication_ApplicationStatus_ApplicationStatusId",
                schema: "Core",
                table: "PermitIssueApplication");

            migrationBuilder.DropForeignKey(
                name: "FK_PermitIssueApplication_District_DistrictId",
                schema: "Core",
                table: "PermitIssueApplication");

            migrationBuilder.DropForeignKey(
                name: "FK_PermitIssueApplication_User_CreatedBy",
                schema: "Core",
                table: "PermitIssueApplication");

            migrationBuilder.DropForeignKey(
                name: "FK_PermitIssueApplication_User_ModifiedBy",
                schema: "Core",
                table: "PermitIssueApplication");

            migrationBuilder.DropForeignKey(
                name: "FK_PermitTypes_User_CreatedBy",
                table: "PermitTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_PermitTypes_User_ModifiedBy",
                table: "PermitTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_User_CreatedBy",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_User_ModifiedBy",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumber_User_CreatedBy",
                table: "PhoneNumber");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumber_User_ModifiedBy",
                table: "PhoneNumber");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumberType_User_CreatedBy",
                table: "PhoneNumberType");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumberType_User_ModifiedBy",
                table: "PhoneNumberType");

            migrationBuilder.DropForeignKey(
                name: "FK_Port_User_CreatedBy",
                table: "Port");

            migrationBuilder.DropForeignKey(
                name: "FK_Port_User_ModifiedBy",
                table: "Port");

            migrationBuilder.DropForeignKey(
                name: "FK_RegFeePenaltyRate_User_CreatedBy",
                table: "RegFeePenaltyRate");

            migrationBuilder.DropForeignKey(
                name: "FK_RegFeePenaltyRate_User_ModifiedBy",
                table: "RegFeePenaltyRate");

            migrationBuilder.DropForeignKey(
                name: "FK_Remarks_User_CreatedBy",
                table: "Remarks");

            migrationBuilder.DropForeignKey(
                name: "FK_Remarks_User_ModifiedBy",
                table: "Remarks");

            migrationBuilder.DropForeignKey(
                name: "FK_Resource_User_CreatedBy",
                table: "Resource");

            migrationBuilder.DropForeignKey(
                name: "FK_Resource_User_ModifiedBy",
                table: "Resource");

            migrationBuilder.DropForeignKey(
                name: "FK_ResourceAction_User_CreatedBy",
                table: "ResourceAction");

            migrationBuilder.DropForeignKey(
                name: "FK_ResourceAction_User_ModifiedBy",
                table: "ResourceAction");

            migrationBuilder.DropForeignKey(
                name: "FK_ResourceController_User_CreatedBy",
                table: "ResourceController");

            migrationBuilder.DropForeignKey(
                name: "FK_ResourceController_User_ModifiedBy",
                table: "ResourceController");

            migrationBuilder.DropForeignKey(
                name: "FK_ResourceType_User_CreatedBy",
                table: "ResourceType");

            migrationBuilder.DropForeignKey(
                name: "FK_ResourceType_User_ModifiedBy",
                table: "ResourceType");

            migrationBuilder.DropForeignKey(
                name: "FK_ResourceTypeDefaultRight_User_CreatedBy",
                table: "ResourceTypeDefaultRight");

            migrationBuilder.DropForeignKey(
                name: "FK_ResourceTypeDefaultRight_User_ModifiedBy",
                table: "ResourceTypeDefaultRight");

            migrationBuilder.DropForeignKey(
                name: "FK_ResourceTypeRight_User_CreatedBy",
                table: "ResourceTypeRight");

            migrationBuilder.DropForeignKey(
                name: "FK_ResourceTypeRight_User_ModifiedBy",
                table: "ResourceTypeRight");

            migrationBuilder.DropForeignKey(
                name: "FK_Role_User_CreatedBy",
                table: "Role");

            migrationBuilder.DropForeignKey(
                name: "FK_Role_User_ModifiedBy",
                table: "Role");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleAppProcessFlow_User_CreatedBy",
                table: "RoleAppProcessFlow");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleAppProcessFlow_User_ModifiedBy",
                table: "RoleAppProcessFlow");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleResource_User_CreatedBy",
                table: "RoleResource");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleResource_User_ModifiedBy",
                table: "RoleResource");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleResourceRight_User_CreatedBy",
                table: "RoleResourceRight");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleResourceRight_User_ModifiedBy",
                table: "RoleResourceRight");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleResourceRightsHistory_User_CreatedBy",
                table: "RoleResourceRightsHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleResourceRightsHistory_User_ModifiedBy",
                table: "RoleResourceRightsHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_Series_User_CreatedBy",
                table: "Series");

            migrationBuilder.DropForeignKey(
                name: "FK_Series_User_ModifiedBy",
                table: "Series");

            migrationBuilder.DropForeignKey(
                name: "FK_SeriesCategory_User_CreatedBy",
                table: "SeriesCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_SeriesCategory_User_ModifiedBy",
                table: "SeriesCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_SeriesNumber_User_CreatedBy",
                table: "SeriesNumber");

            migrationBuilder.DropForeignKey(
                name: "FK_SeriesNumber_User_ModifiedBy",
                table: "SeriesNumber");

            migrationBuilder.DropForeignKey(
                name: "FK_SeriesNumberPool_User_CreatedBy",
                table: "SeriesNumberPool");

            migrationBuilder.DropForeignKey(
                name: "FK_SeriesNumberPool_User_ModifiedBy",
                table: "SeriesNumberPool");

            migrationBuilder.DropForeignKey(
                name: "FK_SeriesNumberStatus_User_CreatedBy",
                table: "SeriesNumberStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_SeriesNumberStatus_User_ModifiedBy",
                table: "SeriesNumberStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_SeriesStatus_User_CreatedBy",
                table: "SeriesStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_SeriesStatus_User_ModifiedBy",
                table: "SeriesStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_SeriesType_User_CreatedBy",
                table: "SeriesType");

            migrationBuilder.DropForeignKey(
                name: "FK_SeriesType_User_ModifiedBy",
                table: "SeriesType");

            migrationBuilder.DropForeignKey(
                name: "FK_SqlExceptionLog_User_CreatedBy",
                table: "SqlExceptionLog");

            migrationBuilder.DropForeignKey(
                name: "FK_SqlExceptionLog_User_ModifiedBy",
                table: "SqlExceptionLog");

            migrationBuilder.DropForeignKey(
                name: "FK_StockInApplication_User_CreatedBy",
                schema: "Core",
                table: "StockInApplication");

            migrationBuilder.DropForeignKey(
                name: "FK_StockInApplication_User_ModifiedBy",
                schema: "Core",
                table: "StockInApplication");

            migrationBuilder.DropForeignKey(
                name: "FK_StockInApplicationDetails_User_CreatedBy",
                schema: "Core",
                table: "StockInApplicationDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_StockInApplicationDetails_User_ModifiedBy",
                schema: "Core",
                table: "StockInApplicationDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_TaxBase_User_CreatedBy",
                table: "TaxBase");

            migrationBuilder.DropForeignKey(
                name: "FK_TaxBase_User_ModifiedBy",
                table: "TaxBase");

            migrationBuilder.DropForeignKey(
                name: "FK_TaxRate_User_CreatedBy",
                table: "TaxRate");

            migrationBuilder.DropForeignKey(
                name: "FK_TaxRate_User_ModifiedBy",
                table: "TaxRate");

            migrationBuilder.DropForeignKey(
                name: "FK_TaxRule_User_CreatedBy",
                table: "TaxRule");

            migrationBuilder.DropForeignKey(
                name: "FK_TaxRule_User_ModifiedBy",
                table: "TaxRule");

            migrationBuilder.DropForeignKey(
                name: "FK_TaxType_User_CreatedBy",
                table: "TaxType");

            migrationBuilder.DropForeignKey(
                name: "FK_TaxType_User_ModifiedBy",
                table: "TaxType");

            migrationBuilder.DropForeignKey(
                name: "FK_Tehsil_User_CreatedBy",
                table: "Tehsil");

            migrationBuilder.DropForeignKey(
                name: "FK_Tehsil_User_ModifiedBy",
                table: "Tehsil");

            migrationBuilder.DropForeignKey(
                name: "FK_User_User_ModifiedBy",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_UserStatus_UserStatusId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_UserType_UserTypeId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_User_CreatedBy",
                table: "UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_User_ModifiedBy",
                table: "UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoleHistory_User_CreatedBy",
                table: "UserRoleHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoleHistory_User_ModifiedBy",
                table: "UserRoleHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_UserStatus_User_ModifiedBy",
                table: "UserStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_UserType_User_ModifiedBy",
                table: "UserType");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_User_CreatedBy",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_User_ModifiedBy",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleAdditionalInfo_User_CreatedBy",
                table: "VehicleAdditionalInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleAdditionalInfo_User_ModifiedBy",
                table: "VehicleAdditionalInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleAuctionInfo_User_CreatedBy",
                table: "VehicleAuctionInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleAuctionInfo_User_ModifiedBy",
                table: "VehicleAuctionInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleBodyConvention_User_CreatedBy",
                table: "VehicleBodyConvention");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleBodyConvention_User_ModifiedBy",
                table: "VehicleBodyConvention");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleBodyType_User_CreatedBy",
                table: "VehicleBodyType");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleBodyType_User_ModifiedBy",
                table: "VehicleBodyType");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleBusinessProcessHistory_User_CreatedBy",
                table: "VehicleBusinessProcessHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleBusinessProcessHistory_User_ModifiedBy",
                table: "VehicleBusinessProcessHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleCategory_User_CreatedBy",
                table: "VehicleCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleCategory_User_ModifiedBy",
                table: "VehicleCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleClass_User_CreatedBy",
                table: "VehicleClass");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleClass_User_ModifiedBy",
                table: "VehicleClass");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleClassDetail_User_CreatedBy",
                table: "VehicleClassDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleClassDetail_User_ModifiedBy",
                table: "VehicleClassDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleClassGroup_User_CreatedBy",
                table: "VehicleClassGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleClassGroup_User_ModifiedBy",
                table: "VehicleClassGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleClassification_User_CreatedBy",
                table: "VehicleClassification");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleClassification_User_ModifiedBy",
                table: "VehicleClassification");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleColor_User_CreatedBy",
                table: "VehicleColor");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleColor_User_ModifiedBy",
                table: "VehicleColor");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleDocument_User_CreatedBy",
                table: "VehicleDocument");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleDocument_User_ModifiedBy",
                table: "VehicleDocument");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleDocumentType_User_CreatedBy",
                table: "VehicleDocumentType");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleDocumentType_User_ModifiedBy",
                table: "VehicleDocumentType");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleEngineType_User_CreatedBy",
                table: "VehicleEngineType");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleEngineType_User_ModifiedBy",
                table: "VehicleEngineType");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleFuelType_User_CreatedBy",
                table: "VehicleFuelType");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleFuelType_User_ModifiedBy",
                table: "VehicleFuelType");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleImportInfo_User_CreatedBy",
                table: "VehicleImportInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleImportInfo_User_ModifiedBy",
                table: "VehicleImportInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleMake_User_CreatedBy",
                table: "VehicleMake");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleMake_User_ModifiedBy",
                table: "VehicleMake");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleMaker_User_CreatedBy",
                table: "VehicleMaker");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleMaker_User_ModifiedBy",
                table: "VehicleMaker");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleOwnershipHistory_User_CreatedBy",
                table: "VehicleOwnershipHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleOwnershipHistory_User_ModifiedBy",
                table: "VehicleOwnershipHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_VehiclePurchaseInfo_User_CreatedBy",
                table: "VehiclePurchaseInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_VehiclePurchaseInfo_User_ModifiedBy",
                table: "VehiclePurchaseInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_VehiclePurchaseType_User_CreatedBy",
                table: "VehiclePurchaseType");

            migrationBuilder.DropForeignKey(
                name: "FK_VehiclePurchaseType_User_ModifiedBy",
                table: "VehiclePurchaseType");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleRCStatus_User_CreatedBy",
                table: "VehicleRCStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleRCStatus_User_ModifiedBy",
                table: "VehicleRCStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleRegistrationHistory_User_CreatedBy",
                table: "VehicleRegistrationHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleRegistrationHistory_User_ModifiedBy",
                table: "VehicleRegistrationHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleRouteType_User_CreatedBy",
                table: "VehicleRouteType");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleRouteType_User_ModifiedBy",
                table: "VehicleRouteType");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleScheme_User_CreatedBy",
                table: "VehicleScheme");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleScheme_User_ModifiedBy",
                table: "VehicleScheme");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleStatus_User_CreatedBy",
                table: "VehicleStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleStatus_User_ModifiedBy",
                table: "VehicleStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleType_User_CreatedBy",
                table: "VehicleType");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleType_User_ModifiedBy",
                table: "VehicleType");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleUsage_User_CreatedBy",
                table: "VehicleUsage");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleUsage_User_ModifiedBy",
                table: "VehicleUsage");

            migrationBuilder.DropIndex(
                name: "IX_VehicleUsage_CreatedBy",
                table: "VehicleUsage");

            migrationBuilder.DropIndex(
                name: "IX_VehicleUsage_ModifiedBy",
                table: "VehicleUsage");

            migrationBuilder.DropIndex(
                name: "IX_VehicleType_CreatedBy",
                table: "VehicleType");

            migrationBuilder.DropIndex(
                name: "IX_VehicleType_ModifiedBy",
                table: "VehicleType");

            migrationBuilder.DropIndex(
                name: "IX_VehicleStatus_CreatedBy",
                table: "VehicleStatus");

            migrationBuilder.DropIndex(
                name: "IX_VehicleStatus_ModifiedBy",
                table: "VehicleStatus");

            migrationBuilder.DropIndex(
                name: "IX_VehicleScheme_CreatedBy",
                table: "VehicleScheme");

            migrationBuilder.DropIndex(
                name: "IX_VehicleScheme_ModifiedBy",
                table: "VehicleScheme");

            migrationBuilder.DropIndex(
                name: "IX_VehicleRouteType_CreatedBy",
                table: "VehicleRouteType");

            migrationBuilder.DropIndex(
                name: "IX_VehicleRouteType_ModifiedBy",
                table: "VehicleRouteType");

            migrationBuilder.DropIndex(
                name: "IX_VehicleRegistrationHistory_CreatedBy",
                table: "VehicleRegistrationHistory");

            migrationBuilder.DropIndex(
                name: "IX_VehicleRegistrationHistory_ModifiedBy",
                table: "VehicleRegistrationHistory");

            migrationBuilder.DropIndex(
                name: "IX_VehicleRCStatus_CreatedBy",
                table: "VehicleRCStatus");

            migrationBuilder.DropIndex(
                name: "IX_VehicleRCStatus_ModifiedBy",
                table: "VehicleRCStatus");

            migrationBuilder.DropIndex(
                name: "IX_VehiclePurchaseType_CreatedBy",
                table: "VehiclePurchaseType");

            migrationBuilder.DropIndex(
                name: "IX_VehiclePurchaseType_ModifiedBy",
                table: "VehiclePurchaseType");

            migrationBuilder.DropIndex(
                name: "IX_VehiclePurchaseInfo_CreatedBy",
                table: "VehiclePurchaseInfo");

            migrationBuilder.DropIndex(
                name: "IX_VehiclePurchaseInfo_ModifiedBy",
                table: "VehiclePurchaseInfo");

            migrationBuilder.DropIndex(
                name: "IX_VehicleOwnershipHistory_CreatedBy",
                table: "VehicleOwnershipHistory");

            migrationBuilder.DropIndex(
                name: "IX_VehicleOwnershipHistory_ModifiedBy",
                table: "VehicleOwnershipHistory");

            migrationBuilder.DropIndex(
                name: "IX_VehicleMaker_CreatedBy",
                table: "VehicleMaker");

            migrationBuilder.DropIndex(
                name: "IX_VehicleMaker_ModifiedBy",
                table: "VehicleMaker");

            migrationBuilder.DropIndex(
                name: "IX_VehicleMake_CreatedBy",
                table: "VehicleMake");

            migrationBuilder.DropIndex(
                name: "IX_VehicleMake_ModifiedBy",
                table: "VehicleMake");

            migrationBuilder.DropIndex(
                name: "IX_VehicleImportInfo_CreatedBy",
                table: "VehicleImportInfo");

            migrationBuilder.DropIndex(
                name: "IX_VehicleImportInfo_ModifiedBy",
                table: "VehicleImportInfo");

            migrationBuilder.DropIndex(
                name: "IX_VehicleFuelType_CreatedBy",
                table: "VehicleFuelType");

            migrationBuilder.DropIndex(
                name: "IX_VehicleFuelType_ModifiedBy",
                table: "VehicleFuelType");

            migrationBuilder.DropIndex(
                name: "IX_VehicleEngineType_CreatedBy",
                table: "VehicleEngineType");

            migrationBuilder.DropIndex(
                name: "IX_VehicleEngineType_ModifiedBy",
                table: "VehicleEngineType");

            migrationBuilder.DropIndex(
                name: "IX_VehicleDocumentType_CreatedBy",
                table: "VehicleDocumentType");

            migrationBuilder.DropIndex(
                name: "IX_VehicleDocumentType_ModifiedBy",
                table: "VehicleDocumentType");

            migrationBuilder.DropIndex(
                name: "IX_VehicleDocument_CreatedBy",
                table: "VehicleDocument");

            migrationBuilder.DropIndex(
                name: "IX_VehicleDocument_ModifiedBy",
                table: "VehicleDocument");

            migrationBuilder.DropIndex(
                name: "IX_VehicleColor_CreatedBy",
                table: "VehicleColor");

            migrationBuilder.DropIndex(
                name: "IX_VehicleColor_ModifiedBy",
                table: "VehicleColor");

            migrationBuilder.DropIndex(
                name: "IX_VehicleClassification_CreatedBy",
                table: "VehicleClassification");

            migrationBuilder.DropIndex(
                name: "IX_VehicleClassification_ModifiedBy",
                table: "VehicleClassification");

            migrationBuilder.DropIndex(
                name: "IX_VehicleClassGroup_CreatedBy",
                table: "VehicleClassGroup");

            migrationBuilder.DropIndex(
                name: "IX_VehicleClassGroup_ModifiedBy",
                table: "VehicleClassGroup");

            migrationBuilder.DropIndex(
                name: "IX_VehicleClassDetail_CreatedBy",
                table: "VehicleClassDetail");

            migrationBuilder.DropIndex(
                name: "IX_VehicleClassDetail_ModifiedBy",
                table: "VehicleClassDetail");

            migrationBuilder.DropIndex(
                name: "IX_VehicleClass_CreatedBy",
                table: "VehicleClass");

            migrationBuilder.DropIndex(
                name: "IX_VehicleClass_ModifiedBy",
                table: "VehicleClass");

            migrationBuilder.DropIndex(
                name: "IX_VehicleCategory_CreatedBy",
                table: "VehicleCategory");

            migrationBuilder.DropIndex(
                name: "IX_VehicleCategory_ModifiedBy",
                table: "VehicleCategory");

            migrationBuilder.DropIndex(
                name: "IX_VehicleBusinessProcessHistory_CreatedBy",
                table: "VehicleBusinessProcessHistory");

            migrationBuilder.DropIndex(
                name: "IX_VehicleBusinessProcessHistory_ModifiedBy",
                table: "VehicleBusinessProcessHistory");

            migrationBuilder.DropIndex(
                name: "IX_VehicleBodyType_CreatedBy",
                table: "VehicleBodyType");

            migrationBuilder.DropIndex(
                name: "IX_VehicleBodyType_ModifiedBy",
                table: "VehicleBodyType");

            migrationBuilder.DropIndex(
                name: "IX_VehicleBodyConvention_CreatedBy",
                table: "VehicleBodyConvention");

            migrationBuilder.DropIndex(
                name: "IX_VehicleBodyConvention_ModifiedBy",
                table: "VehicleBodyConvention");

            migrationBuilder.DropIndex(
                name: "IX_VehicleAuctionInfo_CreatedBy",
                table: "VehicleAuctionInfo");

            migrationBuilder.DropIndex(
                name: "IX_VehicleAuctionInfo_ModifiedBy",
                table: "VehicleAuctionInfo");

            migrationBuilder.DropIndex(
                name: "IX_VehicleAdditionalInfo_CreatedBy",
                table: "VehicleAdditionalInfo");

            migrationBuilder.DropIndex(
                name: "IX_VehicleAdditionalInfo_ModifiedBy",
                table: "VehicleAdditionalInfo");

            migrationBuilder.DropIndex(
                name: "IX_Vehicle_CreatedBy",
                table: "Vehicle");

            migrationBuilder.DropIndex(
                name: "IX_Vehicle_ModifiedBy",
                table: "Vehicle");

            migrationBuilder.DropIndex(
                name: "IX_UserType_ModifiedBy",
                table: "UserType");

            migrationBuilder.DropIndex(
                name: "IX_UserStatus_ModifiedBy",
                table: "UserStatus");

            migrationBuilder.DropIndex(
                name: "IX_UserRoleHistory_CreatedBy",
                table: "UserRoleHistory");

            migrationBuilder.DropIndex(
                name: "IX_UserRoleHistory_ModifiedBy",
                table: "UserRoleHistory");

            migrationBuilder.DropIndex(
                name: "IX_UserRole_CreatedBy",
                table: "UserRole");

            migrationBuilder.DropIndex(
                name: "IX_UserRole_ModifiedBy",
                table: "UserRole");

            migrationBuilder.DropIndex(
                name: "IX_User_ModifiedBy",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_UserStatusId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_UserTypeId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_Tehsil_CreatedBy",
                table: "Tehsil");

            migrationBuilder.DropIndex(
                name: "IX_Tehsil_ModifiedBy",
                table: "Tehsil");

            migrationBuilder.DropIndex(
                name: "IX_TaxType_CreatedBy",
                table: "TaxType");

            migrationBuilder.DropIndex(
                name: "IX_TaxType_ModifiedBy",
                table: "TaxType");

            migrationBuilder.DropIndex(
                name: "IX_TaxRule_CreatedBy",
                table: "TaxRule");

            migrationBuilder.DropIndex(
                name: "IX_TaxRule_ModifiedBy",
                table: "TaxRule");

            migrationBuilder.DropIndex(
                name: "IX_TaxRate_CreatedBy",
                table: "TaxRate");

            migrationBuilder.DropIndex(
                name: "IX_TaxRate_ModifiedBy",
                table: "TaxRate");

            migrationBuilder.DropIndex(
                name: "IX_TaxBase_CreatedBy",
                table: "TaxBase");

            migrationBuilder.DropIndex(
                name: "IX_TaxBase_ModifiedBy",
                table: "TaxBase");

            migrationBuilder.DropIndex(
                name: "IX_StockInApplicationDetails_CreatedBy",
                schema: "Core",
                table: "StockInApplicationDetails");

            migrationBuilder.DropIndex(
                name: "IX_StockInApplicationDetails_ModifiedBy",
                schema: "Core",
                table: "StockInApplicationDetails");

            migrationBuilder.DropIndex(
                name: "IX_StockInApplication_CreatedBy",
                schema: "Core",
                table: "StockInApplication");

            migrationBuilder.DropIndex(
                name: "IX_StockInApplication_ModifiedBy",
                schema: "Core",
                table: "StockInApplication");

            migrationBuilder.DropIndex(
                name: "IX_SqlExceptionLog_CreatedBy",
                table: "SqlExceptionLog");

            migrationBuilder.DropIndex(
                name: "IX_SqlExceptionLog_ModifiedBy",
                table: "SqlExceptionLog");

            migrationBuilder.DropIndex(
                name: "IX_SeriesType_CreatedBy",
                table: "SeriesType");

            migrationBuilder.DropIndex(
                name: "IX_SeriesType_ModifiedBy",
                table: "SeriesType");

            migrationBuilder.DropIndex(
                name: "IX_SeriesStatus_CreatedBy",
                table: "SeriesStatus");

            migrationBuilder.DropIndex(
                name: "IX_SeriesStatus_ModifiedBy",
                table: "SeriesStatus");

            migrationBuilder.DropIndex(
                name: "IX_SeriesNumberStatus_CreatedBy",
                table: "SeriesNumberStatus");

            migrationBuilder.DropIndex(
                name: "IX_SeriesNumberStatus_ModifiedBy",
                table: "SeriesNumberStatus");

            migrationBuilder.DropIndex(
                name: "IX_SeriesNumberPool_CreatedBy",
                table: "SeriesNumberPool");

            migrationBuilder.DropIndex(
                name: "IX_SeriesNumberPool_ModifiedBy",
                table: "SeriesNumberPool");

            migrationBuilder.DropIndex(
                name: "IX_SeriesNumber_CreatedBy",
                table: "SeriesNumber");

            migrationBuilder.DropIndex(
                name: "IX_SeriesNumber_ModifiedBy",
                table: "SeriesNumber");

            migrationBuilder.DropIndex(
                name: "IX_SeriesCategory_CreatedBy",
                table: "SeriesCategory");

            migrationBuilder.DropIndex(
                name: "IX_SeriesCategory_ModifiedBy",
                table: "SeriesCategory");

            migrationBuilder.DropIndex(
                name: "IX_Series_CreatedBy",
                table: "Series");

            migrationBuilder.DropIndex(
                name: "IX_Series_ModifiedBy",
                table: "Series");

            migrationBuilder.DropIndex(
                name: "IX_RoleResourceRightsHistory_CreatedBy",
                table: "RoleResourceRightsHistory");

            migrationBuilder.DropIndex(
                name: "IX_RoleResourceRightsHistory_ModifiedBy",
                table: "RoleResourceRightsHistory");

            migrationBuilder.DropIndex(
                name: "IX_RoleResourceRight_CreatedBy",
                table: "RoleResourceRight");

            migrationBuilder.DropIndex(
                name: "IX_RoleResourceRight_ModifiedBy",
                table: "RoleResourceRight");

            migrationBuilder.DropIndex(
                name: "IX_RoleResource_CreatedBy",
                table: "RoleResource");

            migrationBuilder.DropIndex(
                name: "IX_RoleResource_ModifiedBy",
                table: "RoleResource");

            migrationBuilder.DropIndex(
                name: "IX_RoleAppProcessFlow_CreatedBy",
                table: "RoleAppProcessFlow");

            migrationBuilder.DropIndex(
                name: "IX_RoleAppProcessFlow_ModifiedBy",
                table: "RoleAppProcessFlow");

            migrationBuilder.DropIndex(
                name: "IX_Role_CreatedBy",
                table: "Role");

            migrationBuilder.DropIndex(
                name: "IX_Role_ModifiedBy",
                table: "Role");

            migrationBuilder.DropIndex(
                name: "IX_ResourceTypeRight_CreatedBy",
                table: "ResourceTypeRight");

            migrationBuilder.DropIndex(
                name: "IX_ResourceTypeRight_ModifiedBy",
                table: "ResourceTypeRight");

            migrationBuilder.DropIndex(
                name: "IX_ResourceTypeDefaultRight_CreatedBy",
                table: "ResourceTypeDefaultRight");

            migrationBuilder.DropIndex(
                name: "IX_ResourceTypeDefaultRight_ModifiedBy",
                table: "ResourceTypeDefaultRight");

            migrationBuilder.DropIndex(
                name: "IX_ResourceType_CreatedBy",
                table: "ResourceType");

            migrationBuilder.DropIndex(
                name: "IX_ResourceType_ModifiedBy",
                table: "ResourceType");

            migrationBuilder.DropIndex(
                name: "IX_ResourceController_CreatedBy",
                table: "ResourceController");

            migrationBuilder.DropIndex(
                name: "IX_ResourceController_ModifiedBy",
                table: "ResourceController");

            migrationBuilder.DropIndex(
                name: "IX_ResourceAction_CreatedBy",
                table: "ResourceAction");

            migrationBuilder.DropIndex(
                name: "IX_ResourceAction_ModifiedBy",
                table: "ResourceAction");

            migrationBuilder.DropIndex(
                name: "IX_Resource_CreatedBy",
                table: "Resource");

            migrationBuilder.DropIndex(
                name: "IX_Resource_ModifiedBy",
                table: "Resource");

            migrationBuilder.DropIndex(
                name: "IX_Remarks_CreatedBy",
                table: "Remarks");

            migrationBuilder.DropIndex(
                name: "IX_Remarks_ModifiedBy",
                table: "Remarks");

            migrationBuilder.DropIndex(
                name: "IX_RegFeePenaltyRate_CreatedBy",
                table: "RegFeePenaltyRate");

            migrationBuilder.DropIndex(
                name: "IX_RegFeePenaltyRate_ModifiedBy",
                table: "RegFeePenaltyRate");

            migrationBuilder.DropIndex(
                name: "IX_Port_CreatedBy",
                table: "Port");

            migrationBuilder.DropIndex(
                name: "IX_Port_ModifiedBy",
                table: "Port");

            migrationBuilder.DropIndex(
                name: "IX_PhoneNumberType_CreatedBy",
                table: "PhoneNumberType");

            migrationBuilder.DropIndex(
                name: "IX_PhoneNumberType_ModifiedBy",
                table: "PhoneNumberType");

            migrationBuilder.DropIndex(
                name: "IX_PhoneNumber_CreatedBy",
                table: "PhoneNumber");

            migrationBuilder.DropIndex(
                name: "IX_PhoneNumber_ModifiedBy",
                table: "PhoneNumber");

            migrationBuilder.DropIndex(
                name: "IX_Person_CreatedBy",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Person_ModifiedBy",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_PermitTypes_CreatedBy",
                table: "PermitTypes");

            migrationBuilder.DropIndex(
                name: "IX_PermitTypes_ModifiedBy",
                table: "PermitTypes");

            migrationBuilder.DropIndex(
                name: "IX_PermitIssueApplication_ApplicationStatusId",
                schema: "Core",
                table: "PermitIssueApplication");

            migrationBuilder.DropIndex(
                name: "IX_PermitIssueApplication_CreatedBy",
                schema: "Core",
                table: "PermitIssueApplication");

            migrationBuilder.DropIndex(
                name: "IX_PermitIssueApplication_DistrictId",
                schema: "Core",
                table: "PermitIssueApplication");

            migrationBuilder.DropIndex(
                name: "IX_PermitIssueApplication_ModifiedBy",
                schema: "Core",
                table: "PermitIssueApplication");

            migrationBuilder.DropIndex(
                name: "IX_PermitApplicationDetail_CreatedBy",
                schema: "Core",
                table: "PermitApplicationDetail");

            migrationBuilder.DropIndex(
                name: "IX_PermitApplicationDetail_ModifiedBy",
                schema: "Core",
                table: "PermitApplicationDetail");

            migrationBuilder.DropIndex(
                name: "IX_PaymentStatus_CreatedBy",
                table: "PaymentStatus");

            migrationBuilder.DropIndex(
                name: "IX_PaymentStatus_ModifiedBy",
                table: "PaymentStatus");

            migrationBuilder.DropIndex(
                name: "IX_PaymentMode_CreatedBy",
                table: "PaymentMode");

            migrationBuilder.DropIndex(
                name: "IX_PaymentMode_ModifiedBy",
                table: "PaymentMode");

            migrationBuilder.DropIndex(
                name: "IX_Payment_CreatedBy",
                table: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_Payment_ModifiedBy",
                table: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_OwnerType_CreatedBy",
                table: "OwnerType");

            migrationBuilder.DropIndex(
                name: "IX_OwnerType_ModifiedBy",
                table: "OwnerType");

            migrationBuilder.DropIndex(
                name: "IX_OwnerTaxGroup_CreatedBy",
                table: "OwnerTaxGroup");

            migrationBuilder.DropIndex(
                name: "IX_OwnerTaxGroup_ModifiedBy",
                table: "OwnerTaxGroup");

            migrationBuilder.DropIndex(
                name: "IX_OwnerStatus_CreatedBy",
                table: "OwnerStatus");

            migrationBuilder.DropIndex(
                name: "IX_OwnerStatus_ModifiedBy",
                table: "OwnerStatus");

            migrationBuilder.DropIndex(
                name: "IX_OwnerGroup_CreatedBy",
                table: "OwnerGroup");

            migrationBuilder.DropIndex(
                name: "IX_OwnerGroup_ModifiedBy",
                table: "OwnerGroup");

            migrationBuilder.DropIndex(
                name: "IX_Owner_CreatedBy",
                table: "Owner");

            migrationBuilder.DropIndex(
                name: "IX_Owner_ModifiedBy",
                table: "Owner");

            migrationBuilder.DropIndex(
                name: "IX_OrganizationCategory_CreatedBy",
                table: "OrganizationCategory");

            migrationBuilder.DropIndex(
                name: "IX_OrganizationCategory_ModifiedBy",
                table: "OrganizationCategory");

            migrationBuilder.DropIndex(
                name: "IX_NadraFranchise_CreatedBy",
                table: "NadraFranchise");

            migrationBuilder.DropIndex(
                name: "IX_NadraFranchise_ModifiedBy",
                table: "NadraFranchise");

            migrationBuilder.DropIndex(
                name: "IX_Keeper_CreatedBy",
                table: "Keeper");

            migrationBuilder.DropIndex(
                name: "IX_Keeper_ModifiedBy",
                table: "Keeper");

            migrationBuilder.DropIndex(
                name: "IX_HttpRequestLog_CreatedBy",
                table: "HttpRequestLog");

            migrationBuilder.DropIndex(
                name: "IX_HttpRequestLog_ModifiedBy",
                table: "HttpRequestLog");

            migrationBuilder.DropIndex(
                name: "IX_HPAStatusHistory_CreatedBy",
                table: "HPAStatusHistory");

            migrationBuilder.DropIndex(
                name: "IX_HPAStatusHistory_ModifiedBy",
                table: "HPAStatusHistory");

            migrationBuilder.DropIndex(
                name: "IX_HPAStatus_CreatedBy",
                table: "HPAStatus");

            migrationBuilder.DropIndex(
                name: "IX_HPAStatus_ModifiedBy",
                table: "HPAStatus");

            migrationBuilder.DropIndex(
                name: "IX_HPA_CreatedBy",
                table: "HPA");

            migrationBuilder.DropIndex(
                name: "IX_HPA_ModifiedBy",
                table: "HPA");

            migrationBuilder.DropIndex(
                name: "IX_GlobalRight_CreatedBy",
                table: "GlobalRight");

            migrationBuilder.DropIndex(
                name: "IX_GlobalRight_ModifiedBy",
                table: "GlobalRight");

            migrationBuilder.DropIndex(
                name: "IX_EPRSPerson_CountryId",
                schema: "Core",
                table: "EPRSPerson");

            migrationBuilder.DropIndex(
                name: "IX_EPRSPerson_CreatedBy",
                schema: "Core",
                table: "EPRSPerson");

            migrationBuilder.DropIndex(
                name: "IX_EPRSPerson_ModifiedBy",
                schema: "Core",
                table: "EPRSPerson");

            migrationBuilder.DropIndex(
                name: "IX_EPRSPermitTypes_CreatedBy",
                schema: "Setup",
                table: "EPRSPermitTypes");

            migrationBuilder.DropIndex(
                name: "IX_EPRSPermitTypes_ModifiedBy",
                schema: "Setup",
                table: "EPRSPermitTypes");

            migrationBuilder.DropIndex(
                name: "IX_District_CreatedBy",
                table: "District");

            migrationBuilder.DropIndex(
                name: "IX_District_ModifiedBy",
                table: "District");

            migrationBuilder.DropIndex(
                name: "IX_Dealer_CreatedBy",
                table: "Dealer");

            migrationBuilder.DropIndex(
                name: "IX_Dealer_ModifiedBy",
                table: "Dealer");

            migrationBuilder.DropIndex(
                name: "IX_CustomCollectorate_CreatedBy",
                table: "CustomCollectorate");

            migrationBuilder.DropIndex(
                name: "IX_CustomCollectorate_ModifiedBy",
                table: "CustomCollectorate");

            migrationBuilder.DropIndex(
                name: "IX_Country_CreatedBy",
                table: "Country");

            migrationBuilder.DropIndex(
                name: "IX_Country_ModifiedBy",
                table: "Country");

            migrationBuilder.DropIndex(
                name: "IX_ClearingAgent_CreatedBy",
                table: "ClearingAgent");

            migrationBuilder.DropIndex(
                name: "IX_ClearingAgent_ModifiedBy",
                table: "ClearingAgent");

            migrationBuilder.DropIndex(
                name: "IX_ChallanType_CreatedBy",
                table: "ChallanType");

            migrationBuilder.DropIndex(
                name: "IX_ChallanType_ModifiedBy",
                table: "ChallanType");

            migrationBuilder.DropIndex(
                name: "IX_ChallanStatus_CreatedBy",
                table: "ChallanStatus");

            migrationBuilder.DropIndex(
                name: "IX_ChallanStatus_ModifiedBy",
                table: "ChallanStatus");

            migrationBuilder.DropIndex(
                name: "IX_Challan_CreatedBy",
                table: "Challan");

            migrationBuilder.DropIndex(
                name: "IX_Challan_ModifiedBy",
                table: "Challan");

            migrationBuilder.DropIndex(
                name: "IX_BusinessType_CreatedBy",
                table: "BusinessType");

            migrationBuilder.DropIndex(
                name: "IX_BusinessType_ModifiedBy",
                table: "BusinessType");

            migrationBuilder.DropIndex(
                name: "IX_BusinessTableAccess_CreatedBy",
                table: "BusinessTableAccess");

            migrationBuilder.DropIndex(
                name: "IX_BusinessTableAccess_ModifiedBy",
                table: "BusinessTableAccess");

            migrationBuilder.DropIndex(
                name: "IX_BusinessTable_CreatedBy",
                table: "BusinessTable");

            migrationBuilder.DropIndex(
                name: "IX_BusinessTable_ModifiedBy",
                table: "BusinessTable");

            migrationBuilder.DropIndex(
                name: "IX_BusinessStatus_CreatedBy",
                table: "BusinessStatus");

            migrationBuilder.DropIndex(
                name: "IX_BusinessStatus_ModifiedBy",
                table: "BusinessStatus");

            migrationBuilder.DropIndex(
                name: "IX_BusinessSector_CreatedBy",
                table: "BusinessSector");

            migrationBuilder.DropIndex(
                name: "IX_BusinessSector_ModifiedBy",
                table: "BusinessSector");

            migrationBuilder.DropIndex(
                name: "IX_BusinessRepStatus_CreatedBy",
                table: "BusinessRepStatus");

            migrationBuilder.DropIndex(
                name: "IX_BusinessRepStatus_ModifiedBy",
                table: "BusinessRepStatus");

            migrationBuilder.DropIndex(
                name: "IX_BusinessRep_CreatedBy",
                table: "BusinessRep");

            migrationBuilder.DropIndex(
                name: "IX_BusinessRep_ModifiedBy",
                table: "BusinessRep");

            migrationBuilder.DropIndex(
                name: "IX_BusinessProFeeTax_CreatedBy",
                table: "BusinessProFeeTax");

            migrationBuilder.DropIndex(
                name: "IX_BusinessProFeeTax_ModifiedBy",
                table: "BusinessProFeeTax");

            migrationBuilder.DropIndex(
                name: "IX_BusinessProcess_CreatedBy",
                table: "BusinessProcess");

            migrationBuilder.DropIndex(
                name: "IX_BusinessProcess_ModifiedBy",
                table: "BusinessProcess");

            migrationBuilder.DropIndex(
                name: "IX_BusinessPhaseStatus_CreatedBy",
                table: "BusinessPhaseStatus");

            migrationBuilder.DropIndex(
                name: "IX_BusinessPhaseStatus_ModifiedBy",
                table: "BusinessPhaseStatus");

            migrationBuilder.DropIndex(
                name: "IX_BusinessPhase_CreatedBy",
                table: "BusinessPhase");

            migrationBuilder.DropIndex(
                name: "IX_BusinessPhase_ModifiedBy",
                table: "BusinessPhase");

            migrationBuilder.DropIndex(
                name: "IX_BusinessEvent_CreatedBy",
                table: "BusinessEvent");

            migrationBuilder.DropIndex(
                name: "IX_BusinessEvent_ModifiedBy",
                table: "BusinessEvent");

            migrationBuilder.DropIndex(
                name: "IX_Business_CreatedBy",
                table: "Business");

            migrationBuilder.DropIndex(
                name: "IX_Business_ModifiedBy",
                table: "Business");

            migrationBuilder.DropIndex(
                name: "IX_BiometricVerification_CreatedBy",
                table: "BiometricVerification");

            migrationBuilder.DropIndex(
                name: "IX_BiometricVerification_ModifiedBy",
                table: "BiometricVerification");

            migrationBuilder.DropIndex(
                name: "IX_Bank_CreatedBy",
                table: "Bank");

            migrationBuilder.DropIndex(
                name: "IX_Bank_ModifiedBy",
                table: "Bank");

            migrationBuilder.DropIndex(
                name: "IX_AuctionResult_CreatedBy",
                table: "AuctionResult");

            migrationBuilder.DropIndex(
                name: "IX_AuctionResult_ModifiedBy",
                table: "AuctionResult");

            migrationBuilder.DropIndex(
                name: "IX_AssessmentStatus_CreatedBy",
                table: "AssessmentStatus");

            migrationBuilder.DropIndex(
                name: "IX_AssessmentStatus_ModifiedBy",
                table: "AssessmentStatus");

            migrationBuilder.DropIndex(
                name: "IX_AssessmentDetail_CreatedBy",
                table: "AssessmentDetail");

            migrationBuilder.DropIndex(
                name: "IX_AssessmentDetail_ModifiedBy",
                table: "AssessmentDetail");

            migrationBuilder.DropIndex(
                name: "IX_AssessmentBase_CreatedBy",
                table: "AssessmentBase");

            migrationBuilder.DropIndex(
                name: "IX_AssessmentBase_ModifiedBy",
                table: "AssessmentBase");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationStatus_CreatedBy",
                table: "ApplicationStatus");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationStatus_ModifiedBy",
                table: "ApplicationStatus");

            migrationBuilder.DropIndex(
                name: "IX_Application_CreatedBy",
                table: "Application");

            migrationBuilder.DropIndex(
                name: "IX_Application_ModifiedBy",
                table: "Application");

            migrationBuilder.DropIndex(
                name: "IX_AddressType_CreatedBy",
                table: "AddressType");

            migrationBuilder.DropIndex(
                name: "IX_AddressType_ModifiedBy",
                table: "AddressType");

            migrationBuilder.DropIndex(
                name: "IX_Address_CreatedBy",
                table: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Address_ModifiedBy",
                table: "Address");

            migrationBuilder.DropIndex(
                name: "IX_AccountHead_CreatedBy",
                table: "AccountHead");

            migrationBuilder.DropIndex(
                name: "IX_AccountHead_ModifiedBy",
                table: "AccountHead");

            migrationBuilder.AlterColumn<long>(
                name: "PermitStatus",
                schema: "Core",
                table: "PermitIssueApplication",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "OldPermitNo",
                schema: "Core",
                table: "PermitIssueApplication",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "BioStatus",
                schema: "Core",
                table: "PermitIssueApplication",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "ApplicationStatusId",
                schema: "Core",
                table: "PermitIssueApplication",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "PermitStatus",
                schema: "Core",
                table: "PermitIssueApplication",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "OldPermitNo",
                schema: "Core",
                table: "PermitIssueApplication",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "BioStatus",
                schema: "Core",
                table: "PermitIssueApplication",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "ApplicationStatusId",
                schema: "Core",
                table: "PermitIssueApplication",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VehicleUsage_CreatedBy",
                table: "VehicleUsage",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleUsage_ModifiedBy",
                table: "VehicleUsage",
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
                name: "IX_VehicleStatus_CreatedBy",
                table: "VehicleStatus",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleStatus_ModifiedBy",
                table: "VehicleStatus",
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
                name: "IX_VehicleRouteType_CreatedBy",
                table: "VehicleRouteType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleRouteType_ModifiedBy",
                table: "VehicleRouteType",
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
                name: "IX_VehicleRCStatus_CreatedBy",
                table: "VehicleRCStatus",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleRCStatus_ModifiedBy",
                table: "VehicleRCStatus",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehiclePurchaseType_CreatedBy",
                table: "VehiclePurchaseType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehiclePurchaseType_ModifiedBy",
                table: "VehiclePurchaseType",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehiclePurchaseInfo_CreatedBy",
                table: "VehiclePurchaseInfo",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehiclePurchaseInfo_ModifiedBy",
                table: "VehiclePurchaseInfo",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleOwnershipHistory_CreatedBy",
                table: "VehicleOwnershipHistory",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleOwnershipHistory_ModifiedBy",
                table: "VehicleOwnershipHistory",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleMaker_CreatedBy",
                table: "VehicleMaker",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleMaker_ModifiedBy",
                table: "VehicleMaker",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleMake_CreatedBy",
                table: "VehicleMake",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleMake_ModifiedBy",
                table: "VehicleMake",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImportInfo_CreatedBy",
                table: "VehicleImportInfo",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImportInfo_ModifiedBy",
                table: "VehicleImportInfo",
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
                name: "IX_VehicleEngineType_CreatedBy",
                table: "VehicleEngineType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleEngineType_ModifiedBy",
                table: "VehicleEngineType",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleDocumentType_CreatedBy",
                table: "VehicleDocumentType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleDocumentType_ModifiedBy",
                table: "VehicleDocumentType",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleDocument_CreatedBy",
                table: "VehicleDocument",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleDocument_ModifiedBy",
                table: "VehicleDocument",
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
                name: "IX_VehicleClassification_CreatedBy",
                table: "VehicleClassification",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClassification_ModifiedBy",
                table: "VehicleClassification",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClassGroup_CreatedBy",
                table: "VehicleClassGroup",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClassGroup_ModifiedBy",
                table: "VehicleClassGroup",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClassDetail_CreatedBy",
                table: "VehicleClassDetail",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleClassDetail_ModifiedBy",
                table: "VehicleClassDetail",
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
                name: "IX_VehicleCategory_CreatedBy",
                table: "VehicleCategory",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleCategory_ModifiedBy",
                table: "VehicleCategory",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBusinessProcessHistory_CreatedBy",
                table: "VehicleBusinessProcessHistory",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBusinessProcessHistory_ModifiedBy",
                table: "VehicleBusinessProcessHistory",
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
                name: "IX_VehicleBodyConvention_CreatedBy",
                table: "VehicleBodyConvention",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBodyConvention_ModifiedBy",
                table: "VehicleBodyConvention",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAuctionInfo_CreatedBy",
                table: "VehicleAuctionInfo",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAuctionInfo_ModifiedBy",
                table: "VehicleAuctionInfo",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAdditionalInfo_CreatedBy",
                table: "VehicleAdditionalInfo",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAdditionalInfo_ModifiedBy",
                table: "VehicleAdditionalInfo",
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
                name: "IX_UserType_ModifiedBy",
                table: "UserType",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserStatus_ModifiedBy",
                table: "UserStatus",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleHistory_CreatedBy",
                table: "UserRoleHistory",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleHistory_ModifiedBy",
                table: "UserRoleHistory",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_CreatedBy",
                table: "UserRole",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_ModifiedBy",
                table: "UserRole",
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
                name: "IX_Tehsil_CreatedBy",
                table: "Tehsil",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Tehsil_ModifiedBy",
                table: "Tehsil",
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
                name: "IX_TaxRule_CreatedBy",
                table: "TaxRule",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TaxRule_ModifiedBy",
                table: "TaxRule",
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
                name: "IX_TaxBase_CreatedBy",
                table: "TaxBase",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TaxBase_ModifiedBy",
                table: "TaxBase",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_StockInApplicationDetails_CreatedBy",
                schema: "Core",
                table: "StockInApplicationDetails",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_StockInApplicationDetails_ModifiedBy",
                schema: "Core",
                table: "StockInApplicationDetails",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_StockInApplication_CreatedBy",
                schema: "Core",
                table: "StockInApplication",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_StockInApplication_ModifiedBy",
                schema: "Core",
                table: "StockInApplication",
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
                name: "IX_SeriesType_CreatedBy",
                table: "SeriesType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesType_ModifiedBy",
                table: "SeriesType",
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
                name: "IX_SeriesNumberStatus_CreatedBy",
                table: "SeriesNumberStatus",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumberStatus_ModifiedBy",
                table: "SeriesNumberStatus",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumberPool_CreatedBy",
                table: "SeriesNumberPool",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesNumberPool_ModifiedBy",
                table: "SeriesNumberPool",
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
                name: "IX_SeriesCategory_CreatedBy",
                table: "SeriesCategory",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SeriesCategory_ModifiedBy",
                table: "SeriesCategory",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Series_CreatedBy",
                table: "Series",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Series_ModifiedBy",
                table: "Series",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_RoleResourceRightsHistory_CreatedBy",
                table: "RoleResourceRightsHistory",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_RoleResourceRightsHistory_ModifiedBy",
                table: "RoleResourceRightsHistory",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_RoleResourceRight_CreatedBy",
                table: "RoleResourceRight",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_RoleResourceRight_ModifiedBy",
                table: "RoleResourceRight",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_RoleResource_CreatedBy",
                table: "RoleResource",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_RoleResource_ModifiedBy",
                table: "RoleResource",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_RoleAppProcessFlow_CreatedBy",
                table: "RoleAppProcessFlow",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_RoleAppProcessFlow_ModifiedBy",
                table: "RoleAppProcessFlow",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Role_CreatedBy",
                table: "Role",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Role_ModifiedBy",
                table: "Role",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceTypeRight_CreatedBy",
                table: "ResourceTypeRight",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceTypeRight_ModifiedBy",
                table: "ResourceTypeRight",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceTypeDefaultRight_CreatedBy",
                table: "ResourceTypeDefaultRight",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceTypeDefaultRight_ModifiedBy",
                table: "ResourceTypeDefaultRight",
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
                name: "IX_ResourceController_CreatedBy",
                table: "ResourceController",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceController_ModifiedBy",
                table: "ResourceController",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceAction_CreatedBy",
                table: "ResourceAction",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceAction_ModifiedBy",
                table: "ResourceAction",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Resource_CreatedBy",
                table: "Resource",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Resource_ModifiedBy",
                table: "Resource",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Remarks_CreatedBy",
                table: "Remarks",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Remarks_ModifiedBy",
                table: "Remarks",
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
                name: "IX_Port_CreatedBy",
                table: "Port",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Port_ModifiedBy",
                table: "Port",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumberType_CreatedBy",
                table: "PhoneNumberType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumberType_ModifiedBy",
                table: "PhoneNumberType",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumber_CreatedBy",
                table: "PhoneNumber",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumber_ModifiedBy",
                table: "PhoneNumber",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Person_CreatedBy",
                table: "Person",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Person_ModifiedBy",
                table: "Person",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PermitTypes_CreatedBy",
                table: "PermitTypes",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PermitTypes_ModifiedBy",
                table: "PermitTypes",
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
                name: "IX_PaymentStatus_CreatedBy",
                table: "PaymentStatus",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentStatus_ModifiedBy",
                table: "PaymentStatus",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMode_CreatedBy",
                table: "PaymentMode",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMode_ModifiedBy",
                table: "PaymentMode",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_CreatedBy",
                table: "Payment",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_ModifiedBy",
                table: "Payment",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerType_CreatedBy",
                table: "OwnerType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerType_ModifiedBy",
                table: "OwnerType",
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
                name: "IX_OwnerStatus_CreatedBy",
                table: "OwnerStatus",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerStatus_ModifiedBy",
                table: "OwnerStatus",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerGroup_CreatedBy",
                table: "OwnerGroup",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerGroup_ModifiedBy",
                table: "OwnerGroup",
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
                name: "IX_OrganizationCategory_CreatedBy",
                table: "OrganizationCategory",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationCategory_ModifiedBy",
                table: "OrganizationCategory",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_NadraFranchise_CreatedBy",
                table: "NadraFranchise",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_NadraFranchise_ModifiedBy",
                table: "NadraFranchise",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Keeper_CreatedBy",
                table: "Keeper",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Keeper_ModifiedBy",
                table: "Keeper",
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
                name: "IX_HPAStatusHistory_CreatedBy",
                table: "HPAStatusHistory",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_HPAStatusHistory_ModifiedBy",
                table: "HPAStatusHistory",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_HPAStatus_CreatedBy",
                table: "HPAStatus",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_HPAStatus_ModifiedBy",
                table: "HPAStatus",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_HPA_CreatedBy",
                table: "HPA",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_HPA_ModifiedBy",
                table: "HPA",
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
                name: "IX_EPRSPerson_CountryId",
                schema: "Core",
                table: "EPRSPerson",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_EPRSPerson_CreatedBy",
                schema: "Core",
                table: "EPRSPerson",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_EPRSPerson_ModifiedBy",
                schema: "Core",
                table: "EPRSPerson",
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
                name: "IX_District_CreatedBy",
                table: "District",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_District_ModifiedBy",
                table: "District",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Dealer_CreatedBy",
                table: "Dealer",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Dealer_ModifiedBy",
                table: "Dealer",
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
                name: "IX_Country_CreatedBy",
                table: "Country",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Country_ModifiedBy",
                table: "Country",
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
                name: "IX_ChallanType_CreatedBy",
                table: "ChallanType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ChallanType_ModifiedBy",
                table: "ChallanType",
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
                name: "IX_Challan_CreatedBy",
                table: "Challan",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Challan_ModifiedBy",
                table: "Challan",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessType_CreatedBy",
                table: "BusinessType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessType_ModifiedBy",
                table: "BusinessType",
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
                name: "IX_BusinessTable_CreatedBy",
                table: "BusinessTable",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTable_ModifiedBy",
                table: "BusinessTable",
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
                name: "IX_BusinessSector_CreatedBy",
                table: "BusinessSector",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessSector_ModifiedBy",
                table: "BusinessSector",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessRepStatus_CreatedBy",
                table: "BusinessRepStatus",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessRepStatus_ModifiedBy",
                table: "BusinessRepStatus",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessRep_CreatedBy",
                table: "BusinessRep",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessRep_ModifiedBy",
                table: "BusinessRep",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessProFeeTax_CreatedBy",
                table: "BusinessProFeeTax",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessProFeeTax_ModifiedBy",
                table: "BusinessProFeeTax",
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
                name: "IX_BusinessPhaseStatus_CreatedBy",
                table: "BusinessPhaseStatus",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessPhaseStatus_ModifiedBy",
                table: "BusinessPhaseStatus",
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
                name: "IX_BusinessEvent_CreatedBy",
                table: "BusinessEvent",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessEvent_ModifiedBy",
                table: "BusinessEvent",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Business_CreatedBy",
                table: "Business",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Business_ModifiedBy",
                table: "Business",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BiometricVerification_CreatedBy",
                table: "BiometricVerification",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BiometricVerification_ModifiedBy",
                table: "BiometricVerification",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Bank_CreatedBy",
                table: "Bank",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Bank_ModifiedBy",
                table: "Bank",
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
                name: "IX_AssessmentStatus_CreatedBy",
                table: "AssessmentStatus",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentStatus_ModifiedBy",
                table: "AssessmentStatus",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentDetail_CreatedBy",
                table: "AssessmentDetail",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentDetail_ModifiedBy",
                table: "AssessmentDetail",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_CreatedBy",
                table: "AssessmentBase",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentBase_ModifiedBy",
                table: "AssessmentBase",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationStatus_CreatedBy",
                table: "ApplicationStatus",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationStatus_ModifiedBy",
                table: "ApplicationStatus",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Application_CreatedBy",
                table: "Application",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Application_ModifiedBy",
                table: "Application",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AddressType_CreatedBy",
                table: "AddressType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AddressType_ModifiedBy",
                table: "AddressType",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Address_CreatedBy",
                table: "Address",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Address_ModifiedBy",
                table: "Address",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AccountHead_CreatedBy",
                table: "AccountHead",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AccountHead_ModifiedBy",
                table: "AccountHead",
                column: "ModifiedBy");

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
                name: "FK_EPRSPerson_Country_CountryId",
                schema: "Core",
                table: "EPRSPerson",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EPRSPerson_User_CreatedBy",
                schema: "Core",
                table: "EPRSPerson",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_EPRSPerson_User_ModifiedBy",
                schema: "Core",
                table: "EPRSPerson",
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
                name: "FK_StockInApplication_User_CreatedBy",
                schema: "Core",
                table: "StockInApplication",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_StockInApplication_User_ModifiedBy",
                schema: "Core",
                table: "StockInApplication",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_StockInApplicationDetails_User_CreatedBy",
                schema: "Core",
                table: "StockInApplicationDetails",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_StockInApplicationDetails_User_ModifiedBy",
                schema: "Core",
                table: "StockInApplicationDetails",
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
                name: "FK_User_User_ModifiedBy",
                table: "User",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_UserStatus_UserStatusId",
                table: "User",
                column: "UserStatusId",
                principalTable: "UserStatus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_User_UserType_UserTypeId",
                table: "User",
                column: "UserTypeId",
                principalTable: "UserType",
                principalColumn: "Id");

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
                name: "FK_VehicleAdditionalInfo_User_CreatedBy",
                table: "VehicleAdditionalInfo",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleAdditionalInfo_User_ModifiedBy",
                table: "VehicleAdditionalInfo",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

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
                name: "FK_VehicleBodyConvention_User_CreatedBy",
                table: "VehicleBodyConvention",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleBodyConvention_User_ModifiedBy",
                table: "VehicleBodyConvention",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleBodyType_User_CreatedBy",
                table: "VehicleBodyType",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleBodyType_User_ModifiedBy",
                table: "VehicleBodyType",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

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
                name: "FK_VehicleCategory_User_CreatedBy",
                table: "VehicleCategory",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleCategory_User_ModifiedBy",
                table: "VehicleCategory",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleClass_User_CreatedBy",
                table: "VehicleClass",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleClass_User_ModifiedBy",
                table: "VehicleClass",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleClassDetail_User_CreatedBy",
                table: "VehicleClassDetail",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleClassDetail_User_ModifiedBy",
                table: "VehicleClassDetail",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleClassGroup_User_CreatedBy",
                table: "VehicleClassGroup",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleClassGroup_User_ModifiedBy",
                table: "VehicleClassGroup",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleClassification_User_CreatedBy",
                table: "VehicleClassification",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleClassification_User_ModifiedBy",
                table: "VehicleClassification",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleColor_User_CreatedBy",
                table: "VehicleColor",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleColor_User_ModifiedBy",
                table: "VehicleColor",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

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
                name: "FK_VehicleDocumentType_User_CreatedBy",
                table: "VehicleDocumentType",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleDocumentType_User_ModifiedBy",
                table: "VehicleDocumentType",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleEngineType_User_CreatedBy",
                table: "VehicleEngineType",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleEngineType_User_ModifiedBy",
                table: "VehicleEngineType",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleFuelType_User_CreatedBy",
                table: "VehicleFuelType",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleFuelType_User_ModifiedBy",
                table: "VehicleFuelType",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

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
                name: "FK_VehicleMake_User_CreatedBy",
                table: "VehicleMake",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleMake_User_ModifiedBy",
                table: "VehicleMake",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleMaker_User_CreatedBy",
                table: "VehicleMaker",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleMaker_User_ModifiedBy",
                table: "VehicleMaker",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

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
                name: "FK_VehiclePurchaseType_User_CreatedBy",
                table: "VehiclePurchaseType",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehiclePurchaseType_User_ModifiedBy",
                table: "VehiclePurchaseType",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleRCStatus_User_CreatedBy",
                table: "VehicleRCStatus",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleRCStatus_User_ModifiedBy",
                table: "VehicleRCStatus",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

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
                name: "FK_VehicleRouteType_User_CreatedBy",
                table: "VehicleRouteType",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleRouteType_User_ModifiedBy",
                table: "VehicleRouteType",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleScheme_User_CreatedBy",
                table: "VehicleScheme",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleScheme_User_ModifiedBy",
                table: "VehicleScheme",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleStatus_User_CreatedBy",
                table: "VehicleStatus",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleStatus_User_ModifiedBy",
                table: "VehicleStatus",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleType_User_CreatedBy",
                table: "VehicleType",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleType_User_ModifiedBy",
                table: "VehicleType",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleUsage_User_CreatedBy",
                table: "VehicleUsage",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleUsage_User_ModifiedBy",
                table: "VehicleUsage",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "UserId");
        }
    }
}
