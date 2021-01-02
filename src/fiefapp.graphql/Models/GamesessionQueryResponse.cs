using fiefapp.entities;
using System.Collections.Generic;

namespace fiefapp.graphql.Models
{
    public class GamesessionQueryResponse
    {
        public Gamesession Gamesession { get; set; }
        public ICollection<Steward> Stewards { get; set; }
        public ICollection<Fief> Fiefs { get; set; }
    }
}
