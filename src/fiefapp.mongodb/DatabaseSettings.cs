namespace fiefapp.mongodb
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string BuildingAlternativesCollectionName { get; set; }
        public string InheritancesCollectionName { get; set; }
        public string LivingconditionsCollectionName { get; set; }
        public string RoadsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
