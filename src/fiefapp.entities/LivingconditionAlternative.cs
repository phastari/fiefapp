using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace fiefapp.entities
{
    public class LivingconditionAlternative
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public int BaseCost { get; set; }
        public int LuxuryCost { get; set; }
        public int FocusGain { get; set; }
        public int WellbeingGain { get; set; }
        public string Description { get; set; }
    }
}
