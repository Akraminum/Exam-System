using EExamSystem.Infrastructure.Entities.Exams;
using EExamSystem.Infrastructure.Entities.Users;

namespace EExamSystem.Infrastructure.Entities.Bridgets
{
    public class UserExam
    {
        public int UserId { get; set; }
        public int ExamId { get; set; }
        public int UserScore { get; set; }
        public DateTime Date { get; set; }

        // Propriétés de navigation
        public StudentProfile Users { get; set; }
        public Exam Exam { get; set; }
        public ICollection<UserExamQuestion> UserExamQuestions { get; set; }
    }
}
