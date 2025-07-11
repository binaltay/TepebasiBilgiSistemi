using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace TepebasiBilgiSistemi.WebUI.Models.AccountViewModel
{
    public class UserUpdateViewModel
    {
        public string Id { get; set; }

        [Display(Name = "Ad Soyad")]
        public string Name { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; }
        
        [Display(Name = "Görev")]
        public string ApRoleName { get; set; }

        public List<SelectListItem> ApRoles { get; set; }
    }
}
