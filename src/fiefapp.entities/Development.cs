using fiefapp.entities.Interfaces;
using System;

namespace fiefapp.entities
{
    public class Development : IBaseEntity, INeedSteward
    {
        public Development()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public Guid DevelopingId { get; set; }
        public int Difficulty { get; set; }
        public string Name { get; set; }
        public Guid? StewardId { get; set; }
        public Steward Steward { get; set; }
    }
}
