using EExamSystem.API.Models;
using EExamSystem.Core.Dtos.TopicDtos;
using EExamSystem.Core.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace EExamSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopicController : ControllerBase
    {
        private ResponseDto _response;
        private readonly ITopicService _topicService;
        public TopicController(ITopicService topicService)
        {
            _topicService = topicService;
            _response = new ResponseDto();
        }


        [HttpPost]
        public async Task<ResponseDto> AddTopic(TopicDtoInput topic)
        {
            try
            {
                var result = _topicService.Add(topic);
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
        [HttpGet("GetByCategoryId")]
        public async Task<ResponseDto> GetByCategoryId(int id)
        {
            try
            {
                var result = await _topicService.GetByCategoryId(id);
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
        [HttpGet("GetAllTopic")]
        public async Task<ResponseDto> GetAllTopic()
        {
            try
            {
                var result = await _topicService.GetAll();
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
        public async Task<ResponseDto> Remove(TopicDtoUpdate entity)
        {
            try
            {
                _topicService.Remove(entity);
                _response.Result = "this topic is deleted";
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
        public async Task<ResponseDto> Update(TopicDtoUpdate entity)
        {
            try
            {
                var result = await _topicService.Update(entity);
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
