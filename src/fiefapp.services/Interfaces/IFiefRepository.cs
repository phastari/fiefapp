using fiefapp.entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace fiefapp.services.Interfaces
{
    public interface IFiefRepository
    {
        Task<ICollection<Fief>> GetFiefsForGamesessionAndUser(Guid gamesessionId, string userId);
    }
}
