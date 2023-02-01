using Models.DatabaseModels.EPRSDatabaseObjects.Core;
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
        Task<DataSet> GetPersonImage(long applicationId);
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

                paramDict.Add("@DocumentName", personDocument.DocumentName);
                paramDict.Add("@DocumentType", personDocument.DocumentType);
                paramDict.Add("@DocumentDescription", personDocument.DocumentDescription);
                paramDict.Add("@DocumentPath", personDocument.DocumentPath);
                paramDict.Add("@PersonId", personDocument.PersonId);
                paramDict.Add("@ApplicationId", personDocument.ApplicationId);
                paramDict.Add("@CreatedAt", DateTime.Now);
                paramDict.Add("@CreatedBy", VwEPRSUser.UserId);

                var ds = await this.dbHelper.GetDataSetByStoredProcedure("[Core].[SavePersonDocument]", paramDict);

                return ds;
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public async Task<DataSet> GetPersonImage(long applicationId)
        {
            try
            {
                Dictionary<string, object> paramDict = new Dictionary<string, object>();
                paramDict.Add("@ApplicationId", applicationId);
                paramDict.Add("@DocumentType", "Photo");

                var ds = await this.dbHelper.GetDataSetByStoredProcedure("[Core].[GetPersonImage]", paramDict);

                return ds;
            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}