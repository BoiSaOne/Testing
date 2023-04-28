using Microsoft.EntityFrameworkCore;
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

        public async Task<User?> LoginAsync(UserViewModel userViewModel)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Login  == userViewModel.Login &&
                u.Password == HashPasswordHelper.GetHashPassword(userViewModel.Password));
        }

        public async Task<User?> RegisterAsync(RegisterViewModel registerViewModel)
        {
            var newUser = await _context.Users.FirstOrDefaultAsync(u => u.Login == registerViewModel.Login);
            if (newUser == null)
            {
                string passwordHash = HashPasswordHelper.GetHashPassword(registerViewModel.Password);
                newUser = new User(registerViewModel.Login, passwordHash, registerViewModel.Password);
                _context.Users.Add(newUser);
                _context.SaveChanges();
            }
            return newUser;
        }
    }
}
