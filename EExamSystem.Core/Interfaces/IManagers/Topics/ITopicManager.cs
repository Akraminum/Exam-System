using EExamSystem.Core.Interfaces.IRepositories.Topics;
using EExamSystem.Infrastructure.Entities.Topics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EExamSystem.Core.Interfaces.IManagers.Topics
{
    public interface ITopicManager
    {
        IEnumerable<Topic> GetAllTopics();
        IEnumerable<Topic> GetAllByCategory();
        IEnumerable<Topic> GetAllByName();

        IEnumerable<Topic> GetTopicById();
    }
}
