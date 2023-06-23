using EExamSystem.Infrastructure.DataBase;
using EExamSystem.Infrastructure.Entities.Categorys;
using EExamSystem.Infrastructure.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace EExamSystem.Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public readonly ApplicationDbContext Context;

        public CategoryRepository(ApplicationDbContext db)

        {
            Context = db;
        }

        public async Task<Category> AddAsync(Category entity)
        {
            await Context.Categories.AddAsync(entity);
            Context.SaveChanges();
            return entity;
        }

        public async Task<List<Category>> AddRangeAsync(List<Category> entity)
        {
            await Context.Categories.AddRangeAsync(entity);
            Context.SaveChanges();
            return entity;
        }

        public async Task<int> DeleteAsync(int id)
        {
            var result = await Context.Categories.FindAsync(id);
            Context.Categories.Remove(result);
            Context.SaveChanges();
            return result.Id;
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            var result = await Context.Categories.FindAsync(id);
            return result;
        }

        public async Task<List<Category>> GetListAsync()
        {
            var result = await Context.Categories.ToListAsync();
            return result.ToList();
        }

        public async Task<Category> UpdateAsync(Category entity)
        {
            var result = Context.Categories.Update(entity);
            Context.SaveChanges();
            return entity;
        }

        public async Task<List<Category>> UpdateRangeAsync(List<Category> entity)
        {
            Context.Categories.UpdateRange(entity);
            Context.SaveChanges();
            return entity;
        }
    }
}
