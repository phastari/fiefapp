using fiefapp.entities.BaseClasses;
using fiefapp.entities.Interfaces;
using System;
using System.Collections.Generic;

namespace fiefapp.entities
{
    public class Shipyard : Industry, IBaseEntity, IModifyPopulation, ICanBeDeveloped, IIncomeListItem, IFiefForeinKey
    {
        public override Guid Id { get; set; }
        public Guid FiefId { get; set; }
        public override string Name { get; set; }
        public int SmallDocks { get; set; }
        public int MediumDocks { get; set; }
        public int LargeDocks { get; set; }
        public int PopulationModifier { get; set; }
        public override int DevelopmentLevel { get; set; }
        public override bool IsBeingDeveloped { get; set; }
        public override int? Silver { get; set; }
        public override int? Base { get; set; }
        public override int? Luxury { get; set; }
        public override int? Wood { get; set; }
        public override int? Stone { get; set; }
        public override int? Iron { get; set; }
        public override int? Quality { get; set; }
        public override bool IsInformationItem { get; set; }
        public ICollection<Guid> BoatbuilderIds { get; set; }
        public ICollection<Boatbuilder> Boatbuilders { get; set; }
        public ICollection<Guid> BoatIds { get; set; }
        public ICollection<Boat> Boats { get; set; }
        public override Guid? StewardId { get; set; }
        public override Steward Steward { get; set; }
        public override Guid? DevelopmentId { get; set; }
        public override Development Development { get; set; }
    }
}
