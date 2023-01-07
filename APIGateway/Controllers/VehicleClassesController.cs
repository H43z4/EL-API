using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Setup;
using Models.ViewModels.VehicleRegistration.Setup;
using Logging;
using SharedLib.Validation;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIGateway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleClassesController : ControllerBase
    {
        private readonly Setup.IVehicleClassService _service;
        private readonly ILog _logger;


        public VehicleClassesController(Setup.IVehicleClassService service, ILog logger)
        {
            _service = service;
            _logger = logger;
        }

        
        [HttpGet("{id}")]
        public async Task<ApiResponse> Get(int id)
        {
            try
            {
                

                return new ApiResponse()
                {
                    status = ApiResponseType.SUCCESS,
                    message = "Data retrieved successfully.",
                    data = _service.Get(id)
                };
            }
            catch (Exception ex)
            {
                var traceid = Logging.ConfigurationClasses.RequestConfiguration.GetRequestTraceId(this.HttpContext);

                _logger.Log(traceid, ex);
                return new ApiResponse()
                {
                    status = ApiResponseType.EXCEPTION,
                    message = ApiResponseCommons.GetExceptionMessage(ex, traceid),
                    data = _service.GetAll()
                };

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
                return new ApiResponse()
                {
                    status = ApiResponseType.EXCEPTION,
                    message = ApiResponseCommons.GetExceptionMessage(ex, traceid),
                    data = _service.GetAll()
                };

            }

        }


        [HttpPut("{id}")]
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
                return new ApiResponse()
                {
                    status = ApiResponseType.EXCEPTION,
                    message = ApiResponseCommons.GetExceptionMessage(ex, traceid),
                    data = _service.GetAll()
                };

            }
        }

        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            try
            {
                
            }catch(Exception ex)
            {
                throw new NotImplementedException();
            }
        }
    }
}
