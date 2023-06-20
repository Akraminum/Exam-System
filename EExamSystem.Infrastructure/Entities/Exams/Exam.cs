using EExamSystem.Infrastructure.Entities.Bridgets;
using EExamSystem.Infrastructure.Entities.Certificates;
using EExamSystem.Infrastructure.Entities.Questions;

namespace EExamSystem.Infrastructure.Entities.Exams
{
    public class Exam
    {
        public int Id { get; set; }
        public int CertificateId { get; set; }
        public int QuestionCount { get; set; }
        public int PassScore { get; set; }

        // Propriétés de navigation
        public Certificate Certificate { get; set; }
        public ICollection<UserExam> UserExams { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}
