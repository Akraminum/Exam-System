using EExamSystem.Infrastructure.Entities.Topicss;

namespace EExamSystem.Core.Dtos.CateoryDtos
{
    public class CategoryDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string? Description { get; set; }
        public ICollection<Topic>? Topics { get; set; }
    }
}
