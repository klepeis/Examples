using Newtonsoft.Json;
using System.Collections.Generic;

namespace GlobalExceptionHandler.Models
{
    public class ErrorResponse
    {
        [JsonProperty("errors")]
        public List<ErrorDetails> Errors { get; private set; }

        public ErrorResponse()
        {
            Errors = new List<ErrorDetails>();
        }

        public void AddError(string id, int statusCode, string message)
        {
            Errors.Add(new ErrorDetails(id, statusCode, message));
        }

        public void AddError(ErrorDetails errorMessage)
        {
            Errors.Add(errorMessage);
        }

        public void AddErrors(IEnumerable<ErrorDetails> errorMessages)
        {
            Errors.AddRange(errorMessages);
        }
    }
}
