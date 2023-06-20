using EExamSystem.Infrastructure.Entities.Bridgets;
using EExamSystem.Infrastructure.Entities.Certificates;
using EExamSystem.Infrastructure.Entities.Exams;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace EExamSystem.Infrastructure.Entities.Users
{

    [Table(nameof(StudentProfile))]
    public class StudentProfile : IdentityUser
    {
        public string ImageUrl { get; set; }
        public ICollection<StudentCertificate>? UserCertificates { get; set; }

        public ICollection<Certificate>? Certificates { get; set; }
        public ICollection<StudentExam>? StudentExams { get; set; }
        public ICollection<Exam>? Exams { get; set; }

    }
}
