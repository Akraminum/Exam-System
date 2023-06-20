using EExamSystem.Infrastructure.Entities.Choices;
using EExamSystem.Infrastructure.Entities.Questions;
using Microsoft.EntityFrameworkCore;

namespace EExamSystem.Infrastructure.Entities.Bridgets
{
    [Index(nameof(UserExamId), nameof(QuestionId), IsUnique = true)] 
    public class StudentExamQuestion
    {

        public int Id { get; set; }
        public int UserExamId { get; set; }
        public int QuestionId { get; set; }
        public int ChoiceId { get; set; }

        // Propriétés de navigation
        public StudentExam? UserExam { get; set; }
        public Question? Question { get; set; }
        public Choice? Choice { get; set; }
    }
}
