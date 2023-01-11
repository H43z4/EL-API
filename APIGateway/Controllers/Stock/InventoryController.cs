using Authentication.Schemes;
using Logging;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.ViewModels.Identity;
using Models.ViewModels.PermitIssuance.Setup;
using Models.ViewModels.Stock;
using Models.ViewModels.VehicleRegistration.Core;
using PermitIssuance;
using SharedLib.Common;
using Stock;
using System.Data;
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

        //[HttpGet]
        //public async Task<ApiResponse> GetStockInApplicationList()
        //{
        //    DataSet resultData = await inventoryService.GetStockInApplicationList();
        //    var apiResponseType = ApiResponseType.SUCCESS;
        //    var msg = Constants.RECORD_FOUND_MESSAGE;
        //    object data;

        //    if (resultData.Tables.Count > 0 && resultData.Tables[0].Rows[0][0].ToString() != "0")
        //    {
        //        apiResponseType = ApiResponseType.SUCCESS;
        //        msg = Constants.RECORD_FOUND_MESSAGE;
        //        data = resultData;
        //    }
        //    else
        //    {
        //        apiResponseType = ApiResponseType.FAILED;
        //        msg = Constants.NOT_FOUND_MESSAGE;
        //        data = null;
        //    }

        //    return ApiResponse.GetApiResponse(apiResponseType, data, msg);
        //}

        //[HttpGet]
        //public async Task<ApiResponse> GetStockInApplicationListById(int id)
        //{
        //    DataSet resultData = await inventoryService.GetStockInApplicationListById(id);
        //    var apiResponseType = ApiResponseType.SUCCESS;
        //    var msg = Constants.RECORD_FOUND_MESSAGE;
        //    object data;

        //    if (resultData.Tables.Count > 0 && resultData.Tables[0].Rows[0][0].ToString() != "0")
        //    {
        //        apiResponseType = ApiResponseType.SUCCESS;
        //        msg = Constants.RECORD_FOUND_MESSAGE;
        //        data = resultData;
        //    }
        //    else
        //    {
        //        apiResponseType = ApiResponseType.FAILED;
        //        msg = Constants.NOT_FOUND_MESSAGE;
        //        data = null;
        //    }

        //    return ApiResponse.GetApiResponse(apiResponseType, data, msg);
        //} 
        #endregion
    }
}
