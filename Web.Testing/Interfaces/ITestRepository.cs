using Web.Testing.Models;

namespace Web.Testing.Interfaces
{
    public interface ITestRepository
    {
        Task<IEnumerable<Test>> GetTestsAsync();
    }
}
