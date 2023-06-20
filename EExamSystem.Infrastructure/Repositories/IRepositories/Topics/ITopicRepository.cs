using EExamSystem.Infrastructure.Entities.Topicss;

namespace EExamSystem.Infrastructure.Repositories.IRepositories.Topics
{
    public interface ITopicRepository : IGenericRepository<Topic>
    {
        public Topic? CustomeRepoMethod(int id);
    }

}
