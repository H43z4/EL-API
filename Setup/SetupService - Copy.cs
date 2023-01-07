using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models.DatabaseModels.Setup;
using Models.DatabaseModels.VehicleRegistration.Setup;
using RepositoryLayer;

namespace Setup
{
    public interface _copyISetupservice

    {
        public SetupBaseModel GetSetup(long Id);

        IEnumerable<SetupBaseModel> GetAll(Expression<Func<SetupBaseModel, bool>> filter = null,
     Func<IQueryable<SetupBaseModel>, IOrderedQueryable<SetupBaseModel>> orderby = null, string property = "", int? pageNo = null, int? recordsPerPage = null);

        public void AddSetup(SetupBaseModel setup);

        public void UpdateSetup(SetupBaseModel setup);

        public void DeleteSetup(long setupId);

        public void RemoveSetup(SetupBaseModel setup);
        public void SaveChanges();

    }

    public class _copySetupService:_copyISetupservice
    {
        private IRepository<SetupBaseModel> _repository;
        //private DbSet<T> entities;
        //private readonly AppDbContext _context;

        public _copySetupService(IRepository<SetupBaseModel> repository)
        {
            _repository = repository;
           // entities = dbContext.Set<T>();
        }

        public SetupBaseModel GetSetup(long Id)
        {
            return _repository.Get(Id);// entities.SingleOrDefault(x => x.Id == Id);
        }

        public IEnumerable<SetupBaseModel> GetAll(Expression<Func<SetupBaseModel, bool>> filter = null,
Func<IQueryable<SetupBaseModel>, IOrderedQueryable<SetupBaseModel>> orderby = null, string property = "", int? pageNo = null, int? recordsPerPage = null)
        {

            //return _repository.GetEntities().Select(x=>x);

            return _repository.GetAll();
        }
        public void AddSetup(SetupBaseModel setup) {

            _repository.Insert(setup);
        }

        public void UpdateSetup(SetupBaseModel setup) {
            _repository.Update(setup);
        }

        public void DeleteSetup(long setupId) {

            throw new NotImplementedException();
        }

        public void RemoveSetup(SetupBaseModel setup) {
            _repository.Remove(setup);
        }
        public void SaveChanges() {

            _repository.SaveChanges();
        }

    }
}
