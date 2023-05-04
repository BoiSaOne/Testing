using System.Security.Claims;
using Web.Testing.Models;
using Web.Testing.ViewModels;

namespace Web.Testing.Interfaces
{
    public interface IAuthRepository
    {
        Task<AuthViewModel<ClaimsIdentity>> RegisterAsync(RegisterViewModel registerViewModel);
        Task<AuthViewModel<ClaimsIdentity>> LoginAsync(LoginViewModel userViewModel);
    }
}
