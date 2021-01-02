using fiefapp.entities.BaseClasses;
using fiefapp.entities.Interfaces;
using System;

namespace fiefapp.entities
{
    public class Subsidiary : Industry, IBaseEntity, IAffectedByWeather, IFiefForeinKey
    {
        public override Guid Id { get; set; }
        public Guid FiefId { get; set; }
        public override string Name { get; set; }
        public override int? Silver { get; set; }
        public override int? Base { get; set; }
        public override int? Luxury { get; set; }
        public override int? Wood { get; set; }
        public override int? Stone { get; set; }
        public override int? Iron { get; set; }
        public override int? Quality { get; set; }
        public override int DevelopmentLevel { get; set; }
        public int DaysworkThisYear { get; set; }
        public int DaysworkUpkeep { get; set; }
        public int DaysworkBuild { get; set; }
        public int IncomeFactor { get; set; }
        public decimal SilverPortion { get; set; }
        public decimal BasePortion { get; set; }
        public decimal LuxuryPortion { get; set; }
        public decimal SpringModifier { get; set; }
        public decimal SummerModifier { get; set; }
        public decimal FallModifier { get; set; }
        public decimal WinterModifier { get; set; }
        public override bool IsBeingDeveloped { get; set; }
        public override bool IsInformationItem { get; set; }
        public override Guid? StewardId { get; set; }
        public override Steward Steward { get; set; }
        public override Guid? DevelopmentId { get; set; }
        public override Development Development { get; set; }
    }
}
