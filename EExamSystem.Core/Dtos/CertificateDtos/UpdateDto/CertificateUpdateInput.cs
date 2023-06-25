namespace EExamSystem.Core.Dtos.CertificateDtos.UpdateDtos
{
    public class CertificateUpdateInput
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public string Title { get; set; }

        public string? Description { get; set; }

        public decimal? PassPercentage { get; set; }

        public string? signature { get; set; }

    }
}
