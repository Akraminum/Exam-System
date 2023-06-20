using EExamSystem.Core.Interfaces.IRepositories.Topics;
using EExamSystem.Infrastructure.DataBase;
using EExamSystem.Infrastructure.Entities.Topics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
