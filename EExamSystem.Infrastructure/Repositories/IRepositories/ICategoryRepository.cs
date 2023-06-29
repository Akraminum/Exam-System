using EExamSystem.Infrastructure.Entities.Categorys;

namespace EExamSystem.Infrastructure.Repositories.IRepositories
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetListAsync();
        Task<Category> GetByIdAsync(int id);
        Task<Category> AddAsync(Category entity);
        Task<Category> UpdateAsync(Category entity);
        Task<int> DeleteAsync(int id);
        Task<List<Category>> AddRangeAsync(List<Category> entity);
        Task<List<Category>> UpdateRangeAsync(List<Category> entity);

    }
}
