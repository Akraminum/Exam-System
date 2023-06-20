using EExamSystem.Infrastructure.Entities.Questions;

namespace EExamSystem.Infrastructure.Entities.Choices
{
    public class Choice
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string ChoiceBody { get; set; }
        public bool IsCorrect { get; set; }

        // Propriétés de navigation
        public Question? Question { get; set; }
    }
}
