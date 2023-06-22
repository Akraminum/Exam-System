using EExamSystem.Infrastructure.Entities.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EExamSystem.Infrastructure.Repositories.IRepositories
{
    public interface IQuestionRepository
    {
        Task<Question> GetAsync(Expression<Func<Question, bool>> filter = null);
        Task<List<Question>> GetListAsync(Expression<Func<Question, bool>> filter = null);
       
        
        Task AddAsync(Question entity);
        Task<Question> UpdateAsync(Question entity);
        Task<int> DeleteAsync(Question entity);


        Task<int> Save();
    }
}
