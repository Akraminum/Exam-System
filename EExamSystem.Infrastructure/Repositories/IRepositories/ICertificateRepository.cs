using EExamSystem.Infrastructure.Entities.Certificates;

namespace EExamSystem.Infrastructure.Repositories.IRepositories
{
    public interface ICertificateRepository
    {
        //Task<List<Certificate>> FilterAsync(Expression<Func<Certificate, bool>> filter);

        Task<List<Certificate>> GetListAsync();
        Task<List<Certificate>> GetListByCategoryIdAsync(int id);

        Task<Certificate> GetByIdAsync(int id);

        Task<Certificate> AddAsync(Certificate input);

        Task<List<Certificate>> AddRangeAsync(List<Certificate> input);

        Task<Certificate> UpdateAsync(Certificate input);

        Task<List<Certificate>> UpdateRangeAsync(List<Certificate> input);

        Task DeleteAsync(int id);
    }
}
