using AutoMapper;
using EExamSystem.Core.Dtos.Tests;
using EExamSystem.Infrastructure.Entities.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EExamSystem.API.Mappers.Tests
{
    public class TestsProfile : Profile
    {
        public TestsProfile()
        {
            CreateMap<TestInputDto, Test>();
            CreateMap<Test, TestOutputDto>();
        }
    }
}
