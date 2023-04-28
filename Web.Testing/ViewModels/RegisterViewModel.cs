using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Web.Testing.ViewModels
{
    public class RegisterViewModel
    {
        [EmailAddress(ErrorMessage = "Некорректный адрес")]
        public string Email { get; set; } = null!;
        [Required(ErrorMessage = "Не указан логин")]
        [StringLength(40, MinimumLength = 6, ErrorMessage = "Логин должен содержать от 6 до 40 символов")]
        public string Login { get; set; } = null!;
        [Required]
        [DataType(DataType.Password)]
        [JsonIgnore]
        public string Password { get; set; } = null!;
        [Compare(nameof(Password), ErrorMessage = "Пароли не совпадают")]
        [JsonIgnore]
        public string? PasswordConfirm { get; set; } = null!;
    }
}
