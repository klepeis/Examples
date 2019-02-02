namespace MappingBetweenLayers.Core.SampleDomain.BusinessObjects
{
    public interface IBusinessObject
    {
        void GetDataFromDatabase();

        void GetDataFromExternalSource();

        void GetDataFromDatabaseAndExternalSource();
    }
}