using System.ComponentModel.DataAnnotations;

namespace EExamSystem.Core.DTO
{
    public class QueryParametersDto
    {

        [MaxLength(255)]
        public string? Name { get; set; }


        [MaxLength(255)]
        public string? Title { get; set; }

    }
}
