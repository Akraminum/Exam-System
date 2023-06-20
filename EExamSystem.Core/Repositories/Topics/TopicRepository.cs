using EExamSystem.Core.Interfaces.IRepositories.Topics;
using EExamSystem.Infrastructure.DataBase;
using EExamSystem.Infrastructure.Entities.Topicss;

namespace EExamSystem.Core.Repositories.Topics
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
