namespace EExamSystem.Core.Dtos.CertificateDtos
{
    public class CertificateOutput
    {
        public int Id { get; set; }

        public string CategoryName { get; set; }

        /* public int ExamId { get; set; }*/
        public string Title { get; set; }
        public string? Description { get; set; }
        public decimal? PassPercentage { get; set; }
        public string? signature { get; set; }



    }
}
