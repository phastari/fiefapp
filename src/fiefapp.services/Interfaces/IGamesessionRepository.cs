using fiefapp.entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace fiefapp.services.Interfaces
{
    public interface IGamesessionRepository
    {
        IEnumerable<Gamesession> GetGamesessionsAsPlayer(string userId);
        Task<IEnumerable<Gamesession>> GetGamesessionsAsPlayerAsync(string userId);
        IEnumerable<Gamesession> GetGamesessionsAsGamemaster(string userId);
        Task<IEnumerable<Gamesession>> GetGamesessionsAsGamemasterAsync(string userId);
        IEnumerable<Gamesession> GetGamesesssionInvitations(string userId);
        Task<IEnumerable<Gamesession>> GetGamesessionInvitationsAsync(string userId);
    }
}
