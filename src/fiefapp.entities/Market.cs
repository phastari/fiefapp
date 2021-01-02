using fiefapp.entities.BaseClasses;
using fiefapp.entities.Interfaces;
using System;
using System.Collections.Generic;

namespace fiefapp.entities
{
    public class Market : Industry, IBaseEntity, IFiefForeinKey, ICanHaveSoldiers, ICanBeDeveloped, INeedSteward, IIncomeListItem
    {
        public Market()
        {
            Id = Guid.NewGuid();
            FiefId = Guid.Empty;
            Merchants = new HashSet<Merchant>();
            Soldiers = new HashSet<Soldier>();
        }

        public override Guid Id { get; set; }
        public Guid FiefId { get; set; }
        public override string Name { get; set; }
        public override int DevelopmentLevel { get; set; }
        public override bool IsInformationItem { get; set; }
        public override bool IsBeingDeveloped { get; set; }
        public override int? Wood { get; set; }
        public override int? Stone { get; set; }
        public override int? Iron { get; set; }
        public override int? Quality { get; set; }
        public override int? Silver { get; set; }
        public override int? Base { get; set; }
        public override int? Luxury { get; set; }
        public int Merchandise { get; set; }
        public int Taxes { get; set; }
        public int Bailiffs { get; set; }
        public int Crime { get; set; }
        public override Guid? StewardId { get; set; }
        public override Steward Steward { get; set; }
        public override Guid? DevelopmentId { get; set; }
        public override Development Development { get; set; }
        public ICollection<Guid> MerchantIds { get; set; }
        public ICollection<Merchant> Merchants { get; set; }
        public ICollection<Guid> SoldierIds { get; set; }
        public ICollection<Soldier> Soldiers { get; set; }
    }
}
