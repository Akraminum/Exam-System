using EExamSystem.API.Models;
using EExamSystem.Core.Dtos.CertificateDtos;
using EExamSystem.Core.Dtos.CertificateDtos.DeleteDto;
using EExamSystem.Core.Dtos.CertificateDtos.UpdateDtos;
using EExamSystem.Core.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace EExamSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CertificatesController : ControllerBase
    {
        private readonly ICertificateService _certificateService;
        private ResponseDto _response;

        public CertificatesController(ICertificateService certificateService)
        {
            _certificateService = certificateService;
            _response = new ResponseDto();
        }

        [HttpGet("Get-By-Id")]
        public async Task<ResponseDto> GetById(int id)
        {
            try
            {
                if (id <= 0)
                    _response.DisplayMessage = "Please enter Valid Id, Id Can't be null, 0 or less than 1.";

                var _data = await _certificateService.GetAsync(id);

                if (_data == null)
                    _response.DisplayMessage = "Sorry, This Id Doesn't Exist.";

                _response.Result = _data;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }
            return _response;
        }

        [HttpGet("Get-All")]
        public async Task<ResponseDto> GetAll()
        {
            try
            {
                var _data = await _certificateService.GetListAsync();

                if (_data == null)
                    _response.DisplayMessage = "Sorry, This Id Doesn't Exist.";

                _response.Result = _data;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }
            return _response;
        }

        [HttpGet("Get-All-By-Category-Id")]
        public async Task<ResponseDto> GetAllByCategoryId(int id)
        {
            try
            {
                var _data = await _certificateService.GetListByCategoryIdAsync(id);

                if (_data == null)
                    _response.DisplayMessage = "Sorry, This Id Doesn't Exist.";

                _response.Result = _data;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }
            return _response;
        }

        [HttpPost("Add")]
        public async Task<ResponseDto> Add(CertificateInput input)
        {
            try
            {
                if (!ModelState.IsValid)
                    _response.DisplayMessage = "You entered invalid data.";

                var _data = await _certificateService.AddAsync(input);

                if (_data == null)
                    _response.DisplayMessage = "Sorry, This Id Doesn't Exist.";

                _response.DisplayMessage = "Your Data Added Successfully.";
                _response.Result = _data;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }
            return _response;
        }

        [HttpPost("Add-Range")]
        public async Task<ResponseDto> AddRange(List<CertificateInput> input)
        {
            try
            {
                if (!ModelState.IsValid || input.Count <= 0)
                    _response.DisplayMessage = "Please Enter Some Valid Data.";

                var _data = await _certificateService.AddRangeAsync(input);

                if (_data == null)
                    _response.DisplayMessage = "Sorry, This Id Doesn't Exist.";

                _response.DisplayMessage = "Data Added Successfully.";
                _response.Result = _data;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }
            return _response;
        }

        [HttpPut("Update")]
        public async Task<ResponseDto> Update(CertificateUpdateInput input)
        {
            try
            {
                if (!ModelState.IsValid)
                    _response.DisplayMessage = "You entered invalid data.";

                var _data = await _certificateService.UpdateAsync(input);

                if (_data == null)
                    _response.DisplayMessage = "Sorry, This Id Doesn't Exist.";

                _response.DisplayMessage = "Your Data Updated Successfully.";
                _response.Result = _data;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages
                    = new List<string> { ex.ToString() };
            }
            return _response;
        }

        [HttpPut("Update-Range")]
        public async Task<ResponseDto> UpdateRange(List<CertificateUpdateInput> input)
        {
            try
            {
                if (!ModelState.IsValid || input.Count <= 0)
                    _response.DisplayMessage = "Please Enter Some Valid Data.";

                var _data = await _certificateService.UpdateRangeAsync(input);

                if (_data == null)
                    _response.DisplayMessage = "Sorry, This Id Doesn't Exist.";

                _response.DisplayMessage = "Data Updated Successfully.";
                _response.Result = _data;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }
            return _response;
        }

        [HttpDelete("DeleteCertificate")]
        public async Task<ResponseDto> Delete(CertificateDeleteInput input)
        {
            try
            {
                if (!ModelState.IsValid)
                    _response.DisplayMessage = "You entered invalid data.";
                await _certificateService.DeleteAsync(input);

                _response.DisplayMessage = "This Record Deleted Successfully.";

            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages
                    = new List<string> { ex.ToString() };
            }
            return _response;
        }

    }
}
