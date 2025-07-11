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
    public class Calisan : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Ad")]
        public string Ad { get; set; }

        [Display(Name = "Soyad")]
        public string Soyad { get; set; }

        [Display(Name = "EgitimId")]
        public int EgitimId { get; set; }
        [ForeignKey("EgitimId"), Display(Name = "EgitimId")]
        public virtual Egitim Egitim { get; set; }

        [Display(Name = "KadroId")]
        public int KadroId { get; set; }
        [ForeignKey("KadroId"), Display(Name = "KadroId")]
        public virtual Kadro Kadro { get; set; }       
        
        [Display(Name = "MudurlukId")]
        public int MudurlukId { get; set; }
        [ForeignKey("MudurlukId"), Display(Name = "MudurlukId")]
        public virtual Mudurluk Mudurluk { get; set; }       

        [Display(Name = "Durum")]
        public bool Durum { get; set; }
    }
}