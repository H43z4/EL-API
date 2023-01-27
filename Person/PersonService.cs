using Models.ViewModels.Documents;
using Models.ViewModels.PermitIssuance.Core;
using Models.ViewModels.PermitIssuance.Setup;
using RepositoryLayer;
using SharedLib.Interfaces;
using System.Data;

namespace Person
{
    public interface IPersonService : ICurrentEPRSUser
    {
        Task<DataSet> GetPersonInfoByCNIC(string cnic);
        Task<DataSet> SavePersonDocument(VwPersonDocument personDocument);
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

        public async Task<DataSet> SavePersonDocument(VwPersonDocument personDocument)
        {
            try
            {
                Dictionary<string, object> paramDict = new Dictionary<string, object>();

                paramDict.Add("@DocumentId", personDocument.DocumentId);
                paramDict.Add("@DocumentName", personDocument.DocumentName);
                paramDict.Add("@DocumentType", personDocument.DocumentType);
                paramDict.Add("@DocumentDescription", personDocument.DocumentDescription);
                paramDict.Add("@DocumentPath", personDocument.DocumentPath);
                paramDict.Add("@PersonId", personDocument.PersonId);
                paramDict.Add("@ApplicationId", personDocument.ApplicationId);
                paramDict.Add("@CreatedAt", DateTime.Now);
                paramDict.Add("@CreatedBy", VwEPRSUser.UserId);

                var ds = await this.dbHelper.GetDataSetByStoredProcedure("[Core].[SavePermitApplication]", paramDict);

                return ds;
            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}