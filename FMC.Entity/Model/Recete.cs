using FMC.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMC.Entity.Model
{
    public class Recete:BaseModel
    {
        public string Not { get; set; }
        public virtual Ilac Ilac { get; set; }
    }
}
