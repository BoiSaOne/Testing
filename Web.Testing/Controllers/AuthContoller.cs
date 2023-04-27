using Microsoft.AspNetCore.Mvc;

namespace Web.Testing.Controllers
{
    public class AuthContoller : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
