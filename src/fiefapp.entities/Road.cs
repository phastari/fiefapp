using System;
using System.Collections.Generic;

namespace fiefapp.entities
{
    public class Road : IBaseEntity
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public int UpgradeBaseCost { get; set; }
        public int UpgradeStoneCost { get; set; }
        public double ModificationFactor { get; set; }
        public int Dayswork { get; set; }
        public List<Gamesession> Gamesessions { get; set; }
    }
}
