using fiefapp.entities.Interfaces;
using System;
using System.Collections.Generic;

namespace fiefapp.entities
{
    public class Cargo : IBaseEntity
    {
        public Cargo()
        {
            Id = Guid.NewGuid();
            Notes = new HashSet<string>();
        }

        public Guid Id { get; set; }
        public int Silver { get; set; }
        public int Base { get; set; }
        public int Luxury { get; set; }
        public int Iron { get; set; }
        public int Stone { get; set; }
        public int Wood { get; set; }
        public ICollection<string> Notes { get; set; }
    }
}
