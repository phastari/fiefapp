using MongoDB.Driver;
using System.Collections.Generic;

namespace fiefapp.mongodb.Repositories.BuildingAlternative
{
    public class BuildingAlternativeRepository : IBuildingAlternativeRepository
    {
        private readonly IMongoCollection<entities.BuildingAlternative> _buildingAlternatives;

        public BuildingAlternativeRepository(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _buildingAlternatives = database.GetCollection<entities.BuildingAlternative>(settings.BuildingAlternativesCollectionName);
        }

        public List<entities.BuildingAlternative> Get() =>
            _buildingAlternatives.Find(
                alternative => alternative.IncludedInGamesessions.Contains("default"))
                                                                 .ToList();

        public List<entities.BuildingAlternative> Get(string id) =>
            _buildingAlternatives.Find(
                alternative => alternative.IncludedInGamesessions.Contains("default") 
                || alternative.IncludedInGamesessions.Contains(id))
                                                     .ToList();

        public entities.BuildingAlternative Create(entities.BuildingAlternative alternative)
        {
            _buildingAlternatives.InsertOne(alternative);
            return alternative;
        }

        public void Update(string id, entities.BuildingAlternative alternativeIn) =>
            _buildingAlternatives.ReplaceOne(alternative => alternative.Id == id, alternativeIn);

        public void Remove(entities.BuildingAlternative alternativeIn) =>
            _buildingAlternatives.DeleteOne(alternative => alternative.Id == alternativeIn.Id);

        public void Remove(string id) =>
            _buildingAlternatives.DeleteOne(alternative => alternative.Id == id);

        public entities.BuildingAlternative AddBuildingAlternative(entities.BuildingAlternative alternative)
        {
            _buildingAlternatives.InsertOne(alternative);
            return alternative;
        }
    }
}
