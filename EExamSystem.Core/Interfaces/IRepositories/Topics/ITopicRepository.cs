using EExamSystem.Core.Interfaces.Repositories;
using EExamSystem.Infrastructure.Entities.Topicss;

namespace EExamSystem.Core.Interfaces.IRepositories.Topics
{
    public interface ITopicRepository : IGenericRepository<Topic>
    {
        public Topic? CustomeRepoMethod(int id);
    }

}
