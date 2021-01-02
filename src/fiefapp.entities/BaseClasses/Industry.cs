using fiefapp.entities.Interfaces;
using System;

namespace fiefapp.entities.BaseClasses
{
    public abstract class Industry : INeedSteward, ICanBeDeveloped
    {
        public abstract Guid Id { get; set; }
        public abstract string Name { get; set; }
        public abstract int? Quality { get; set; }
        public abstract int? Silver { get; set; }
        public abstract int? Base { get; set; }
        public abstract int? Luxury { get; set; }
        public abstract int? Wood { get; set; }
        public abstract int? Stone { get; set; }
        public abstract int? Iron { get; set; }
        public abstract int DevelopmentLevel { get; set; }
        public abstract bool IsBeingDeveloped { get; set; }
        public abstract bool IsInformationItem { get; set; }
        public abstract Guid? StewardId { get; set; }
        public abstract Steward Steward { get; set; }
        public abstract Guid? DevelopmentId { get; set; }
        public abstract Development Development { get; set; }
    }
}
