namespace fiefapp.entities.Interfaces
{
    public interface IAffectedByWeather
    {
        public decimal SpringModifier { get; set; }
        public decimal SummerModifier { get; set; }
        public decimal FallModifier { get; set; }
        public decimal WinterModifier { get; set; }
    }
}
