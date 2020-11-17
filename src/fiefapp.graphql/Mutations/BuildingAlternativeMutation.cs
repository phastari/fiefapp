﻿using fiefapp.graphql.Services.BuildingAlternative;
using fiefapp.graphql.Types;
using GraphQL;
using GraphQL.Types;

namespace fiefapp.graphql.Mutations
{
    public class BuildingAlternativeMutation : ObjectGraphType<object>
    {
        public BuildingAlternativeMutation(IBuildingAlternativeSubscriptionService subscriptionService)
        {
            Field<BuildingAlternativeType>(
                "addBuildingAlternative",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<BuildingAlternativeInputType>> { Name = "buildingAlternative" }
                ),
                resolve: context =>
                {
                    var alternative = context.GetArgument<entities.BuildingAlternative>("buildingAlternative");
                    var addedAlternative = subscriptionService.AddBuildingAlternative(alternative);

                    return addedAlternative;
                });
        }
    }
}
