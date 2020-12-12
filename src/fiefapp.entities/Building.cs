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
        public List<Gamesession> Gamesessions { get; set; }
    }
}
