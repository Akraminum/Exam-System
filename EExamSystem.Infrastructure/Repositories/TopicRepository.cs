using EExamSystem.Infrastructure.DataBase;
using EExamSystem.Infrastructure.Entities.Topicss;
using EExamSystem.Infrastructure.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace EExamSystem.Infrastructure.Repositories
{
    public class TopicRepository : ITopicRepository
    {
        private readonly ApplicationDbContext Context;
        /* private readonly ApplicationDbContext _aspNetCoreNTierDbContext;*/
        public TopicRepository(ApplicationDbContext db)

        {
            Context = db;
        }

        public async Task<List<Topic>> GetByCategoryId(int id)
        {
            return await Context.Topics.Where(x => x.CategoryId == id).ToListAsync();
        }

        public async Task<Topic> AddAsync(Topic entity)
        {
            await Context.Topics.AddAsync(entity);
            Context.SaveChanges();
            return entity;
        }

        public async Task<List<Topic>> AddRangeAsync(List<Topic> entity)
        {
            await Context.Topics.AddRangeAsync(entity);
            Context.SaveChanges();
            return entity;
        }

        public async Task<int> DeleteAsync(int id)
        {
            var result = Context.Topics.SingleOrDefault(x => x.Id == id);
            var ret = result.Id;
            Context.Topics.Remove(result);
            Context.SaveChanges();
            return ret;
        }

        public async Task<List<Topic>> GetListAsync()
        {
            var result = await Context.Topics.ToListAsync();
            return result.ToList();
        }
        public async Task<Topic> GetByIdAsync(int id)
        {
            var result = await Context.Topics.FindAsync(id);
            return result;

        }
        public async Task<Topic> UpdateAsync(Topic entity)
        {
            var result = Context.Topics.Update(entity);
            Context.SaveChanges();
            return entity;
        }

        public async Task<List<Topic>> UpdateRangeAsync(List<Topic> entity)
        {
            Context.Topics.UpdateRange(entity);
            Context.SaveChanges();
            return entity;
        }


    }
}
