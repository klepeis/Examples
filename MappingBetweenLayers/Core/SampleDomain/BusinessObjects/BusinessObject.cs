using MappingBetweenLayers.Core.SampleDomain.DataAccessObjects;

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

        public void GetDataFromDatabaseAndExternalSource()
        {
            _dataAccessObject.GetDataFromDatabaseAndExternalSource();
        }

        public void GetDataFromExternalSource()
        {
            _dataAccessObject.GetDataFromExternalSource();
        }
    }
}
