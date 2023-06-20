using EExamSystem.Infrastructure.DataBase;
using EExamSystem.Infrastructure.Entities.Topicss;
using EExamSystem.Infrastructure.Repositories.IRepositories.Topics;

namespace EExamSystem.Infrastructure.Repositories.Topics
{
    public class TopicRepository : GenericRepository<Topic>, ITopicRepository
    {
        public TopicRepository(ApplicationDbContext context) : base(context)
        { }

        public Topic? CustomeRepoMethod(int id)
        {
            throw new Exception();
        }
    }
}
