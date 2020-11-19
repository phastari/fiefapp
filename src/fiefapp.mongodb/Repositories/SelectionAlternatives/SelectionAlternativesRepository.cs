using MongoDB.Driver;

namespace fiefapp.mongodb.Repositories.SelectionAlternatives
{
    public class SelectionAlternativesRepository : ISelectionAlternativesRepository
    {
        private readonly IMongoCollection<entities.Inheritance> _inheritances;
        private readonly IMongoCollection<entities.Livingcondition> _livingconditions;
        private readonly IMongoCollection<entities.Road> _roads;

        public SelectionAlternativesRepository(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _inheritances = database.GetCollection<entities.Inheritance>(settings.InheritancesCollectionName);
            _livingconditions = database.GetCollection<entities.Livingcondition>(settings.LivingconditionsCollectionName);
            _roads = database.GetCollection<entities.Road>(settings.RoadsCollectionName);
        }

        public entities.SelectionAlternatives Get() =>
            new entities.SelectionAlternatives {
                Inheritances = _inheritances.Find(
                    inheritance => inheritance.IncludedInGamesessions.Contains("default"))
                                                                     .ToList(),

                Roads = _roads.Find(
                    road => road.IncludedInGamesessions.Contains("default"))
                                                       .ToList(),

                Livingconditions = _livingconditions.Find(
                    livingcondition => livingcondition.IncludedInGamesessions.Contains("default"))
                                                                             .ToList()
            };

        public entities.SelectionAlternatives Get(string id) =>
            new entities.SelectionAlternatives {
                Inheritances = _inheritances.Find(
                    inheritance => inheritance.IncludedInGamesessions.Contains("default") 
                    || inheritance.IncludedInGamesessions.Contains(id))
                                                         .ToList(),

                Roads = _roads.Find(
                    road => road.IncludedInGamesessions.Contains("default") 
                    || road.IncludedInGamesessions.Contains(id))
                                                  .ToList(),

                Livingconditions = _livingconditions.Find(
                    livingcondition => livingcondition.IncludedInGamesessions.Contains("default") 
                    || livingcondition.IncludedInGamesessions.Contains(id))
                                                             .ToList()
            };
    }
}
