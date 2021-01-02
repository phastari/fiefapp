using fiefapp.entities;
using fiefapp.entities.Interfaces;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;

namespace fiefapp.mongodb.Mapping
{
    public static class MongoDBMapperConfiguration
    {
        public static void RegisterMongoDBMappings()
        {
            BsonSerializer.RegisterSerializer(new GuidSerializer(BsonType.String));

            RegisterClass<Gamesession>();
            RegisterClass<Fief>();
            RegisterClass<Inheritance>();
            RegisterClass<Livingcondition>();
            RegisterClass<Road>();
            RegisterClass<Building>();
        }

        private static void RegisterClass<T>() where T : IBaseEntity
        {
            BsonClassMap.RegisterClassMap<T>(cm =>
            {
                cm.AutoMap();
                cm.MapIdMember(c => c.Id);
            });
        }
    }
}
