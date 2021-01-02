using fiefapp.entities;
using fiefapp.services.Interfaces;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace fiefapp.mongodb.Repositories
{
    class StewardRepository : IStewardRepository
    {
        private readonly IMongoCollection<Steward> _collection;
        private readonly IMongoDatabase _database;

        public StewardRepository(IDatabaseSettings settings)
        {
            if (!string.IsNullOrEmpty(settings.ConnectionString))
            {
                var client = new MongoClient(settings.ConnectionString);

                _database = client.GetDatabase(settings.DatabaseName);
                _collection = _database.GetCollection<Steward>("Steward");
            }
        }

        public async Task<Steward> GetStewardForEntity(Guid entityId)
        {
            return await _collection.Find(e => e.AssignedTo == entityId).SingleOrDefaultAsync();
        }

        public async Task<ICollection<Steward>> GetStewardsForGamesessionAndUser(Guid gamesessionId, string userId)
        {
            return await _collection.Find(e => e.GamesessionId == gamesessionId && e.UserId == userId).ToListAsync();
        }
    }
}
