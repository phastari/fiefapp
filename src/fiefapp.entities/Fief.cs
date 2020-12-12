using System;

namespace fiefapp.entities
{
    public class Fief : IBaseEntity
    {
        public Guid Id { get; set; }
        public Gamesession Gamesession { get; set; }
        public string PlayerId { get; set; }
        public string Name { get; set; }
        public string ManorName { get; set; }
        public int Acres { get; set; }
        public int FarmlandAcres { get; set; }
        public int PastureAcres { get; set; }
        public int WoodlandAcres { get; set; }
        public int FellingAcres { get; set; }
        public int UnusableAcres { get; set; }
        public int AnimalHusbandryQuality { get; set; }
        public int AgriculturalQuality { get; set; }
        public int FishingQuality { get; set; }
        public int OreQuality { get; set; }
        public int HuntingQuality { get; set; }
        public int AnimalHusbandryDevelopmentLevel { get; set; }
        public int AgriculturalDevelopmentLevel { get; set; }
        public int FishingDevelopmentLevel { get; set; }
        public int WoodlandDevelopmentLevel { get; set; }
        public int OreDevelopmentLevel { get; set; }
        public int HuntingDevelopmentLevel { get; set; }
        public int EducationDevelopmentLevel { get; set; }
        public int HealthcareDevelopmentLevel { get; set; }
        public int MilitaryDevelopmentLevel { get; set; }
        public int SeafaringDevelopmentLevel { get; set; }
        // public Market? Market { get; set; }
        // public string? StewardId { get; set; }
        // public Port? Port { get; set; }
        public Livingcondition Livingcondition { get; set; }
        public Road Road { get; set; }
        public Inheritance Inheritance { get; set; }
        // public List<Village> Villages { get; set; }
        // public List<Industry> Industries { get; set; }
        // public List<Building> Buildings { get; set; }
        // public List<Boat> Boats { get; set; }
        // public List<Resident> Residents { get; set; }
        // public List<Soldier> Soldiers { get; set; }
        // public List<Employee> Employees { get; set; }
        // public List<Builder> Builders { get; set; }
    }
}