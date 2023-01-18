using Authentication.Schemes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SharedLib.Common;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Models.ViewModels.PermitIssuance.Setup;
using Person;
using PermitIssuance;
using UserManagement;

namespace APIGateway.Controllers.Person
{
    [Route("[controller]/[action]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = AuthenticationSchemes.JWT_BEARER_TOKEN_STATELESS)]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService personService;
        private readonly IUserManagement userManagementService;

        public VwEPRSUser User
        {
            get
            {
                return (VwEPRSUser)this.Request.HttpContext.Items["User"];
            }
        }
        public PersonController(IPersonService personService, IUserManagement userManagementService)
        {
            this.personService = personService;
            this.userManagementService = userManagementService;
        }
        #region GET-APIs
        [HttpGet]
        public async Task<ApiResponse> GetPersonInfoByCNIC(string cnic)
        {
            try
            {
                personService.VwEPRSUser = User;
                DataSet resultData = await personService.GetPersonInfoByCNIC(cnic);
                var lstPersonInfo = resultData.Tables[0].ToList<VwEPRSPerson>();

                var apiResponseType = lstPersonInfo != null ? ApiResponseType.SUCCESS : ApiResponseType.NOT_FOUND;
                var msg = lstPersonInfo != null ? Constants.RECORD_FOUND_MESSAGE : Constants.NOT_FOUND_MESSAGE;

                return ApiResponse.GetApiResponse(apiResponseType, lstPersonInfo, msg);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
