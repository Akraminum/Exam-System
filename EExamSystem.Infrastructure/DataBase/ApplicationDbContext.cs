using EExamSystem.Infrastructure.Entities.Bridgets;
using EExamSystem.Infrastructure.Entities.Categorys;
using EExamSystem.Infrastructure.Entities.Certificates;
using EExamSystem.Infrastructure.Entities.Choices;
using EExamSystem.Infrastructure.Entities.Exams;
using EExamSystem.Infrastructure.Entities.Questions;
using EExamSystem.Infrastructure.Entities.Topicss;
using EExamSystem.Infrastructure.Entities.Users;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EExamSystem.Infrastructure.DataBase
{
    public class ApplicationDbContext : IdentityDbContext
    {
        // DbSets
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<StudentExamQuestion> StudentExamQuestions { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<StudentExam> UserExams { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<StudentCertificate> UserCertificates { get; set; }
        public DbSet<Choice> Choices { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<StudentProfile> StudentProfiles { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder
            .Entity<Certificate>()
            .HasMany(c => c.StudentProfiles)
            .WithMany(s => s.Certificates)
            .UsingEntity<StudentCertificate>(
               j => j
                .HasOne(pt => pt.Student)
                .WithMany(t => t.UserCertificates)
                .HasForeignKey(pt => pt.StudentId),
            j => j
                .HasOne(pt => pt.Certificate)
                .WithMany(p => p.UserCertificates)
                .HasForeignKey(pt => pt.CertificateId),
            j =>
            {

                j.HasKey(t => new { t.StudentId, t.CertificateId });
                j.ToTable("UserCertificateEnrollments");
            });





            modelBuilder
           .Entity<StudentProfile>()
           .HasMany(c => c.Exams)
           .WithMany(s => s.StudentProfiles)
           .UsingEntity<StudentExam>(
              j => j
               .HasOne(pt => pt.Exam)
               .WithMany(t => t.StudentExams)
               .HasForeignKey(pt => pt.ExamId),
           j => j
               .HasOne(pt => pt.Student)
               .WithMany(p => p.StudentExams)
               .HasForeignKey(pt => pt.StudentId),
           j =>
           {
               //j.HasKey(t => t.Id);
               j.ToTable("UserExamEnrollments");
           });


           modelBuilder
          .Entity<StudentExam>()
          .HasMany(c => c.Questions)
          .WithMany(s => s.StudentExams)
          .UsingEntity<StudentExamQuestion>(
             j => j
              .HasOne(pt => pt.Question)
              .WithMany(t => t.UserExamQuestions)
              .HasForeignKey(pt => pt.QuestionId),
            j => j
                .HasOne(pt => pt.UserExam)
                .WithMany(p => p.UserExamQuestions)
                .HasForeignKey(pt => pt.UserExamId),
            j =>
            {
                //j.HasKey(t => new { t.UserExam, t.QuestionId });
                j.ToTable("UserExamQuestionHistory");
            });

            modelBuilder
           .Entity<StudentExamQuestion>()
           .HasOne(eq => eq.Choice)
           .WithMany()
           .HasForeignKey(eq => eq.ChoiceId)
           .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
            .Entity<StudentExamQuestion>()
            .HasOne(eq => eq.Question)
            .WithMany()
            .HasForeignKey(eq => eq.QuestionId)
            .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
