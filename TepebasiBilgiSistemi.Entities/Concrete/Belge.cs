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
    public class Belge : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "BelgeGuid")]
        public Guid BelgeGuid { get; set; }
        
        [Display(Name = "Name")]
        public string Name { get; set; }


        [Display(Name = "BaslangicTarih")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime BaslangicTarih { get; set; }


        [Display(Name = "BitisTarih")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime BitisTarih { get; set; }

        public virtual ICollection<BelgeMudurluk> BelgeMudurluk { get; set; }
    }
}