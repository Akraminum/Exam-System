using EExamSystem.Core.Dtos.CertificateDtos;
using EExamSystem.Core.Dtos.CertificateDtos.DeleteDto;
using EExamSystem.Core.Dtos.CertificateDtos.UpdateDtos;

namespace EExamSystem.Core.Services.IServices
{
    public interface ICertificateService
    {
        Task<CertificateOutput> GetAsync(int id);

        Task<List<CertificateOutput>> GetListByCategoryIdAsync(int id);

        Task<List<CertificateOutput>> GetListAsync();

        Task<CertificateOutput> AddAsync(CertificateInput input);

        Task<CertificateOutput> UpdateAsync(CertificateUpdateInput input);

        Task DeleteAsync(CertificateDeleteInput input);

        Task<List<CertificateOutput>> AddRangeAsync(List<CertificateInput> input);

        Task<List<CertificateOutput>> UpdateRangeAsync(List<CertificateUpdateInput> input);
    }
}
