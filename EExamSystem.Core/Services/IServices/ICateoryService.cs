using EExamSystem.Core.Dtos.CateoryDtos;
using System.Linq.Expressions;

namespace EExamSystem.Core.Services.IServices
{
    public interface ICateoryService
    {
        Task<CategoryDtoOutput> GetAsync(Expression<Func<CategoryDtoInput, bool>> filter = null);
        Task<List<CategoryDtoOutput>> GetListAsync(Expression<Func<CategoryDtoInput, bool>> filter = null);
        Task<CategoryDtoOutput> AddAsync(CategoryDtoInput entity);
        Task<CategoryDtoOutput> UpdateAsync(CategoryUpdateDto entity);
        Task<int> DeleteAsync(CategoryDtoInput entity);
        Task<List<CategoryDtoOutput>> AddRangeAsync(List<CategoryDtoInput> entity);
        Task<List<CategoryDtoOutput>> UpdateRangeAsync(List<CategoryUpdateDto> entity);
    }
}
