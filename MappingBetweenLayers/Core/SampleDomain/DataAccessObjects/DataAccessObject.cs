using MappingBetweenLayers.Services.External;
using System;

namespace MappingBetweenLayers.Core.SampleDomain.DataAccessObjects
{
    public class DataAccessObject : IDataAccessObject
    {
        public readonly IExternalService _externalService;

        public DataAccessObject(IExternalService externalService)
        {
            _externalService = externalService;
        }

        public void GetDataFromDatabase()
        {
            throw new NotImplementedException();
        }

        public void GetDataFromDatabaseAndExternalSource()
        {
            throw new NotImplementedException();
        }

        public void GetDataFromExternalSource()
        {
            throw new NotImplementedException();
        }
    }
}
