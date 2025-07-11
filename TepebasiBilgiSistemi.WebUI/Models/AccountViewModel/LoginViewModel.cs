using System.ComponentModel.DataAnnotations;

namespace TepebasiBilgiSistemi.WebUI.Models.AccountViewModel
{
    public class LoginViewModel
    {
        [Required]
        public string UserName { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
    }
}