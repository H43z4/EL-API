using Models.DatabaseModels.VehicleRegistration.Core;
using Models.ViewModels.Identity;
using Models.ViewModels.VehicleRegistration.Core;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer;
using SharedLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using SharedLib.Common;
using Models.DatabaseModels.PermitIssuance.Setup;
using Models.DatabaseModels.PermitIssuance.Core;
using Models.DatabaseModels.VehicleRegistration.Setup;
using Models.ViewModels.PermitIssuance.Core;

namespace PermitIssuance
{
    public interface IPermitIssuanceService : ICurrentUser

    {
        Task<DataSet> SavePermit(VwPermitIssueApplication permitApp);
        Task<DataSet> GetPermitApplicationListById (int id);

    }
    public class PermitIssuanceService : IPermitIssuanceService
    {
        readonly AppDbContext appDbContext;
        readonly IAdoNet adoNet;
        readonly IDBHelper dbHelper;
        public VwUser VwUser { get; set; }

        public PermitIssuanceService(AppDbContext appDbContext, IAdoNet adoNet, IDBHelper dbHelper)
        {
            this.appDbContext = appDbContext;
            this.adoNet = adoNet;
            this.dbHelper = dbHelper;
        }

        public async Task<DataSet> SavePermit(VwPermitIssueApplication permitApp)
        {
            Dictionary<string, object> paramDict = new Dictionary<string, object>();

            paramDict.Add("@ApplicationId", permitApp.ApplicationId);
            paramDict.Add("@OldPermitNo", permitApp.OldPermitNo.Value);
            paramDict.Add("@PermitTypeId", permitApp.PermitTypeId);
            paramDict.Add("@PersonName", permitApp.PersonName);
            paramDict.Add("@FatherHusbandName", permitApp.FatherHusbandName);
            paramDict.Add("@Address", permitApp.Address);
            paramDict.Add("@DateofBirth", permitApp.DateofBirth);
            paramDict.Add("@CellNo", permitApp.CellNo);
            paramDict.Add("@City", permitApp.City.ToString());
            paramDict.Add("@CountryId", permitApp.CountryId.Value);
            paramDict.Add("@CNIC", permitApp.CNIC.ToString());
            paramDict.Add("@PassportNo", permitApp.PassportNo.ToString());
            paramDict.Add("@Nationality", "Christian");
            paramDict.Add("@VisaExpiryDate", permitApp.VisaExpiryDate.ToString());

            paramDict.Add("@UserId", 1);
            //paramDict.Add("@UserId", this.VwUser.UserId);

            var ds = await this.dbHelper.GetDataSetByStoredProcedure("[Core].[SavePermitApplication]", paramDict);

            return ds;
        }

        public async Task<DataSet> GetPermitApplicationListById(int Id)
        {
            Dictionary<string, object> paramDict = new Dictionary<string, object>();

            paramDict.Add("@Id", Id);
            
            var ds = await dbHelper.GetDataSetByStoredProcedure("[Core].[GetPermitApplicationListById]", paramDict);

            return ds;
        }
    }
}