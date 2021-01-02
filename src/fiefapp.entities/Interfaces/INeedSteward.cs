using System;

namespace fiefapp.entities.Interfaces
{
    public interface INeedSteward
    {
        public Guid? StewardId { get; set; }
        public Steward Steward { get; set; }
    }
}
