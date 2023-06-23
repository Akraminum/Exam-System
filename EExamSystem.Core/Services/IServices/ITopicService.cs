using EExamSystem.Core.Dtos.TopicDtos;
using System.Linq.Expressions;

namespace EExamSystem.Core.Services.IServices
{
    public interface ITopicService
    {
        Task<TopicDtoOutput> Add(TopicDtoInput entity);
        void Remove(TopicDtoUpdate entity);
        Task<TopicDtoOutput> Update(TopicDtoUpdate entity);

        Task<List<TopicDtoOutput>> GetByCategoryId(int id);
        Task<TopicDtoOutput>? GetById(int id);
        Task<IEnumerable<TopicDtoOutput>> GetAll();
        Task<IEnumerable<TopicDtoOutput>> Find(Expression<Func<TopicDtoInput, bool>> predicate);
    }
}
