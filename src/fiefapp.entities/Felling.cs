using fiefapp.entities.BaseClasses;
using fiefapp.entities.Interfaces;
using System;

namespace fiefapp.entities
{
    public class Felling : Industry, IBaseEntity, INeedSteward, ICanBeDeveloped, IFiefForeinKey
    {
        public Felling()
        {
            Id = Guid.NewGuid();
            Name = "Skogsavverkning";
            IsInformationItem = true;
        }

        public override Guid Id { get; set; }
        public Guid FiefId { get; set; }
        public override string Name { get; set; }
        public override int? Silver { get; set; }
        public override int? Base { get; set; }
        public override int? Luxury { get; set; }
        public override int? Wood { get; set; }
        public override int? Stone { get; set; }
        public override int? Iron { get; set; }
        public int AmountLandclearing { get; set; }
        public int AmountLandclearingOfFelling { get; set; }
        public int AmountFelling { get; set; }
        public int AmountClearUseless { get; set; }
        public override int DevelopmentLevel { get; set; }
        public override bool IsBeingDeveloped { get; set; }
        public override int? Quality { get; set; }
        public override bool IsInformationItem { get; set; }
        public override Guid? DevelopmentId { get; set; }
        public override Development Development { get; set; }
        public override Guid? StewardId { get; set; }
        public override Steward Steward { get; set; }
    }
}
