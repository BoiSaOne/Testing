using Microsoft.AspNetCore.Mvc;
using Web.Testing.Interfaces;
using Web.Testing.ViewModels;

namespace Web.Testing.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthRepository _repository;

        public AuthController(IAuthRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserViewModel userViewModel, string returnUrl)
        {
            return RedirectToAction(returnUrl);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            var result = await _repository.RegisterAsync(registerViewModel);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Logout()
        {
            return RedirectToAction(nameof(Login));
        }
    }
}
