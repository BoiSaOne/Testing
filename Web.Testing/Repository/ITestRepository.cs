using Web.Testing.Models;

namespace Web.Testing.Repository
{
    public interface ITestRepository
    {
        Task<IEnumerable<Test>> GetTestsAsync();
    }
}
