using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace fiefapp.entities
{
    public class RoadAlternative
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public int UpgradeBaseCost { get; set; }
        public int UpgradeStoneCost { get; set; }
        public double ModificationFactor { get; set; }
    }
}
