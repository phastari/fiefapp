using fiefapp.entities;
using fiefapp.graphql.Services;
using GraphQL.Types;

namespace fiefapp.graphql
{
    public partial class RootSubscription : ObjectGraphType
    {
        public RootSubscription(ISubscriptionService<Building> buildingService)
        {
            AddBuildingFields(buildingService);
        }

        partial void AddBuildingFields(ISubscriptionService<Building> buildingService);
    }
}
