using fiefapp.entities;
using fiefapp.services.Interfaces;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace fiefapp.mongodb.Repositories
{
    class GamesessionRepository : BaseEntityRepository<Gamesession>, IGamesessionRepository
    {
        public GamesessionRepository(IDatabaseSettings settings) : base(settings)
        {
        }

        public async Task<IEnumerable<Gamesession>> GetGamesessionsAsync(string userId)
        {
            return await _collection.Find(e => e.UserIds.Contains(userId)).ToListAsync();
        }

        public async Task<Gamesession> GetGamesessionAsync(Guid id)
        {
            return await _collection.Find(e => e.Id == id).FirstOrDefaultAsync();
        }
    }
}
