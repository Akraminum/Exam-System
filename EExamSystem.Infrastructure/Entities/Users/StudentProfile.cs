using EExamSystem.Infrastructure.Entities.Bridgets;
using EExamSystem.Infrastructure.Entities.Certificates;
using EExamSystem.Infrastructure.Entities.Exams;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace EExamSystem.Infrastructure.Entities.Users
{
    [Index(nameof(UserId), IsUnique = true)]
    public class StudentProfile
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string ImageUrl { get; set; }
        public IdentityUser User { get; set; }
        public ICollection<StudentCertificate>? UserCertificates { get; set; }

        public ICollection<Certificate>? Certificates { get; set; }
        public ICollection<StudentExam>? StudentExams { get; set; }
        public ICollection<Exam>? Exams { get; set; }

    }
}
