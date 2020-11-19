namespace fiefapp.mongodb
{
    public interface IDatabaseSettings
    {
        string BuildingAlternativesCollectionName { get; set; }
        string InheritancesCollectionName { get; set; }
        string LivingconditionsCollectionName { get; set; }
        string RoadsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
