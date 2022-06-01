using FMC.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMC.Entity.Model
{
    public class Randevu:BaseModel
    {
        public bool Aktif { get; set; }
        public virtual Doktor Doktor { get; set; }
        public virtual Hasta Hasta { get; set; }
        public virtual Recete Recete { get; set; }
        public DateTime Tarih { get; set; }
    }
}
