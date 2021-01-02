using fiefapp.entities.Interfaces;
using System;

namespace fiefapp.entities
{
    public class Village : IBaseEntity, IFiefForeinKey
    {
        public Guid Id { get; set; }
        public Guid FiefId { get; set; }
        public string Name { get; set; }
        public int Serfdoms { get; set; }
        public int Farmers { get; set; }
        public int Boatbuilders { get; set; }
        public int Tanners { get; set; }
        public int Millers { get; set; }
        public int Furriers { get; set; }
        public int Tailors { get; set; }
        public int Blacksmiths { get; set; }
        public int Carpenters { get; set; }
        public int Innkeepers { get; set; }
    }
}
