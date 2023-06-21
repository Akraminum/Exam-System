using AutoMapper;
using EExamSystem.Core.Dtos.CateoryDtos;
using EExamSystem.Core.Services.IServices;
using EExamSystem.Infrastructure.Entities.Categorys;
using EExamSystem.Infrastructure.Repositories.IRepositories;
using System.Linq.Expressions;

namespace EExamSystem.Core.Services
{
    public class CateoryService : ICateoryService
    {
        private readonly ICategoryRepository _CategoryRepository;
        private readonly IMapper _mapper;
        public CateoryService(ICategoryRepository CategoryRepository, IMapper mapper)
        {
            _CategoryRepository = CategoryRepository;
            _mapper = mapper;
        }
        public async Task<CategoryDto> AddAsync(CategoryDto entity)
        {
            var CategoryMapper = _mapper.Map<Category>(entity);
            await _CategoryRepository.AddAsync(CategoryMapper);
            return entity;
        }

        public async Task<List<CategoryDto>> AddRangeAsync(List<CategoryDto> entity)
        {
            var CategoryListMapper = _mapper.Map<List<Category>>(entity);
            await _CategoryRepository.AddRangeAsync(CategoryListMapper);
            return entity;
        }

        public async Task<int> DeleteAsync(CategoryDto entity)
        {
            var CategoryMapper = _mapper.Map<Category>(entity);
            return await _CategoryRepository.DeleteAsync(CategoryMapper);
        }

        public async Task<CategoryDto> GetAsync(Expression<Func<CategoryDto, bool>> filter = null)
        {

            var result = await _CategoryRepository.GetAsync();
            var CategoryMapper = _mapper.Map<CategoryDto>(result);
            return CategoryMapper;
        }

        public async Task<List<CategoryDto>> GetListAsync(Expression<Func<CategoryDto, bool>> filter = null)
        {
            var result = await _CategoryRepository.GetListAsync();
            var CategoryMapper = _mapper.Map<List<CategoryDto>>(result);
            return CategoryMapper;
        }

        public async Task<CategoryDto> UpdateAsync(CategoryDto entity)
        {
            var CategoryMapper = _mapper.Map<Category>(entity);
            var result = await _CategoryRepository.UpdateAsync(CategoryMapper);

            return entity;
        }

        public async Task<List<CategoryDto>> UpdateRangeAsync(List<CategoryDto> entity)
        {
            var CategoryListMapper = _mapper.Map<List<Category>>(entity);
            await _CategoryRepository.UpdateRangeAsync(CategoryListMapper);
            return entity;
        }
    }
}
