using EExamSystem.Core.Dtos.TopicDtos;
using System.Linq.Expressions;

namespace EExamSystem.Core.Services.IServices
{
    public interface ITopicService
    {
        Task<TopicDto> GetAsync(Expression<Func<TopicDto, bool>> filter = null);
        Task<List<TopicDto>> GetListAsync(Expression<Func<TopicDto, bool>> filter = null);
        Task<TopicDto> AddAsync(TopicDto entity);
        Task<TopicDto> UpdateAsync(TopicDto entity);
        Task<int> DeleteAsync(TopicDto entity);
        Task<List<TopicDto>> AddRangeAsync(List<TopicDto> entity);
        Task<List<TopicDto>> UpdateRangeAsync(List<TopicDto> entity);
        Task<List<TopicDto>> GetByCategoryId(int id);
    }
}
