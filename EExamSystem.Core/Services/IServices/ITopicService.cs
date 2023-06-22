using EExamSystem.Core.Dtos.TopicDtos;
using System.Linq.Expressions;

namespace EExamSystem.Core.Services.IServices
{
    public interface ITopicService
    {
        TopicDtoOutput Add(TopicDtoInput entity);
        void Remove(TopicDtoInput entity);
        public TopicDtoOutput Update(TopicDtoUpdate entity);


        TopicDtoOutput? GetById(int id);
        IEnumerable<TopicDtoOutput> GetAll();
        IEnumerable<TopicDtoOutput> Find(Expression<Func<TopicDtoInput, bool>> predicate);
    }
}
