using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Authentication.Schemes;
using Microsoft.AspNetCore.Authorization;

using VehicleRegistration;
using Models.ViewModels.VehicleRegistration.Core;
using Models.DatabaseModels.VehicleRegistration.Core;
using Logging;
using SharedLib.Validation;

namespace APIGateway.Controllers.SetupControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = AuthenticationSchemes.JWT_BEARER_TOKEN)]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleService _service;
        private readonly ILog _logger;

        
        public VehicleController(IVehicleService service, ILog logger)
        {
            _service = service;
            _logger = logger;
            _service.ProcessBy = 1; //APIGateway.Common.ClsCommon.GetCurrentUserId(this);

            //var context = this.HttpContext;
            
        }


        [HttpGet]
        public async Task<ApiResponse> Get(int id)
        {
            try
            {
                var data = _service.Get(id);

                return ApiResponse.GetResponse(ApiResponseType.SUCCESS, data, "success", null);
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

        

        [HttpGet]
        public async Task<ApiResponse> GetDropDowns()
        {
            try
            {

                var data = await _service.GetVehiclesDropDowns();
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
        public async Task<ApiResponse> Post(ICollection<VwVehicle> vehicles)
        {
            try
            {
                #region ValidateModel
                foreach (var vehicle in vehicles)
                {
                    ValidationErrorResponse result = null;

                    if (!ModelValidator.TryValidate(vehicle, out result))
                    {
                        return ApiResponse.GetValidationErrorResponse(ApiResponseType.VALIDATION_ERROR, null, null, null, result);
                    }
                }
                #endregion

                _service.AddVehicle(vehicles);

                return ApiResponse.GetResponse(ApiResponseType.SUCCESS, vehicles, "Data Saved successfully", "");
            }
            catch (Exception ex)
            {
                var traceid = Logging.ConfigurationClasses.RequestConfiguration.GetRequestTraceId(this.HttpContext);

                _logger.Log(traceid, ex);
                return ApiResponse.GetExceptionResponse(ApiResponseType.EXCEPTION, null,null,null, ex,traceid);
            }

        }


        [HttpPut]
        public async Task<ApiResponse> Put(ICollection<VwVehicle> vehicles)
        {
            try
            {

                #region ValidateModel
                foreach (var vehicle in vehicles)
                {
                    ValidationErrorResponse result = null;

                    if (!ModelValidator.TryValidate(vehicle, out result))
                    {
                        return ApiResponse.GetValidationErrorResponse(ApiResponseType.VALIDATION_ERROR, null, null, null, result);
                    }
                }
                #endregion

                _service.UpdateVehicle(vehicles);

                return ApiResponse.GetResponse(ApiResponseType.SUCCESS, vehicles, "Updated Successfully.", "");

            }
            catch (Exception ex)
            {
                var traceid = Logging.ConfigurationClasses.RequestConfiguration.GetRequestTraceId(this.HttpContext);

                _logger.Log(traceid, ex);
                return ApiResponse.GetExceptionResponse(ApiResponseType.EXCEPTION, null, null, null, ex, traceid);
            }
        }


        [HttpDelete]
        public async Task<ApiResponse> Delete(long[] ids)
        {
            try
            {
                _service.RemoveVehicle(ids);
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

