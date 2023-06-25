﻿using EExamSystem.Core.Dtos.Choices;
using EExamSystem.Infrastructure.Entities.Bridgets;
using EExamSystem.Infrastructure.Entities.Choices;
using EExamSystem.Infrastructure.Entities.Topicss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EExamSystem.Core.Dtos.Questions
{
    public class QuestionOutputDto
    {
        public int Id { get; set; }
        public string QuestionBody { get; set; }

        public List<ChoiceOutputDto> Choices { get; set; }

    }
}