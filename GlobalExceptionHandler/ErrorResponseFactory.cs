using GlobalExceptionHandler.Exceptions;
using GlobalExceptionHandler.Models;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace GlobalExceptionHandler
{
    public class ErrorResponseFactory
    {
        private readonly IExceptionHandlerFeature _exceptionHandler;
        private readonly HttpContext _httpContext;

        public ErrorResponseFactory(HttpContext httpContext)
        {
            _exceptionHandler = httpContext.Features.Get<IExceptionHandlerFeature>();
            _httpContext = httpContext;
        }

        public ErrorResponse CreateErrorResponse()
        {
            ErrorResponse returnValue = new ErrorResponse();

            Exception ex = _exceptionHandler.Error;

            if (ex as AggregateException != null)
            {
                AggregateException aggregateException = ex as AggregateException;
                returnValue.AddErrors(ProcessAggregateException(aggregateException));
            }

            if (ex as ApiCallFailedException != null)
            {
                ApiCallFailedException apiCallFailedException = ex as ApiCallFailedException;
                returnValue.AddError(ProcessApiCallFailedException(apiCallFailedException));
            }

            returnValue.AddError(_httpContext.TraceIdentifier, 500, ex.Message);

            return returnValue;
        }

        private List<ErrorDetails> ProcessAggregateException(AggregateException aggregateException)
        {
            List<ErrorDetails> returnValue = new List<ErrorDetails>();

            foreach (Exception ex in aggregateException.InnerExceptions)
            {
                //TODO: Handle this
            }

            return returnValue;
        }

        private ErrorDetails ProcessApiCallFailedException(ApiCallFailedException apiCallFailedException)
        {
            ErrorDetails returnValue = new ErrorDetails(_httpContext.TraceIdentifier, apiCallFailedException.StatusCode, apiCallFailedException.Message);

            return returnValue;
        }
    }
}
