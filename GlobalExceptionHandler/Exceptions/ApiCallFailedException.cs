using System;
using System.Runtime.Serialization;

namespace GlobalExceptionHandler.Exceptions
{
    [Serializable]
    public class ApiCallFailedException : Exception
    {
        public int StatusCode { get; private set; }

        public ApiCallFailedException() { }

        public ApiCallFailedException(int statusCode)
        {
            StatusCode = statusCode;
        }

        public ApiCallFailedException(string message)
            :base(message)
        {
        }

        public ApiCallFailedException(int statusCode, string message)
            :base(message)
        {
            StatusCode = statusCode;
        }

        public ApiCallFailedException(string message, Exception innerException) 
            :base(message, innerException)
        {
        }

        public ApiCallFailedException(int statusCode, string message, Exception innerException)
            : base(message, innerException)
        {
            StatusCode = statusCode;
        }

        public ApiCallFailedException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public ApiCallFailedException(int statusCode, SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            StatusCode = statusCode;
        }
    }
}
