using System.ComponentModel.DataAnnotations;

namespace EExamSystem.Core.Dtos
{
    public class PagingParametersInputDto
    {
        const int _maxCount = 20;
        private int _defaultCount = 15;


        [Range(0, int.MaxValue)]
        public int PageNumber { get; set; } = 1;

        [Range(0, int.MaxValue)]
        public int Count
        {
            get
            {
                return _defaultCount;
            }
            set
            {
                _defaultCount = (value > _maxCount) ? _maxCount : value;
            }
        }
    }
}
