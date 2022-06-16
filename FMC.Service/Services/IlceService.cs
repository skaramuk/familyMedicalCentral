using FMC.Entity.Model;
using FMC.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMC.Service.Services
{
    public class IlceService
    {
        private IlceRepository ilceRepository = new IlceRepository();

        public List<Ilce> GetAll()
        {
            return ilceRepository.GetList();
        }
        public List<Ilce> GetByIl(int sehirid)
        {
            return ilceRepository.GetList(x => x.Sehir.Id == sehirid);
        }
    }
}
