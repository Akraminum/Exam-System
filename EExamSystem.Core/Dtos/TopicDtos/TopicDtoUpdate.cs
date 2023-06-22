namespace EExamSystem.Core.Dtos.TopicDtos
{
    public class TopicDtoUpdate
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string? Article { get; set; }
        public string? Description { get; set; }
    }
}
