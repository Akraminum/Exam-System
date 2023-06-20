using EExamSystem.Infrastructure.Entities.Bridgets;
using EExamSystem.Infrastructure.Entities.Certificates;
using EExamSystem.Infrastructure.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace EExamSystem.Infrastructure.Entities.Exams
{
    [Index(nameof(CertificateId), IsUnique = true)]
    public class Exam
    {
        public int Id { get; set; }
        public int CertificateId { get; set; }
        public int QuestionCount { get; set; }
        public int PassScore { get; set; }

        // Propriétés de navigation
        public Certificate Certificate { get; set; }
        public virtual ICollection<StudentExam>? StudentExams { get; set; }
        public virtual ICollection<StudentProfile>? StudentProfiles { get; set; }
        /*public virtual ICollection<Question> Questions { get; set; }*/
    }
}
