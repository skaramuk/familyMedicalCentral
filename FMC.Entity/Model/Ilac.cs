using FMC.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMC.Entity.Model
{
    public class Ilac:BaseModel
    {
        public string Kategori { get; set; }
        public string Ad { get; set; }
        public string Marka { get; set; }

        public ICollection<Recete> ReceteList { get; set; }
    }
}
