using Web.Testing.Models;
using Web.Testing.ViewModels;

namespace Web.Testing.Interfaces
{
    public interface IAuthRepository
    {
        Task<User?> RegisterAsync(RegisterViewModel registerViewModel);
        Task<User?> LoginAsync(UserViewModel userViewModel);
    }
}
