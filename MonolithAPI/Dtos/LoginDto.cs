using System.ComponentModel.DataAnnotations;

namespace MonolithAPI.Dtos
{
    public class LoginDto
    {
        [Required (ErrorMessage ="UserName is Required")]
        public string Username { get; set; }
        [Required(ErrorMessage ="Password is required")]
        public string Password { get; set; }
    }
}
