using EExamSystem.Core.Dtos.CateoryDtos;
using System.Linq.Expressions;

namespace EExamSystem.Core.Services.IServices
{
    public interface ICateoryService
    {
        Task<CategoryDtoOutput> Add(CategoryDtoInput entity);
        void Remove(CategoryUpdateDto entity);
        Task<CategoryDtoOutput> Update(CategoryUpdateDto entity);


        Task<CategoryDtoOutput>? GetById(int id);
        Task<IEnumerable<CategoryDtoOutput>> GetAll();
        Task<IEnumerable<CategoryDtoOutput>> Find(Expression<Func<CategoryDtoInput, bool>> predicate);
    }
}
