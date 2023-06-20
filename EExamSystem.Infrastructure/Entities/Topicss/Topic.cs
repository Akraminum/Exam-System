
using EExamSystem.Infrastructure.Entities.Categorys;
using EExamSystem.Infrastructure.Entities.Questions;

namespace EExamSystem.Infrastructure.Entities.Topicss
{
    public class Topic
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string? Article { get; set; }
        public string? Description { get; set; }

        // Propriétés de navigation
        public Category? Category { get; set; }
        public ICollection<Question>? Questions { get; set; }
    }
}