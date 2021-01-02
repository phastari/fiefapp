using System;

namespace fiefapp.entities.Interfaces
{
    public interface ICanBeDeveloped
    {
        public Guid Id { get; set; }
        public Guid? DevelopmentId { get; set; }
        public Development Development { get; set; }
        public string Name { get; set; }
        public int DevelopmentLevel { get; set; }
        public bool IsBeingDeveloped { get; set; }
    }
}
