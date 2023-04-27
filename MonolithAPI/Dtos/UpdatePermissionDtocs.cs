using System.ComponentModel.DataAnnotations;

namespace MonolithAPI.Dtos
{
    public class UpdatePermissionDtocs
    {
        [Required(ErrorMessage = "UserName is Requireed")]
        public string UserName { get; set; }
    }
}
