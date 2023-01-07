using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models.DatabaseModels.VehicleRegistration.Setup;
using Models.ViewModels.VehicleRegistration.Setup;
using RepositoryLayer;

namespace Setup
{
    public interface IVehicleClassService

    {
        public VehicleClass Get(long Id);

        IEnumerable<VehicleClass> GetAll(Expression<Func<VehicleClass, bool>> filter = null,
     Func<IQueryable<VehicleClass>, IOrderedQueryable<VehicleClass>> orderby = null, string property = "", int? pageNo = null, int? recordsPerPage = null);


        public bool AddSetup(vwSetup setup);

        public bool UpdateSetup(vwSetup setup);

        public bool DeleteSetup(long setupId);

        public bool RemoveSetup(vwSetup setup);
        public void SaveChanges();

    }

    public class VehicleClassService: IVehicleClassService
    {
        private IRepository<VehicleClass> _repository;
        //private DbSet<T> entities;
        //private readonly AppDbContext _context;

        public VehicleClassService(IRepository<VehicleClass> repository)
        {
            _repository = repository;
           // entities = dbContext.Set<T>();
        }

        public VehicleClass Get(long Id)
        {
            return _repository.GetAll(x=>x.Id==Id).FirstOrDefault();// entities.SingleOrDefault(x => x.Id == Id);
        }

        public IEnumerable<VehicleClass> GetAll(Expression<Func<VehicleClass, bool>> filter = null,
Func<IQueryable<VehicleClass>, IOrderedQueryable<VehicleClass>> orderby = null, string property = "", int? pageNo = null, int? recordsPerPage = null)
        {

            //return _repository.GetEntities().Select(x=>x);

            return _repository.GetAll();
        }
        public bool AddSetup(vwSetup setup) {

            try
            {
                _repository.Insert(new VehicleClass()
                {

                    Name = setup.Name,
                    Abbreviation = setup.Abbreviation,
                    Description = setup.Description,
                    CreatedBy = setup.CreatedBy
                });
                this.SaveChanges();
                return true;
            }
            catch
            {
                throw;
            }
        }

        public bool UpdateSetup(vwSetup setup) {

            var dbo = _repository.GetAll(x => x.Id == setup.Id).FirstOrDefault();
            if (dbo != null)
            {
                dbo.Name = setup.Name;
                dbo.Abbreviation = setup.Abbreviation;
                dbo.Description = setup.Description;
                dbo.CreatedBy = setup.CreatedBy;
                _repository.Update(dbo);
                this.SaveChanges();

                return true;
            }

            throw new NullReferenceException($"object not found against id = {setup.Id}");

        }

        public bool DeleteSetup(long setupId) {

            var dbo = _repository.GetAll(x => x.Id == setupId).FirstOrDefault();
            if (dbo != null)
            {
                _repository.Delete(dbo);
                this.SaveChanges();

                return true;
            }

            throw new NullReferenceException($"object not found against id = {setupId}");
        }

        public bool RemoveSetup(vwSetup setup) {
            var dbo = _repository.GetAll(x => x.Id == setup.Id).FirstOrDefault();
            if (dbo != null)
            {
                _repository.Remove(dbo);
                this.SaveChanges();

                return true;
            }
            throw new NullReferenceException($"object not found against id = {setup.Id}");
        }
        public void SaveChanges() {

            this.SaveChanges();
        }

    }
}
