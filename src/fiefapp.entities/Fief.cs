namespace fiefapp.entities
{
    public class Fief
    {
        public string FiefId { get; set; }
        public string GamesessionId { get; set; }
        public string? PlayerId { get; set; }
        public string Name { get; set; }
        public string ManorName { get; set; }
        public byte Acres { get; set; }
        public byte FarmlandAcres { get; set; }
        public byte PastureAcres { get; set; }
        public byte WoodlandAcres { get; set; }
        public byte FellingAcres { get; set; }
        public byte UnusableAcres { get; set; }
        public byte AnimalHusbandryQuality { get; set; }
        public byte AgriculturalQuality { get; set; }
        public byte FishingQuality { get; set; }
        public byte OreQuality { get; set; }
        public byte HuntingQuality { get; set; }
        public byte AnimalHusbandryDevelopmentLevel { get; set; }
        public byte AgriculturalDevelopmentLevel { get; set; }
        public byte FishingDevelopmentLevel { get; set; }
        public byte WoodlandDevelopmentLevel { get; set; }
        public byte OreDevelopmentLevel { get; set; }
        public byte HuntingDevelopmentLevel { get; set; }
        public byte EducationDevelopmentLevel { get; set; }
        public byte HealthcareDevelopmentLevel { get; set; }
        public byte MilitaryDevelopmentLevel { get; set; }
        public byte SeafaringDevelopmentLevel { get; set; }
        public Market? Market { get; set; }
        public string? StewardId { get; set; }
        public Port? Port { get; set; }
        public Livingcondition Livingcondition { get; set; }
        public Road Road { get; set; }
        public Inheritance Inheritance { get; set; }
        public List<Village> Villages { get; set; }
        public List<Industry> Industries { get; set; }
        public List<Building> Buildings { get; set; }
        public List<Boat> Boats { get; set; }
        public List<Resident> Residents { get; set; }
        public List<Soldier> Soldiers { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Builder> Builders { get; set; }
    }
}