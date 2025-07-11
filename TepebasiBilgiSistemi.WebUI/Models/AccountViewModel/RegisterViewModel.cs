using System.ComponentModel.DataAnnotations;

namespace TepebasiBilgiSistemi.WebUI.Models.AccountViewModel
{
    public class RegisterViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [Required, DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        public string RoleName { get; set; }

        [Required]
        public int Mudurluk_Id { get; set; }
    }
}
