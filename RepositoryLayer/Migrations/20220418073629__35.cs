using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class _35 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_VehiclePurchaseInfo_ApplicationId",
                schema: "Core",
                table: "VehiclePurchaseInfo");

            migrationBuilder.DropIndex(
                name: "IX_VehicleImportInfo_ApplicationId",
                schema: "Core",
                table: "VehicleImportInfo");

            migrationBuilder.DropIndex(
                name: "IX_VehicleAuctionInfo_ApplicationId",
                schema: "Core",
                table: "VehicleAuctionInfo");

            migrationBuilder.DropIndex(
                name: "IX_Vehicle_VehicleMakeId",
                schema: "Core",
                table: "Vehicle");

            migrationBuilder.DropIndex(
                name: "IX_PhoneNumber_PhoneNumberTypeId",
                schema: "Core",
                table: "PhoneNumber");

            migrationBuilder.DropIndex(
                name: "IX_OwnerGroup_OwnerId",
                schema: "Core",
                table: "OwnerGroup");

            migrationBuilder.DropIndex(
                name: "IX_Application_ApplicationPhaseId",
                schema: "Core",
                table: "Application");

            migrationBuilder.DropIndex(
                name: "IX_Address_AddressTypeId",
                schema: "Core",
                table: "Address");

            migrationBuilder.CreateIndex(
                name: "IX_VehiclePurchaseInfo_ApplicationId_VehiclePurchaseInfoId",
                schema: "Core",
                table: "VehiclePurchaseInfo",
                columns: new[] { "ApplicationId", "VehiclePurchaseInfoId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImportInfo_ApplicationId_VehicleImportInfoId",
                schema: "Core",
                table: "VehicleImportInfo",
                columns: new[] { "ApplicationId", "VehicleImportInfoId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAuctionInfo_ApplicationId_VehicleAuctionInfoId",
                schema: "Core",
                table: "VehicleAuctionInfo",
                columns: new[] { "ApplicationId", "VehicleAuctionInfoId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_ChasisNo_RegistrationNo",
                schema: "Core",
                table: "Vehicle",
                columns: new[] { "ChasisNo", "RegistrationNo" },
                unique: true,
                filter: "[RegistrationNo] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleMakeId_VehicleMakerId_ChasisNo",
                schema: "Core",
                table: "Vehicle",
                columns: new[] { "VehicleMakeId", "VehicleMakerId", "ChasisNo" },
                unique: true,
                filter: "[VehicleMakeId] IS NOT NULL AND [VehicleMakerId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumber_PhoneNumberTypeId_BusinessId",
                schema: "Core",
                table: "PhoneNumber",
                columns: new[] { "PhoneNumberTypeId", "BusinessId" },
                unique: true,
                filter: "[BusinessId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumber_PhoneNumberTypeId_PersonId",
                schema: "Core",
                table: "PhoneNumber",
                columns: new[] { "PhoneNumberTypeId", "PersonId" },
                unique: true,
                filter: "[PersonId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Person_CNIC",
                schema: "Core",
                table: "Person",
                column: "CNIC",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OwnerGroup_OwnerId_BusinessId",
                schema: "Core",
                table: "OwnerGroup",
                columns: new[] { "OwnerId", "BusinessId" },
                unique: true,
                filter: "[BusinessId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerGroup_OwnerId_PersonId",
                schema: "Core",
                table: "OwnerGroup",
                columns: new[] { "OwnerId", "PersonId" },
                unique: true,
                filter: "[PersonId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Business_NTN",
                schema: "Core",
                table: "Business",
                column: "NTN",
                unique: true,
                filter: "[NTN] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Application_ApplicationPhaseId_ApplicationStatusId_ApplicationTypeId",
                schema: "Core",
                table: "Application",
                columns: new[] { "ApplicationPhaseId", "ApplicationStatusId", "ApplicationTypeId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Address_AddressTypeId_BusinessId",
                schema: "Core",
                table: "Address",
                columns: new[] { "AddressTypeId", "BusinessId" },
                unique: true,
                filter: "[BusinessId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Address_AddressTypeId_PersonId",
                schema: "Core",
                table: "Address",
                columns: new[] { "AddressTypeId", "PersonId" },
                unique: true,
                filter: "[PersonId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_VehiclePurchaseInfo_ApplicationId_VehiclePurchaseInfoId",
                schema: "Core",
                table: "VehiclePurchaseInfo");

            migrationBuilder.DropIndex(
                name: "IX_VehicleImportInfo_ApplicationId_VehicleImportInfoId",
                schema: "Core",
                table: "VehicleImportInfo");

            migrationBuilder.DropIndex(
                name: "IX_VehicleAuctionInfo_ApplicationId_VehicleAuctionInfoId",
                schema: "Core",
                table: "VehicleAuctionInfo");

            migrationBuilder.DropIndex(
                name: "IX_Vehicle_ChasisNo_RegistrationNo",
                schema: "Core",
                table: "Vehicle");

            migrationBuilder.DropIndex(
                name: "IX_Vehicle_VehicleMakeId_VehicleMakerId_ChasisNo",
                schema: "Core",
                table: "Vehicle");

            migrationBuilder.DropIndex(
                name: "IX_PhoneNumber_PhoneNumberTypeId_BusinessId",
                schema: "Core",
                table: "PhoneNumber");

            migrationBuilder.DropIndex(
                name: "IX_PhoneNumber_PhoneNumberTypeId_PersonId",
                schema: "Core",
                table: "PhoneNumber");

            migrationBuilder.DropIndex(
                name: "IX_Person_CNIC",
                schema: "Core",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_OwnerGroup_OwnerId_BusinessId",
                schema: "Core",
                table: "OwnerGroup");

            migrationBuilder.DropIndex(
                name: "IX_OwnerGroup_OwnerId_PersonId",
                schema: "Core",
                table: "OwnerGroup");

            migrationBuilder.DropIndex(
                name: "IX_Business_NTN",
                schema: "Core",
                table: "Business");

            migrationBuilder.DropIndex(
                name: "IX_Application_ApplicationPhaseId_ApplicationStatusId_ApplicationTypeId",
                schema: "Core",
                table: "Application");

            migrationBuilder.DropIndex(
                name: "IX_Address_AddressTypeId_BusinessId",
                schema: "Core",
                table: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Address_AddressTypeId_PersonId",
                schema: "Core",
                table: "Address");

            migrationBuilder.CreateIndex(
                name: "IX_VehiclePurchaseInfo_ApplicationId",
                schema: "Core",
                table: "VehiclePurchaseInfo",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImportInfo_ApplicationId",
                schema: "Core",
                table: "VehicleImportInfo",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAuctionInfo_ApplicationId",
                schema: "Core",
                table: "VehicleAuctionInfo",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleMakeId",
                schema: "Core",
                table: "Vehicle",
                column: "VehicleMakeId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumber_PhoneNumberTypeId",
                schema: "Core",
                table: "PhoneNumber",
                column: "PhoneNumberTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerGroup_OwnerId",
                schema: "Core",
                table: "OwnerGroup",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_ApplicationPhaseId",
                schema: "Core",
                table: "Application",
                column: "ApplicationPhaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_AddressTypeId",
                schema: "Core",
                table: "Address",
                column: "AddressTypeId");
        }
    }
}
