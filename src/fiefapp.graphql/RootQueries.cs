using fiefapp.entities;
using fiefapp.services.Interfaces;
using GraphQL.Types;

namespace fiefapp.graphql
{
    public partial class RootQueries : ObjectGraphType
    {
        public RootQueries(IRepository<Building> buildingRepository, IGamesessionRepository gamesessionRepository)
        {
            AddBuildingFields(buildingRepository);
            AddGamesessionFields(gamesessionRepository);
        }

        partial void AddBuildingFields(IRepository<Building> repository);
        partial void AddGamesessionFields(IGamesessionRepository repository);
    }
}
