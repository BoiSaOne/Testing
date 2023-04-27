using Microsoft.EntityFrameworkCore;
using Web.Testing.Data;

namespace Web.Testing.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationContext _context;

        public CategoryRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<string[]> GetMenuCategoryesAsync()
        {
            var categories = await _context.Categories.ToListAsync();
            return categories.Select(c => c.Name).ToArray();
        }
    }
}
