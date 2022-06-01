using FMC.Entity.Model;
using FMC.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMC.Service.Services
{
    public class SehirService
    {
        private SehirRepository SehirRepository = new SehirRepository();

        public List<Sehir> GetAll()
        {
            return SehirRepository.GetList();
        }
    }

}
