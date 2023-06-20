using EExamSystem.Infrastructure.Entities.Bridgets;
using EExamSystem.Infrastructure.Entities.Choices;

namespace EExamSystem.Infrastructure.Entities.Questions
{
    public class Question
    {
        public int Id { get; set; }
        public int TopicId { get; set; }
        public string QuestionBody { get; set; }

        // Propriétés de navigation
        public Topic Topic { get; set; }
        public ICollection<UserExamQuestion> UserExamQuestions { get; set; }
        public ICollection<ChoiceAnswer> ChoiceAnswers { get; set; }
    }
}
