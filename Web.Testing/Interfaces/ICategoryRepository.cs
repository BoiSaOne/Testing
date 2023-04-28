namespace Web.Testing.Interfaces
{
    public interface ICategoryRepository
    {
        Task<string[]> GetMenuCategoryesAsync();
    }
}
