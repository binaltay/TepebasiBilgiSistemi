using System.ComponentModel.DataAnnotations;

namespace TepebasiBilgiSistemi.WebUI.Models.AccountViewModel
{
    public class PassViewModel
    {
        [Display(Name = "Yeni Şifre")]
        public string Password { get; set; }
        [Display(Name = "Yeni Şifre Tekrar")]
        public string ConfirmPassword { get; set; }
    }
}