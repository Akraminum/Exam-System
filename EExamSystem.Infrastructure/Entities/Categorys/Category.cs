using EExamSystem.Infrastructure.Entities.Topicss;

namespace EExamSystem.Infrastructure.Entities.Categorys
{
    public class Category
    {
        public int Id { get; set; }
        /*  public int CertificateId { get; set; }
          public Certificate? Certificate { get; set; }*/
        public string Title { get; set; }

        public string? Description { get; set; }
        public ICollection<Topic>? Topics { get; set; }

    }
}
