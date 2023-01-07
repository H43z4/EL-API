using Database;
using Models.ViewModels.Identity;
using Representative.ViewModels;
using SharedLib.Interfaces;
using System.Data;

namespace Issuance.Services
{
    public interface IIssuanceService : ICurrentUser
    {
        Task<DataSet> GetApplicationsByRegNo(string registrationNo);

    }

    public class IssuanceService: IIssuanceService
    {
        readonly IDBHelper dbHelper;
        public VwUser VwUser { get; set; }
        public IssuanceService(IDBHelper dbHelper)
        {
            this.dbHelper = dbHelper;
        }
        #region Public method
        public async Task<DataSet> GetApplicationsByRegNo(string registrationNo)
        {
            Dictionary<string, object> paramDict = new Dictionary<string, object>();

            paramDict.Add("@VehicleRegNo", registrationNo);

            var ds = await this.dbHelper.GetDataSetByStoredProcedure("[OC].[GetOCInfo]", paramDict);

            return ds;
        }
        #endregion
    }
}
