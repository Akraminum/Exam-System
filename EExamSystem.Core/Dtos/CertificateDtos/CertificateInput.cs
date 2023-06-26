﻿namespace EExamSystem.Core.Dtos.CertificateDtos
{
    public class CertificateInput
    {

        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }

        //[Range(0, 100, ErrorMessage = "Sorry but Pass Percentage must be between 50 and 100.")]
        public decimal PassPercentage { get; set; }
        public string? signature { get; set; }


    }
}