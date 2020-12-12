using fiefapp.entities;
using fiefapp.services.Interfaces;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace fiefapp.mongodb.Repositories
{
    class Repository<T> : IRepository<T> where T : class, IBaseEntity
    {
        protected IMongoCollection<T> _collection;
        protected IMongoDatabase _database;

        public Repository(IDatabaseSettings settings)
        {
            if (!string.IsNullOrEmpty(settings.ConnectionString))
            {
                var client = new MongoClient(settings.ConnectionString);

                _database = client.GetDatabase(settings.DatabaseName);
                _collection = _database.GetCollection<T>(typeof(T).Name);
            }
        }

        public virtual async Task<T?> InsertAsync(T entity)
        {
            if (entity.Id == null)
            {
                entity.Id = Guid.NewGuid();
            }

            await _collection.InsertOneAsync(entity);

            Console.WriteLine("ID: " + entity.Id);

            return entity.Id != null ? entity : null;
        }

        public virtual async Task<T?> GetByIdAsync(Guid id)
        {
            return await _collection.Find(e => e.Id == id).FirstOrDefaultAsync();
        }

        public virtual async Task<IEnumerable<T>> GetListAsync()
        {
            return await _collection.Find(e => true).ToListAsync();
        }

        public virtual async Task<T?> UpdateAsync(T entity)
        {
            var result = await _collection.ReplaceOneAsync(x => x.Id == entity.Id, entity, new ReplaceOptions() { IsUpsert = false });
            
            return result.ModifiedCount > 0 ? entity : null;
        }

        public virtual async Task<T?> DeleteAsync(Guid id)
        {
            return await _collection.FindOneAndDeleteAsync(e => e.Id == id);
        }
    }
}
