using Authentication.Schemes;
using Logging;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
//using Models.DatabaseModels.VehicleRegistration.Core;
//using Models.DatabaseModels.VehicleRegistration.Setup;
using Models.ViewModels.Identity;
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
using PermitIssuance;
//using Models.DatabaseModels.epay;
using Models.ViewModels.PermitIssuance.Setup;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

namespace APIGateway.Controllers.PermitIssuance
{
    [Route("[controller]/[action]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = AuthenticationSchemes.JWT_BEARER_TOKEN_STATELESS)]
    public class PermitController : ControllerBase
    {
        private readonly IPermitIssuanceService permitIssuanceService;
        private readonly IUserManagement userManagementService;
        private readonly ILoggingService logger;

        public VwEPRSUser User
        {
            get
            {
                return (VwEPRSUser)this.Request.HttpContext.Items["User"];
            }
        }

        public PermitController(IPermitIssuanceService permitIssuanceService, IUserManagement userManagementServuce)
        {
            this.permitIssuanceService = permitIssuanceService;
            this.userManagementService = userManagementServuce;
        }

        #region GET-APIs
        [HttpGet]
        public async Task<ApiResponse> GetPermitList(int? hours = null)
        {
            try
            {   
                permitIssuanceService.VwEPRSUser = User;
                DataSet resultData = await permitIssuanceService.GetPermitList();
                var lstPermitApplications = resultData.Tables[0].ToList<VwPermitIssueApplication>();
                if (lstPermitApplications.Count > 0)
                {
                    foreach (var item in lstPermitApplications)
                    {
                        DateTime date1 = item.CreatedAt;
                        DateTime date2 = DateTime.Now;
                        TimeSpan diff = date2 - date1;
                        double diffHours = diff.TotalHours;
                        
                        if (diffHours < 24)
                        {
                            item.RowTimeline = "less24";

                            // inputField.classList.add("less24");
                        }
                        else if (diffHours > 24 && diffHours < 48)
                        {
                            item.RowTimeline = "hours24";

                            // inputField.classList.add("hours24");
                        }
                        else if (diffHours > 24 && diffHours > 48 && diffHours < 72)
                        {
                            item.RowTimeline = "hours48";

                            // inputField.classList.add("hours48");
                        }
                        else
                        {
                            item.RowTimeline = "hours72";

                            // inputField.classList.add("hours72");
                        }
                    }
                }
                var apiResponseType = lstPermitApplications != null ? ApiResponseType.SUCCESS : ApiResponseType.NOT_FOUND;
                var msg = lstPermitApplications != null ? Constants.RECORD_FOUND_MESSAGE : Constants.NOT_FOUND_MESSAGE;

                return ApiResponse.GetApiResponse(apiResponseType, lstPermitApplications, msg);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public async Task<ApiResponse> GetPermitApplicationListById(int id)
        {
            try
            {
                permitIssuanceService.VwEPRSUser = User;
                DataSet resultData = await permitIssuanceService.GetPermitApplicationListById(id);
                var lstPermitApplication = resultData.Tables[0].ToList<VwPermitIssueApplication>();

                var apiResponseType = lstPermitApplication != null ? ApiResponseType.SUCCESS : ApiResponseType.FAILED;
                var msg = lstPermitApplication != null ? Constants.RECORD_FOUND_MESSAGE : Constants.NOT_FOUND_MESSAGE;

                return ApiResponse.GetApiResponse(apiResponseType, lstPermitApplication, msg);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region POST-APIs
        [HttpPost]
        public async Task<ApiResponse> SavePermit(VwPermitIssueApplication permitApp)
        {

            this.permitIssuanceService.VwEPRSUser = this.User;

            DataSet resultData = await this.permitIssuanceService.SavePermit(permitApp);
            var apiResponseType = ApiResponseType.SUCCESS;
            var msg = Constants.DATA_SAVED_MESSAGE;
            object data;

            if (resultData.Tables.Count > 0)
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
        #endregion
    }
}
