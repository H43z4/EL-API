using Authentication.Schemes;
using Logging;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Models.ViewModels.PermitIssuance.Setup;
using Models.ViewModels.Stock;
using SharedLib.Common;
using Stock;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using UserManagement;

namespace APIGateway.Controllers.Stock
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = AuthenticationSchemes.JWT_BEARER_TOKEN_STATELESS)]
    public class InventoryController : Controller
    {
        private readonly IInventoryService inventoryService;
        private readonly IUserManagement userManagementService;
        private readonly ILoggingService logger;

        public InventoryController(IInventoryService inventoryService, IUserManagement userManagementService, ILoggingService logger)
        {
            this.inventoryService = inventoryService;
            this.userManagementService = userManagementService;
            this.logger = logger;
        }
        public VwEPRSUser User
        {
            get
            {
                return (VwEPRSUser)this.Request.HttpContext.Items["User"];
            }
        }
        #region POST-APIs
        [HttpPost(Name = "SaveConsignment")]
        public async Task<ApiResponse> SaveConsignment(VwInventory inventory)
        {

            //this.nrtService.VwUser = this.User;
            this.inventoryService.VwEPRSUser = this.User;

            DataSet resultData = await this.inventoryService.SaveConsignment(inventory);
            var apiResponseType = ApiResponseType.SUCCESS;
            var msg = Constants.DATA_SAVED_MESSAGE;
            object data;

            if (resultData.Tables.Count > 0)
            {
                apiResponseType = ApiResponseType.SUCCESS;
                msg = Constants.DATA_SAVED_MESSAGE;
                data = new
                {
                    ConsignmentId = resultData.Tables[0].Rows[0][0].ToString(),
                };

            }
            else
            {
                apiResponseType = ApiResponseType.FAILED;
                msg = Constants.DATA_NOT_SAVED_MESSAGE + resultData.Tables[0].Rows[0][1].ToString();
                data = null;
            }
            return ApiResponse.GetApiResponse(apiResponseType, data, msg);
        }
        #endregion

        #region GET-APIs

        [HttpGet]
        public async Task<ApiResponse> GetStockInApplicationList()
        {
            try
            {
                inventoryService.VwEPRSUser = User;
                DataSet resultData = await inventoryService.GetStockInApplicationList();
                var lstStockInApplications = resultData.Tables[0].ToList<VwInventory>();

                var apiResponseType = lstStockInApplications != null ? ApiResponseType.SUCCESS : ApiResponseType.NOT_FOUND;
                var msg = lstStockInApplications != null ? Constants.RECORD_FOUND_MESSAGE : Constants.NOT_FOUND_MESSAGE;

                return ApiResponse.GetApiResponse(apiResponseType, lstStockInApplications, msg);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public async Task<ApiResponse> GetStockInApplicationListById(int id)
        {
            try
            {
                inventoryService.VwEPRSUser = User;
                DataSet resultData = await inventoryService.GetStockInApplicationListById(id);
                var lstStockInApplication = resultData.Tables[0].ToList<VwInventory>().FirstOrDefault();
                if (lstStockInApplication != null)
                {
                    lstStockInApplication.items = resultData.Tables[1].ToList<VwInventoryItems>();
                }
                var apiResponseType = lstStockInApplication != null ? ApiResponseType.SUCCESS : ApiResponseType.NOT_FOUND;
                var msg = lstStockInApplication != null ? Constants.RECORD_FOUND_MESSAGE : Constants.NOT_FOUND_MESSAGE;

                return ApiResponse.GetApiResponse(apiResponseType, lstStockInApplication, msg);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public async Task<ApiResponse> GetProductList()
        {
            try
            {
                inventoryService.VwEPRSUser = User;
                DataSet resultData = await inventoryService.GetProductList();
                var lstProductList = resultData.Tables[0].ToList<VwProductList>();

                var apiResponseType = lstProductList != null ? ApiResponseType.SUCCESS : ApiResponseType.NOT_FOUND;
                var msg = lstProductList != null ? Constants.RECORD_FOUND_MESSAGE : Constants.NOT_FOUND_MESSAGE;

                return ApiResponse.GetApiResponse(apiResponseType, lstProductList, msg);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //[HttpGet]
        //public async Task<ApiResponse> GetPersonInfoByCNIC(string cnic)
        //{
        //    try
        //    {
        //        inventoryService.VwEPRSUser = User;
        //        DataSet resultData = await inventoryService.GetPersonInfoByCNIC(cnic);
        //        var lstPersonInfo = resultData.Tables[0].ToList<VwEPRSPerson>();

        //        var apiResponseType = lstPersonInfo != null ? ApiResponseType.SUCCESS : ApiResponseType.NOT_FOUND;
        //        var msg = lstPersonInfo != null ? Constants.RECORD_FOUND_MESSAGE : Constants.NOT_FOUND_MESSAGE;

        //        return ApiResponse.GetApiResponse(apiResponseType, lstPersonInfo, msg);
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
        #endregion
    }
}
