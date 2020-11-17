﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace fiefapp.entities
{
    public class InheritanceAlternative
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
