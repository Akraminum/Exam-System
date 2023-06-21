using EExamSystem.Core.Dtos.CateoryDtos;
using System.Linq.Expressions;

namespace EExamSystem.Core.Services.IServices
{
    public interface ICateoryService
    {
        Task<CategoryDto> GetAsync(Expression<Func<CategoryDto, bool>> filter = null);
        Task<List<CategoryDto>> GetListAsync(Expression<Func<CategoryDto, bool>> filter = null);
        Task<CategoryDto> AddAsync(CategoryDto entity);
        Task<CategoryDto> UpdateAsync(CategoryDto entity);
        Task<int> DeleteAsync(CategoryDto entity);
        Task<List<CategoryDto>> AddRangeAsync(List<CategoryDto> entity);
        Task<List<CategoryDto>> UpdateRangeAsync(List<CategoryDto> entity);
    }
}
