using fiefapp.entities;
using fiefapp.graphql.Services;
using fiefapp.graphql.Types;
using fiefapp.graphql.Types.Input;
using GraphQL;
using GraphQL.Types;
using System;

namespace fiefapp.graphql
{
    public partial class RootMutations
    {
        partial void AddBuildingFields(ISubscriptionService<Building> subscriptionService)
        {
            FieldAsync<MutationResponseType<Building, BuildingType>>(
                "addBuilding",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<GuidGraphType>> { Name = "gamesessionId" },
                    new QueryArgument<NonNullGraphType<BuildingInputType>> { Name = "building" }
                ),
                resolve: async context =>
                {
                    var building = context.GetArgument<Building>("building");
                    var gamesessionId = context.GetArgument<Guid>("gamesessionId");

                    building.Id = Guid.NewGuid();
                    building.GamesessionIds.Add(gamesessionId);

                    return await subscriptionService.Add(building);
                }
            );

            FieldAsync<MutationResponseType<Building, BuildingType>>(
                "updateBuilding",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<BuildingInputType>> { Name = "building" }
                ),
                resolve: async context =>
                {
                    return await subscriptionService.Update(
                        context.GetArgument<Building>("building")
                    );
                }
            );

            FieldAsync<MutationResponseType<Building, BuildingType>>(
                "deleteBuilding",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<GuidGraphType>> { Name = "id" }
                ),
                resolve: async context =>
                {
                    return await subscriptionService.Delete(
                        context.GetArgument<Guid>("id")
                    );
                }
            );
        }
    }
}
