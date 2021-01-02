using fiefapp.entities.Interfaces;
using fiefapp.services.Interfaces;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace fiefapp.mongodb.Repositories
{
    class FiefForeinKeyRepository<T> : IFiefForeinKeyRepository<T> where T : class, IFiefForeinKey
    {
        protected IMongoCollection<T> _collection;
        protected IMongoDatabase _database;

        public FiefForeinKeyRepository(IDatabaseSettings settings)
        {
            if (!string.IsNullOrEmpty(settings.ConnectionString))
            {
                var client = new MongoClient(settings.ConnectionString);

                _database = client.GetDatabase(settings.DatabaseName);
                _collection = _database.GetCollection<T>(typeof(T).Name);
            }
        }

#nullable enable
        public virtual async Task<T?> GetByFiefIdAsync(Guid fiefId)
        {
            return await _collection.Find(e => e.FiefId == fiefId).FirstOrDefaultAsync();
        }
#nullable disable

        public virtual async Task<ICollection<T>> GetListByFiefIdAsync(Guid fiefId)
        {
            return await _collection.Find(e => e.FiefId == fiefId).ToListAsync();
        }
    }
}
