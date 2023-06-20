using EExamSystem.Infrastructure.Entities.Bridgets;
using EExamSystem.Infrastructure.Entities.Categorys;
using EExamSystem.Infrastructure.Entities.Exams;

namespace EExamSystem.Infrastructure.Entities.Certificates
{
    public class Certificate
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int ExamId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal PassPercentage { get; set; }

        // Propriétés de navigation
        public Category Category { get; set; }
        public Exam Exam { get; set; }
        public ICollection<UserCertificate> UserCertificates { get; set; }
    }
}
