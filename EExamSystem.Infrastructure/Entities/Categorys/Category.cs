using EExamSystem.Infrastructure.Entities.Certificates;

namespace EExamSystem.Infrastructure.Entities.Categorys
{
    public class Category
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public ICollection<Topic> Topics { get; set; }
        public ICollection<Certificate> Certificates { get; set; }
    }
}
