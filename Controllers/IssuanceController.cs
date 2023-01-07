using Issuance.Services;
using Issuance.ViewModels.IssuanceCertificateViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.ViewModels.Identity;
using Representative.Services;
using Representative.ViewModels;
using SharedLib.APIs;
using SharedLib.Common;
using SharedLib.Security;

namespace Issuance.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = AuthenticationSchemes.JWT_BEARER_TOKEN_STATELESS)]
    public class IssuanceController : ControllerBase
    {
        private readonly IIssuanceService issuanceService;
        public VwUser User
        {
            get
            {
                return (VwUser)this.Request.HttpContext.Items["User"];
            }
        }

        public IssuanceController(IIssuanceService issuanceService)
        {
            this.issuanceService = issuanceService;
        }
        [HttpGet(Name = "GetApplicationsbyRegNo")]
        public async Task<ApiResponse> GetApplicationsbyRegNo(string registrationNo)
        {
            this.issuanceService.VwUser = this.User;

            var ds = await this.issuanceService.GetApplicationsByRegNo(registrationNo);

            if (ds.Tables[0].Rows.Count == 0)
            {
                return ApiResponse.GetApiResponse(ApiResponseType.FAILED, null, Constants.NOT_FOUND_MESSAGE);
            }

            var data = ds.Tables[0].ToList<IssuanceCertificate>();

            return ApiResponse.GetApiResponse(ApiResponseType.SUCCESS, data, Constants.RECORD_FOUND_MESSAGE);
        }


    }
}
