using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TepebasiBilgiSistemi.Entities.Concrete
{
    public class User : IdentityUser
    {
        public string Name { get; set; }

        [Display(Name = "Mudurluk")]
        public int Mudurluk_Id { get; set; }
        [ForeignKey("Mudurluk_Id"), Display(Name = "Mudurluk")]
        public virtual Mudurluk Mudurluk { get; set; }
    }
}
