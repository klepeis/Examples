using MappingBetweenLayers.Models;

namespace MappingBetweenLayers.Core.SampleDomain.DataAccessObjects
{
    public interface IDataAccessObject
    {
        void GetDataFromDatabase();
        IGetExternalDataResponse GetDataFromExternalSource();
        void GetDataFromDatabaseAndExternalSource();
    }
}