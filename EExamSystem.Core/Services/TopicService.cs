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
        public async Task<TopicDto> AddAsync(TopicDto entity)
        {
            var TopicMapper = _mapper.Map<Topic>(entity);
            await _TopicRepository.AddAsync(TopicMapper);
            return entity;
        }

        public async Task<List<TopicDto>> AddRangeAsync(List<TopicDto> entity)
        {
            var TopicListMapper = _mapper.Map<List<Topic>>(entity);
            await _TopicRepository.AddRangeAsync(TopicListMapper);
            return entity;
        }

        public async Task<int> DeleteAsync(TopicDto entity)
        {
            var TopicMapper = _mapper.Map<Topic>(entity);
            return await _TopicRepository.DeleteAsync(TopicMapper);
        }

        public async Task<TopicDto> GetAsync(Expression<Func<TopicDto, bool>> filter = null)
        {

            var result = await _TopicRepository.GetAsync();
            var TopicMapper = _mapper.Map<TopicDto>(result);
            return TopicMapper;
        }

        public async Task<List<TopicDto>> GetListAsync(Expression<Func<TopicDto, bool>> filter = null)
        {
            var result = await _TopicRepository.GetListAsync();
            var TopicMapper = _mapper.Map<List<TopicDto>>(result);
            return TopicMapper;
        }

        public async Task<TopicDto> UpdateAsync(TopicDto entity)
        {
            var TopicMapper = _mapper.Map<Topic>(entity);
            var result = await _TopicRepository.UpdateAsync(TopicMapper);

            return entity;
        }

        public async Task<List<TopicDto>> UpdateRangeAsync(List<TopicDto> entity)
        {
            var TopicListMapper = _mapper.Map<List<Topic>>(entity);
            await _TopicRepository.UpdateRangeAsync(TopicListMapper);
            return entity;
        }

        Task<List<TopicDto>> ITopicService.GetByCategoryId(int id)
        {

        }
    }
}
