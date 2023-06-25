using EExamSystem.Infrastructure.Entities.Bridgets;
using EExamSystem.Infrastructure.Entities.Categorys;
using EExamSystem.Infrastructure.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

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

        [MaxLength(100, ErrorMessage = "Sorry but Pass Percentage can't be more than 100")]
        [MinLength(0, ErrorMessage = "Sorry but Pass Percentage can't be less than 0")]
        public decimal? PassPercentage { get; set; }

        public string? signature { get; set; }

        public Category? Category { get; set; }

        public ICollection<StudentCertificate>? UserCertificates { get; set; }

        public ICollection<StudentProfile>? StudentProfiles { get; set; }
    }
}
