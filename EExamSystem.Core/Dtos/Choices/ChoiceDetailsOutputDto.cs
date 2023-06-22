using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EExamSystem.Core.Dtos.Choices
{
    public class ChoiceDetailsOutputDto
    {
        public int id { get; set; }
        public string ChoiceBody { get; set; }
        public bool IsCorrect { get; set; }
    }
}
