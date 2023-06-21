using EExamSystem.Core.Dtos.CateoryDtos;
using FluentValidation;

namespace EExamSystem.Core.Validator
{
    public class AddCategoryDto : AbstractValidator<CategoryDto>
    {
        public AddCategoryDto()
        {
            RuleFor(x => x.Title).NotEmpty();

        }
    }
}
