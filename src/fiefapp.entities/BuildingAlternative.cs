using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace fiefapp.entities
{
    public class BuildingAlternative
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Type { get; set; }
        public decimal Upkeep { get; set; }
        public int Stonework { get; set; }
        public int Woodwork { get; set; }
        public int Smithswork { get; set; }
        public int Stone { get; set; }
        public int Wood { get; set; }
        public int Iron { get; set; }
    }
}
