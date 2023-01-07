using Authentication.Schemes;
using Admin;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.ViewModels.Identity;
using SharedLib.Common;
using System.Linq;
using System.Threading.Tasks;
using Models.ViewModels.VehicleRegistration.Core;
using AMQPSvc;

namespace APIGateway.Controllers.Admin
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = AuthenticationSchemes.JWT_BEARER_TOKEN_STATELESS)]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService adminService;
        private readonly IMessageProducer messageProducer;

        public VwUser User
        {
            get
            {
                return (VwUser)this.Request.HttpContext.Items["User"];
            }
        }

        public AdminController(IAdminService adminService, IMessageProducer messageProducer)
        {
            this.adminService = adminService;
            this.messageProducer = messageProducer;
        }


        [HttpGet(Name = "GetPerson")]
        public async Task<ApiResponse> GetPerson(long? personId, string cnic)
        {
            var ds = await this.adminService.GetPerson(personId, cnic);

            var person = ds.Tables[0].ToList<VwPerson>().FirstOrDefault();

            if (person is not null)
            {
                person.Addresses = ds.Tables[1].ToList<VwAddress>();
                person.PhoneNumbers = ds.Tables[2].ToList<VwPhoneNumber>();
            }

            var apiResponseType = person is not null ? ApiResponseType.SUCCESS : ApiResponseType.FAILED;
            var msg = person is not null ? Constants.RECORD_FOUND_MESSAGE : Constants.NOT_FOUND_MESSAGE;

            return ApiResponse.GetApiResponse(apiResponseType, person, msg);
        }

        [HttpGet(Name = "GetBusiness")]
        public async Task<ApiResponse> GetBusiness(long? businessId, string ntn, string ftn, string stn)
        {
            var ds = await this.adminService.GetBusiness(businessId, ntn, ftn, stn);

            var businessProfile = ds.Tables[0].ToList<VwBusiness>().FirstOrDefault();

            if (businessProfile is not null)
            {
                businessProfile.Addresses = ds.Tables[1].ToList<VwAddress>();
                businessProfile.PhoneNumbers = ds.Tables[2].ToList<VwPhoneNumber>();
            }

            var apiResponseType = businessProfile is not null ? ApiResponseType.SUCCESS : ApiResponseType.FAILED;
            var msg = businessProfile is not null ? Constants.RECORD_FOUND_MESSAGE : Constants.NOT_FOUND_MESSAGE;

            return ApiResponse.GetApiResponse(apiResponseType, businessProfile, msg);
        }

        [HttpPost]
        public async Task<ApiResponse> ApproveBusiness(VwBusinessOwner businessOwner)
        {
            this.adminService.VwUser = this.User;

            //var rowsAffected = await this.adminService.ApproveBusiness(businessOwner);

            //var apiResponseType = rowsAffected > 0 ? ApiResponseType.SUCCESS : ApiResponseType.FAILED;
            //var msg = rowsAffected > 0 ? Constants.DATA_SAVED_MESSAGE : Constants.DATA_NOT_SAVED_MESSAGE;

            //if (rowsAffected > 0)
            //{
            //    await this.messageProducer.SendMessage<VwBusinessOwner>(businessOwner, "CH-BIOMETRIC", "Q-BIO-BUSINESS");
            //}

            //return ApiResponse.GetApiResponse(apiResponseType, null, msg);
         
            await this.messageProducer.SendMessage<VwBusinessOwner>(businessOwner, "CH-BIOMETRIC", "Q-BIO-BUSINESS");
            return ApiResponse.GetApiResponse(ApiResponseType.SUCCESS, null, Constants.DATA_SAVED_MESSAGE);
        }

        [HttpPost]
        public async Task<ApiResponse> SaveBusiness(VwBusiness business)
        {
            this.adminService.VwUser = this.User;

            var rowsAffected = await this.adminService.SaveBusiness(business);

            var apiResponseType = rowsAffected > 0 ? ApiResponseType.SUCCESS : ApiResponseType.FAILED;
            var msg = rowsAffected > 0 ? Constants.DATA_SAVED_MESSAGE : Constants.DATA_NOT_SAVED_MESSAGE;

            if (rowsAffected > 0)
            {
                await this.messageProducer.SendMessage<VwBusiness>(business, "CH-BIOMETRIC", "Q-BIO-BUSINESS");
            }

            return ApiResponse.GetApiResponse(apiResponseType, null, msg);
        }

        [HttpPost]
        public async Task<ApiResponse> SaveBusinessRep(VwBusinessRep vwBusinessRep)
        {
            this.adminService.VwUser = this.User;

            var rowsAffected = await this.adminService.SaveBusinessRep(vwBusinessRep);

            var apiResponseType = rowsAffected > 0 ? ApiResponseType.SUCCESS : ApiResponseType.FAILED;
            var msg = rowsAffected > 0 ? Constants.DATA_SAVED_MESSAGE : Constants.DATA_NOT_SAVED_MESSAGE;
            
            if (rowsAffected > 0)
            {
                await this.messageProducer.SendMessage<VwBusinessRep>(vwBusinessRep, "CH-BIOMETRIC", "Q-BIO-BUSINESS-REP");
            }

            return ApiResponse.GetApiResponse(apiResponseType, null, msg);
        }
    }
}
