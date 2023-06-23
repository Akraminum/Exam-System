using EExamSystem.Infrastructure.Entities.Topicss;

namespace EExamSystem.Infrastructure.Repositories.IRepositories
{
    public interface ITopicRepository
    {
        Task<List<Topic>> GetByCategoryId(int id);
        Task<List<Topic>> GetListAsync();
        Task<Topic> GetByIdAsync(int id);
        Task<Topic> AddAsync(Topic entity);
        Task<Topic> UpdateAsync(Topic entity);
        Task<int> DeleteAsync(int id);
        Task<List<Topic>> AddRangeAsync(List<Topic> entity);
        Task<List<Topic>> UpdateRangeAsync(List<Topic> entity);
    }
}
