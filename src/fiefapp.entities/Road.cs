using fiefapp.entities.Interfaces;
using System;
using System.Collections.Generic;

namespace fiefapp.entities
{
    public class Road : IBaseEntity, IAlternativeEntity
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public int UpgradeBaseCost { get; set; }
        public int UpgradeStoneCost { get; set; }
        public decimal ModificationFactor { get; set; }
        public int Dayswork { get; set; }
        public ICollection<Guid> GamesessionIds { get; set; }
    }
}
