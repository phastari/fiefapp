using fiefapp.entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace fiefapp.services.Interfaces
{
    public interface IGamesessionRepository
    {
        Task<IEnumerable<Gamesession>> GetGamesessionsAsync(string userId);
        Task<Gamesession> GetGamesessionAsync(Guid id);
    }
}
