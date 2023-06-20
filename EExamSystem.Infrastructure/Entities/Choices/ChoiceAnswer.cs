using EExamSystem.Infrastructure.Entities.Questions;

namespace EExamSystem.Infrastructure.Entities.Choices
{
    public class ChoiceAnswer
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string BodyAnswer { get; set; }
        public bool IsCorrect { get; set; }

        // Propriétés de navigation
        public Question Question { get; set; }
    }
}
