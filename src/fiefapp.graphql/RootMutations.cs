using fiefapp.entities;
using fiefapp.graphql.Services;
using GraphQL.Types;

namespace fiefapp.graphql
{
    public partial class RootMutations : ObjectGraphType
    {
        public RootMutations(ISubscriptionService<Building> buildingSubscriptionService, ISubscriptionService<Gamesession> gamesessionSubscriptionService)
        {
            AddBuildingFields(buildingSubscriptionService);
            AddGamesessionFields(gamesessionSubscriptionService);
        }

        partial void AddBuildingFields(ISubscriptionService<Building> buildingSubscriptionService);
        partial void AddGamesessionFields(ISubscriptionService<Gamesession> gamesessionSubscriptionService);
    }
}
