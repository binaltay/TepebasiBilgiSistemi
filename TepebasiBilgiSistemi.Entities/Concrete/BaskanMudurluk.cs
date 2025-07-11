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
    public class BaskanMudurluk : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "BaskanId")]
        public int BaskanId { get; set; }
        [ForeignKey("BaskanId"), Display(Name = "BaskanId")]
        public virtual Baskan Baskan { get; set; }

        [Display(Name = "MudurlukId")]
        public int MudurlukId { get; set; }
        [ForeignKey("MudurlukId"), Display(Name = "MudurlukId")]
        public virtual Mudurluk Mudurluk { get; set; }       
    }
}
