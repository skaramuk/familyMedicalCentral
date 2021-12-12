using FMC.Entity.Base;
using FMC.Repository.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMC.Repository.Base
{
    public class BaseRepository<Model> where Model : BaseModel, new()
    {
        protected FmcDbContext fmcDbContext = new FmcDbContext();

        public List<Model> GetList(Func<Model, bool> filter)
        {
            return filter != null ? this.fmcDbContext.Set<Model>().Where(filter).ToList() : this.fmcDbContext.Set<Model>().ToList();
        }

        public Model Get(Func<Model, bool> filter)
        {
            return this.fmcDbContext.Set<Model>().FirstOrDefault(filter);
        }

        public Model Add(Model model)
        {
            Model retModel = fmcDbContext.Set<Model>().Add(model);
            fmcDbContext.SaveChanges();
            return retModel;
        }

        public void Delete(Model model)
        {
            fmcDbContext.Set<Model>().Remove(model);
            fmcDbContext.SaveChanges();
        }

        public Model Update(Model model)
        {
            Model retModel = this.fmcDbContext.Set<Model>().FirstOrDefault(x => x.Id == model.Id);
            retModel = model;
            this.fmcDbContext.SaveChanges();
            return retModel;
        }

        public void DeleteById(int id)
        {
            Model model = fmcDbContext.Set<Model>().First(x => x.Id == id);
            this.Delete(model);
            fmcDbContext.SaveChanges();
        }
    }
}
