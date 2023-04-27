using System.ComponentModel;

namespace Web.Testing.Models
{
    /// <summary>
    /// Тест
    /// </summary>
    public class Test
    {
        /// <summary>
        /// Id
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Имя теста
        /// </summary>
        public string Name { get; set; } = null!;
        /// <summary>
        /// Id категории
        /// </summary>
        public Guid? CategoryId { get; set; }
        /// <summary>
        /// Категория
        /// </summary>
        public Category? Category { get; set; }
        /// <summary>
        /// Список ответов
        /// </summary>
        public List<Question> Questions { get; set; } = new();
    }
}
