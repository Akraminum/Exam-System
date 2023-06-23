using AutoMapper;
using EExamSystem.Core.Dtos.CateoryDtos;
using EExamSystem.Core.Dtos.TopicDtos;
using EExamSystem.Infrastructure.Entities.Categorys;
using EExamSystem.Infrastructure.Entities.Topicss;

namespace EExamSystem.API.Mappers.Tests
{
    public class TestsProfile : Profile
    {
        public TestsProfile()
        {
            CreateMap<CategoryDtoInput, Category>();
            CreateMap<Category, CategoryDtoOutput>();
            CreateMap<CategoryUpdateDto, Category>();


            CreateMap<TopicDtoInput, Topic>();
            CreateMap<Topic, TopicDtoOutput>();
            CreateMap<TopicDtoUpdate, Topic>();


            CreateMap<TopicDtoInput, TopicDtoOutput>()
            .ForMember(dest => dest.Id, opt => opt.Ignore()) // Ignorer la propriété "Id" lors du mapping
            .ForMember(dest => dest.Category, opt => opt.Ignore()); // Ignorer la propriété "Category" lors du mapping

            CreateMap<CategoryDtoInput, CategoryDtoOutput>()
           .ForMember(dest => dest.Id, opt => opt.Ignore());// Ignorer la propriété "Id" lors du mapping

        }
    }
}
