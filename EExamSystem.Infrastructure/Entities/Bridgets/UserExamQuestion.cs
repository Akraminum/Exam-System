using EExamSystem.Infrastructure.Entities.Choices;
using EExamSystem.Infrastructure.Entities.Questions;

namespace EExamSystem.Infrastructure.Entities.Bridgets
{
    public class UserExamQuestion
    {
        public int Id { get; set; }
        public int UserExamId { get; set; }
        public int QuestionId { get; set; }
        public int ChoiceAnswerId { get; set; }

        // Propriétés de navigation
        public UserExam UserExam { get; set; }
        public Question Question { get; set; }
        public ChoiceAnswer ChoiceAnswer { get; set; }
    }
}
