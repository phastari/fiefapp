using fiefapp.entities;
using fiefapp.graphql.Models;
using fiefapp.graphql.Services;
using fiefapp.graphql.Types;
using GraphQL.Resolvers;
using GraphQL.Types;

namespace fiefapp.graphql
{
    public partial class RootSubscription
    {
        partial void AddBuildingFields(ISubscriptionService<Building> buildingService)
        {
            AddField(new EventStreamFieldType
            {
                Name = "buildingChanged",
                Type = typeof(MutationResponseType<Building, BuildingType>),
                Resolver = new FuncFieldResolver<MutationResponse<Building>>((context) => context.Source as MutationResponse<Building>),
                Subscriber = new EventStreamResolver<MutationResponse<Building>>((context) =>
                {
                    return buildingService.Entities();
                })
            });
        }
    }
}
