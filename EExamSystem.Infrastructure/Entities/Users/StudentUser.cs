using EExamSystem.Infrastructure.Entities.Bridgets;

namespace EExamSystem.Infrastructure.Entities.Users
{
    public class StudentProfile
    {
        public int id { get; set; }
        public int Userid { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<UserCertificate> UserCertificates { get; set; }
        public ICollection<UserExam> UserExams { get; set; }

    }
}
