using fiefapp.entities;
using fiefapp.graphql.Services.BuildingAlternative;
using fiefapp.graphql.Types;
using GraphQL.Resolvers;
using GraphQL.Types;

namespace fiefapp.graphql
{
    public class RootSubscription : ObjectGraphType<object>
    {
        private readonly IBuildingAlternativeSubscriptionService _subscriptionService;

        public RootSubscription(IBuildingAlternativeSubscriptionService subscriptionService)
        {
            _subscriptionService = subscriptionService;

            AddField(new EventStreamFieldType
            {
                Name = "buildingAlternativeAdded",
                Type = typeof(BuildingAlternativeType),
                Resolver = new FuncFieldResolver<BuildingAlternative>((context) => context.Source as BuildingAlternative),
                Subscriber = new EventStreamResolver<BuildingAlternative>((context) =>
                {
                    return _subscriptionService.BuildingAlternatives();
                })
            });
        }
    }
}
