namespace fiefapp.mongodb
{
    public interface IDatabaseSettings
    {
        string BuildingAlternativesCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
