namespace EExamSystem.Core.Dtos.CertificateDtos
{
    public class CertificateInput
    {

        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public decimal? PassPercentage { get; set; }
        public string? signature { get; set; }


    }
}
