using MappingBetweenLayers.Models.Controllers.Response;

namespace MappingBetweenLayers.Core.SampleDomain.BusinessObjects
{
    public interface IBusinessObject
    {
        void GetDataFromDatabase();
        GetExternalDataResponse GetDataFromExternalSource();
        void GetDataFromDatabaseAndExternalSource();
    }
}