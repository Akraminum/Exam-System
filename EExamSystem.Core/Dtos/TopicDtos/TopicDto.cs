using EExamSystem.Core.Dtos.CateoryDtos;

namespace EExamSystem.Core.Dtos.TopicDtos
{
    public class TopicDto
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string? Article { get; set; }
        public string? Description { get; set; }

        public CategoryDto? Category { get; set; }
        /*public ICollection<Question>? Questions { get; set; }*/
    }
}
