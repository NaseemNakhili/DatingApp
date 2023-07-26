
namespace API.Errors
{
    public class ApiExcption
    {
        public ApiExcption(int statusCode, string message, string detalis)
        {
            StatusCode = statusCode;
            Message = message;
            Detalis = detalis;
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string Detalis { get; set; }

    }
}