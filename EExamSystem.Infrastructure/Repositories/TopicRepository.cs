using EExamSystem.Infrastructure.DataBase;
using EExamSystem.Infrastructure.Entities.Topicss;
using EExamSystem.Infrastructure.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace EExamSystem.Infrastructure.Repositories
{
    public class TopicRepository : GenericRepository<Topic, int>, ITopicRepository
    {
        /* public readonly ApplicationDbContext Context;*/
        private readonly ApplicationDbContext _aspNetCoreNTierDbContext;
        public TopicRepository(ApplicationDbContext db) : base(db)

        {
            _aspNetCoreNTierDbContext = db;
        }

        public async Task<List<Topic>> GetByCategoryId(int id)
        {
            return await _aspNetCoreNTierDbContext.Set<Topic>().Where(x => x.CategoryId == id).ToListAsync();
        }


    }
}
