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
using Models.ViewModels.PermitIssuance.Core;
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
using PermitIssuance;
using Models.DatabaseModels.epay;
using Models.ViewModels.PermitIssuance.Setup;
using Models.ViewModels.SeriesNumberPool.Core;

namespace APIGateway.Controllers.PermitIssuance
{
    [Route("[controller]/[action]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = AuthenticationSchemes.JWT_BEARER_TOKEN_STATELESS)]
    public class PermitController : ControllerBase
    {
        private readonly IPermitIssuanceService permitIssuanceService;
        private readonly INRTService nrtService;
        private readonly ITOService toService;
        private readonly IUserManagement userManagementService;
        private readonly ILoggingService logger;

        public VwEPRSUser User
        {
            get
            {
                return (VwEPRSUser)this.Request.HttpContext.Items["User"];
            }
        }

        public PermitController(IPermitIssuanceService permitIssuanceService, INRTService nrtService, ITOService toService, IUserManagement userManagementServuce)
        {
            this.permitIssuanceService = permitIssuanceService;
            this.nrtService = nrtService;
            this.toService = toService;
            this.userManagementService = userManagementServuce;
        }

        [HttpPost]
        public async Task<ApiResponse> SavePermit(VwPermitIssueApplication permitApp)
        {

            this.permitIssuanceService.VwEPRSUser = this.User;

            DataSet resultData = await this.permitIssuanceService.SavePermit(permitApp);
            var apiResponseType = ApiResponseType.SUCCESS;
            var msg = Constants.DATA_SAVED_MESSAGE;
            object data;

            if (resultData.Tables.Count > 0 && resultData.Tables[0].Rows[0][0].ToString() != "0")
            {
                apiResponseType = ApiResponseType.SUCCESS;
                msg = Constants.DATA_SAVED_MESSAGE;
                data = new
                {
                    ApplicationId = resultData.Tables[0].Rows[0][0].ToString()
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

        }


        [HttpGet]
        public async Task<ApiResponse> GetPermitList()
        {
            this.permitIssuanceService.VwEPRSUser = this.User;
            DataSet resultData = await this.permitIssuanceService.GetPermitList();
            var schedule = resultData.Tables[0].ToList<VwPermitIssueApplication>();

            var apiResponseType = schedule.Count() > 0 ? ApiResponseType.SUCCESS : ApiResponseType.NOT_FOUND;
            var msg = schedule.Count() > 0 ? Constants.RECORD_FOUND_MESSAGE : Constants.NOT_FOUND_MESSAGE;

            return ApiResponse.GetApiResponse(apiResponseType, schedule, msg);

        }
    }
}
