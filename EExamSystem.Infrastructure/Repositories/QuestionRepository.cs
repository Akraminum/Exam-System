using EExamSystem.Infrastructure.DataBase;
using EExamSystem.Infrastructure.Entities.Questions;
using EExamSystem.Infrastructure.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EExamSystem.Infrastructure.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly ApplicationDbContext _context;
        public QuestionRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Question entity)
        {
            await _context.Set<Question>().AddAsync(entity);
            
        }

        public Task<int> DeleteAsync(Question entity)
        {
            throw new NotImplementedException();
        }

        public Task<Question> GetAsync(Expression<Func<Question, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<List<Question>> GetListAsync(Expression<Func<Question, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<Question> UpdateAsync(Question entity)
        {
            throw new NotImplementedException();
        }
   
        public async Task<int> Save()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
