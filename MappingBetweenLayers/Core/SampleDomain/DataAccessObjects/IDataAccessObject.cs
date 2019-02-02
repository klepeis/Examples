namespace MappingBetweenLayers.Core.SampleDomain.DataAccessObjects
{
    public interface IDataAccessObject
    {
        void GetDataFromDatabase();

        void GetDataFromExternalSource();

        void GetDataFromDatabaseAndExternalSource();
    }
}