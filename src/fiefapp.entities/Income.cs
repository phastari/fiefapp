using fiefapp.entities.BaseClasses;
using fiefapp.entities.Enums;
using fiefapp.entities.Interfaces;
using System;

namespace fiefapp.entities
{
    public class Income : Industry, IBaseEntity, IAffectedByWeather, IIncomeListItem, INeedSteward, ICanBeDeveloped, IFiefForeinKey
    {
        public Income()
        {
            Id = Guid.NewGuid();
        }

        public override Guid Id { get; set; }
        public Guid FiefId { get; set; }
        public TypeOfIncome Type { get; set; }
        public override string Name { get; set; }
        public override int? Silver { get; set; }
        public override int? Base { get; set; }
        public override int? Luxury { get; set; }
        public override int? Wood { get; set; }
        public override int? Stone { get; set; }
        public override int? Iron { get; set; }
        public override int? Quality { get; set; }
        public bool ShowInIncomes { get; set; }
        public decimal SpringModifier { get; set; }
        public decimal SummerModifier { get; set; }
        public decimal FallModifier { get; set; }
        public decimal WinterModifier { get; set; }
        public override int DevelopmentLevel { get; set; }
        public override bool IsBeingDeveloped { get; set; }
        public override bool IsInformationItem { get; set; }
        public override Guid? StewardId { get; set; }
        public override Steward Steward { get; set; }
        public override Guid? DevelopmentId { get; set; }
        public override Development Development { get; set; }
    }
}
