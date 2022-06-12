using FMC.Entity.Model;
using FMC.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMC.Service.Services
{
    public class HastaneService
    {
        private HastaneRepository hastaneRepository = new HastaneRepository();

        public List<Hastane> GetAll()
        {
            return hastaneRepository.GetList();
        }
        public Hastane Add(Hastane hastane)
        {
            return hastaneRepository.Add(hastane);
        }

    }
}
