using AutoMapper;
using EExamSystem.Core.Dtos.CertificateDtos;
using EExamSystem.Core.Dtos.CertificateDtos.DeleteDto;
using EExamSystem.Core.Dtos.CertificateDtos.UpdateDtos;
using EExamSystem.Infrastructure.Entities.Certificates;

namespace EExamSystem.Core.Mappers
{
    public class CertificateProfile : Profile
    {
        public CertificateProfile()
        {
            CreateMap<Certificate, CertificateOutput>()
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Title));

            CreateMap<CertificateInput, Certificate>();
            CreateMap<CertificateUpdateInput, Certificate>();
            CreateMap<CertificateDeleteInput, Certificate>();
        }
    }
}
