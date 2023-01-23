using Logging;
using Microsoft.AspNetCore.Mvc;
using Models.ViewModels.PermitIssuance.Setup;
using System.Data;
using System.Threading.Tasks;
using System;
using UserManagement;
using Setup;
using SharedLib.Common;
using Models.ViewModels.Setup;
using Authentication.Schemes;
using Microsoft.AspNetCore.Authorization;

namespace APIGateway.Controllers.SetupControllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = AuthenticationSchemes.JWT_BEARER_TOKEN_STATELESS)]
    public class DropDownController : Controller
    {
        private readonly ILovService listOfValuesService;
        private readonly IUserManagement userManagementService;
        private readonly ILoggingService logger;

        public VwEPRSUser User
        {
            get
            {
                return (VwEPRSUser)this.Request.HttpContext.Items["User"];
            }
        }

        public DropDownController(ILovService listOfValuesService, IUserManagement userManagementServuce)
        {
            this.listOfValuesService = listOfValuesService;
            this.userManagementService = userManagementServuce;
        }

        [HttpGet]
        public async Task<ApiResponse> GetCitiesLOV()
        {
            try
            {
                listOfValuesService.VwEPRSUser = User;
                DataSet resultData = await listOfValuesService.GetCitiesLOV();
                var lst = resultData.Tables[0].ToList<VwLOVs>();

                var apiResponseType = lst != null ? ApiResponseType.SUCCESS : ApiResponseType.NOT_FOUND;
                var msg = lst != null ? Constants.RECORD_FOUND_MESSAGE : Constants.NOT_FOUND_MESSAGE;

                return ApiResponse.GetApiResponse(apiResponseType, lst, msg);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public async Task<ApiResponse> GetCountriesLOV()
        {
            try
            {
                listOfValuesService.VwEPRSUser = User;
                DataSet resultData = await listOfValuesService.GetCountriesLOV();
                var lst = resultData.Tables[0].ToList<VwLOVs>();

                var apiResponseType = lst != null ? ApiResponseType.SUCCESS : ApiResponseType.NOT_FOUND;
                var msg = lst != null ? Constants.RECORD_FOUND_MESSAGE : Constants.NOT_FOUND_MESSAGE;

                return ApiResponse.GetApiResponse(apiResponseType, lst, msg);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public async Task<ApiResponse> GetDistrictsLOV()
        {
            try
            {
                listOfValuesService.VwEPRSUser = User;
                DataSet resultData = await listOfValuesService.GetDistrictsLOV();
                var lst = resultData.Tables[0].ToList<VwLOVs>();

                var apiResponseType = lst != null ? ApiResponseType.SUCCESS : ApiResponseType.NOT_FOUND;
                var msg = lst != null ? Constants.RECORD_FOUND_MESSAGE : Constants.NOT_FOUND_MESSAGE;

                return ApiResponse.GetApiResponse(apiResponseType, lst, msg);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public async Task<ApiResponse> GetManufacturersLOV()
        {
            try
            {
                listOfValuesService.VwEPRSUser = User;
                DataSet resultData = await listOfValuesService.GetManufacturersLOV();
                var lst = resultData.Tables[0].ToList<VwLOVs>();

                var apiResponseType = lst != null ? ApiResponseType.SUCCESS : ApiResponseType.NOT_FOUND;
                var msg = lst != null ? Constants.RECORD_FOUND_MESSAGE : Constants.NOT_FOUND_MESSAGE;

                return ApiResponse.GetApiResponse(apiResponseType, lst, msg);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public async Task<ApiResponse> GetProductsLOV()
        {
            try
            {
                listOfValuesService.VwEPRSUser = User;
                DataSet resultData = await listOfValuesService.GetProductsLOV();
                var lst = resultData.Tables[0].ToList<VwLOVs>();

                var apiResponseType = lst != null ? ApiResponseType.SUCCESS : ApiResponseType.NOT_FOUND;
                var msg = lst != null ? Constants.RECORD_FOUND_MESSAGE : Constants.NOT_FOUND_MESSAGE;

                return ApiResponse.GetApiResponse(apiResponseType, lst, msg);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public async Task<ApiResponse> GetProductUnitsLOV()
        {
            try
            {
                listOfValuesService.VwEPRSUser = User;
                DataSet resultData = await listOfValuesService.GetProductUnitsLOV();
                var lst = resultData.Tables[0].ToList<VwProductUnits>();

                var apiResponseType = lst != null ? ApiResponseType.SUCCESS : ApiResponseType.NOT_FOUND;
                var msg = lst != null ? Constants.RECORD_FOUND_MESSAGE : Constants.NOT_FOUND_MESSAGE;

                return ApiResponse.GetApiResponse(apiResponseType, lst, msg);
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        [HttpGet]
        public async Task<ApiResponse> GetProfessionsLOV()
        {
            try
            {
                listOfValuesService.VwEPRSUser = User;
                DataSet resultData = await listOfValuesService.GetProfessionsLOV();
                var lst = resultData.Tables[0].ToList<VwLOVs>();

                var apiResponseType = lst != null ? ApiResponseType.SUCCESS : ApiResponseType.NOT_FOUND;
                var msg = lst != null ? Constants.RECORD_FOUND_MESSAGE : Constants.NOT_FOUND_MESSAGE;

                return ApiResponse.GetApiResponse(apiResponseType, lst, msg);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
