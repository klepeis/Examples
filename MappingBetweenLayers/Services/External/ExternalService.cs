using MappingBetweenLayers.Services.External.Models.Responses;
using System.Net.Http;

namespace MappingBetweenLayers.Services.External
{
    public class ExternalService : IExternalService
    {
        private readonly HttpClient _httpClient;

        public ExternalService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public GetExternalDataResponse GetExternalData()
        {
            //Make external service call to retrieve data.
            return new GetExternalDataResponse()
            {
                DataPoint1 = "Value1",
                DataPoint2 = "Value2",
                DataPoint3 = "Value3"
            };
        }
    }
}
