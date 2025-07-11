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
    public class ButceMudurluk : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Butce")]
        public double Butce { get; set; }

        [Display(Name = "MudurlukId")]
        public int MudurlukId { get; set; }
        [ForeignKey("MudurlukId"), Display(Name = "MudurlukId")]
        public virtual Mudurluk Mudurluk { get; set; }

        [Display(Name = "KayitTarihi")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime KayitTarihi { get; set; }        
    }
}