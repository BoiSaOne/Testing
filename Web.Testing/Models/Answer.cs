namespace Web.Testing.Models
{
    /// <summary>
    /// Ответ
    /// </summary>
    public class Answer
    {
        /// <summary>
        /// Id
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Текст ответа
        /// </summary>
        public string AnswerText { get; set; } = null!;
        /// <summary>
        /// Id вопроса
        /// </summary>
        public Guid QuestionId { get; set; }
        /// <summary>
        /// Вопрос
        /// </summary>
        public Question Question { get; set; } = null!;
        /// <summary>
        /// Верный ответ
        /// </summary>
        public bool IsCorrect { get; set; }
    }
}