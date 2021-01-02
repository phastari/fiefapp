using System;
using System.Collections.Generic;

namespace fiefapp.entities.Interfaces
{
    public interface ICanHaveSoldiers
    {
        public ICollection<Soldier> Soldiers { get; set; }
    }
}
