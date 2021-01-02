using fiefapp.entities.BaseClasses;
using fiefapp.entities.Interfaces;
using System;
using System.Collections.Generic;

namespace fiefapp.entities
{
    public class Fief : IBaseEntity, INeedSteward
    {
        public Fief()
        {
            Id = Guid.NewGuid();
            GamesessionId = Guid.NewGuid();
            Name = "Ny förläning";
            ManorName = "Ny förlänings högsäte";
        }

        public Guid Id { get; set; }
        public Guid GamesessionId { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string ManorName { get; set; }
        public int Acres { get; set; }
        public int FarmlandAcres { get; set; }
        public int PastureAcres { get; set; }
        public int WoodlandAcres { get; set; }
        public int FellingAcres { get; set; }
        public int UnusableAcres { get; set; }
        public Guid? MarketId { get; set; }
        public Market Market { get; set; }
        public Guid? StewardId { get; set; }
        public Steward Steward { get; set; }
        public Guid? PortId { get; set; }
        public Port Port { get; set; }
        public Guid LivingconditionId { get; set; }
        public Livingcondition Livingcondition { get; set; }
        public Guid RoadId { get; set; }
        public Road Road { get; set; }
        public Guid InheritanceId { get; set; }
        public Inheritance Inheritance { get; set; }
        public ICollection<Guid> VillageIds { get; set; }
        public ICollection<Village> Villages { get; set; }
        public ICollection<Guid> IndustryIds { get; set; }
        public ICollection<Industry> Industries { get; set; }
        public ICollection<Guid> BuildingIds { get; set; }
        public ICollection<Building> Buildings { get; set; }
        public ICollection<Guid> ResidentIds { get; set; }
        public ICollection<Resident> Residents { get; set; }
        public ICollection<Guid> SoldierIds { get; set; }
        public ICollection<Soldier> Soldiers { get; set; }
        public ICollection<Guid> EmployeeIds { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public ICollection<Guid> BuilderIds { get; set; }
        public ICollection<Builder> Builders { get; set; }
    }
}