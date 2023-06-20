using EExamSystem.Infrastructure.Entities.Topicss;

namespace EExamSystem.Core.Interfaces.IManagers.Topics
{
    public interface ITopicManager
    {
        IEnumerable<Topic> GetAllTopics();
        IEnumerable<Topic> GetAllByCategory();
        IEnumerable<Topic> GetAllByName();

        IEnumerable<Topic> GetTopicById();
    }
}
