using FMC.Entity.Model;
using FMC.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMC.Service.Services
{
    public class IlacService
    {
        private IlacRepository ilacRepository = new IlacRepository();

        public List<Ilac> GetAll()
        {
            return ilacRepository.GetList();
        }

        public Ilac GetByCategory(string category)
        {
            return ilacRepository.Get(x => x.Kategori == category);
        }
    }
}
