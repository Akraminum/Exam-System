using EExamSystem.Core.Services.IServices;
using EExamSystem.Core.Utilities.CustomeException;
using EExamSystem.Infrastructure.Entities.Questions;
using EExamSystem.Infrastructure.Repositories;
using EExamSystem.Infrastructure.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EExamSystem.Core.Services
{
    public class QuestionService : IQuestionService
    {
        private IQuestionRepository _questionRepository;

        public QuestionService(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }
        public async Task CreateQuestion(Question question)
        {
            // Validate Topic Existence
            // need TopicsService VS TopicRepo


            // Validate that at least one choice is correct one
            if (question.Choices is not null &&
                !question.Choices.Any(x => x.IsCorrect == true))
                throw new CustomException("user sent inv da", "At least one choice should be true", 400);


            // call repository
            await _questionRepository.AddAsync(question);

            // done!
            try
            { await _questionRepository.Save(); }
            catch (Exception ex) { throw new CustomException("saving data ........"); }
                

        }
    }
}
