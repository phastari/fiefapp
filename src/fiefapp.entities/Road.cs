using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace fiefapp.entities
{
    public class Road
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public int UpgradeBaseCost { get; set; }
        public int UpgradeStoneCost { get; set; }
        public double ModificationFactor { get; set; }
        public int Dayswork { get; set; }
        public List<string> IncludedInGamesessions { get; set; }
    }
}
