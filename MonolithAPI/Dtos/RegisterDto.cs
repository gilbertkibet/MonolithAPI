using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace MonolithAPI.Dtos
{
    public class RegisterDto
    {
        [Required(ErrorMessage="UserName is Requireed")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email is Requireed")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is Requireed")]
        public string Password { get; set; }

    }
}
