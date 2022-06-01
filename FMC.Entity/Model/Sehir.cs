using FMC.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMC.Entity.Model
{
    public class Sehir:BaseModel
    {
        public string Ad { get; set; }

        public ICollection<Ilce> IlceList { get; set; }
    }
}
