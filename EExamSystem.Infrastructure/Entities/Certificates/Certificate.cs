using EExamSystem.Infrastructure.Entities.Bridgets;
using EExamSystem.Infrastructure.Entities.Categorys;
using EExamSystem.Infrastructure.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace EExamSystem.Infrastructure.Entities.Certificates
{
    [Index(nameof(CategoryId), IsUnique = true)]
    public class Certificate
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }
        /* public int ExamId { get; set; }*/
        public string Title { get; set; }
        public string? Description { get; set; }
        public decimal? PassPercentage { get; set; }
        public string? signature { get; set; }


        public Category? Category { get; set; }

        public ICollection<StudentCertificate>? UserCertificates { get; set; }

        public ICollection<StudentProfile>? StudentProfiles { get; set; }
    }
}
