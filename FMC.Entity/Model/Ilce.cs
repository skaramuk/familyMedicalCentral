using FMC.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMC.Entity.Model
{
   public class Ilce:BaseModel
    {
        public string Ad { get; set; }
        public virtual Sehir Sehir { get; set; }

        public ICollection<Hastane> HastaneList { get; set; }
        public ICollection<Hasta> HastaList { get; set; }
    }
}
