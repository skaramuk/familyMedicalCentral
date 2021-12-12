using FMC.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMC.Entity.Model
{

    public class User : BaseModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ad alanı boş geçilemez")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Tc kimlik no alanı boş geçilemez")]
        public string TcIdentityNumber { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Şifre alanı boş geçilemez")]
        public string Password { get; set; }
    }
}
