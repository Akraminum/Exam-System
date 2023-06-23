using EExamSystem.API.Models;
using EExamSystem.Core.Dtos.CateoryDtos;
using EExamSystem.Core.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace EExamSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICateoryService _CategoryService;
        private ResponseDto _response;
        public CategoryController(ICateoryService topicService)
        {
            _CategoryService = topicService;
            _response = new ResponseDto();
        }
        [HttpPost]
        public async Task<ResponseDto> AddCategory(CategoryDtoInput Cat)
        {
            try
            {
                var result = _CategoryService.Add(Cat);
                _response.Result = result;
            }
            catch (Exception ex)
            {

                _response.IsSuccess = false;
                _response.ErrorMessages
                    = new List<string> { ex.ToString() };
            }

            return _response;
        }
        [HttpGet("GetAllCategory")]
        public async Task<ResponseDto> GetAllCategory()
        {
            try
            {
                var result = await _CategoryService.GetAll();
                _response.Result = result;
            }
            catch (Exception ex)
            {

                _response.IsSuccess = false;
                _response.ErrorMessages
                    = new List<string> { ex.ToString() };
            }

            return _response;
        }
        [HttpGet]
        public async Task<ResponseDto> GetCategoryById(int id)
        {
            try
            {
                var result = await _CategoryService.GetById(id);
                _response.Result = result;
            }
            catch (Exception ex)
            {

                _response.IsSuccess = false;
                _response.ErrorMessages
                    = new List<string> { ex.ToString() };
            }

            return _response;
        }
        [HttpDelete]
        public async Task<ResponseDto> Remove(CategoryUpdateDto entity)
        {
            try
            {
                _CategoryService.Remove(entity);
                _response.Result = "this Category is deleted";
            }
            catch (Exception ex)
            {

                _response.IsSuccess = false;
                _response.ErrorMessages
                    = new List<string> { ex.ToString() };
            }

            return _response;
        }
        [HttpPut]
        public async Task<ResponseDto> Update(CategoryUpdateDto entity)
        {
            try
            {
                var result = await _CategoryService.Update(entity);
                _response.Result = result;
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
