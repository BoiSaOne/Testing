using Microsoft.AspNetCore.Identity;
using Web.Testing.Helpers;
using Web.Testing.Models.Enums;

namespace Web.Testing.Models
{
    /// <summary>
    /// Пользователь
    /// </summary>
    public class User
    {
        /// <summary>
        /// Id
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Логин
        /// </summary>
        public string Login { get; set; } = null!;
        /// <summary>
        /// Хэш пароля
        /// </summary>
        public string Password { get; set; } = null!;
        /// <summary>
        /// Адрес эл. почты
        /// </summary>
        public string Email { get; set; } = null!;
        /// <summary>
        /// Роль
        /// </summary>
        public Role Role { get; set; } = Role.User;

        public User() { }

        public User(string login, string password, string email)
        {
            Login = login;
            Password = HashPasswordHelper.GetHashPassword(password);
            Email = email;
        }
    }
}
