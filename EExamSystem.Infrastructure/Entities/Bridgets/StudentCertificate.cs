using EExamSystem.Infrastructure.Entities.Certificates;
using EExamSystem.Infrastructure.Entities.Users;
namespace EExamSystem.Infrastructure.Entities.Bridgets
{
    public class StudentCertificate
    {
        public string StudentId { get; set; }
        public int CertificateId { get; set; }
        public DateTime DateAchieved { get; set; }

        // Propriétés de navigation
        public StudentProfile? Student { get; set; }
        public Certificate? Certificate { get; set; }
    }
}
