using fiefapp.entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace fiefapp.services.Interfaces
{
    public interface IStewardRepository
    {
        Task<Steward> GetStewardForEntity(Guid entityId);
        Task<ICollection<Steward>> GetStewardsForGamesessionAndUser(Guid gamesessionId, string userId);
    }
}
