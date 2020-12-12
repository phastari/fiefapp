using fiefapp.entities;
using fiefapp.services.Interfaces;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace fiefapp.mongodb.Repositories
{
    class GamesessionRepository : Repository<Gamesession>, IGamesessionRepository
    {
        public GamesessionRepository(IDatabaseSettings settings) : base(settings)
        {
        }

        public IEnumerable<Gamesession> GetGamesessionsAsPlayer(string userId)
        {
            return _collection.Find(e => e.PlayerIds.Contains(userId)).ToEnumerable();
        }

        public async Task<IEnumerable<Gamesession>> GetGamesessionsAsPlayerAsync(string userId)
        {
            return await _collection.Find(e => e.PlayerIds.Contains(userId)).ToListAsync();
        }

        public IEnumerable<Gamesession> GetGamesessionsAsGamemaster(string userId)
        {
            return _collection.Find(e => e.GamemasterId == userId).ToEnumerable();
        }

        public async Task<IEnumerable<Gamesession>> GetGamesessionsAsGamemasterAsync(string userId)
        {
            return await _collection.Find(e => e.GamemasterId == userId).ToListAsync();
        }

        public IEnumerable<Gamesession> GetGamesesssionInvitations(string userId)
        {
            return _collection.Find(e => e.UserIds.Contains(userId) && !e.PlayerIds.Contains(userId) && e.GamemasterId != userId).ToEnumerable();
        }

        public async Task<IEnumerable<Gamesession>> GetGamesessionInvitationsAsync(string userId)
        {
            return await _collection.Find(e => e.UserIds.Contains(userId) && !e.PlayerIds.Contains(userId) && e.GamemasterId != userId).ToListAsync();
        }

        public override async Task<Gamesession> InsertAsync(Gamesession entity)
        {
            if (entity.Id == null)
            {
                entity.Id = Guid.NewGuid();
            }

            await _collection.InsertOneAsync(entity);

            return entity;
        }
    }
}
