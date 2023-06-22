using AutoMapper;
using EExamSystem.Core.Dtos.Questions;
using EExamSystem.Core.Services;
using EExamSystem.Core.Services.IServices;
using EExamSystem.Infrastructure.Entities.Questions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace EExamSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IQuestionService _questionService;

        public QuestionController(
            IMapper mapper,
            IQuestionService questionService
            )
        {
            _mapper = mapper;
            _questionService = questionService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateQuestionInputDto dto)
        {
            // map
            var entity = _mapper.Map<Question>(dto);



            // call service
            await _questionService.CreateQuestion(entity);


            // map
            var outputDto = _mapper.Map<QuestionDetailsOutputDto>(entity);
            return Ok(outputDto);
        }
    }
}
