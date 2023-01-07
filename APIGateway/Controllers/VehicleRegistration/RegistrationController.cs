using Authentication.Schemes;
using Logging;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using Models.DatabaseModels.VehicleRegistration.Core;
using Models.DatabaseModels.VehicleRegistration.Setup;
using Models.ViewModels.Identity;
using Models.ViewModels.Payment;
using Models.ViewModels.VehicleRegistration.Core;
using Models.ViewModels.VehicleRegistration.Setup;
using SharedLib.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using UserManagement;
using VehicleRegistration;

namespace APIGateway.Controllers.VehicleRegistration
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = AuthenticationSchemes.JWT_BEARER_TOKEN_STATELESS)]
    public class RegistrationController : ControllerBase
    {
        private readonly IRegistrationService registrationService;
        private readonly INRTService nrtService;
        private readonly ITOService toService;
        private readonly IUserManagement userManagementService;
        private readonly ILoggingService logger;

        public VwUser User
        {
            get
            {
                return (VwUser)this.Request.HttpContext.Items["User"];
            }
        }

        public RegistrationController(IRegistrationService registrationService, INRTService nrtService, ITOService toService, IUserManagement userManagementServuce)
        {
            this.registrationService = registrationService;
            this.nrtService = nrtService;
            this.toService = toService;
            this.userManagementService = userManagementServuce;
        }


        [HttpGet(Name = "GetOwnersDropDowns")]
        public async Task<ApiResponse> GetOwnersDropDowns()
        {
            var ds = await this.registrationService.GetOwnersDropDowns();

            var data = new
            {
                OwnerTypes = ds.Tables[0],
                OwnerTaxGroups = ds.Tables[1],
                Countries = ds.Tables[2],
                Districts = ds.Tables[3],
                businessSector = ds.Tables[4],
                businessStatus = ds.Tables[5],
                businessType = ds.Tables[6],
                tehsils = ds.Tables[7]
            };

            return ApiResponse.GetResponse(ApiResponseType.SUCCESS, data, Constants.RECORD_FOUND_MESSAGE, null);
        }


        [HttpGet(Name = "GetVehiclesDropDowns")]
        public async Task<ApiResponse> GetVehiclesDropDowns()
        {
            var ds = await this.registrationService.GetVehiclesDropDowns();

            var data = new
            {
                VehicleBodyConvention = ds.Tables[0],
                VehicleBodyType = ds.Tables[1],
                VehicleCategory = ds.Tables[2],
                VehicleClassification = ds.Tables[3],
                VehicleColor = ds.Tables[4],
                VehicleEngineType = ds.Tables[5],
                VehicleFuelType = ds.Tables[6],
                VehicleMake = ds.Tables[7],
                VehicleMaker = ds.Tables[8],
                VehiclePurchaseType = ds.Tables[9],
                VehicleRCStatus = ds.Tables[10],
                VehicleScheme = ds.Tables[11],
                VehicleStatus = ds.Tables[12],
                VehicleUsage = ds.Tables[13],
                VehicleClass = ds.Tables[14],
                VehicleType = ds.Tables[15],
                VehicleClassGroup = ds.Tables[16],
            };

            return ApiResponse.GetResponse(ApiResponseType.SUCCESS, data, Constants.RECORD_FOUND_MESSAGE, null);
        }


        [HttpGet(Name = "GetPurchaseDropDowns")]
        public async Task<ApiResponse> GetPurchaseDropDowns()
        {
            var ds = await this.registrationService.GetPurchaseDropDowns();

            var data = new
            {
                banks = ds.Tables[0],
                clearingAgents = ds.Tables[1],
                customCollectorates = ds.Tables[2],
                vehicleSchemes = ds.Tables[3],
                ports = ds.Tables[4],
                countries = ds.Tables[5],
                dealers = ds.Tables[6]
            };

            return ApiResponse.GetResponse(ApiResponseType.SUCCESS, data, Constants.RECORD_FOUND_MESSAGE, null);
        }


        [HttpGet(Name = "GetDocumentDropDowns")]
        public async Task<ApiResponse> GetDocumentDropDowns()
        {
            var ds = await this.registrationService.GetDocumentDropDowns();

            var data = new
            {
                vehicleDocumentType = ds.Tables[0],
            };

            return ApiResponse.GetResponse(ApiResponseType.SUCCESS, data, Constants.RECORD_FOUND_MESSAGE, null);
        }


        [HttpGet(Name = "GetApplications")]
        public async Task<ApiResponse> GetApplications(long? applicationId, long businessProcessId, long applicationStatusId)
        {
            this.registrationService.VwUser = this.User;

            var ds = await this.registrationService.GetApplications(applicationId, businessProcessId, applicationStatusId);

            var apps = ds.Tables[0].ToList<VwApplication>();

            var apiResponseType = apps.Count > 0 ? ApiResponseType.SUCCESS : ApiResponseType.FAILED;
            var msg = apps.Count > 0 ? Constants.RECORD_FOUND_MESSAGE : Constants.NOT_FOUND_MESSAGE;

            return ApiResponse.GetApiResponse(apiResponseType, apps, msg);
        }

        [HttpGet(Name = "GetApplicationDetails")]
        public async Task<ApiResponse> GetApplicationDetails(long applicationId)
        {
            this.registrationService.VwUser = this.User;

            var ds = await this.registrationService.GetApplicationDetails(applicationId);

            VwApplication currentApp = SharedLib.Common.Extentions.ToList<VwApplication>(ds.Tables[0]).FirstOrDefault();

            if (currentApp is not null)
            {
                var ownersList = ds.Tables[1].ToList<VwTempOwner_v1>();

                if (ownersList.Any())
                {
                    currentApp.Owner = ownersList.FirstOrDefault();
                    var addresses = ds.Tables[3].ToList<VwAddress>();
                    var phoneNumbers = ds.Tables[4].ToList<VwPhoneNumber>();

                    if (currentApp.Owner.OwnerTypeId == 1)
                    {
                        currentApp.Owner.Persons = ds.Tables[2].ToList<VwPerson>();
                        currentApp.Owner.Persons.ForEach(x =>
                        {
                            x.Addresses = new List<VwAddress>();
                            x.PhoneNumbers = new List<VwPhoneNumber>();

                            x.Addresses.AddRange(addresses.Where(add => add.PersonId == x.PersonId));
                            x.PhoneNumbers.AddRange(phoneNumbers.Where(add => add.PersonId == x.PersonId));
                        });
                    }
                    else if (currentApp.Owner.OwnerTypeId == 2)
                    {
                        currentApp.Owner.Business = ds.Tables[2].ToList<VwBusiness>().FirstOrDefault();
                        currentApp.Owner.Business.Addresses = new List<VwAddress>();
                        currentApp.Owner.Business.PhoneNumbers = new List<VwPhoneNumber>();

                        currentApp.Owner.Business.Addresses.AddRange(addresses.Where(add => add.BusinessId == currentApp.Owner.Business.BusinessId));
                        currentApp.Owner.Business.PhoneNumbers.AddRange(phoneNumbers.Where(add => add.BusinessId == currentApp.Owner.Business.BusinessId));
                    }
                }

                currentApp.Vehicle = ds.Tables[5].ToList<VwVehicle>().FirstOrDefault();

                currentApp.PurchaseInfo = new VwVehiclePurchaseInfo();

                currentApp.PurchaseInfo.LocalPurchaseInfo = ds.Tables[6].ToList<VwVehicleLocalPurchaseInfo>().FirstOrDefault();
                currentApp.PurchaseInfo.ImportInfo = ds.Tables[7].ToList<VwVehicleImportInfo>().FirstOrDefault();
                currentApp.PurchaseInfo.AuctionInfo = ds.Tables[8].ToList<VwVehicleAuctionInfo>().FirstOrDefault();
                currentApp.HPAInfo = ds.Tables[9].ToList<VwHPA>().FirstOrDefault();

                if (currentApp.HPAInfo is not null)
                {
                    currentApp.HPAInfo.SponserBusiness = ds.Tables[10].ToList<VwBusiness>().FirstOrDefault();
                    currentApp.HPAInfo.SponserBusiness.Addresses = ds.Tables[11].ToList<VwAddress>().ToList();
                    currentApp.HPAInfo.SponserBusiness.PhoneNumbers = ds.Tables[12].ToList<VwPhoneNumber>().ToList();
                }

                currentApp.Keeper = ds.Tables[13].ToList<VwKeeper>().FirstOrDefault();

                if (currentApp.Keeper is not null)
                {
                    currentApp.Keeper.Person = ds.Tables[14].ToList<VwPerson>().FirstOrDefault();
                    currentApp.Keeper.Person.Addresses = ds.Tables[15].ToList<VwAddress>().ToList();
                    currentApp.Keeper.Person.PhoneNumbers = ds.Tables[16].ToList<VwPhoneNumber>().ToList();
                }

                currentApp.Documents = ds.Tables[17].ToList<VwVehicleDocumentDetail>().ToList();
                currentApp.TaxAssessment = ds.Tables[18].ToList<VwAssessment>().ToList();

                var sellerList = ds.Tables[19].ToList<VwTempOwner_v1>();

                if (sellerList.Any())
                {
                    currentApp.Seller = sellerList.FirstOrDefault();
                    var addresses = ds.Tables[21].ToList<VwAddress>();
                    var phoneNumbers = ds.Tables[22].ToList<VwPhoneNumber>();

                    if (currentApp.Seller.OwnerTypeId == 1)
                    {
                        currentApp.Seller.Persons = ds.Tables[20].ToList<VwPerson>();
                        currentApp.Seller.Persons.ForEach(x =>
                        {
                            x.Addresses = new List<VwAddress>();
                            x.PhoneNumbers = new List<VwPhoneNumber>();

                            x.Addresses.AddRange(addresses.Where(add => add.PersonId == x.PersonId));
                            x.PhoneNumbers.AddRange(phoneNumbers.Where(add => add.PersonId == x.PersonId));
                        });
                    }
                    else if (currentApp.Seller.OwnerTypeId == 2)
                    {
                        currentApp.Seller.Business = ds.Tables[20].ToList<VwBusiness>().FirstOrDefault();
                        currentApp.Seller.Business.Addresses = new List<VwAddress>();
                        currentApp.Seller.Business.PhoneNumbers = new List<VwPhoneNumber>();

                        currentApp.Seller.Business.Addresses.AddRange(addresses.Where(add => add.BusinessId == currentApp.Seller.Business.BusinessId));
                        currentApp.Seller.Business.PhoneNumbers.AddRange(phoneNumbers.Where(add => add.BusinessId == currentApp.Seller.Business.BusinessId));
                    }
                }

                var vwBusinessTableAccessLevel = ds.Tables[23].ToList<VwBusinessTableAccessLevel>();

                var commonFeature = new CommonFunctionality(vwBusinessTableAccessLevel);

                if (currentApp.Owner is not null)
                    currentApp.Owner.AccessLevel = commonFeature.GetBusinessTableLevelAccess(currentApp.Owner);

                if (currentApp.Seller is not null)
                    currentApp.Seller.AccessLevel = commonFeature.GetBusinessTableLevelAccess(currentApp.Seller);

                if (currentApp.Vehicle is not null)
                    currentApp.Vehicle.AccessLevel = commonFeature.GetBusinessTableLevelAccess(currentApp.Vehicle);

                if (currentApp.PurchaseInfo.AuctionInfo is not null)
                    currentApp.PurchaseInfo.AuctionInfo.AccessLevel = commonFeature.GetBusinessTableLevelAccess(currentApp.PurchaseInfo.AuctionInfo);

                if (currentApp.PurchaseInfo.LocalPurchaseInfo is not null)
                    currentApp.PurchaseInfo.LocalPurchaseInfo.AccessLevel = commonFeature.GetBusinessTableLevelAccess(currentApp.PurchaseInfo.LocalPurchaseInfo);

                if (currentApp.PurchaseInfo.ImportInfo is not null)
                    currentApp.PurchaseInfo.ImportInfo.AccessLevel = commonFeature.GetBusinessTableLevelAccess(currentApp.PurchaseInfo.ImportInfo);

                if (currentApp.HPAInfo is not null)
                    currentApp.HPAInfo.AccessLevel = commonFeature.GetBusinessTableLevelAccess(currentApp.HPAInfo);

                if (currentApp.Keeper is not null)
                    currentApp.Keeper.AccessLevel = commonFeature.GetBusinessTableLevelAccess(currentApp.Keeper);

                currentApp.Documents.ForEach(x =>
                {
                    x.AccessLevel = commonFeature.GetBusinessTableLevelAccess(x);
                });

                var data = new
                {
                    currentApp.ApplicationId,
                    currentApp.ApplicationStatus,
                    currentApp.ApplicationStatusId,
                    currentApp.BusinessProcess,
                    currentApp.BusinessProcessId,
                    currentApp.BusinessPhase,
                    currentApp.BusinessPhaseId,
                    currentApp.BusinessPhaseStatus,
                    currentApp.BusinessPhaseStatusId,
                    currentApp.ReceivedAt,
                    currentApp.Owner,
                    currentApp.Seller,
                    currentApp.Vehicle,
                    currentApp.PurchaseInfo,
                    currentApp.HPAInfo,
                    currentApp.Keeper,
                    currentApp.Documents,
                    currentApp.TaxAssessment
                };

                return ApiResponse.GetResponse(ApiResponseType.SUCCESS, data, Constants.RECORD_FOUND_MESSAGE, "");
            }

            return ApiResponse.GetResponse(ApiResponseType.FAILED, null, Constants.NOT_FOUND_MESSAGE, null);
        }

        [HttpGet(Name = "GetOwnerDetails")]
        public async Task<ApiResponse> GetOwnerDetails(long? applicationId, long? ownerId)
        {
            this.registrationService.VwUser = this.User;

            if (applicationId.HasValue && ownerId is null)
            {
                var dsApp = await this.registrationService.GetApplications(applicationId.Value, 1, 1);

                var currentApp = dsApp.Tables[0].ToList<VwApplication>().FirstOrDefault();

                ownerId = currentApp.OwnerId;
            }

            var ds = await this.registrationService.GetOwnerDetails(ownerId.Value);

            var owners = ds.Tables[0].ToList<VwTempOwner_v1>();
            var addresses = ds.Tables[2].ToList<VwAddress>();
            var phoneNumbers = ds.Tables[3].ToList<VwPhoneNumber>();

            if (owners.Count > 0)
            {
                var owner = owners.FirstOrDefault();

                if (owner.OwnerTypeId == 1)
                {
                    owner.Persons = ds.Tables[1].ToList<VwPerson>();

                    owner.Persons.ForEach(x =>
                    {
                        x.Addresses = new List<VwAddress>();
                        x.PhoneNumbers = new List<VwPhoneNumber>();

                        x.Addresses.AddRange(addresses.Where(add => add.PersonId == x.PersonId));
                        x.PhoneNumbers.AddRange(phoneNumbers.Where(add => add.PersonId == x.PersonId));
                    });
                }
                else if (owner.OwnerTypeId == 2)
                {
                    owner.Business = ds.Tables[1].ToList<VwBusiness>().FirstOrDefault();
                    owner.Business.Addresses = new List<VwAddress>();
                    owner.Business.PhoneNumbers = new List<VwPhoneNumber>();

                    owner.Business.Addresses.AddRange(addresses.Where(add => add.BusinessId == owner.Business.BusinessId));
                    owner.Business.PhoneNumbers.AddRange(phoneNumbers.Where(add => add.BusinessId == owner.Business.BusinessId));
                }
            }

            var apiResponseType = owners.Count > 0 ? ApiResponseType.SUCCESS : ApiResponseType.FAILED;
            var msg = owners.Count > 0 ? Constants.RECORD_FOUND_MESSAGE : Constants.NOT_FOUND_MESSAGE;

            return ApiResponse.GetApiResponse(apiResponseType, owners.FirstOrDefault(), msg);
        }

        [HttpGet(Name = "GetVehicle")]
        public async Task<ApiResponse> GetVehicle(long? applicationId, long? vehicleId)
        {
            this.registrationService.VwUser = this.User;

            if (applicationId.HasValue && vehicleId is null)
            {
                var dsApp = await this.registrationService.GetApplications(applicationId.Value, 1, 1);

                var currentApp = dsApp.Tables[0].ToList<VwApplication>().FirstOrDefault();

                vehicleId = currentApp.VehicleId;
            }

            var ds = await this.registrationService.GetVehicle(vehicleId.Value);

            var vehicle = ds.Tables[0].ToList<VwVehicle>().FirstOrDefault();

            var apiResponseType = vehicle is not null ? ApiResponseType.SUCCESS : ApiResponseType.FAILED;
            var msg = vehicle is not null ? Constants.RECORD_FOUND_MESSAGE : Constants.NOT_FOUND_MESSAGE;

            return ApiResponse.GetApiResponse(apiResponseType, vehicle, msg);
        }

        [HttpGet(Name = "GetVehiclePurchaseInfo")]
        public async Task<ApiResponse> GetVehiclePurchaseInfo(long? applicationId, long? vehicleId)
        {
            this.registrationService.VwUser = this.User;

            if (applicationId.HasValue && vehicleId is null)
            {
                var dsApp = await this.registrationService.GetApplications(applicationId.Value, 1, 1);

                var currentApp = dsApp.Tables[0].ToList<VwApplication>().FirstOrDefault();

                vehicleId = currentApp.VehicleId;
            }

            var ds = await this.registrationService.GetVehiclePurchaseInfo(vehicleId.Value);

            var vehicleLocalPurchaseInfo = ds.Tables[0].ToList<VwVehicleLocalPurchaseInfo>();
            var vehicleImportInfo = ds.Tables[1].ToList<VwVehicleImportInfo>();
            var vehicleAuctionInfo = ds.Tables[2].ToList<VwVehicleAuctionInfo>();

            var data = new
            {
                LocalPurchaseInfo = vehicleLocalPurchaseInfo.Count > 0 ? vehicleLocalPurchaseInfo.FirstOrDefault() : null,
                ImportInfo = vehicleImportInfo.Count > 0 ? vehicleImportInfo.FirstOrDefault() : null,
                AuctionInfo = vehicleAuctionInfo.Count > 0 ? vehicleAuctionInfo.FirstOrDefault() : null,

            };

            var apiResponseType = vehicleLocalPurchaseInfo.Count > 0 || vehicleImportInfo.Count > 0 || vehicleAuctionInfo.Count > 0 ? ApiResponseType.SUCCESS : ApiResponseType.FAILED;
            var msg = vehicleLocalPurchaseInfo.Count > 0 || vehicleImportInfo.Count > 0 || vehicleAuctionInfo.Count > 0 ? Constants.RECORD_FOUND_MESSAGE : Constants.NOT_FOUND_MESSAGE;

            return ApiResponse.GetApiResponse(apiResponseType, data, msg);
        }


        [HttpGet(Name = "GetHPA")]
        public async Task<ApiResponse> GetHPA(long applicationId)
        {
            this.registrationService.VwUser = this.User;

            var ds = await this.registrationService.GetHPA(applicationId);

            var hPAInfo = ds.Tables[0].ToList<VwHPA>().FirstOrDefault();

            if (hPAInfo is not null)
            {
                hPAInfo.SponserBusiness = ds.Tables[1].ToList<VwBusiness>().FirstOrDefault();
                hPAInfo.SponserBusiness.Addresses = ds.Tables[2].ToList<VwAddress>().ToList();
                hPAInfo.SponserBusiness.PhoneNumbers = ds.Tables[3].ToList<VwPhoneNumber>().ToList();
            }

            var apiResponseType = hPAInfo is not null ? ApiResponseType.SUCCESS : ApiResponseType.FAILED;
            var msg = hPAInfo is not null ? Constants.RECORD_FOUND_MESSAGE : Constants.NOT_FOUND_MESSAGE;

            return ApiResponse.GetApiResponse(apiResponseType, hPAInfo, msg);
        }

        [HttpGet(Name = "GetKeeper")]
        public async Task<ApiResponse> GetKeeper(long? applicationId, long? ownerId)
        {
            this.registrationService.VwUser = this.User;

            if (applicationId.HasValue && ownerId is null)
            {
                var dsApp = await this.registrationService.GetApplications(applicationId.Value, 1, 1);

                var currentApp = dsApp.Tables[0].ToList<VwApplication>().FirstOrDefault();

                ownerId = currentApp.OwnerId;
            }

            var ds = await this.registrationService.GetKeeper(ownerId.Value);

            var keeper = ds.Tables[0].ToList<VwKeeper>().FirstOrDefault();

            if (keeper is not null)
            {
                keeper.Person = ds.Tables[1].ToList<VwPerson>().FirstOrDefault();
                keeper.Person.Addresses = ds.Tables[2].ToList<VwAddress>();
                keeper.Person.PhoneNumbers = ds.Tables[3].ToList<VwPhoneNumber>();
            }

            var apiResponseType = keeper is not null ? ApiResponseType.SUCCESS : ApiResponseType.FAILED;
            var msg = keeper is not null ? Constants.RECORD_FOUND_MESSAGE : Constants.NOT_FOUND_MESSAGE;

            return ApiResponse.GetApiResponse(apiResponseType, keeper, msg);
        }



        [HttpGet(Name = "GetRemarks")]
        public async Task<ApiResponse> GetRemarks(long applicationId, int applicationStateId)
        {
            this.registrationService.VwUser = this.User;

            var ds = await this.registrationService.GetRemarks(applicationId);

            var application = ds.Tables[0].ToList<VwApplication>().FirstOrDefault();
            var remarks = ds.Tables[1].ToList<VwRemarks>();

            var data = new
            {
                application,
                remarks,
                validBusinessEventId = ds.Tables[2].AsEnumerable().Select(x => x.Field<Int64>(0)).ToArray(),
                roleId = this.User.UserRoles.FirstOrDefault().RoleId
            };

            //Response will always be success.

            var apiResponseType = ApiResponseType.SUCCESS;
            var msg = Constants.RECORD_FOUND_MESSAGE;

            return ApiResponse.GetApiResponse(apiResponseType, data, msg);
        }

        [HttpGet(Name = "GetOwnerByCNIC")]
        public async Task<ApiResponse> GetOwnerByCNIC(string cnic)
        {
            var ds = await this.registrationService.GetPersonByCNIC(cnic);

            var person = SharedLib.Common.Extentions.ToList<VwPerson>(ds.Tables[0]).FirstOrDefault();

            if (person is not null)
            {
                person.Addresses = SharedLib.Common.Extentions.ToList<VwAddress>(ds.Tables[1]).ToList();
                person.PhoneNumbers = SharedLib.Common.Extentions.ToList<VwPhoneNumber>(ds.Tables[2]).ToList();
            }

            var data = new { person };

            var status = person is not null ? Constants.RECORD_FOUND_MESSAGE : Constants.NOT_FOUND_MESSAGE;

            return ApiResponse.GetResponse(ApiResponseType.SUCCESS, data, status, null);
        }

        [HttpGet(Name = "GetBusinessByTaxNumber")]
        public async Task<ApiResponse> GetBusinessByTaxNumber(string ntn, string ftn, string stn)
        {
            var businessProfile = await this.registrationService.GetBusinessByTaxNumber(ntn, ftn, stn);

            var data = new { businessProfile };

            var status = businessProfile is not null ? Constants.RECORD_FOUND_MESSAGE : Constants.NOT_FOUND_MESSAGE;

            return ApiResponse.GetResponse(ApiResponseType.SUCCESS, data, status, null);
        }
        
        [HttpGet(Name = "GetBusinessByTaxNumber1")]
        public async Task<ApiResponse> GetAuctionedNumber(string chassisNumber)
        {
            var ds = await this.registrationService.GetAuctionedNumber(chassisNumber);

            if (ds.Tables.Count == 0)
            {
                return ApiResponse.GetApiResponse(ApiResponseType.FAILED, null, Constants.NOT_FOUND_MESSAGE);
            }

            var data = new { registrationNumbers = ds.Tables[0] };

            return ApiResponse.GetApiResponse(ApiResponseType.SUCCESS, data, Constants.RECORD_FOUND_MESSAGE);
        }

        [HttpGet(Name = "GetAssessment")]
        public async Task<ApiResponse> GetAssessment(long applicationId)
        {
            this.registrationService.VwUser = this.User;

            var ds = await this.registrationService.GetAssessment(applicationId);

            var taxesApplied = ds.Tables[0].ToList<VwAssessment>();

            var apiResponseType = taxesApplied.Count > 0 ? ApiResponseType.SUCCESS : ApiResponseType.FAILED;
            var msg = taxesApplied.Count > 0 ? Constants.RECORD_FOUND_MESSAGE : Constants.NOT_FOUND_MESSAGE;

            return ApiResponse.GetApiResponse(apiResponseType, taxesApplied, msg);
        }

        [HttpGet(Name = "GetChallanDetail")]
        public async Task<ApiResponse> GetChallanDetail(long applicationId)
        {
            this.registrationService.VwUser = this.User;

            var ds = await this.registrationService.GetChallanDetail(applicationId);

            VwApplication currentApp = ds.Tables[0].ToList<VwApplication>().FirstOrDefault();

            if (currentApp is not null)
            {
                var sellerList = ds.Tables[1].ToList<VwTempOwner_v1>();

                if (sellerList.Any())
                {
                    currentApp.Seller = sellerList.FirstOrDefault();
                    var addresses = ds.Tables[3].ToList<VwAddress>();
                    var phoneNumbers = ds.Tables[4].ToList<VwPhoneNumber>();

                    if (currentApp.Seller.OwnerTypeId == 1)
                    {
                        currentApp.Seller.Persons = ds.Tables[2].ToList<VwPerson>();
                        currentApp.Seller.Persons.ForEach(x =>
                        {
                            x.Addresses = new List<VwAddress>();
                            x.PhoneNumbers = new List<VwPhoneNumber>();

                            x.Addresses.AddRange(addresses.Where(add => add.PersonId == x.PersonId));
                            x.PhoneNumbers.AddRange(phoneNumbers.Where(add => add.PersonId == x.PersonId));
                        });
                    }
                    else if (currentApp.Seller.OwnerTypeId == 2)
                    {
                        currentApp.Seller.Business = ds.Tables[2].ToList<VwBusiness>().FirstOrDefault();
                        currentApp.Seller.Business.Addresses = new List<VwAddress>();
                        currentApp.Seller.Business.PhoneNumbers = new List<VwPhoneNumber>();

                        currentApp.Seller.Business.Addresses.AddRange(addresses.Where(add => add.BusinessId == currentApp.Seller.Business.BusinessId));
                        currentApp.Seller.Business.PhoneNumbers.AddRange(phoneNumbers.Where(add => add.BusinessId == currentApp.Seller.Business.BusinessId));
                    }
                }

                var ownersList = ds.Tables[5].ToList<VwTempOwner_v1>();

                if (ownersList.Any())
                {
                    currentApp.Owner = ownersList.FirstOrDefault();
                    var addresses = ds.Tables[7].ToList<VwAddress>();
                    var phoneNumbers = ds.Tables[8].ToList<VwPhoneNumber>();

                    if (currentApp.Owner.OwnerTypeId == 1)
                    {
                        currentApp.Owner.Persons = ds.Tables[6].ToList<VwPerson>();
                        currentApp.Owner.Persons.ForEach(x =>
                        {
                            x.Addresses = new List<VwAddress>();
                            x.PhoneNumbers = new List<VwPhoneNumber>();

                            x.Addresses.AddRange(addresses.Where(add => add.PersonId == x.PersonId));
                            x.PhoneNumbers.AddRange(phoneNumbers.Where(add => add.PersonId == x.PersonId));
                        });
                    }
                    else if (currentApp.Owner.OwnerTypeId == 2)
                    {
                        currentApp.Owner.Business = ds.Tables[6].ToList<VwBusiness>().FirstOrDefault();
                        currentApp.Owner.Business.Addresses = new List<VwAddress>();
                        currentApp.Owner.Business.PhoneNumbers = new List<VwPhoneNumber>();

                        currentApp.Owner.Business.Addresses.AddRange(addresses.Where(add => add.BusinessId == currentApp.Owner.Business.BusinessId));
                        currentApp.Owner.Business.PhoneNumbers.AddRange(phoneNumbers.Where(add => add.BusinessId == currentApp.Owner.Business.BusinessId));
                    }
                }

                currentApp.Vehicle = ds.Tables[9].ToList<VwVehicle>().FirstOrDefault();

                currentApp.ChallanPayments = ds.Tables[10].ToList<VwChallanPaymentInfo>().ToList();
                var taxAssessment = ds.Tables[11].ToList<VwAssessment>().ToList();

                currentApp.ChallanPayments.ForEach(x =>
                {
                    x.TaxAssessment = taxAssessment.Where(a => a.AssessmentBaseId == x.AssessmentBaseId).ToList();
                });

                var data = new
                {
                    currentApp.ApplicationId,
                    currentApp.ApplicationStatus,
                    currentApp.ApplicationStatusId,
                    currentApp.BusinessProcess,
                    currentApp.BusinessProcessId,
                    currentApp.BusinessPhase,
                    currentApp.BusinessPhaseId,
                    currentApp.BusinessPhaseStatus,
                    currentApp.BusinessPhaseStatusId,
                    currentApp.ReceivedAt,
                    currentApp.Seller,
                    currentApp.Owner,
                    currentApp.Vehicle,
                    currentApp.ChallanPayments,
                };

                return ApiResponse.GetResponse(ApiResponseType.SUCCESS, data, Constants.RECORD_FOUND_MESSAGE, "");
            }

            return ApiResponse.GetResponse(ApiResponseType.FAILED, null, Constants.NOT_FOUND_MESSAGE, null);
        }

        [HttpGet(Name = "GetOwnerVehicleDetails")]
        public async Task<ApiResponse> GetOwnerVehicleDetails(string VehicleRegNo)
        {
            this.toService.VwUser = this.User;

            var ds = await this.toService.GetOwnerVehicleDetails(VehicleRegNo);

            VwTempOwner_v1 Owner = SharedLib.Common.Extentions.ToList<VwTempOwner_v1>(ds.Tables[0]).FirstOrDefault();

            if (Owner is not null)
            {
                var addresses = SharedLib.Common.Extentions.ToList<VwAddress>(ds.Tables[2]).ToList();
                var phoneNumbers = SharedLib.Common.Extentions.ToList<VwPhoneNumber>(ds.Tables[3]).ToList();

                if (Owner.OwnerTypeId == 1)
                {
                    Owner.Persons = SharedLib.Common.Extentions.ToList<VwPerson>(ds.Tables[1]).ToList();
                    Owner.Persons.ForEach(x =>
                    {
                        x.Addresses = new List<VwAddress>();
                        x.PhoneNumbers = new List<VwPhoneNumber>();

                        x.Addresses.AddRange(addresses.Where(add => add.PersonId == x.PersonId));
                        x.PhoneNumbers.AddRange(phoneNumbers.Where(add => add.PersonId == x.PersonId));
                    });
                }
                else if (Owner.OwnerTypeId == 2)
                {
                    Owner.Business = SharedLib.Common.Extentions.ToList<VwBusiness>(ds.Tables[1]).FirstOrDefault();
                    Owner.Business.Addresses = new List<VwAddress>();
                    Owner.Business.PhoneNumbers = new List<VwPhoneNumber>();

                    Owner.Business.Addresses.AddRange(addresses.Where(add => add.BusinessId == Owner.Business.BusinessId));
                    Owner.Business.PhoneNumbers.AddRange(phoneNumbers.Where(add => add.BusinessId == Owner.Business.BusinessId));
                }

                VwVehicle Vehicle = SharedLib.Common.Extentions.ToList<VwVehicle>(ds.Tables[4]).FirstOrDefault();

                VwVehiclePurchaseInfo PurchaseInfo = new VwVehiclePurchaseInfo();

                PurchaseInfo.LocalPurchaseInfo = SharedLib.Common.Extentions.ToList<VwVehicleLocalPurchaseInfo>(ds.Tables[5]).FirstOrDefault();
                PurchaseInfo.ImportInfo = SharedLib.Common.Extentions.ToList<VwVehicleImportInfo>(ds.Tables[6]).FirstOrDefault();
                PurchaseInfo.AuctionInfo = SharedLib.Common.Extentions.ToList<VwVehicleAuctionInfo>(ds.Tables[7]).FirstOrDefault();

                //List<VwVehicleDocumentDetail> Documents = new List<VwVehicleDocumentDetail>();
                //Documents = SharedLib.Common.Extentions.ToList<VwVehicleDocumentDetail>(ds.Tables[17]).ToList();

                var data = new
                {
                    Owner,
                    //Owner.OwnerId,
                    //Owner.OwnerTypeId,
                    //Owner.OwnerTaxGroupId,
                    //Owner.OwnerType,
                    //Owner.OwnerTaxGroup,
                    //Owner.IsHPA,
                    //Owner.Persons,
                    //Owner.Business,
                    Vehicle,
                    PurchaseInfo.LocalPurchaseInfo,
                    PurchaseInfo.ImportInfo,
                    PurchaseInfo.AuctionInfo
                };

                return ApiResponse.GetResponse(ApiResponseType.SUCCESS, data, Constants.RECORD_FOUND_MESSAGE, "");
            }

            return ApiResponse.GetResponse(ApiResponseType.FAILED, null, Constants.NOT_FOUND_MESSAGE, null);
        }


        [HttpGet(Name = "GetVehicleOwnerInfo")]
        public async Task<ApiResponse> GetVehicleOwnerInfoForDelivery(string SearchCriteria)
        {
            this.toService.VwUser = this.User;

            var ds = await this.registrationService.GetVehicleOwnerInfo(SearchCriteria);

            VwTempOwner_v1 Owner = SharedLib.Common.Extentions.ToList<VwTempOwner_v1>(ds.Tables[0]).FirstOrDefault();

            if (Owner is not null)
            {
                var addresses = SharedLib.Common.Extentions.ToList<VwAddress>(ds.Tables[2]).ToList();
                var phoneNumbers = SharedLib.Common.Extentions.ToList<VwPhoneNumber>(ds.Tables[3]).ToList();

                if (Owner.OwnerTypeId == 1)
                {
                    Owner.Persons = SharedLib.Common.Extentions.ToList<VwPerson>(ds.Tables[1]).ToList();
                    Owner.Persons.ForEach(x =>
                    {
                        x.Addresses = new List<VwAddress>();
                        x.PhoneNumbers = new List<VwPhoneNumber>();

                        x.Addresses.AddRange(addresses.Where(add => add.PersonId == x.PersonId));
                        x.PhoneNumbers.AddRange(phoneNumbers.Where(add => add.PersonId == x.PersonId));
                    });
                }
                else if (Owner.OwnerTypeId == 2)
                {
                    Owner.Business = SharedLib.Common.Extentions.ToList<VwBusiness>(ds.Tables[1]).FirstOrDefault();
                    Owner.Business.Addresses = new List<VwAddress>();
                    Owner.Business.PhoneNumbers = new List<VwPhoneNumber>();

                    Owner.Business.Addresses.AddRange(addresses.Where(add => add.BusinessId == Owner.Business.BusinessId));
                    Owner.Business.PhoneNumbers.AddRange(phoneNumbers.Where(add => add.BusinessId == Owner.Business.BusinessId));
                }

                VwVehicle Vehicle = SharedLib.Common.Extentions.ToList<VwVehicle>(ds.Tables[4]).FirstOrDefault();

                List<VehicleArticle> vehicleArticle = new List<VehicleArticle>();

                vehicleArticle = SharedLib.Common.Extentions.ToList<VehicleArticle>(ds.Tables[5]).ToList();

                List<VwVehicleArticleDelivery> vehicleArticleDelivery = new List<VwVehicleArticleDelivery>();

                vehicleArticleDelivery = SharedLib.Common.Extentions.ToList<VwVehicleArticleDelivery>(ds.Tables[6]).ToList();

                long ApplicationId = SharedLib.Common.Extentions.ToList<VwApplication>(ds.Tables[7]).FirstOrDefault().ApplicationId;
                List<VwVehicleArticlePrintingInfo> vehicleArticlePrintingInfo = new List<VwVehicleArticlePrintingInfo>();

                vehicleArticlePrintingInfo = SharedLib.Common.Extentions.ToList<VwVehicleArticlePrintingInfo>(ds.Tables[8]).ToList();


                var data = new
                {
                    ApplicationId,
                    Owner,
                    //Owner.OwnerId,
                    //Owner.OwnerTypeId,
                    //Owner.OwnerTaxGroupId,
                    //Owner.OwnerType,
                    //Owner.OwnerTaxGroup,
                    //Owner.IsHPA,
                    //Owner.Persons,
                    //Owner.Business,
                    Vehicle,
                    vehicleArticle,
                    vehicleArticleDelivery,
                    vehicleArticlePrintingInfo

                };

                return ApiResponse.GetResponse(ApiResponseType.SUCCESS, data, Constants.RECORD_FOUND_MESSAGE, "");
            }

            return ApiResponse.GetResponse(ApiResponseType.FAILED, null, Constants.NOT_FOUND_MESSAGE, null);
        }

        [HttpGet(Name = "GetVehicleOwnerInfoForScanning")]
        public async Task<ApiResponse> GetVehicleOwnerInfoForScanning(string SearchCriteria)
        {
            this.registrationService.VwUser = this.User;

            var ds = await this.registrationService.GetVehicleOwnerInfoForScanning(SearchCriteria);

            VwTempOwner_v1 Owner = SharedLib.Common.Extentions.ToList<VwTempOwner_v1>(ds.Tables[0]).FirstOrDefault();

            if (Owner is not null)
            {
                var addresses = SharedLib.Common.Extentions.ToList<VwAddress>(ds.Tables[2]).ToList();
                var phoneNumbers = SharedLib.Common.Extentions.ToList<VwPhoneNumber>(ds.Tables[3]).ToList();

                if (Owner.OwnerTypeId == 1)
                {
                    Owner.Persons = SharedLib.Common.Extentions.ToList<VwPerson>(ds.Tables[1]).ToList();
                    Owner.Persons.ForEach(x =>
                    {
                        x.Addresses = new List<VwAddress>();
                        x.PhoneNumbers = new List<VwPhoneNumber>();

                        x.Addresses.AddRange(addresses.Where(add => add.PersonId == x.PersonId));
                        x.PhoneNumbers.AddRange(phoneNumbers.Where(add => add.PersonId == x.PersonId));
                    });
                }
                else if (Owner.OwnerTypeId == 2)
                {
                    Owner.Business = SharedLib.Common.Extentions.ToList<VwBusiness>(ds.Tables[1]).FirstOrDefault();
                    Owner.Business.Addresses = new List<VwAddress>();
                    Owner.Business.PhoneNumbers = new List<VwPhoneNumber>();

                    Owner.Business.Addresses.AddRange(addresses.Where(add => add.BusinessId == Owner.Business.BusinessId));
                    Owner.Business.PhoneNumbers.AddRange(phoneNumbers.Where(add => add.BusinessId == Owner.Business.BusinessId));
                }

                VwVehicle Vehicle = SharedLib.Common.Extentions.ToList<VwVehicle>(ds.Tables[4]).FirstOrDefault();

                List<VwVehicleScannedDocuments> VehicleDocuments = new List<VwVehicleScannedDocuments>();

                VehicleDocuments = SharedLib.Common.Extentions.ToList<VwVehicleScannedDocuments>(ds.Tables[5]).ToList();


                long ApplicationId = SharedLib.Common.Extentions.ToList<VwApplication>(ds.Tables[6]).FirstOrDefault().ApplicationId;
                var data = new
                {
                    ApplicationId,
                    Owner,
                    //Owner.OwnerId,
                    //Owner.OwnerTypeId,
                    //Owner.OwnerTaxGroupId,
                    //Owner.OwnerType,
                    //Owner.OwnerTaxGroup,
                    //Owner.IsHPA,
                    //Owner.Persons,
                    //Owner.Business,
                    Vehicle,
                    VehicleDocuments

                };

                return ApiResponse.GetResponse(ApiResponseType.SUCCESS, data, Constants.RECORD_FOUND_MESSAGE, "");
            }

            return ApiResponse.GetResponse(ApiResponseType.FAILED, null, Constants.NOT_FOUND_MESSAGE, null);
        }



        [HttpPost]
        public async Task<ApiResponse> SaveOwner(VwTempOwner_v1 owner)
        {

            //this.nrtService.VwUser = this.User;
            this.registrationService.VwUser = this.User;

            DataSet resultData = await this.registrationService.NRSaveOwner(owner);
            var apiResponseType = ApiResponseType.SUCCESS;
            var msg = Constants.DATA_SAVED_MESSAGE;
            object data;

            if (resultData.Tables.Count > 0 && resultData.Tables[0].Rows[0][0].ToString() == "0")
            {
                apiResponseType = ApiResponseType.SUCCESS;
                msg = Constants.DATA_SAVED_MESSAGE;
                data = new
                {
                    ApplicationId = resultData.Tables[1].Rows[0][0].ToString(),
                    OwnerId = resultData.Tables[1].Rows[0][1].ToString()
                };

            }
            else
            {
                apiResponseType = ApiResponseType.FAILED;
                msg = Constants.DATA_NOT_SAVED_MESSAGE + resultData.Tables[0].Rows[0][1].ToString();
                data = null;
            }
            return ApiResponse.GetApiResponse(apiResponseType, data, msg);



            // Old code

            //this.registrationService.VwUser = this.User;

            //var vwTempApplication = await this.registrationService.SaveOwner(owner);

            //var data = new
            //{
            //    vwTempApplication.ApplicationId,
            //    vwTempApplication.ReceivedAt,
            //    vwTempApplication.Owner.OwnerId,
            //    vwTempApplication.Owner.Persons?.FirstOrDefault().PersonId,
            //    vwTempApplication.Owner.Business?.BusinessId
            //};

            //var apiResponseType = vwTempApplication.ApplicationId > 0 ? ApiResponseType.SUCCESS : ApiResponseType.FAILED;
            //var msg = vwTempApplication.ApplicationId > 0 ? Constants.DATA_SAVED_MESSAGE : Constants.DATA_NOT_SAVED_MESSAGE;

            //return ApiResponse.GetApiResponse(apiResponseType, data, msg);
        }

        [HttpPost]
        public async Task<ApiResponse> SaveSeller(VwTempOwner_v1 owner)
        {
            // this is a test comment for gitlab
            this.nrtService.VwUser = this.User;

            DataSet resultData = await this.nrtService.SaveSeller(owner);
            var apiResponseType = ApiResponseType.SUCCESS;
            var msg = Constants.DATA_SAVED_MESSAGE;
            object data;

            if (resultData.Tables.Count > 0 && resultData.Tables[0].Rows[0][0].ToString() == "0")
            {
                apiResponseType = ApiResponseType.SUCCESS;
                msg = Constants.DATA_SAVED_MESSAGE;
                data = new
                {
                    ApplicationId = resultData.Tables[1].Rows[0][0].ToString(),
                    OwnerId = resultData.Tables[1].Rows[0][1].ToString()
                };

            }
            else
            {
                apiResponseType = ApiResponseType.FAILED;
                msg = Constants.DATA_NOT_SAVED_MESSAGE;
                data = null;
            }


            //var data = new
            //{
            //    vwTempApplication.ApplicationId,
            //    vwTempApplication.ReceivedAt,
            //    vwTempApplication.Owner.OwnerId,
            //    vwTempApplication.Owner.Persons?.FirstOrDefault().PersonId,
            //    vwTempApplication.Owner.Business?.BusinessId
            //};

            //var apiResponseType = vwTempApplication.ApplicationId > 0 ? ApiResponseType.SUCCESS : ApiResponseType.FAILED;
            //var msg = vwTempApplication.ApplicationId > 0 ? Constants.DATA_SAVED_MESSAGE : Constants.DATA_NOT_SAVED_MESSAGE;

            return ApiResponse.GetApiResponse(apiResponseType, data, msg);
            //return ApiResponse.GetApiResponse(ApiResponseType.SUCCESS, null, "OK");
        }


        [HttpPost]
        public async Task<ApiResponse> NRTSaveOwner(VwTempOwner_v1 owner)
        {
            this.nrtService.VwUser = this.User;

            DataSet resultData = await this.nrtService.SaveOwner(owner);
            var apiResponseType = ApiResponseType.SUCCESS;
            var msg = Constants.DATA_SAVED_MESSAGE;
            object data;

            if (resultData.Tables.Count > 0 && resultData.Tables[0].Rows[0][0].ToString() == "0")
            {
                apiResponseType = ApiResponseType.SUCCESS;
                msg = Constants.DATA_SAVED_MESSAGE;
                data = new
                {
                    OwnerId = resultData.Tables[1].Rows[0][0].ToString()
                };

            }
            else
            {
                apiResponseType = ApiResponseType.FAILED;
                msg = Constants.DATA_NOT_SAVED_MESSAGE;
                data = null;
            }


            //var data = new
            //{
            //    vwTempApplication.ApplicationId,
            //    vwTempApplication.ReceivedAt,
            //    vwTempApplication.Owner.OwnerId,
            //    vwTempApplication.Owner.Persons?.FirstOrDefault().PersonId,
            //    vwTempApplication.Owner.Business?.BusinessId
            //};

            //var apiResponseType = vwTempApplication.ApplicationId > 0 ? ApiResponseType.SUCCESS : ApiResponseType.FAILED;
            //var msg = vwTempApplication.ApplicationId > 0 ? Constants.DATA_SAVED_MESSAGE : Constants.DATA_NOT_SAVED_MESSAGE;

            return ApiResponse.GetApiResponse(apiResponseType, data, msg);
            //return ApiResponse.GetApiResponse(ApiResponseType.SUCCESS, null, "OK");
        }

        [HttpPost]
        public async Task<ApiResponse> NRTSaveVehicle(VwVehicle vehicle)
        {

            this.nrtService.VwUser = this.User;

            DataSet resultData = await this.nrtService.SaveVehicle(vehicle, this.User.UserId);
            var apiResponseType = ApiResponseType.SUCCESS;
            var msg = Constants.DATA_SAVED_MESSAGE;
            object data;

            if (resultData.Tables.Count > 0 && resultData.Tables[0].Rows[0][0].ToString() == "0")
            {
                apiResponseType = ApiResponseType.SUCCESS;
                msg = Constants.DATA_SAVED_MESSAGE;
                data = new
                {
                    VehicleId = resultData.Tables[1].Rows[0][0].ToString()
                };

            }
            else
            {
                apiResponseType = ApiResponseType.FAILED;
                msg = Constants.DATA_NOT_SAVED_MESSAGE;
                data = null;
            }

            return ApiResponse.GetApiResponse(apiResponseType, data, msg);
        }

        [HttpPost]
        public async Task<ApiResponse> SaveVehicle(VwVehicle vehicle)
        {

            this.registrationService.VwUser = this.User;


            DataSet resultData = await this.registrationService.NRSaveVehicle(vehicle);
            var apiResponseType = ApiResponseType.SUCCESS;
            var msg = Constants.DATA_SAVED_MESSAGE;
            object data;

            if (resultData.Tables.Count > 0 && resultData.Tables[0].Rows[0][0].ToString() == "0")
            {
                apiResponseType = ApiResponseType.SUCCESS;
                msg = Constants.DATA_SAVED_MESSAGE;
                data = new
                {
                    VehicleId = resultData.Tables[1].Rows[0][0].ToString()
                };

            }
            else
            {
                apiResponseType = ApiResponseType.FAILED;
                msg = Constants.DATA_NOT_SAVED_MESSAGE + resultData.Tables[0].Rows[0][1].ToString();
                data = null;
            }

            return ApiResponse.GetApiResponse(apiResponseType, data, msg);
            //this.registrationService.VwUser = this.User;

            //var vwVehicle = await this.registrationService.SaveVehicle(vehicle);

            //var data = new
            //{
            //    vwVehicle.VehicleId
            //};

            //var apiResponseType = vwVehicle.VehicleId > 0 ? ApiResponseType.SUCCESS : ApiResponseType.FAILED;
            //var msg = vwVehicle.VehicleId > 0 ? Constants.DATA_SAVED_MESSAGE : Constants.DATA_NOT_SAVED_MESSAGE;

            //return ApiResponse.GetApiResponse(apiResponseType, data, msg);
        }

        [HttpPost]
        public async Task<ApiResponse> SaveVehiclePurchaseInfo(VwVehiclePurchaseInfo vehiclePurchaseInfo)
        {
            this.registrationService.VwUser = this.User;

            DataSet resultData = await this.registrationService.NRSaveVehiclePurchaseInfo(vehiclePurchaseInfo);
            var apiResponseType = ApiResponseType.SUCCESS;
            var msg = Constants.DATA_SAVED_MESSAGE;
            object data;

            if (resultData.Tables.Count > 0 && resultData.Tables[0].Rows[0][0].ToString() == "0")
            {
                apiResponseType = ApiResponseType.SUCCESS;
                msg = Constants.DATA_SAVED_MESSAGE;
                data = new
                {
                    VehicleAuctionInfoId = resultData.Tables[1].Rows[0][0].ToString(),
                    VehicleImportInfoId = resultData.Tables[1].Rows[0][1].ToString(),
                    VehiclePurchaseInfoId = resultData.Tables[1].Rows[0][2].ToString()
                };

            }
            else
            {
                apiResponseType = ApiResponseType.FAILED;
                msg = Constants.DATA_NOT_SAVED_MESSAGE + resultData.Tables[0].Rows[0][1].ToString();
                data = null;
            }

            return ApiResponse.GetApiResponse(apiResponseType, data, msg);

            //this.registrationService.VwUser = this.User;

            //var vwVehiclePurchaseInfo = await this.registrationService.SaveVehiclePurchaseInfo(vehiclePurchaseInfo);

            //var data = new
            //{
            //    vwVehiclePurchaseInfo.LocalPurchaseInfo?.LocalPurchaseInfoId,
            //    vwVehiclePurchaseInfo.ImportInfo?.ImportInfoId,
            //    vwVehiclePurchaseInfo.AuctionInfo?.AuctionInfoId
            //};

            //var transactionResult = vwVehiclePurchaseInfo.LocalPurchaseInfo?.LocalPurchaseInfoId > 0 ||
            //    vwVehiclePurchaseInfo.ImportInfo?.ImportInfoId > 0 ||
            //    vwVehiclePurchaseInfo.AuctionInfo?.AuctionInfoId > 0;

            //var apiResponseType = transactionResult ? ApiResponseType.SUCCESS : ApiResponseType.FAILED;
            //var msg = transactionResult ? Constants.DATA_SAVED_MESSAGE : Constants.DATA_NOT_SAVED_MESSAGE;

            //return ApiResponse.GetApiResponse(apiResponseType, data, msg);
        }


        [HttpPost]
        public async Task<ApiResponse> NRTSaveVehiclePurchaseInfo(VwVehiclePurchaseInfo vehiclePurchaseInfo)
        {

            this.registrationService.VwUser = this.User;
            DataSet resultData = await this.nrtService.SaveVehiclePurchaseInfo(vehiclePurchaseInfo, this.User.UserId);
            var apiResponseType = ApiResponseType.SUCCESS;
            var msg = Constants.DATA_SAVED_MESSAGE;
            object data;

            if (resultData.Tables.Count > 0 && resultData.Tables[0].Rows[0][0].ToString() == "0")
            {
                apiResponseType = ApiResponseType.SUCCESS;
                msg = Constants.DATA_SAVED_MESSAGE;
                data = new
                {
                    VehicleAuctionInfoId = resultData.Tables[1].Rows[0][0].ToString(),
                    VehicleImportInfoId = resultData.Tables[1].Rows[0][1].ToString(),
                    VehiclePurchaseInfoId = resultData.Tables[1].Rows[0][2].ToString()
                };

            }
            else
            {
                apiResponseType = ApiResponseType.FAILED;
                msg = Constants.DATA_NOT_SAVED_MESSAGE;
                data = null;
            }

            return ApiResponse.GetApiResponse(apiResponseType, data, msg);
        }


        [HttpPost]
        public async Task<ApiResponse> SaveRemarks(VwRemarks remarks)
        {
            var roles = this.userManagementService.GetUserRoles(this.User.UserId);
            this.User.UserRoles = roles;
            this.registrationService.VwUser = this.User;

            var vwRemarks = await this.registrationService.SaveRemarks(remarks);

            var data = new
            {
                vwRemarks.RemarksId
            };

            var apiResponseType = vwRemarks.RemarksId > 0 ? ApiResponseType.SUCCESS : ApiResponseType.FAILED;
            var msg = vwRemarks.RemarksId > 0 ? Constants.DATA_SAVED_MESSAGE : Constants.DATA_NOT_SAVED_MESSAGE;

            return ApiResponse.GetApiResponse(apiResponseType, data, msg);
        }

        [HttpPost]
        public async Task<ApiResponse> SaveVehicleDocuments(VwVehicleDocument vwVehicleDocument)
        {

            this.registrationService.VwUser = this.User;

            DataSet resultData = await this.registrationService.NRSaveVehicleDocument(vwVehicleDocument);
            var apiResponseType = ApiResponseType.SUCCESS;
            var msg = Constants.DATA_SAVED_MESSAGE;


            if (resultData.Tables.Count > 0 && resultData.Tables[0].Rows[0][0].ToString() == "0")
            {
                apiResponseType = ApiResponseType.SUCCESS;
                msg = Constants.DATA_SAVED_MESSAGE;
            }
            else
            {
                apiResponseType = ApiResponseType.FAILED;
                msg = Constants.DATA_NOT_SAVED_MESSAGE + resultData.Tables[0].Rows[0][1].ToString();
            }

            return ApiResponse.GetApiResponse(apiResponseType, null, msg);


            //this.registrationService.VwUser = this.User;

            //var isSaved = await this.registrationService.SaveVehicleDocument(vwVehicleDocument);

            //var apiResponseType = isSaved ? ApiResponseType.SUCCESS : ApiResponseType.FAILED;
            //var msg = isSaved ? Constants.DATA_SAVED_MESSAGE : Constants.DATA_NOT_SAVED_MESSAGE;

            //return ApiResponse.GetApiResponse(apiResponseType, null, msg);
        }

        [HttpPost]
        public async Task<ApiResponse> NRTSaveVehicleDocuments(VwVehicleDocument vwVehicleDocument)
        {
            this.registrationService.VwUser = this.User;

            DataSet resultData = await this.nrtService.SaveVehicleDocument(vwVehicleDocument, this.User.UserId);

            var apiResponseType = ApiResponseType.SUCCESS;
            var msg = Constants.DATA_SAVED_MESSAGE;


            if (resultData.Tables.Count > 0 && resultData.Tables[0].Rows[0][0].ToString() == "0")
            {
                apiResponseType = ApiResponseType.SUCCESS;
                msg = Constants.DATA_SAVED_MESSAGE;
            }
            else
            {
                apiResponseType = ApiResponseType.FAILED;
                msg = Constants.DATA_NOT_SAVED_MESSAGE;
            }

            return ApiResponse.GetApiResponse(apiResponseType, null, msg);

        }

        [HttpPost]
        public async Task<ApiResponse> SaveHPA(VwHPA vwTempHPA)
        {
            this.registrationService.VwUser = this.User;

            DataSet resultData = await this.registrationService.NRSaveHPA(vwTempHPA);
            var apiResponseType = ApiResponseType.SUCCESS;
            var msg = Constants.DATA_SAVED_MESSAGE;

            if (resultData.Tables.Count > 0 && resultData.Tables[0].Rows[0][0].ToString() == "0")
            {
                apiResponseType = ApiResponseType.SUCCESS;
                msg = Constants.DATA_SAVED_MESSAGE;
            }
            else
            {
                apiResponseType = ApiResponseType.FAILED;
                msg = Constants.DATA_NOT_SAVED_MESSAGE + " " + resultData.Tables[0].Rows[0][1].ToString();
            }

            return ApiResponse.GetApiResponse(apiResponseType, null, msg);

            //this.registrationService.VwUser = this.User;

            //var hPA = await this.registrationService.SaveHPA(vwTempHPA);

            //var data = new
            //{
            //    hPA.HPAId
            //};

            //var apiResponseType = hPA.HPAId > 0 ? ApiResponseType.SUCCESS : ApiResponseType.FAILED;
            //var msg = hPA.HPAId > 0 ? Constants.DATA_SAVED_MESSAGE : Constants.DATA_NOT_SAVED_MESSAGE;

            //return ApiResponse.GetApiResponse(apiResponseType, data, msg);
        }


        [HttpPost]
        public async Task<ApiResponse> NRTSaveHPA(VwHPA vwTempHPA)
        {
            this.registrationService.VwUser = this.User;
            DataSet resultData = await this.nrtService.SaveHPA(vwTempHPA, this.User.UserId);
            var apiResponseType = ApiResponseType.SUCCESS;
            var msg = Constants.DATA_SAVED_MESSAGE;

            if (resultData.Tables.Count > 0 && resultData.Tables[0].Rows[0][0].ToString() == "0")
            {
                apiResponseType = ApiResponseType.SUCCESS;
                msg = Constants.DATA_SAVED_MESSAGE;
            }
            else
            {
                apiResponseType = ApiResponseType.FAILED;
                msg = Constants.DATA_NOT_SAVED_MESSAGE;
            }

            return ApiResponse.GetApiResponse(apiResponseType, null, msg);

        }

        [HttpPost]
        public async Task<ApiResponse> TOSaveKeeper(VwKeeper vwTempKeeper)
        {
            this.toService.VwUser = this.User;
            DataSet resultData = await this.toService.SaveKeeper(vwTempKeeper);
            var apiResponseType = ApiResponseType.SUCCESS;
            var msg = Constants.DATA_SAVED_MESSAGE;

            if (resultData.Tables.Count > 0 && resultData.Tables[0].Rows[0][0].ToString() == "0")
            {
                apiResponseType = ApiResponseType.SUCCESS;
                msg = Constants.DATA_SAVED_MESSAGE;
            }
            else
            {
                apiResponseType = ApiResponseType.FAILED;
                msg = Constants.DATA_NOT_SAVED_MESSAGE;
            }

            return ApiResponse.GetApiResponse(apiResponseType, null, msg);

        }


        [HttpPost]
        public async Task<ApiResponse> TOSaveHPA(VwHPA vwTempHPA)
        {
            this.toService.VwUser = this.User;
            DataSet resultData = await this.toService.SaveHPA(vwTempHPA, this.User.UserId);
            var apiResponseType = ApiResponseType.SUCCESS;
            var msg = Constants.DATA_SAVED_MESSAGE;

            if (resultData.Tables.Count > 0 && resultData.Tables[0].Rows[0][0].ToString() == "0")
            {
                apiResponseType = ApiResponseType.SUCCESS;
                msg = Constants.DATA_SAVED_MESSAGE;
            }
            else
            {
                apiResponseType = ApiResponseType.FAILED;
                msg = Constants.DATA_NOT_SAVED_MESSAGE;
            }

            return ApiResponse.GetApiResponse(apiResponseType, null, msg);

        }


        [HttpPost]
        public async Task<ApiResponse> SaveKeeper(VwKeeper vwTempKeeper)
        {
            this.registrationService.VwUser = this.User;
            DataSet resultData = await this.registrationService.NRSaveKeeper(vwTempKeeper);
            var apiResponseType = ApiResponseType.SUCCESS;
            var msg = Constants.DATA_SAVED_MESSAGE;

            if (resultData.Tables.Count > 0 && resultData.Tables[0].Rows[0][0].ToString() == "0")
            {
                apiResponseType = ApiResponseType.SUCCESS;
                msg = Constants.DATA_SAVED_MESSAGE;
            }
            else
            {
                apiResponseType = ApiResponseType.FAILED;
                msg = Constants.DATA_NOT_SAVED_MESSAGE;
            }

            return ApiResponse.GetApiResponse(apiResponseType, null, msg);

            //this.registrationService.VwUser = this.User;

            //var keeper = await this.registrationService.SaveKeeper(vwTempKeeper);

            //var data = new
            //{
            //    keeper.KeeperId,
            //    keeper.KeeperPersonId
            //};

            //var apiResponseType = keeper.KeeperId > 0 ? ApiResponseType.SUCCESS : ApiResponseType.FAILED;
            //var msg = keeper.KeeperId > 0 ? Constants.DATA_SAVED_MESSAGE : Constants.DATA_NOT_SAVED_MESSAGE;

            //return ApiResponse.GetApiResponse(apiResponseType, data, msg);
        }

        [HttpPost]
        public async Task<ApiResponse> NRTSaveKeeper(VwKeeper vwTempKeeper)
        {
            this.nrtService.VwUser = this.User;
            DataSet resultData = await this.nrtService.SaveKeeper(vwTempKeeper, this.User.UserId);
            var apiResponseType = ApiResponseType.SUCCESS;
            var msg = Constants.DATA_SAVED_MESSAGE;

            if (resultData.Tables.Count > 0 && resultData.Tables[0].Rows[0][0].ToString() == "0")
            {
                apiResponseType = ApiResponseType.SUCCESS;
                msg = Constants.DATA_SAVED_MESSAGE;
            }
            else
            {
                apiResponseType = ApiResponseType.FAILED;
                msg = Constants.DATA_NOT_SAVED_MESSAGE;
            }

            return ApiResponse.GetApiResponse(apiResponseType, null, msg);

        }

        [HttpPost]
        public async Task<ApiResponse> SaveApplicationPhase(VwApplicationPhaseChange vwApplicationPhaseChange)
        {
            this.registrationService.VwUser = this.User;

            var ds = await this.registrationService.SaveApplicationPhase(vwApplicationPhaseChange);

            var apiResponseType = ApiResponseType.SUCCESS;
            var msg = Constants.DATA_SAVED_MESSAGE;

            if (ds.Tables[0].Rows[0][0].ToString() == "0")
            {
                apiResponseType = ApiResponseType.SUCCESS;
                msg = Constants.DATA_SAVED_MESSAGE;
            }
            else
            {
                apiResponseType = ApiResponseType.FAILED;
                msg = Constants.DATA_NOT_SAVED_MESSAGE;
            }

            return ApiResponse.GetApiResponse(apiResponseType, null, msg);
        }


        [HttpPost]
        public async Task<ApiResponse> SavePurchaser(VwTempOwner_v1 owner)
        {
            this.toService.VwUser = this.User;

            DataSet resultData = await this.toService.SavePurchaser(owner);
            var apiResponseType = ApiResponseType.SUCCESS;
            var msg = Constants.DATA_SAVED_MESSAGE;
            object data;

            if (resultData.Tables.Count > 0 && resultData.Tables[0].Rows[0][0].ToString() == "0")
            {
                apiResponseType = ApiResponseType.SUCCESS;
                msg = Constants.DATA_SAVED_MESSAGE;
                data = new
                {
                    ApplicationId = resultData.Tables[1].Rows[0][0].ToString(),
                    OwnerId = resultData.Tables[1].Rows[0][1].ToString()
                };

            }
            else
            {
                apiResponseType = ApiResponseType.FAILED;
                msg = Constants.DATA_NOT_SAVED_MESSAGE;
                data = null;
            }


            //var data = new
            //{
            //    vwTempApplication.ApplicationId,
            //    vwTempApplication.ReceivedAt,
            //    vwTempApplication.Owner.OwnerId,
            //    vwTempApplication.Owner.Persons?.FirstOrDefault().PersonId,
            //    vwTempApplication.Owner.Business?.BusinessId
            //};

            //var apiResponseType = vwTempApplication.ApplicationId > 0 ? ApiResponseType.SUCCESS : ApiResponseType.FAILED;
            //var msg = vwTempApplication.ApplicationId > 0 ? Constants.DATA_SAVED_MESSAGE : Constants.DATA_NOT_SAVED_MESSAGE;

            return ApiResponse.GetApiResponse(apiResponseType, data, msg);
            //return ApiResponse.GetApiResponse(ApiResponseType.SUCCESS, null, "OK");
        }

        [HttpPost]
        public async Task<ApiResponse> SaveVehicleArticleDelivery(VwVehicleArticleDelivery vwVehicleArticleDelivery)
        {
            this.registrationService.VwUser = this.User;

            var rowsAffected = await this.registrationService.SaveVehicleArticleDelivery(vwVehicleArticleDelivery);

            var apiResponseType = rowsAffected > 0 ? ApiResponseType.SUCCESS : ApiResponseType.FAILED;
            var msg = rowsAffected > 0 ? Constants.DATA_SAVED_MESSAGE : Constants.DATA_NOT_SAVED_MESSAGE;

            return ApiResponse.GetApiResponse(apiResponseType, null, msg);
        }

        [HttpPost, DisableRequestSizeLimit]
        public async Task<ApiResponse> Upload()
        {
            var apiResponseType = ApiResponseType.FAILED;
            var msg = "";
            var fullPath= "/var/mvrs-documents/";
            try
            {
                //var file = Request.Form.Files[0];
                IFormFileCollection files = Request.Form.Files;
                int ApplicationId = int.Parse(Request.Form["ApplicationId"]);
                int DocumentTypeId = int.Parse(Request.Form["DocumentTypeId"]);
                int TotalPages = int.Parse(Request.Form["TotalPages"]);
                var folderName = "/var/mvrs-documents/"; //Path.Combine("var", "mvrs-documents"); //Path.Combine("Attachments", "Scanned_Documents");
                //var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
                var dbPath = folderName;
                
                foreach (var file in files)
                {
                    if (file.Length > 0)
                    {
                        string MIMEType = file.ContentType;
                        string FileExtension = System.IO.Path.GetExtension(file.FileName);
                        var fileName = ApplicationId + "-" + DocumentTypeId + "-" + file.FileName;// ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                        fullPath = "/var/mvrs-documents/" + fileName; //Path.Combine(pathToSave, fileName);
                        dbPath = "/var/mvrs-documents/" + fileName; //Path.Combine(folderName, fileName);
                        using (var stream = new FileStream(fullPath, FileMode.Create))
                        {
                            file.CopyTo(stream);
                        }
                        VehicleDocument vfu = new VehicleDocument();

                        vfu.VehicleDocumentId = ApplicationId;
                        vfu.ApplicationId = ApplicationId;
                        vfu.VehicleDocumentTypeId = DocumentTypeId;
                        vfu.TotalPages = TotalPages;
                        vfu.MIMEType = MIMEType;
                        vfu.FileExtension = FileExtension;
                        vfu.FileName = fileName;
                        vfu.FilePath = dbPath;
                        var rowsAffected = await this.registrationService.SaveVehicleDocumentUploadInfo(vfu);

                        apiResponseType = rowsAffected > 0 ? ApiResponseType.SUCCESS : ApiResponseType.FAILED;
                        msg = rowsAffected > 0 ? Constants.DATA_SAVED_MESSAGE : Constants.DATA_NOT_SAVED_MESSAGE;
                    }
                    else
                    {
                        return ApiResponse.GetApiResponse(apiResponseType, fullPath, "BAD REQUEST"); ;
                    }
                }
                return ApiResponse.GetApiResponse(apiResponseType, fullPath, msg);
                //return Ok(new { dbPath });
            }
            catch (Exception ex)
            {
                return ApiResponse.GetApiResponse(apiResponseType, fullPath, $"Internal server error: {ex}");
            }
        }

        //public async Task<ApiResponse> SaveFileUploadInfo(VehicleDocument vehicleDocument)
        //{
        //    this.registrationService.VwUser = this.User;

        //    var rowsAffected = await this.registrationService.SaveVehicleDocumentUploadInfo(vehicleDocument);

        //    var apiResponseType = rowsAffected > 0 ? ApiResponseType.SUCCESS : ApiResponseType.FAILED;
        //    var msg = rowsAffected > 0 ? Constants.DATA_SAVED_MESSAGE : Constants.DATA_NOT_SAVED_MESSAGE;

        //    return ApiResponse.GetApiResponse(apiResponseType, null, msg);
        //}
    }
}
