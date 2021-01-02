using fiefapp.entities.Interfaces;
using fiefapp.services.Interfaces;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace fiefapp.mongodb.Repositories
{
    class AlternativesRepository<T> : BaseEntityRepository<T>, IAlternativesRepository<T> where T : class, IAlternativeEntity, IBaseEntity
    {
        public AlternativesRepository(IDatabaseSettings settings) : base(settings)
        {
        }

        public async Task<List<T>> GetAsync(Guid gamesessionId)
        {
            return gamesessionId == Guid.Empty
                ? await _collection.Find(e => e.GamesessionIds.Contains(gamesessionId)).ToListAsync()
                : await _collection.Find(e => e.GamesessionIds.Contains(gamesessionId) || e.GamesessionIds.Contains(Guid.Empty)).ToListAsync();
        }

        public async Task<T> AddAsync(T entity)
        {
            await _collection.InsertOneAsync(entity);

            return entity;
        }
    }
}
