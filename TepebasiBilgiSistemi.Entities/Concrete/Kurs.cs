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
    public class Kurs : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "KatilimciSayisi")]
        public int KatilimciSayisi { get; set; }

        [Display(Name = "MudurlukId")]
        public int MudurlukId { get; set; }
        [ForeignKey("MudurlukId"), Display(Name = "MudurlukId")]
        public virtual Mudurluk Mudurluk { get; set; }

        [Display(Name = "BaslangicTarih")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime BaslangicTarih { get; set; }


        [Display(Name = "BitisTarih")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime BitisTarih { get; set; }
    }
}