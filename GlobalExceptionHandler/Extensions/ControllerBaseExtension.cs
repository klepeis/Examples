using GlobalExceptionHandler.Models;
using Microsoft.AspNetCore.Mvc;

namespace GlobalExceptionHandler.Extensions
{
    public static class ControllerBaseExtension
    {
        [NonAction]
        public static ObjectResult Problems(this ControllerBase controller)
        { 
            ErrorResponseFactory errorResponseFactory = new ErrorResponseFactory(controller.HttpContext);
            ErrorResponse errorResponse = errorResponseFactory.CreateErrorResponse();

            return new ObjectResult(errorResponse);
        }
    }
}
