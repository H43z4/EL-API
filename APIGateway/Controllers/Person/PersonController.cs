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
using Models.ViewModels.PermitIssuance.Core;
using Models.ViewModels.Documents;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

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

                var apiResponseType = lstPersonInfo.Count > 0 ? ApiResponseType.SUCCESS : ApiResponseType.NOT_FOUND;
                var msg = lstPersonInfo.Count > 0 ? Constants.RECORD_FOUND_MESSAGE : Constants.NOT_FOUND_MESSAGE;

                return ApiResponse.GetApiResponse(apiResponseType, lstPersonInfo, msg);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region POST-APIs
        [HttpPost]
        public async Task<ApiResponse> SavePersonDocument(VwPersonDocument personDocument)
        {
            try
            {
                personService.VwEPRSUser = User;

                DataSet resultData = await this.personService.SavePersonDocument(personDocument);
                object data;
                var apiResponseType = ApiResponseType.SUCCESS;
                var msg = Constants.DATA_SAVED_MESSAGE;

                long docId;
                long.TryParse(resultData.Tables[0].Rows[0][0].ToString(), out docId);

                if (resultData.Tables.Count > 0 && docId > 0)
                {
                    apiResponseType = ApiResponseType.SUCCESS;
                    msg = Constants.DATA_SAVED_MESSAGE;
                    data = new
                    {
                        DocumentId = resultData.Tables[0].Rows[0][0].ToString()
                    };

                }
                else
                {
                    apiResponseType = ApiResponseType.FAILED;
                    msg = Constants.DATA_NOT_SAVED_MESSAGE;
                    data = null;
                }

                return ApiResponse.GetApiResponse(apiResponseType, data, msg);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
