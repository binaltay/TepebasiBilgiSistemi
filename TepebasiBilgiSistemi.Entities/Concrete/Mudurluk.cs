using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TepebasiBilgiSistemi.Core.Entities;

namespace TepebasiBilgiSistemi.Entities.Concrete
{
    public class Mudurluk:IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }
        
        [Display(Name = "Color")]
        public string Color { get; set; }

        public virtual ICollection<User> User { get; set; }
        public virtual ICollection<BelgeMudurluk> BelgeMudurluk { get; set; }
        public virtual ICollection<BaskanMudurluk> BaskanMudurluk { get; set; }
        public virtual ICollection<ButceMudurluk> ButceMudurluk { get; set; }
        public virtual ICollection<IstekSikayet> IstekSikayet { get; set; }
        public virtual ICollection<Etkinlik> Etkinlik { get; set; }
        public virtual ICollection<Kurs> Kurs { get; set; }
    }
}
