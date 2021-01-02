using fiefapp.entities.Interfaces;
using System;
using System.Collections.Generic;

namespace fiefapp.entities
{
    public class Livingcondition : IBaseEntity, IAlternativeEntity
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public int BaseCost { get; set; }
        public int LuxuryCost { get; set; }
        public int FocusGain { get; set; }
        public int WellbeingGain { get; set; }
        public string Description { get; set; }
        public ICollection<Guid> GamesessionIds { get; set; }
    }
}
