using FMC.Entity.Model;
using FMC.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMC.Service.Services
{
   public class RandevuService
    {
        private RandevuRepository randevuRepository = new RandevuRepository();

        public List<Randevu> GetAll()
        {
            return randevuRepository.GetList();
        }

        public Randevu GetByKimlik(string kimlik)
        {
            return randevuRepository.Get(x => x.Hasta.KimlikNo == kimlik);
        }

        public Randevu Create(Randevu randevu)
        {
            return randevuRepository.Add(randevu);
        }

        public Randevu Delete(Randevu randevu)
        {
            randevuRepository.Delete(randevu);
            return randevu;
        }

        public Randevu Update(Randevu randevu)
        {
            return randevuRepository.Update(randevu);
        }
    }
}
