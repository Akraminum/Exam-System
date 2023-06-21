using System.Linq.Expressions;

namespace EExamSystem.Infrastructure.Repositories.IRepositories
{
    public interface IGenericRepository<TEntity, Tkey> where TEntity : class
    {
        /* Task<TEntity> Add(TEntity entity);
         void Remove(TEntity entity);
         Task<TEntity> Update(TEntity entity);


         Task<TEntity>? GetById(Tkey id);
         Task<IEnumerable<TEntity>> GetAll();
         Task<IEnumerable<TEntity>>? FindList(Expression<Func<TEntity, bool>> predicate);*/

        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter = null);
        Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> filter = null);
        Task<TEntity> AddAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<int> DeleteAsync(TEntity entity);
        Task<List<TEntity>> AddRangeAsync(List<TEntity> entity);
        Task<List<TEntity>> UpdateRangeAsync(List<TEntity> entity);
    }
}
