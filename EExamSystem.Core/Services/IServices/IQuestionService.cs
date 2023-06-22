using EExamSystem.Infrastructure.Entities.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EExamSystem.Core.Services.IServices
{
    public interface IQuestionService
    {
        Task CreateQuestion(Question question);
    }
}
