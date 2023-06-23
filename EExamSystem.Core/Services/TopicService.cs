using AutoMapper;
using EExamSystem.Core.Dtos.TopicDtos;
using EExamSystem.Core.Services.IServices;
using EExamSystem.Infrastructure.Entities.Topicss;
using EExamSystem.Infrastructure.Repositories.IRepositories;
using System.Linq.Expressions;

namespace EExamSystem.Core.Services
{
    public class TopicService : ITopicService
    {
        private readonly ITopicRepository _TopicRepository;
        private readonly IMapper _mapper;
        public TopicService(ITopicRepository TopicRepository, IMapper mapper)
        {
            _TopicRepository = TopicRepository;
            _mapper = mapper;
        }
        /*  public async Task<TopicDtoOutput> AddAsync(TopicDtoInput entity)
          {
              var TopicMapper = _mapper.Map<Topic>(entity);
              _TopicRepository.Add(TopicMapper);
              var TopicDto = _mapper.Map<TopicDtoOutput>(entity);
              return TopicDto;
          }



          public void DeleteAsync(TopicDtoInput entity)
          {
              var TopicMapper = _mapper.Map<Topic>(entity);
              _TopicRepository.Remove(TopicMapper);
          }



          public async Task<List<TopicDtoOutput>> GetListAsync(Expression<Func<TopicDtoInput, bool>> filter = null)
          {
              var result = _TopicRepository.GetAll();
              var TopicMapper = _mapper.Map<List<TopicDtoOutput>>(result);
              return TopicMapper;
          }

          public async Task<TopicDtoOutput> UpdateAsync(TopicDtoUpdate entity)
          {
              var TopicMapper = _mapper.Map<Topic>(entity);
              var result = _TopicRepository.Update(TopicMapper);

              var TopicDto = _mapper.Map<TopicDtoOutput>(result);
              return TopicDto;
          }
  */


        public async Task<List<TopicDtoOutput>> GetByCategoryId(int id)
        {
            var result = await _TopicRepository.GetByCategoryId(id);
            var TopicListMapper = _mapper.Map<List<TopicDtoOutput>>(result);
            return TopicListMapper.ToList();
        }

        public async Task<TopicDtoOutput> Add(TopicDtoInput entity)
        {
            var TopicMapper = _mapper.Map<Topic>(entity);
            await _TopicRepository.AddAsync(TopicMapper);
            var TopicDto = _mapper.Map<TopicDtoOutput>(entity);
            return TopicDto;
        }

        public void Remove(TopicDtoUpdate entity)
        {
            var TopicMapper = _mapper.Map<Topic>(entity);
            _TopicRepository.DeleteAsync(entity.Id);
        }

        public async Task<TopicDtoOutput> Update(TopicDtoUpdate entity)
        {
            var TopicMapper = _mapper.Map<Topic>(entity);
            var result = await _TopicRepository.UpdateAsync(TopicMapper);

            var TopicDto = _mapper.Map<TopicDtoOutput>(result);
            return TopicDto;
        }

        public async Task<TopicDtoOutput>? GetById(int id)
        {
            var result = await _TopicRepository.GetByIdAsync(id);
            var TopicDto = _mapper.Map<TopicDtoOutput>(result);
            return TopicDto;
        }

        public async Task<IEnumerable<TopicDtoOutput>> GetAll()
        {
            var result = await _TopicRepository.GetListAsync();
            var TopicMapper = _mapper.Map<List<TopicDtoOutput>>(result);
            return TopicMapper.ToList();
        }

        public async Task<IEnumerable<TopicDtoOutput>> Find(Expression<Func<TopicDtoInput, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
