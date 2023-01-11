using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Models.DatabaseModels.epay;
using Models.DatabaseModels.PermitIssuance.Core;
using Models.DatabaseModels.VehicleRegistration.Core;
using Models.ViewModels.Identity;
using Models.ViewModels.PermitIssuance.Core;
using Models.ViewModels.PermitIssuance.Setup;
using Models.ViewModels.Stock;
using Models.ViewModels.VehicleRegistration.Core;
using RepositoryLayer;
using SharedLib.Common;
using SharedLib.Interfaces;
using System.Data;

namespace Stock
{
    public interface IInventoryService : ICurrentEPRSUser
    {
        Task<DataSet> SaveConsignment(VwInventory inventory);
        Task<DataSet> GetStockInApplicationList();
        Task<DataSet> GetStockInApplicationListById(int id);
        Task<DataSet> GetProductList();
        Task<DataSet> GetPersonInfoByCNIC(string cnic); 
    }

    public class InventoryInService : IInventoryService
    {
        //readonly AppDbContext appDbContext;
        //readonly IAdoNet adoNet;
        readonly IDBHelper dbHelper;
        public VwEPRSUser VwEPRSUser { get; set; }

        public InventoryInService(IDBHelper dbHelper)
        {
            //this.appDbContext = appDbContext;
            //this.adoNet = adoNet;
            this.dbHelper = dbHelper;
        }
        public async Task<DataSet> SaveConsignment(VwInventory inventory)
        {
            Dictionary<string, object> paramDict = new Dictionary<string, object>();
            Dictionary<string, object> paramDict2 = new Dictionary<string, object>();


            paramDict.Add("@StockInApplicationId", inventory.StockInApplicationId);
            paramDict.Add("@OrganisationId", inventory.OrganisationId);
            paramDict.Add("@ExcisePassNo", inventory.ExcisePassNo);
            paramDict.Add("@RequestDate", inventory.RequestDate);
            paramDict.Add("@TransportExportNo", inventory.TransportExportNo);
            paramDict.Add("@ConsignmentFromId", inventory.ConsignmentFromId);
            paramDict.Add("@PermitNo", inventory.PermitNo);
            paramDict.Add("@PassValidity", inventory.PassValidity);
            paramDict.Add("@PassValidity", inventory.PassValidity);
            paramDict.Add("@VehicleRegistrationNo", inventory.VehicleRegistrationNo);
            paramDict.Add("@SignedByCollector", inventory.SignedByCollector);
            paramDict.Add("@RateOfDauty", inventory.RateOfDauty);
            paramDict.Add("@AmountOfDautyLevied", inventory.AmountOfDautyLevied);
            paramDict.Add("@ChNoDate", inventory.AmountOfDautyLevied);
            paramDict.Add("@Remarks", inventory.Remarks);
            paramDict.Add("@CreatedBy", this.VwEPRSUser.UserId);
            paramDict.Add("@CreatedAt", DateTime.Now);

            var ds = await this.dbHelper.GetDataSetByStoredProcedure("[Core].[SaveStockinApplication]", paramDict);
            string ConsignmentId = "";
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows[0][0].ToString() == "0")
            {
                ConsignmentId = ds.Tables[0].Rows[0][0].ToString();
                if (ConsignmentId != null && ConsignmentId != "")
                {
                    var items = new List<StockInApplicationDetails>();
                    inventory.items.ForEach(x =>
                    {
                        var item = new StockInApplicationDetails();
                        item.StockInApplicationId = Int64.Parse(ConsignmentId);

                        paramDict.Add("@StockInApplicationId", item.StockInApplicationId);
                        paramDict.Add("@ProductId", item.ProductId);
                        paramDict.Add("@BottleSizeId", item.BottleSizeId);
                        paramDict.Add("@Quantity", item.Quantity);
                        paramDict.Add("@BulkGallons", item.BulkGallons);
                        paramDict.Add("@StrenghtPercentage", item.StrenghtPercentage);
                        paramDict.Add("@ProofGallons", item.ProofGallons);
                        paramDict.Add("@CreatedBy", this.VwEPRSUser.UserId);
                        paramDict.Add("@CreatedAt", DateTime.Now);
                        paramDict.Add("@ConsignmentItems", items.ToDataTable());
                        this.dbHelper.GetDataSetByStoredProcedure("[Core].[SaveStockinApplication]", paramDict2);
                    });


                }
            }

            return ds;
        }

        public async Task<DataSet> GetStockInApplicationList()
        {
            var ds = await this.dbHelper.GetDataSetByStoredProcedure("[Core].[GetStockInApplicationList]", null);

            return ds;
        }

        public async Task<DataSet> GetStockInApplicationListById(int id)
        {
            Dictionary<string, object> paramDict = new Dictionary<string, object>();
            paramDict.Add("@Id", id);

            var ds = await this.dbHelper.GetDataSetByStoredProcedure("[Core].[GetStockInApplicationListById]", paramDict);

            return ds;
        }

        public async Task<DataSet> GetProductList()
        {
            var ds = await this.dbHelper.GetDataSetByStoredProcedure("[Core].[GetProductList]", null);

            return ds;
        }

        public async Task<DataSet> GetPersonInfoByCNIC(string cnic)
        {
            Dictionary<string, object> paramDict = new Dictionary<string, object>();

            paramDict.Add("@CNIC", cnic);

            var ds = await this.dbHelper.GetDataSetByStoredProcedure("[Core].[GetPersonInfoByCNIC]", paramDict);

            return ds;
        }
    }
}