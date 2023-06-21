using EExamSystem.Infrastructure.DataBase;
using EExamSystem.Infrastructure.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EExamSystem.Infrastructure.Repositories
{

    public class GenericRepository<T, Tkey> : IGenericRepository<T, Tkey> where T : class
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly ApplicationDbContext _aspNetCoreNTierDbContext;
        public GenericRepository(ApplicationDbContext aspNetCoreNTierDbContext)
        {
            _aspNetCoreNTierDbContext = aspNetCoreNTierDbContext;
        }
        public async Task<T> AddAsync(T entity)
        {
            await _aspNetCoreNTierDbContext.AddAsync(entity);
            await _aspNetCoreNTierDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<List<T>> AddRangeAsync(List<T> entity)
        {
            await _aspNetCoreNTierDbContext.AddRangeAsync(entity);
            await _aspNetCoreNTierDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<int> DeleteAsync(T entity)
        {
            _ = _aspNetCoreNTierDbContext.Remove(entity);
            return await _aspNetCoreNTierDbContext.SaveChangesAsync();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> filter = null)
        {
            return await _aspNetCoreNTierDbContext.Set<T>().AsNoTracking().FirstOrDefaultAsync(filter);
        }

        public async Task<List<T>> GetListAsync(Expression<Func<T, bool>> filter = null)
        {
            return await (filter == null ? _aspNetCoreNTierDbContext.Set<T>().ToListAsync() : _aspNetCoreNTierDbContext.Set<T>().Where(filter).ToListAsync());
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _ = _aspNetCoreNTierDbContext.Update(entity);
            await _aspNetCoreNTierDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<List<T>> UpdateRangeAsync(List<T> entity)
        {
            _aspNetCoreNTierDbContext.UpdateRange(entity);
            await _aspNetCoreNTierDbContext.SaveChangesAsync();
            return entity;
        }





    }
}
