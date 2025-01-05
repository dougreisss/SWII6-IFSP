using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class AuthDTO
    {
        [Required(ErrorMessage = "Por favor, digite um login")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Por favor, digite uma senha")]
        public string Password { get; set; }
    }
}
