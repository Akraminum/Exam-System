using EExamSystem.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EExamSystem.Infrastructure.Entities;

namespace EExamSystem.Core.Interfaces.IRepositories.Topics
{
    public interface ITopicRepository : IGenericRepository<Topic>, IPagableRepository<Topic>
    {
        public Topic? CustomeRepoMethod(int id);
    }
    
}
