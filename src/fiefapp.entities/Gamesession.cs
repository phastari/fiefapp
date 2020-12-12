using System;
using System.Collections.Generic;

namespace fiefapp.entities
{
    public class Gamesession : IBaseEntity
    {
        public Guid Id { get; set; }
        public string OwnerId { get; set; }
        public List<string> UserIds { get; set; }
        public string GamemasterId { get; set; }
        public List<string> PlayerIds { get; set; }
        public string Name { get; set; }
        public List<Fief> Fiefs { get; set; }
        public List<Inheritance> Inheritances { get; set; }
        public List<Road> Roads { get; set; }
        public List<Livingcondition> Livingconditions { get; set; }
    }
}