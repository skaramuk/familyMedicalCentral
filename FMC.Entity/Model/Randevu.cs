using FMC.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Column(TypeName="varchar")]
        public string Tarih { get; set; }
    }
}
