using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;
using Web.Testing.Data;
using Web.Testing.Interfaces;
using Web.Testing.Models;
using Web.Testing.Models.Enums;

namespace Web.Testing.Repository
{
    public class TestRepository : ITestRepository
    {
        private readonly ApplicationContext _context;

        public TestRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Test>> GetTestsAsync()
        {
            return await _context.Tests.Include(t => t.Questions).ThenInclude(q => q.Answers).ToListAsync();
        }
        public async Task<Test?> GetTestAsync(Guid id)
        {
            return await _context.Tests.FirstOrDefaultAsync(t => t.Id == id);
        }
    }
}
