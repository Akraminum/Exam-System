using System.ComponentModel.DataAnnotations;

namespace EExamSystem.Core.DTO
{
    public class PagingParametersDto
    {
        const int maxPageSize = 20;
        private int _pageSize = 15;

        [Range(0, int.MaxValue)]
        public int PageNumber { get; set; } = 1;

        [Range(0, int.MaxValue)]
        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = (value > maxPageSize) ? maxPageSize : value;
            }
        }
    }
}
