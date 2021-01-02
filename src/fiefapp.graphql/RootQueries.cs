using fiefapp.entities;
using fiefapp.services.Interfaces;
using GraphQL.Types;

namespace fiefapp.graphql
{
    public partial class RootQueries : ObjectGraphType
    {
        public RootQueries(
            IBaseEntityRepository<Building> buildingRepository, 
            IGamesessionRepository gamesessionRepository,
            IStewardRepository stewardRepository,
            IFiefRepository fiefRepository
        )
        {
            AddBuildingFields(buildingRepository);
            AddGamesessionFields(gamesessionRepository, stewardRepository, fiefRepository);
        }

        partial void AddBuildingFields(IBaseEntityRepository<Building> repository);
        partial void AddGamesessionFields(IGamesessionRepository repository, IStewardRepository stewardRepository, IFiefRepository fiefRepository);
    }
}
