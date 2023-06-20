using EExamSystem.Infrastructure.Entities.Exams;
using EExamSystem.Infrastructure.Entities.Questions;
using EExamSystem.Infrastructure.Entities.Users;

namespace EExamSystem.Infrastructure.Entities.Bridgets
{
    public class StudentExam
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int ExamId { get; set; }
        public int UserScore { get; set; }
        public DateTime Date { get; set; }

        // Propriétés de navigation
        public StudentProfile? Student { get; set; }
        public Exam? Exam { get; set; }
        public ICollection<StudentExamQuestion>? UserExamQuestions { get; set; }
        public ICollection<Question>? Questions { get; set; }
    }
}
