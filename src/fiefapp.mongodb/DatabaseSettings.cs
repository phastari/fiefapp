namespace fiefapp.mongodb
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string BuildingAlternativesCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
