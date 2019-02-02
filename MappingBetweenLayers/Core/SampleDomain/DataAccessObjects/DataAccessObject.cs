using MappingBetweenLayers.Infrastructure.DbContexts;
using MappingBetweenLayers.Services.External;
using System;

namespace MappingBetweenLayers.Core.SampleDomain.DataAccessObjects
{
    public class DataAccessObject : IDataAccessObject
    {
        public readonly IExternalService _externalService;
        private readonly SampleDbContext _sampleDbContext;

        public DataAccessObject(SampleDbContext sampleContext, IExternalService externalService)
        {
            _externalService = externalService;
            _sampleDbContext = sampleContext;
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
