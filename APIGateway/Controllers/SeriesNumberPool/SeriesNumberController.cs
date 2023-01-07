using Authentication.Schemes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.ViewModels.Identity;
using Models.ViewModels.SeriesNumberPool;
using Models.ViewModels.SeriesNumberPool.Core;
using SeriesNumberPool;
using SharedLib.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIGateway.Controllers.SeriesNumberPool
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = AuthenticationSchemes.JWT_BEARER_TOKEN_STATELESS)]
    public class SeriesNumberController : ControllerBase
    {
        private readonly ISeriesNumberPoolService seriesNumberPoolService;

        public VwUser User
        {
            get
            {
                return (VwUser)this.Request.HttpContext.Items["User"];
            }
        }

        public SeriesNumberController(ISeriesNumberPoolService seriesNumberPoolService)
        {
            this.seriesNumberPoolService = seriesNumberPoolService;
        }

        [HttpGet(Name = "GetAuctionSchedule")]
        public async Task<ApiResponse> GetAuctionSchedule()
        {
            this.seriesNumberPoolService.VwUser = this.User;

            var ds = await this.seriesNumberPoolService.GetAuctionSchedule();

            var schedule = ds.Tables[0].ToList<VwAuctionSchedule>();

            var apiResponseType = schedule.Count() > 0 ? ApiResponseType.SUCCESS : ApiResponseType.NOT_FOUND;
            var msg = schedule.Count() > 0 ? Constants.RECORD_FOUND_MESSAGE : Constants.NOT_FOUND_MESSAGE;

            return ApiResponse.GetApiResponse(apiResponseType, schedule, msg);
        }
        
        [HttpGet(Name = "GetAuctionNumbers")]
        public async Task<ApiResponse> GetAuctionNumbers(long seriesCategoryId, long seriesId)
        {
            this.seriesNumberPoolService.VwUser = this.User;

            var ds = await this.seriesNumberPoolService.GetAuctionNumbers(seriesCategoryId, seriesId);

            var auctionNumbers = ds.Tables[0].ToList<VwAuctionNumber>();

            var apiResponseType = auctionNumbers.Count() > 0 ? ApiResponseType.SUCCESS : ApiResponseType.NOT_FOUND;
            var msg = auctionNumbers.Count() > 0 ? Constants.RECORD_FOUND_MESSAGE : Constants.NOT_FOUND_MESSAGE;

            return ApiResponse.GetApiResponse(apiResponseType, auctionNumbers, msg);
        }

        [HttpGet(Name = "GetSeriesCount")]
        public async Task<ApiResponse> GetSeriesCount(int seriesCategoryId)
        {
            var ds = await this.seriesNumberPoolService.GetAuctionScheduleSeriesCount(seriesCategoryId);

            
            var SeriesRecordCount = ds.Tables[0].Rows[0][0].ToString();
            var apiResponseType = Convert.ToInt32(SeriesRecordCount) > 0 ? ApiResponseType.SUCCESS : ApiResponseType.FAILED;
            var msg = Convert.ToInt32(SeriesRecordCount) > 0 ? Constants.RECORD_FOUND_MESSAGE : Constants.NOT_FOUND_MESSAGE;


            return ApiResponse.GetApiResponse(apiResponseType, SeriesRecordCount, msg);
        }

        [HttpGet(Name = "GetAuctionScheduleSeries")]
        public async Task<ApiResponse> GetAuctionScheduleSeries(int seriesCategoryId, int pageNo, int RecordsCount)
        {
            var ds = await this.seriesNumberPoolService.GetAuctionScheduleSeries(seriesCategoryId, pageNo, RecordsCount);

            var series = ds.Tables[0].ToList<VwSeries>();

            var apiResponseType = series.Count > 0 ? ApiResponseType.SUCCESS : ApiResponseType.FAILED;
            var msg = series.Count > 0 ? Constants.RECORD_FOUND_MESSAGE : Constants.NOT_FOUND_MESSAGE;


            return ApiResponse.GetApiResponse(apiResponseType, series, msg);
        }

        [HttpGet(Name = "GetSeriesCategoriesDropDowns")]
        public async Task<ApiResponse> GetSeriesCategoriesDropDowns()
        {
            var ds = await this.seriesNumberPoolService.GetSeriesCategoryDropDowns();

            var data = new
            {
                SeriesCategories = ds.Tables[0],
            };

            return ApiResponse.GetResponse(ApiResponseType.SUCCESS, data, Constants.RECORD_FOUND_MESSAGE, null);
        }

        [HttpGet(Name = "GetDistrictsDropDowns")]
        public async Task<ApiResponse> GetDistrictsDropDowns()
        {
            var ds = await this.seriesNumberPoolService.GetDistrictsDropDowns();

            var data = new
            {
                Districts = ds.Tables[0],
            };

            return ApiResponse.GetResponse(ApiResponseType.SUCCESS, data, Constants.RECORD_FOUND_MESSAGE, null);
        }

        [HttpGet(Name = "GetSeriesConsumerDropDowns")]
        public async Task<ApiResponse> GetSeriesConsumerDropDowns()
        {
            var ds = await this.seriesNumberPoolService.GetSeriesConsumerDropDowns();

            var data = new
            {
                SeriesConsumer = ds.Tables[0],
            };

            return ApiResponse.GetResponse(ApiResponseType.SUCCESS, data, Constants.RECORD_FOUND_MESSAGE, null);
        }
        [HttpGet(Name = "GetSeriesById")]
        public async Task<ApiResponse> GetSeriesById(int seriesCategoryId, long SeriesId)
        {
            var ds = await this.seriesNumberPoolService.GetSeriesInfoBySeriesId(seriesCategoryId, SeriesId);

            var series = ds.Tables[0].ToList<VwSeries>();

            var apiResponseType = series.Count > 0 ? ApiResponseType.SUCCESS : ApiResponseType.FAILED;
            var msg = series.Count > 0 ? Constants.RECORD_FOUND_MESSAGE : Constants.NOT_FOUND_MESSAGE;


            return ApiResponse.GetApiResponse(apiResponseType, series, msg);
        }

        [HttpGet(Name = "GetSeriesByCategoryId")]
        public async Task<ApiResponse> GetSeriesByCategoryId(int seriesCategoryId)
        {
            var ds = await this.seriesNumberPoolService.GetSeriesInfoByCategoryId(seriesCategoryId);

            var series = ds.Tables[0].ToList<VwSeries>();

            var apiResponseType = series.Count > 0 ? ApiResponseType.SUCCESS : ApiResponseType.FAILED;
            var msg = series.Count > 0 ? Constants.RECORD_FOUND_MESSAGE : Constants.NOT_FOUND_MESSAGE;


            return ApiResponse.GetApiResponse(apiResponseType, series, msg);
        }

        [HttpGet(Name = "GetSeriesAssignmentCount")]
        public async Task<ApiResponse> GetSeriesAssignmentCount(int seriesConsumerId)
        {
            var ds = await this.seriesNumberPoolService.GetSeriesAssignmentCount(seriesConsumerId);


            var SeriesRecordCount = ds.Tables[0].Rows[0][0].ToString();
            var apiResponseType = Convert.ToInt32(SeriesRecordCount) > 0 ? ApiResponseType.SUCCESS : ApiResponseType.FAILED;
            var msg = Convert.ToInt32(SeriesRecordCount) > 0 ? Constants.RECORD_FOUND_MESSAGE : Constants.NOT_FOUND_MESSAGE;


            return ApiResponse.GetApiResponse(apiResponseType, SeriesRecordCount, msg);
        }

        [HttpGet(Name = "GetSeriesAssignment")]
        public async Task<ApiResponse> GetSeriesAssignment(long seriesConsumerId, int pageNo, int recordsCount)
        {
            var ds = await this.seriesNumberPoolService.GetSeriesAssignmentInfoByConsumerId(seriesConsumerId,pageNo, recordsCount);

            var series = ds.Tables[0].ToList<VwSeriesAssignment>();

            var apiResponseType = series.Count > 0 ? ApiResponseType.SUCCESS : ApiResponseType.FAILED;
            var msg = series.Count > 0 ? Constants.RECORD_FOUND_MESSAGE : Constants.NOT_FOUND_MESSAGE;


            return ApiResponse.GetApiResponse(apiResponseType, series, msg);
        }

        [HttpGet(Name = "GetCustomerCreditInfo")]
        public async Task<ApiResponse> GetCustomerCreditInfo(string ChasisNo)
        {
            var ds = await this.seriesNumberPoolService.GetCustomerCreditInfo(ChasisNo);

            var payment = ds.Tables[0].ToList<VwAdvancePayment>();

            var apiResponseType = payment.Count > 0 ? ApiResponseType.SUCCESS : ApiResponseType.FAILED;
            var msg = payment.Count > 0 ? Constants.RECORD_FOUND_MESSAGE : Constants.NOT_FOUND_MESSAGE;


            return ApiResponse.GetApiResponse(apiResponseType, payment, msg);
        }

        [HttpPost]
        public async Task<ApiResponse> SaveAuctionResult(List<VwAuctionResult> vwAuctionResult)
        {
            this.seriesNumberPoolService.VwUser = this.User;

            var rowsAffected = await this.seriesNumberPoolService.SaveAuctionResult(vwAuctionResult);

            var apiResponseType = rowsAffected > 0 ? ApiResponseType.SUCCESS : ApiResponseType.FAILED;
            var msg = rowsAffected > 0 ? Constants.DATA_SAVED_MESSAGE : Constants.DATA_NOT_SAVED_MESSAGE;

            return ApiResponse.GetApiResponse(apiResponseType, null, msg);
        }

        [HttpPost]
        public async Task<ApiResponse> SaveSeriesSchedule(VwSeries vwSeries)
        {
            this.seriesNumberPoolService.VwUser = this.User;

            var rowsAffected = await this.seriesNumberPoolService.SaveSeriesSchedule(vwSeries);

            var apiResponseType = rowsAffected > 0 ? ApiResponseType.SUCCESS : ApiResponseType.FAILED;
            var msg = rowsAffected > 0 ? Constants.DATA_SAVED_MESSAGE : Constants.DATA_NOT_SAVED_MESSAGE;

            return ApiResponse.GetApiResponse(apiResponseType, null, msg);
        }

        [HttpPost]
        public async Task<ApiResponse> SaveSeriesAssignment(VwSeriesAssignment vwSeriesAssignment)
        {
            this.seriesNumberPoolService.VwUser = this.User;

            var rowsAffected = await this.seriesNumberPoolService.SaveSeriesAssignment(vwSeriesAssignment);

            var apiResponseType = rowsAffected > 0 ? ApiResponseType.SUCCESS : ApiResponseType.FAILED;
            var msg = rowsAffected > 0 ? Constants.DATA_SAVED_MESSAGE : Constants.DATA_NOT_SAVED_MESSAGE;

            return ApiResponse.GetApiResponse(apiResponseType, null, msg);
        }

        [HttpPost]
        public async Task<ApiResponse> ActivateSeries(long AuctionScheduleId, long SeriesId)
        {
            this.seriesNumberPoolService.VwUser = this.User;

            var rowsAffected = await this.seriesNumberPoolService.ActivateSeriesforMTC(AuctionScheduleId, SeriesId);

            var apiResponseType = rowsAffected > 0 ? ApiResponseType.SUCCESS : ApiResponseType.FAILED;
            var msg = rowsAffected > 0 ? Constants.DATA_SAVED_MESSAGE : Constants.DATA_NOT_SAVED_MESSAGE;

            return ApiResponse.GetApiResponse(apiResponseType, null, msg);
        }

        [HttpPost]
        public async Task<ApiResponse> SaveCustomerPaymentIntimation(VwAdvancePayment vwAdvancePayment)
        {
            this.seriesNumberPoolService.VwUser = this.User;

            var rowsAffected = await this.seriesNumberPoolService.SaveCustomerPaymentIntimation(vwAdvancePayment);

            var apiResponseType = rowsAffected > 0 ? ApiResponseType.SUCCESS : ApiResponseType.FAILED;
            var msg = rowsAffected > 0 ? Constants.DATA_SAVED_MESSAGE : Constants.DATA_NOT_SAVED_MESSAGE;

            return ApiResponse.GetApiResponse(apiResponseType, null, msg);
        }


    }
}
