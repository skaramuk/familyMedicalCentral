using FMC.Entity.Model;
using FMC.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMC.Service.Services
{
    public class ReceteService
    {
        private ReceteRepository receteRepository = new ReceteRepository();

        public List<Recete> GetAll()
        {
            return receteRepository.GetList();
        }
        //kimlik numarasına göre reçete arama ve listeleme ekle

        public Recete Create(Recete recete)
        {
            return receteRepository.Add(recete);
        }
        public Recete Update(Recete recete)
        {
            return receteRepository.Update(recete);
        }

        //public Recete Delete(Recete recete)
        //{
        //    return receteRepository.Delete(recete);
        //}
    }
}
