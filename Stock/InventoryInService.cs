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

            paramDict.Add("@Consignment", new List<StockInApplication>()
            {
                new StockInApplication()
                {
                    StockInApplicationId = inventory.StockInApplicationId,
                    ExcisePassNo = inventory.ExcisePassNo,
                    RequestDate = inventory.RequestDate,
                    TransportExportNo = inventory.TransportExportNo,
                    ConsignmentFromId = inventory.ConsignmentFromId,
                    PermitNo = inventory.PermitNo,
                    PassValidity = inventory.PassValidity,
                    VehicleRegistrationNo = inventory.VehicleRegistrationNo,
                    SignedByCollector = inventory.SignedByCollector,
                    RateOfDauty = inventory.RateOfDauty,
                    AmountOfDautyLevied = inventory.AmountOfDautyLevied,
                    ChNoDate = inventory.ChNoDate,
                    Remarks = inventory.Remarks,
                    CreatedBy = (long)this.VwEPRSUser.UserId

                }
            }.ToDataTable());
            var items = new List<StockInApplicationDetails>();
            inventory.items.ForEach(x =>
            {
                var item = new StockInApplicationDetails();
                EntityMapper<VwInventoryItems, StockInApplicationDetails>.CopyByPropertyNameAndType(x, item);
                items.Add(item);
            });

            paramDict.Add("@ConsignmentItems", items.ToDataTable());
            paramDict.Add("@UserId", this.VwEPRSUser.UserId);

            var ds = await this.dbHelper.GetDataSetByStoredProcedure("[Core].[SavePermitApplication]", paramDict);

            return ds;
        }
    }
}