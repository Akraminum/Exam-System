namespace EExamSystem.Core.Utilities.CustomeException
{
    public class CustomException : Exception
    {
        public int StatusCode { get; set; }
        public string ResponseMessage { get; set; }

        public CustomException(string message) : base(message)
        {
        }

        public CustomException(string message, string responseMessage, int suatusCode) : base(message)
        {
            StatusCode = suatusCode;
            ResponseMessage = responseMessage;
        }

        public CustomException(string message, Exception innerException) : base(message, innerException)
        {
        }

    }
}
