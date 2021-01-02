using fiefapp.entities.BaseClasses;
using fiefapp.entities.Interfaces;
using System;
using System.Collections.Generic;

namespace fiefapp.entities
{
    public class Merchant : Person, IBaseEntity, IAssignable
    {
        public override Guid Id { get; set; }
        public override string Name { get; set; }
        public override int Age { get; set; }
        public override int Resources { get; set; }
        public override int Loyalty { get; set; }
        public override int Skill { get; set; }
        public override ICollection<string> Notes { get; set; }
        public Guid? AssignedTo { get; set; }
    }
}
