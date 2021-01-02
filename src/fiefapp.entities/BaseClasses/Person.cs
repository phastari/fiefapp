using System;
using System.Collections.Generic;

namespace fiefapp.entities.BaseClasses
{
    public abstract class Person
    {
        public abstract Guid Id { get; set; }
        public abstract string Name { get; set; }
        public abstract int Age { get; set; }
        public abstract int Resources { get; set; }
        public abstract int Loyalty { get; set; }
        public abstract int Skill { get; set; }
        public abstract ICollection<string> Notes { get; set; }
    }
}
