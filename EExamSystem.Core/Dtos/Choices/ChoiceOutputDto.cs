using EExamSystem.Infrastructure.Entities.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EExamSystem.Core.Dtos.Choices
{
    public class ChoiceOutputDto
    {
        public int id { get; set; }
        public string ChoiceBody { get; set; }

    }
}
