using AutoMapper;
using EExamSystem.Core.Dtos.CertificateDtos;
using EExamSystem.Core.Dtos.CertificateDtos.DeleteDto;
using EExamSystem.Core.Dtos.CertificateDtos.UpdateDtos;
using EExamSystem.Core.Services.IServices;
using EExamSystem.Infrastructure.Entities.Certificates;
using EExamSystem.Infrastructure.Repositories.IRepositories;

namespace EExamSystem.Core.Services
{
    public class CertificateService : ICertificateService
    {
        private readonly ICertificateRepository _certificateRepository;
        private readonly IMapper _mapper;

        public CertificateService(ICertificateRepository certificateRepository, IMapper mapper)
        {
            _certificateRepository = certificateRepository;
            _mapper = mapper;
        }

        public async Task<CertificateOutput> AddAsync(CertificateInput input)
        {
            var _entity = _mapper.Map<Certificate>(input);
            var _data = await _certificateRepository.AddAsync(_entity);
            var _output = _mapper.Map<CertificateOutput>(_data);
            return _output;
        }

        public async Task<List<CertificateOutput>> AddRangeAsync(List<CertificateInput> input)
        {
            var _entity = _mapper.Map<List<Certificate>>(input);
            var _data = await _certificateRepository.AddRangeAsync(_entity);
            var _output = _mapper.Map<List<CertificateOutput>>(_data);
            return _output;
        }


        public async Task DeleteAsync(CertificateDeleteInput input)
        {
            var _entity = _mapper.Map<Certificate>(input);
            await _certificateRepository.DeleteAsync(_entity.Id);
        }

        public async Task<CertificateOutput> GetAsync(int id)
        {
            var _entity = await _certificateRepository.GetByIdAsync(id);
            var _output = _mapper.Map<CertificateOutput>(_entity);
            return _output;
        }

        public async Task<List<CertificateOutput>> GetListAsync()
        {
            var _entities = await _certificateRepository.GetListAsync();
            var _output = _mapper.Map<List<CertificateOutput>>(_entities);
            return _output;
        }

        public async Task<List<CertificateOutput>> GetListByCategoryIdAsync(int id)
        {
            var _entities = await _certificateRepository.GetListByCategoryIdAsync(id);
            var _output = _mapper.Map<List<CertificateOutput>>(_entities);
            return _output;
        }

        public async Task<CertificateOutput> UpdateAsync(CertificateUpdateInput input)
        {
            var _entity = _mapper.Map<Certificate>(input);
            var _data = await _certificateRepository.UpdateAsync(_entity);
            var _output = _mapper.Map<CertificateOutput>(_data);
            return _output;
        }

        public async Task<List<CertificateOutput>> UpdateRangeAsync(List<CertificateUpdateInput> input)
        {
            var _entity = _mapper.Map<List<Certificate>>(input);
            var _data = await _certificateRepository.UpdateRangeAsync(_entity);
            var _output = _mapper.Map<List<CertificateOutput>>(_data);
            return _output;

        }

    }
}
