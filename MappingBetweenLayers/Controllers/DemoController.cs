using MappingBetweenLayers.Core.SampleDomain.BusinessObjects;
using Microsoft.AspNetCore.Mvc;

namespace MappingBetweenLayers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly IBusinessObject _businessObject;

        public DemoController(IBusinessObject businessObject)
        {
            _businessObject = businessObject;
        }
    }
}