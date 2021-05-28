using System.Text.Json.Serialization;

namespace GlobalExceptionHandler.Models
{
    public class ErrorDetails
    {
        public string Id { get; private set; }

        /// <summary>
        /// HTTP Status Code.
        /// </summary>
        public int Status { get; private set; }

        /// <summary>
        /// Status Code Desciptor.
        /// </summary>
        public string Title { get; set; }

        public string Detail { get; private set; }

        public ErrorDetails(string id, int statusCode, string detail)
        {
            Id = id;
            Status = statusCode;
            Detail = detail;
        }
    }
}
