using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace fiefapp.entities
{
    public class Gamesession
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string GamesessionId { get; set; }
        public string OwnerId { get; set; }
        public List<string> UserIds { get; set; }
        public string? GamemasterId { get; set; }
        public List<string> PlayerIds { get; set; }
        public string Name { get; set; }
    }
}