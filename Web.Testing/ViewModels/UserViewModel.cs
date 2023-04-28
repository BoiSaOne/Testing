using System.ComponentModel.DataAnnotations;

namespace Web.Testing.ViewModels
{
    public class UserViewModel
    {
        public string Email { get; set; } = null!;
        [Required]
        public string Login { get; set; } = null!;
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
    }
}
