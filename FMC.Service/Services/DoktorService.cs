using FMC.Entity.Model;
using FMC.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMC.Service.Services
{
   public class DoktorService
    {
        private DoktorRepository doktorRepository = new DoktorRepository();

        public List<Doktor> GetAll()
        {
            return doktorRepository.GetList(null);
        }
        public List<Doktor> GetAllByIsim(string isim)
        {
            return doktorRepository.GetList(x => x.Ad == isim);
        }
    }
}
