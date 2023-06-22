using AutoMapper;
using EExamSystem.Core.Dtos.Choices;
using EExamSystem.Infrastructure.Entities.Choices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EExamSystem.Core.Mappers
{
    public class ChoicesMappingProfile : Profile
    {
        public ChoicesMappingProfile()
        {
            CreateMap<Choice, ChoiceOutputDto>();
            CreateMap<Choice, ChoiceDetailsOutputDto>();

            CreateMap<ChoiceInputDto, Choice>();
        }
    }
}
