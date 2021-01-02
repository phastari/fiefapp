using fiefapp.entities.Interfaces;
using System;
using System.Collections.Generic;

namespace fiefapp.entities
{
    public class Inheritance : IBaseEntity, IAlternativeEntity
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Guid> GamesessionIds { get; set; }
    }
}
