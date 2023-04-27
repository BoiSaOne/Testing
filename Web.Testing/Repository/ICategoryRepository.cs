namespace Web.Testing.Repository
{
    public interface ICategoryRepository
    {
        Task<string[]> GetMenuCategoryesAsync();
    }
}
