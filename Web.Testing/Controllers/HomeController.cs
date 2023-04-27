using Microsoft.AspNetCore.Mvc;
using Web.Testing.Data;
using Web.Testing.Repository;

namespace Web.Testing.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITestRepository _repository;

        public HomeController(ITestRepository repository)
        {
            _repository = repository;
        }

        public async Task<IActionResult> Index()
        {
            await _repository.GetTestsAsync();
            return View();
        }
    }
}
