using EExamSystem.Infrastructure.Entities.Bridgets;
using EExamSystem.Infrastructure.Entities.Choices;
using EExamSystem.Infrastructure.Entities.Topicss;

namespace EExamSystem.Infrastructure.Entities.Questions
{
    public class Question
    {

        public int Id { get; set; }
        public int TopicId { get; set; }
        public string QuestionBody { get; set; }

        // Propriétés de navigation
        public Topic? Topic { get; set; }
        public ICollection<StudentExamQuestion>? UserExamQuestions { get; set; }
        public ICollection<StudentExam>? StudentExams { get; set; }
        public ICollection<Choice>? Choices { get; set; }
    }
}
