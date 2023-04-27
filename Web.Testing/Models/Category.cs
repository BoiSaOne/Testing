namespace Web.Testing.Models
{
    /// <summary>
    /// Категория
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Id
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Название категории
        /// </summary>
        public string Name { get; set; } = null!;
        /// <summary>
        /// Id родителя
        /// </summary>
        public Guid? ParentId { get; set; }
        /// <summary>
        /// Категория родитель
        /// </summary>
        public Category? Parent { get; set; }
        /// <summary>
        /// Дочерние категории
        /// </summary>
        public List<Category> CategoriesChildren { get; set; } = new();
        /// <summary>
        /// Список тестов
        /// </summary>
        public List<Test> Tests { get; set; } = new();
    }
}