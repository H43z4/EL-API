using Authentication.Schemes;
using Logging;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.ViewModels.PermitIssuance.Setup;
using Models.ViewModels.Stock;
using POS;
using SharedLib.Common;
using Stock;
using System.Data;
using System.Threading.Tasks;
using UserManagement;

namespace APIGateway.Controllers.PointOfSale
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = AuthenticationSchemes.JWT_BEARER_TOKEN_STATELESS)]
    public class PointOfSaleController : Controller
    {
        private readonly IUserManagement userManagementService;
        private readonly ILoggingService logger;
        private readonly IPOSService pOSService;
        public PointOfSaleController(IPOSService pOSService, IUserManagement userManagementService, ILoggingService logger)
        {
            this.userManagementService = userManagementService;
            this.pOSService = pOSService;
            this.logger = logger;
        }
        public VwEPRSUser User
        {
            get
            {
                return (VwEPRSUser)this.Request.HttpContext.Items["User"];
            }
        }
        [HttpPost(Name = "SaveVendOrder")]
        public async Task<ApiResponse> SaveVendOrder(VwOrderMain orderMain)
        {

            //this.nrtService.VwUser = this.User;
            this.pOSService.VwEPRSUser = this.User;

            DataSet resultData = await this.pOSService.SaveVendOrder(orderMain);
            var apiResponseType = ApiResponseType.SUCCESS;
            var msg = Constants.DATA_SAVED_MESSAGE;
            object data;

            if (resultData.Tables.Count > 0)
            {
                apiResponseType = ApiResponseType.SUCCESS;
                msg = Constants.DATA_SAVED_MESSAGE;
                data = new
                {
                    OrderId = resultData.Tables[0].Rows[0][0].ToString(),
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
    }
}
