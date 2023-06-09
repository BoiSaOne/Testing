﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Web.Testing.ViewModels
{
    public class RegisterViewModel
    {
        [EmailAddress(ErrorMessage = "Некорректный адрес")]
        [Required(ErrorMessage = "Почта не заполнена")]
        public string Email { get; set; } = null!;
        [Required(ErrorMessage = "Не указан логин")]
        [StringLength(40, MinimumLength = 5, ErrorMessage = "Логин должен содержать от 5 до 40 символов")]
        public string Login { get; set; } = null!;
        [Required(ErrorMessage = "Пароль не заполнен")]
        [DataType(DataType.Password)]
        [JsonIgnore]
        public string Password { get; set; } = null!;
        [Compare(nameof(Password), ErrorMessage = "Пароли не совпадают")]
        [Required(ErrorMessage = "Пароль подтверждения не заполнен")]
        [DataType(DataType.Password)]
        [JsonIgnore]
        public string? PasswordConfirm { get; set; } = null!;
    }
}
