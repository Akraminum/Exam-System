using AutoMapper;
using EExamSystem.Core.Dtos.Questions;
using EExamSystem.Infrastructure.Entities.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EExamSystem.Core.Mappers
{
    public class QuestionsMappingProfile : Profile
    {
        public QuestionsMappingProfile()
        {
            CreateMap<Question, QuestionDetailsOutputDto>();
            CreateMap<Question, QuestionOutputDto>();

            CreateMap<CreateQuestionInputDto, Question>();
        }
    }
}
