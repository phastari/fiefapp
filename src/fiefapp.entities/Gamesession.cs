using fiefapp.entities.Interfaces;
using System;
using System.Collections.Generic;

namespace fiefapp.entities
{
    public class Gamesession : IBaseEntity
    {
        public Gamesession()
        {
            Id = Guid.NewGuid();
            UserIds = new HashSet<string>();
            PlayerIds = new HashSet<string>();
            Inheritances = new HashSet<Inheritance>();
            Roads = new HashSet<Road>();
            Livingconditions = new HashSet<Livingcondition>();
        }

        public Guid Id { get; set; }
        public string OwnerId { get; set; }
        public ICollection<string> UserIds { get; set; }
        public string GamemasterId { get; set; }
        public ICollection<string> PlayerIds { get; set; }
        public string Name { get; set; }
        public ICollection<Inheritance> Inheritances { get; set; }
        public ICollection<Road> Roads { get; set; }
        public ICollection<Livingcondition> Livingconditions { get; set; }
    }
}