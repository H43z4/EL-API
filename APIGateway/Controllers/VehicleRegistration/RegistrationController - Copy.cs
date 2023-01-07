using Authentication.Schemes;
using Logging;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.ViewModels.Identity;
using Models.ViewModels.VehicleRegistration.Core;
using SharedLib.Common;
using System;
using System.Collections.Generic;
using System.Linq;
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
        private readonly IUserManagement userManagementService;
        private readonly ILoggingService logger;

        public VwUser User
        {
            get
            {
                return (VwUser)this.Request.HttpContext.Items["User"];
            }
            set { }
        }

        public RegistrationController(IRegistrationService registrationService, IUserManagement userManagementServuce, ILoggingService logger)
        {
            this.registrationService = registrationService;
            this.userManagementService = userManagementServuce;
            this.logger = logger;
        }

        [HttpGet(Name = "GetOwnersDropDowns")]
        public async Task<ApiResponse> GetOwnersDropDowns()
        {
            var data = await Task.Factory.StartNew(() => this.registrationService.GetOwnersDropDowns());
            return ApiResponse.GetResponse(ApiResponseType.SUCCESS, data, "success", null);
        }

        [HttpGet(Name = "GetVehiclesDropDowns")]
        public async Task<ApiResponse> GetVehiclesDropDowns()
        {
            var data = await Task.Factory.StartNew(() => this.registrationService.GetVehiclesDropDowns());
            return ApiResponse.GetResponse(ApiResponseType.SUCCESS, data, "success", null);
        }

        [HttpGet(Name = "GetPurchaseDropDowns")]
        public async Task<ApiResponse> GetPurchaseDropDowns()
        {
            var data = this.registrationService.GetPurchaseDropDowns();
            return ApiResponse.GetResponse(ApiResponseType.SUCCESS, data, "success", null);
        }

        [HttpGet(Name = "GetDocumentDropDowns")]
        public async Task<ApiResponse> GetDocumentDropDowns()
        {
            var data = this.registrationService.GetDocumentDropDowns();
            return ApiResponse.GetResponse(ApiResponseType.SUCCESS, data, "success", null);
        }

        [HttpGet(Name = "GetTempApplication")]
        public async Task<ApiResponse> GetTempApplication(long applicationId)
        {
            this.registrationService.VwUser = this.User;

            var vwTempApplication = await Task.Factory.StartNew(() => this.registrationService.GetTempApplicationDetails(applicationId)).Result;

            var data = new
            {
                vwTempApplication.ApplicationId,
                vwTempApplication.ApplicationStatusId,
                vwTempApplication.ReceivedAt,
                vwTempApplication.Owner,
                vwTempApplication.Vehicle,
                vwTempApplication.PurchaseInfo
            };

            return ApiResponse.GetResponse(ApiResponseType.SUCCESS, data, Constants.RECORD_FOUND_MESSAGE, "");
        }

        [HttpGet(Name = "GetRemarks")]
        public async Task<ApiResponse> GetRemarks(long applicationId, int applicationStateId)
        {
            this.registrationService.VwUser = this.User;

            var vwRemarks = await Task.Factory.StartNew(() =>
            {
                return applicationStateId == 0 ? this.registrationService.GetTempRemarks(applicationId) :
                                                 this.registrationService.GetRemarks(applicationId);
            }).Result;

            var data = new
            {
                remarks = vwRemarks
            };

            return ApiResponse.GetResponse(ApiResponseType.SUCCESS, data, Constants.RECORD_FOUND_MESSAGE, null);
        }

        [HttpGet(Name = "GetOwnerByCNIC")]
        public async Task<ApiResponse> GetOwnerByCNIC(string cnic)
        {
            var data = this.registrationService.GetPersonByCNIC(cnic);
            return ApiResponse.GetResponse(ApiResponseType.SUCCESS, data, Constants.RECORD_FOUND_MESSAGE, null);
        }

        [HttpGet(Name = "GetBusinessByTaxNumber")]
        public async Task<ApiResponse> GetBusinessByTaxNumber(string ntn, string ftn, string stn)
        {
            var businessProfile = this.registrationService.GetBusinessByTaxNumber(ntn, ftn, stn).Result;

            var data = new { businessProfile };

            return ApiResponse.GetResponse(ApiResponseType.SUCCESS, data, Constants.RECORD_FOUND_MESSAGE, null);
        }

        [HttpPost]
        public async Task<ApiResponse> SaveOwner(VwTempOwner_v1 owner)
        {
            this.registrationService.VwUser = this.User;

            if (owner.ApplicationStateId == 0)
            {
                var vwTempApplication = await Task.Factory.StartNew(() => this.registrationService.SaveTempOwner(owner)).Result;

                var data = new
                {
                    vwTempApplication.ApplicationId,
                    vwTempApplication.ReceivedAt,
                    vwTempApplication.Owner.Persons?.FirstOrDefault().PersonId,
                    vwTempApplication.Owner.Business?.BusinessId
                };

                return ApiResponse.GetResponse(ApiResponseType.SUCCESS, data, Constants.DATA_SAVED_MESSAGE, string.Empty);
            }
            else
            {
                //var vwOwner = await Task.Factory.StartNew(() => this.registrationService.SaveOwner(owner)).Result;

                var data = new
                {
                    //vwOwner.OwnerId
                };

                return ApiResponse.GetResponse(ApiResponseType.SUCCESS, data, Constants.DATA_SAVED_MESSAGE, string.Empty);
            }
        }

        [HttpPost]
        public async Task<ApiResponse> SaveVehicle(VwVehicle vehicle)
        {
            this.registrationService.VwUser = this.User;

            var vwVehicle = await Task.Factory.StartNew(() =>
            {
                return vehicle.ApplicationStateId == 0 ? this.registrationService.SaveTempVehicle(vehicle) :
                                                 this.registrationService.SaveVehicle(vehicle);
            }).Result;

            var data = new
            {
                vwVehicle.VehicleId
            };

            return ApiResponse.GetResponse(ApiResponseType.SUCCESS, data, Constants.DATA_SAVED_MESSAGE, string.Empty);
        }

        [HttpPost]
        public async Task<ApiResponse> SaveVehiclePurchaseInfo(VwVehiclePurchaseInfo vehiclePurchaseInfo)
        {
            this.registrationService.VwUser = this.User;

            var vwVehiclePurchaseInfo = await Task.Factory.StartNew(() =>
            {
                return vehiclePurchaseInfo.ApplicationStateId == 0 ? this.registrationService.SaveTempVehiclePurchaseInfo(vehiclePurchaseInfo) :
                                                 this.registrationService.SaveVehiclePurchaseInfo(vehiclePurchaseInfo);
            }).Result;

            var data = new
            {
                vwVehiclePurchaseInfo.LocalPurchaseInfo?.LocalPurchaseInfoId,
                vwVehiclePurchaseInfo.ImportInfo?.ImportInfoId,
                vwVehiclePurchaseInfo.AuctionInfo?.AuctionInfoId
            };

            return ApiResponse.GetResponse(ApiResponseType.SUCCESS, data, Constants.DATA_SAVED_MESSAGE, string.Empty);
        }

        [HttpPost]
        public async Task<ApiResponse> SaveRemarks(VwRemarks remarks)
        {
            var roles = this.userManagementService.GetUserRoles(this.User.UserId);
            this.User.UserRoles = roles;
            this.registrationService.VwUser = this.User;

            var vwRemarks = await Task.Factory.StartNew(() =>
            {
                return remarks.ApplicationStateId == 0 ? this.registrationService.SaveTempRemarks(remarks) :
                                                 this.registrationService.SaveRemarks(remarks);
            }).Result;

            var data = new
            {
                vwRemarks.RemarksId
            };

            return ApiResponse.GetResponse(ApiResponseType.SUCCESS, data, Constants.DATA_SAVED_MESSAGE, string.Empty);
        }

        [HttpPost]
        public async Task<ApiResponse> SaveVehicleDocuments(VwVehicleDocument vwVehicleDocument)
        {
            this.registrationService.VwUser = this.User;

            var vwRemarks = await Task.Factory.StartNew(() =>
            {
                return vwVehicleDocument.ApplicationStateId == 0 ? this.registrationService.SaveTempVehicleDocument(vwVehicleDocument) :
                                                 this.registrationService.SaveVehicleDocument(vwVehicleDocument);
            }).Result;

            var data = new
            {
            };

            return ApiResponse.GetResponse(ApiResponseType.SUCCESS, data, Constants.DATA_SAVED_MESSAGE, string.Empty);
        }
        
        [HttpPost]
        public async Task<ApiResponse> SaveHPA(VwTempHPA vwTempHPA)
        {
            this.registrationService.VwUser = this.User;

            var vwRemarks = await Task.Factory.StartNew(() =>
            {
                return vwTempHPA.ApplicationStateId == 0 ? this.registrationService.SaveTempHPA(vwTempHPA) :
                                                 this.registrationService.SaveHPA(vwTempHPA);
            }).Result;

            var data = new
            {
                vwRemarks
            };

            return ApiResponse.GetResponse(ApiResponseType.SUCCESS, data, Constants.DATA_SAVED_MESSAGE, string.Empty);
        }

        [HttpPost]
        public async Task<ApiResponse> SaveKeeper(VwTempKeeper vwTempKeeper)
        {
            this.registrationService.VwUser = this.User;

            var vwRemarks = await Task.Factory.StartNew(() =>
            {
                return vwTempKeeper.ApplicationStateId == 0 ? this.registrationService.SaveTempKeeper(vwTempKeeper) :
                                                 this.registrationService.SaveKeeper(vwTempKeeper);
            }).Result;

            var data = new
            {
                vwRemarks
            };

            return ApiResponse.GetResponse(ApiResponseType.SUCCESS, data, Constants.DATA_SAVED_MESSAGE, string.Empty);
        }

    }
}
