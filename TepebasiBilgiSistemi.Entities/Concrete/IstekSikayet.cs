using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TepebasiBilgiSistemi.Core.Entities;

namespace TepebasiBilgiSistemi.Entities.Concrete
{
    public class IstekSikayet : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Baslik")]
        public string Baslik { get; set; }

        [Display(Name = "Text")]
        public string Text { get; set; }

        [Display(Name = "MahalleId")]
        public int MahalleId { get; set; }
        [ForeignKey("MahalleId"), Display(Name = "MahalleId")]
        public virtual Mahalle Mahalle { get; set; }       
        
        [Display(Name = "MudurlukId")]
        public int MudurlukId { get; set; }
        [ForeignKey("MudurlukId"), Display(Name = "MudurlukId")]
        public virtual Mudurluk Mudurluk { get; set; }       

        [Display(Name = "Durum")]
        public bool Durum { get; set; }

        [Display(Name = "Konu")]
        public int Konu { get; set; }
    }
}