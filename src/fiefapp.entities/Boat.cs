using fiefapp.entities.Enums;
using fiefapp.entities.Interfaces;
using System;
using System.Collections.Generic;

namespace fiefapp.entities
{
    public class Boat : IBaseEntity, ICanHaveSoldiers
    {
        public Boat()
        {
            Id = Guid.NewGuid();
            SoldierIds = new HashSet<Guid>();
            Soldiers = new HashSet<Soldier>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public int CrewNeeded { get; set; }
        public int Seamens { get; set; }
        public int Mariners { get; set; }
        public int Rowers { get; set; }
        public int RowersNeeded { get; set; }
        public int MaxCargo { get; set; }
        public int Sailors { get; set; }
        public int Officers { get; set; }
        public int Navigators { get; set; }
        public int Amount { get; set; }
        public int CostWhenFinishedSilver { get; set; }
        public int NextFinishedDays { get; set; }
        public int BuildTimeInDays { get; set; }
        public int BuildTimeInDaysAll { get; set; }
        public string Status { get; set; }
        public int BackInDays { get; set; }
        public TypeOfBoat Type { get; set; }
        public string DisplayName { get; set; }
        public int Masts { get; set; }
        public int LengthMin { get; set; }
        public int LengthMax { get; set; }
        public double BL { get; set; }
        public double DB { get; set; }
        public int Crew { get; set; }
        public double BenchMod { get; set; }
        public double BenchMulti { get; set; }
        public double OarsMulti { get; set; }
        public double RowerMulti { get; set; }
        public int Seaworthiness { get; set; }
        public string ImgSrc { get; set; }
        public Guid? BoatbuilderId { get; set; }
        public Boatbuilder Boatbuilder { get; set; }
        public Guid? CargoId { get; set; }
        public Cargo Cargo { get; set; }
        public Guid? ShipyardId { get; set; }
        public Shipyard Shipyard { get; set; }
        public ICollection<Guid> SoldierIds { get; set; }
        public ICollection<Soldier> Soldiers { get; set; }
    }
}
