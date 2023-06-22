using EExamSystem.Core.Dtos.TopicDtos;
using EExamSystem.Core.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace EExamSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopicController : ControllerBase
    {
        private readonly ITopicService _topicService;
        public TopicController(ITopicService topicService)
        {
            _topicService = topicService;
        }
        /*    [HttpGet]
            public async Task<IActionResult> GetAllTopic()
            {
                try
                {
                    return Ok(await _topicService.GetListAsync());
                }
                catch (Exception)
                {
                    return BadRequest("Something went wrong");
                }
            }
            [HttpGet]
            public async Task<IActionResult> GetListTopicsByCategoryId(int id)
            {
                try
                {
                    return Ok(await _topicService.GetByCategoryId(id));
                }
                catch (Exception)
                {
                    return BadRequest("Something went wrong");
                }
            }*/

        [HttpPost]
        public async Task<IActionResult> AddTopic(TopicDtoInput topic)
        {
            try
            {
                var result = await _topicService.AddAsync(topic);
                return Ok(result);
            }
            catch (Exception)
            {
                return BadRequest("Something went wrong");
            }
        }
        [HttpGet("GetByCategoryId")]
        public async Task<IActionResult> GetByCategoryId(int id)
        {
            try
            {
                return Ok(await _topicService.GetByCategoryId(id));
            }
            catch (Exception)
            {
                return BadRequest("Something went wrong");
            }
        }
        [HttpGet("GetAllTopic")]
        public async Task<IActionResult> GetAllTopic()
        {
            try
            {
                return Ok(await _topicService.GetListAsync());
            }
            catch (Exception)
            {
                return BadRequest("Something went wrong");
            }
        }
    }
}
