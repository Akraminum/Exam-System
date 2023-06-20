using EExamSystem.Infrastructure.Entities.Choices;
using EExamSystem.Infrastructure.Entities.Questions;

namespace EExamSystem.Infrastructure.Entities.Bridgets
{
    public class StudentExamQuestion
    {

        public int UserExamId { get; set; }
        public int QuestionId { get; set; }
        public int ChoiceId { get; set; }

        // Propriétés de navigation
        public StudentExam? UserExam { get; set; }
        public Question? Question { get; set; }
        public Choice? Choice { get; set; }
    }
}
