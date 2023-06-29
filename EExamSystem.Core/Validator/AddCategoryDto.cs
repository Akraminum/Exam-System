using EExamSystem.Core.Dtos.CateoryDtos;
using FluentValidation;

namespace EExamSystem.Core.Validator
{
    public class AddCategoryDto : AbstractValidator<CategoryDtoInput>
    {
        public AddCategoryDto()
        {
            RuleFor(x => x.Title).NotEmpty();

        }
    }
}
