using fiefapp.entities;
using fiefapp.services.Interfaces;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace fiefapp.mongodb.Repositories
{
    class FiefRepository : IFiefRepository
    {
        private readonly IMongoCollection<Fief> _collection;
        private readonly IMongoDatabase _database;

        public FiefRepository(IDatabaseSettings settings)
        {
            if (!string.IsNullOrEmpty(settings.ConnectionString))
            {
                var client = new MongoClient(settings.ConnectionString);

                _database = client.GetDatabase(settings.DatabaseName);
                _collection = _database.GetCollection<Fief>("Fief");
            }
        }

        public async Task<ICollection<Fief>> GetFiefsForGamesessionAndUser(Guid gamesessionId, string userId)
        {
            return await _collection.Find(e => e.GamesessionId == gamesessionId && e.UserId == userId).ToListAsync();
        }
    }
}
