using System.Collections.Generic;

namespace fiefapp.entities
{
    public class SelectionAlternatives
    {
        public List<Inheritance> Inheritances { get; set; }
        public List<Livingcondition> Livingconditions { get; set; }
        public List<Road> Roads { get; set; }
    }
}