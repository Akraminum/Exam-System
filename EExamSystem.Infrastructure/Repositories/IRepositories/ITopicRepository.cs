using EExamSystem.Infrastructure.Entities.Topicss;

namespace EExamSystem.Infrastructure.Repositories.IRepositories
{
    public interface ITopicRepository : IGenericRepository<Topic, int>
    {
        Task<List<Topic>> GetByCategoryId(int id);
    }
}
