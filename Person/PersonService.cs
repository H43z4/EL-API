using Models.ViewModels.PermitIssuance.Setup;
using RepositoryLayer;
using SharedLib.Interfaces;
using System.Data;

namespace Person
{
    public interface IPersonService : ICurrentEPRSUser
    {
        Task<DataSet> GetPersonInfoByCNIC(string cnic);
    }
    public class PersonService : IPersonService
    {
        readonly AppDbContext appDbContext;
        readonly IAdoNet adoNet;
        readonly IDBHelper dbHelper;
        public VwEPRSUser VwUser { get; set; }
        public VwEPRSUser VwEPRSUser { get; set; }

        public PersonService(AppDbContext appDbContext, IAdoNet adoNet, IDBHelper dbHelper)
        {
            this.appDbContext = appDbContext;
            this.adoNet = adoNet;
            this.dbHelper = dbHelper;
        }

        public async Task<DataSet> GetPersonInfoByCNIC(string cnic)
        {
            Dictionary<string, object> paramDict = new Dictionary<string, object>
            {
                { "@CNIC", cnic }
            };

            var ds = await this.dbHelper.GetDataSetByStoredProcedure("[Core].[GetPersonInfoByCNIC]", paramDict);

            return ds;
        }
    }
}