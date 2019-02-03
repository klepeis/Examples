using MappingBetweenLayers.Core.SampleDomain.DataAccessObjects;
using MappingBetweenLayers.Models.Controllers.Response;

namespace MappingBetweenLayers.Core.SampleDomain.BusinessObjects
{
    public class BusinessObject : IBusinessObject
    {
        private readonly IDataAccessObject _dataAccessObject;

        public BusinessObject(IDataAccessObject dataAccessObject)
        {
            _dataAccessObject = dataAccessObject;
        }

        public void GetDataFromDatabase()
        {
            _dataAccessObject.GetDataFromDatabase();
        }

        public GetExternalDataResponse GetDataFromExternalSource()
        {
            var result = _dataAccessObject.GetDataFromExternalSource();

            //TODO: How to map this...
            return new GetExternalDataResponse()
            {
                DataPoint1 = result.DataPoint1,
                DataPoint3 = result.DataPoint3
            };
        }

        public void GetDataFromDatabaseAndExternalSource()
        {
            _dataAccessObject.GetDataFromDatabaseAndExternalSource();
        }
    }
}
