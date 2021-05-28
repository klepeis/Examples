using GlobalExceptionHandler.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace GlobalExceptionHandler.Controllers
{
    [ApiController]
    public class ErrorController : ControllerBase
    {
        [Route("/error")]
        [Produces("application/json")]
        public IActionResult Error()
        {
            return this.Problems();
        }
    }
}
