using EExamSystem.Core.Dtos.Choices;
using EExamSystem.Infrastructure.Entities.Bridgets;
using EExamSystem.Infrastructure.Entities.Choices;
using EExamSystem.Infrastructure.Entities.Topicss;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EExamSystem.Core.Dtos.Questions
{
    public class CreateQuestionInputDto
    {
        [Range(1, int.MaxValue)]
        public int TopicId { get; set; }

        [StringLength(maximumLength: 500, MinimumLength = 5)]
        public string QuestionBody { get; set; } = null!;

        [MinLength(2)]
        [MaxLength(4)]
        public List<ChoiceInputDto> Choices { get; set; }
    }
}
