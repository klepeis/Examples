using MappingBetweenLayers.Core.SampleDomain.BusinessObjects;
using MappingBetweenLayers.Models.Controllers.Response;
using Microsoft.AspNetCore.Mvc;

namespace MappingBetweenLayers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemosController : ControllerBase
    {
        private readonly IBusinessObject _businessObject;

        public DemosController(IBusinessObject businessObject)
        {
            _businessObject = businessObject;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<GetExternalDataResponse> GetFromExternalSource()
        {
            var returnValue = _businessObject.GetDataFromExternalSource();
            return Ok(returnValue);
        }
    }
}