using EExamSystem.Infrastructure.Entities.Certificates;
using EExamSystem.Infrastructure.Entities.Users;
namespace EExamSystem.Infrastructure.Entities.Bridgets
{
    public class UserCertificate
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CertificateId { get; set; }
        public DateTime DateAchieved { get; set; }

        // Propriétés de navigation
        public StudentProfile User { get; set; }
        public Certificate Certificate { get; set; }
    }
}
