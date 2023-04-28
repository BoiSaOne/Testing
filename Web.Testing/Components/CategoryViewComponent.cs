using Microsoft.AspNetCore.Mvc;
using Web.Testing.Interfaces;

namespace Web.Testing.Components
{
    public class CategoryViewComponent : ViewComponent
    {
        private readonly ICategoryRepository _repository;

        public CategoryViewComponent(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _repository.GetMenuCategoryesAsync());
        }
    }
}
