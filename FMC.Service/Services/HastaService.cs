using FMC.Entity.Model;
using FMC.Repository.Concrete;
using FMC.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMC.Service.Services
{
    public class HastaService
    {
        private HastaRepository hastaRepository = new HastaRepository();

        public List<Hasta> GetAll()
        {
            return hastaRepository.GetList();
        }
        
        public Hasta GetById(string kimlik)
        {
            return hastaRepository.Get(x => x.KimlikNo == kimlik);
        }
        public Hasta Create(Hasta hasta)
        {
            return hastaRepository.Add(hasta);
        }
        public Hasta Delete(Hasta hasta)
        {
             hastaRepository.Delete(hasta);
             return hasta;
        }
        public Hasta Login(LoginModel hasta)
        {
           return hastaRepository.Get(x=>x.KimlikNo==hasta.Kimlikno&&x.Sifre==hasta.Sifre);
        }
    }
}
