using FMC.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMC.Entity.Model
{
    public class Hasta:BaseModel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KimlikNo { get; set; }
        public string TelefonNo { get; set; }
        public string Mail { get; set; }
        public string Sifre { get; set; }
        public string Adres { get; set; }
        public virtual Ilce Ilce { get; set; }

        public ICollection<Randevu> RandevuList { get; set; }
    }
}
