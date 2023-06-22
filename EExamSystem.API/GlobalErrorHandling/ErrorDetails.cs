using System.Text.Json;

namespace EExamSystem.API.GlobalErrorHandling
{
    public class ErrorDetails
    {
        public string Message { get; set; }
        public int StatusCode { get; set; }
        public string ResponseMessage { get; set; }


        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
