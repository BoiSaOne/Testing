using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Web.Testing.Data;
using Web.Testing.Helpers;
using Web.Testing.Interfaces;
using Web.Testing.Models;
using Web.Testing.ViewModels;

namespace Web.Testing.Repository
{
    public class AuthRepository : IAuthRepository
    {
        private readonly ApplicationContext _context;

        public AuthRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<AuthViewModel<ClaimsIdentity>> LoginAsync(LoginViewModel userViewModel)
        {
            AuthViewModel<ClaimsIdentity> authViewModel = new AuthViewModel<ClaimsIdentity>();
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Login == userViewModel.Login &&
                u.Password == HashPasswordHelper.GetHashPassword(userViewModel.Password));

            if (user == null)
            {
                authViewModel.MessageError = "Не верно введен логин или пароль";
            }
            else
            {
                authViewModel.Data = GetClaimsIdentity(user);
                authViewModel.Success = true;
            }
            return authViewModel;
        }

        public async Task<AuthViewModel<ClaimsIdentity>> RegisterAsync(RegisterViewModel registerViewModel)
        {
            AuthViewModel<ClaimsIdentity> authViewModel = new AuthViewModel<ClaimsIdentity>();
            var userParametrs = await _context.Users.Select(u => new { IsLogin = registerViewModel.Login == u.Login,
                IsEmail = registerViewModel.Email == u.Email }).FirstOrDefaultAsync();

            if (userParametrs == null || !userParametrs.IsEmail && !userParametrs.IsLogin)
            {
                var newUser = new User(registerViewModel.Login, registerViewModel.Password, registerViewModel.Email);
                _context.Users.Add(newUser);
                _context.SaveChanges();

                authViewModel.Data = GetClaimsIdentity(newUser);
                authViewModel.Success = true;
            }
            else if (userParametrs.IsLogin)
            {
                authViewModel.MessageError = "Логин уже зарегистрирован";
            }
            else if (userParametrs.IsEmail)
            {
                authViewModel.MessageError = "Email уже зарегистрирован";
            }

            return authViewModel;
        }

        private ClaimsIdentity GetClaimsIdentity(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Login),
                new Claim(ClaimTypes.Role, user.Role.ToString()),
                new Claim(ClaimTypes.Email, user.Email)
            };

            return new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
        }
    }
}
