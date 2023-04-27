using System.ComponentModel.DataAnnotations.Schema;
using Web.Testing.Models.Enums;

namespace Web.Testing.Models
{
    /// <summary>
    /// Вопрос
    /// </summary>
    public class Question
    {
        /// <summary>
        /// Id
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Текст вопроса
        /// </summary>
        public string QuestionText { get; set; } = null!;
        /// <summary>
        /// Тип вопроса
        /// </summary>
        [Column("")]
        public QuestionType QuestionType { get; set; }
        /// <summary>
        /// Id теста
        /// </summary>
        public Guid TestId { get; set; }
        /// <summary>
        /// Тест
        /// </summary>
        public Test Test { get; set; } = null!;
        /// <summary>
        /// Список ответов
        /// </summary>
        public List<Answer> Answers { get; set; } = new();
    }
}