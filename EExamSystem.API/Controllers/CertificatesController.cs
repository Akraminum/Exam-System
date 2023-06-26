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
                {
                    _response.DisplayMessage = "Please enter Valid Id, Id Can't be null, 0 or less than 1.";
                    _response.Result = id;
                }

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
                if (id <= 0)
                {
                    _response.DisplayMessage = "Please enter Valid Id, Id Can't be null, 0 or less than 1.";
                    _response.Result = id;
                }
                var _data = await _certificateService.GetListByCategoryIdAsync(id);

                if (_data == null)
                    _response.DisplayMessage = "Sorry, This Category Id Doesn't Exist in database.";

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
                {
                    _response.DisplayMessage = "You entered invalid data.";
                    _response.Result = input;
                }

                var _exist = await _certificateService.GetListByCategoryIdAsync(input.CategoryId);

                if (_exist != null)
                {
                    _response.DisplayMessage = "Sorry, This Category Id is Already Exist in Database.";
                    _response.Result = input;
                }

                if (_certificateService.CheckRange(input.PassPercentage))
                {
                    _response.DisplayMessage = "Sorry, Pass Percentage must be between 50 and 100.";
                    _response.Result = input;
                }

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
                {
                    _response.DisplayMessage = "Please Enter Some Valid Data.";
                    _response.Result = input;
                }

                foreach (var item in input)
                {
                    var _exist = await _certificateService.GetListByCategoryIdAsync(item.CategoryId);

                    if (_exist != null)
                    {
                        _response.DisplayMessage = "Sorry, This Category Id is Already Exist in Database.";
                        _response.Result = item;
                    }

                    var check = _certificateService.CheckRange(item.PassPercentage);
                    if (check == false)
                    {
                        _response.DisplayMessage = "Sorry, Pass Percentage must be between 50 and 100.";
                        _response.Result = item;
                    }

                }

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
                {
                    _response.DisplayMessage = "You entered invalid data.";
                    _response.Result = input;
                }

                var _exist = await _certificateService.GetListByCategoryIdAsync(input.CategoryId);

                if (_exist != null)
                {
                    _response.DisplayMessage = "Sorry, This Category Id is Already Exist in Database.";
                    _response.Result = input;
                }

                var check = _certificateService.CheckRange(input.PassPercentage);
                if (check == false)
                {
                    _response.DisplayMessage = "Sorry, Pass Percentage must be between 50 and 100.";
                    _response.Result = input;
                }

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
                {
                    _response.DisplayMessage = "Please Enter Some Valid Data.";
                    _response.Result = input;
                }

                foreach (var item in input)
                {
                    var _exist = await _certificateService.GetListByCategoryIdAsync(item.CategoryId);
                    if (_exist != null)
                    {
                        _response.DisplayMessage = "Sorry, This Category Id is Already Exist in Database.";
                        _response.Result = item;
                    }

                    var check = _certificateService.CheckRange(item.PassPercentage);
                    if (check == false)
                    {
                        _response.DisplayMessage = "Sorry, Pass Percentage must be between 50 and 100.";
                        _response.Result = item;
                    }
                }

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
                {
                    _response.DisplayMessage = "You entered invalid data.";
                    _response.Result = input;
                }
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
