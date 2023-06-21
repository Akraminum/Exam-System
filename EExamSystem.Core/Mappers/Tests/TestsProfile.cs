using AutoMapper;
using EExamSystem.Core.Dtos.CateoryDtos;
using EExamSystem.Infrastructure.Entities.Categorys;

namespace EExamSystem.API.Mappers.Tests
{
    public class TestsProfile : Profile
    {
        public TestsProfile()
        {
            CreateMap<CategoryDto, Category>();
            CreateMap<Category, CategoryDto>();
        }
    }
}
