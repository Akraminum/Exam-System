using EExamSystem.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EExamSystem.Infrastructure.Entities.Topics;

namespace EExamSystem.Core.Interfaces.IRepositories.Topics
{
    public interface ITopicRepository : IGenericRepository<Topic>
    {
        public Topic? CustomeRepoMethod(int id);
    }
    
}
