using AutoMapper;
using EExamSystem.Core.Dtos.Tests;
using EExamSystem.Infrastructure.Entities.Tests;
using Microsoft.AspNetCore.Mvc;

namespace EExamSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IMapper _mapper;

        public TestController(IMapper mapper)
        {
            _mapper = mapper;
        }


        [HttpGet]
        public TestOutputDto Test([FromQuery]TestInputDto input)
        {
            var entity = _mapper.Map<Test>(input);
            var output = _mapper.Map<TestOutputDto>(entity);
            return output;
        }
    }
}
