using fiefapp.entities.BaseClasses;
using fiefapp.entities.Interfaces;
using System;
using System.Collections.Generic;

namespace fiefapp.entities
{
    public class Boatbuilder : Person, IBaseEntity
    {
        public Boatbuilder()
        {
            Id = Guid.NewGuid();
            Notes = new HashSet<string>();
        }

        public override Guid Id { get; set; }
        public override string Name { get; set; }
        public override int Age { get; set; }
        public override int Resources { get; set; }
        public override int Loyalty { get; set; }
        public override int Skill { get; set; }
        public override ICollection<string> Notes { get; set; }
        public Guid? ShipyardId { get; set; }
        public Shipyard Shipyard { get; set; }
    }
}
