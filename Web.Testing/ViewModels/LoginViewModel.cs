using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Web.Testing.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Не указан логин")]
        [StringLength(40, MinimumLength = 5, ErrorMessage = "Логин должен содержать от 5 до 40 символов")]
        public string Login { get; set; } = null!;
        [Required(ErrorMessage = "Пароль не заполнен")]
        [DataType(DataType.Password)]
        [JsonIgnore]
        public string Password { get; set; } = null!;
    }
}
