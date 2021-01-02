using fiefapp.entities.Interfaces;
using System;
using System.Collections.Generic;

namespace fiefapp.entities
{
    public class Building : IBaseEntity
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public decimal Upkeep { get; set; }
        public int Stonework { get; set; }
        public int Woodwork { get; set; }
        public int Smithswork { get; set; }
        public int Stone { get; set; }
        public int Wood { get; set; }
        public int Iron { get; set; }
        public int Amount { get; set; }
        public int WoodworkThisYear { get; set; }
        public int StoneworkThisYear { get; set; }
        public int SmithsworkThisYear { get; set; }
        public int WoodThisYear { get; set; }
        public int StoneThisYear { get; set; }
        public int IronThisYear { get; set; }
        public Guid? BuilderId { get; set; }
        public Builder Builder { get; set; }
        public ICollection<Guid> GamesessionIds { get; set; }
        public ICollection<Gamesession> Gamesessions { get; set; }
    }
}
