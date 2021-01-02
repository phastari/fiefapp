using System;
using System.Collections.Generic;

namespace fiefapp.entities.Interfaces
{
    public interface IAlternativeEntity
    {
        public ICollection<Guid> GamesessionIds { get; set; }
    }
}
