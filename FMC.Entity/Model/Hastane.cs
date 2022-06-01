using FMC.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMC.Entity.Model
{
    public class Hastane:BaseModel
    {
        public string Ad { get; set; }
        public string AdresDetay { get; set; }
        public virtual Ilce Ilce { get; set; }

        public ICollection<Doktor> DoktorList { get; set; }
    }
}
