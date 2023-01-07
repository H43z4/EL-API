using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Authentication.Schemes;
using Microsoft.AspNetCore.Authorization;

using Setup;
using Models.ViewModels.VehicleRegistration.Setup;
using Models.DatabaseModels.VehicleRegistration.Setup;
using Logging;
using SharedLib.Validation;

namespace APIGateway.Controllers.SetupControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = AuthenticationSchemes.JWT_BEARER_TOKEN)]
    public class VehicleUsageController : ControllerBase
    {
        private readonly Setup.ISetupservice<VehicleUsage> _service;
        private readonly ILog _logger;


        public VehicleUsageController(Setup.ISetupservice<VehicleUsage> service, ILog logger)
        {
            _service = service;
            _logger = logger;
        }


        [HttpGet]
        public async Task<ApiResponse> Get(int id)
        {
            try
            {
                //return null;// _service.GetAll();

                return ApiResponse.GetResponse(ApiResponseType.SUCCESS, _service.Get(id), "success", null);
            }
            catch (Exception ex)
            {
                var traceid = Logging.ConfigurationClasses.RequestConfiguration.GetRequestTraceId(this.HttpContext);

                _logger.Log(traceid, ex);
                return ApiResponse.GetExceptionResponse(ApiResponseType.EXCEPTION, null, null, null, ex, traceid);

            }
        }

        [HttpGet]
        public async Task<ApiResponse> GetAll(int recs_per_page, int page_no)
        {
            try
            {

                var data = _service.GetAll(null, null, null, page_no, recs_per_page);
                return ApiResponse.GetResponse(ApiResponseType.SUCCESS, data, "success", null);
            }
            catch (Exception ex)
            {
                var traceid = Logging.ConfigurationClasses.RequestConfiguration.GetRequestTraceId(this.HttpContext);

                _logger.Log(traceid, ex);
                return ApiResponse.GetExceptionResponse(ApiResponseType.EXCEPTION, null, null, null, ex, traceid);

            }
        }

        [HttpPost]
        public async Task<ApiResponse> Post(vwSetup setup)
        {
            try
            {
                //return null;// _service.GetAll();

                #region ValidateModel
                ValidationErrorResponse result = null;
                if (!ModelValidator.TryValidate(setup, out result))
                {
                    return ApiResponse.GetValidationErrorResponse(ApiResponseType.VALIDATION_ERROR, null, null,null, result);
                }
                #endregion

                _service.AddSetup(setup);

                return ApiResponse.GetResponse(ApiResponseType.SUCCESS, setup, "Data Saved successfully", "");
            }
            catch (Exception ex)
            {
                var traceid = Logging.ConfigurationClasses.RequestConfiguration.GetRequestTraceId(this.HttpContext);

                _logger.Log(traceid, ex);
                return ApiResponse.GetExceptionResponse(ApiResponseType.EXCEPTION, null, null, null, ex, traceid);

            }

        }


        [HttpPut]
        public async Task<ApiResponse> Put(vwSetup setup)
        {
            try
            {
                //return null;// _service.GetAll();

                                #region ValidateModel
                ValidationErrorResponse result = null;
                if (!ModelValidator.TryValidate(setup, out result))
                {
                    return ApiResponse.GetValidationErrorResponse(ApiResponseType.VALIDATION_ERROR, null, null, null, result);
                }
                #endregion

	_service.UpdateSetup(setup);

return ApiResponse.GetResponse(ApiResponseType.SUCCESS, setup, "Updated Successfully.", "");
            }
            catch (Exception ex)
            {
                var traceid = Logging.ConfigurationClasses.RequestConfiguration.GetRequestTraceId(this.HttpContext);

                _logger.Log(traceid, ex);
                return ApiResponse.GetExceptionResponse(ApiResponseType.EXCEPTION, null, null, null, ex, traceid);

            }
        }


        [HttpDelete]
        public async Task<ApiResponse> Delete(int id)
        {
            try
            {
                _service.DeleteSetup(id);
                return ApiResponse.GetResponse(ApiResponseType.SUCCESS, null, "Deleted Successfully.", "");
            }
            catch (Exception ex)
            {
                var traceid = Logging.ConfigurationClasses.RequestConfiguration.GetRequestTraceId(this.HttpContext);

                _logger.Log(traceid, ex);
                return ApiResponse.GetExceptionResponse(ApiResponseType.EXCEPTION, null, null, null, ex, traceid);
            }
        }

    }

}

