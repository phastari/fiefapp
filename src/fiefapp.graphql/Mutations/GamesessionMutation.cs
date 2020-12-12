using fiefapp.entities;
using fiefapp.graphql.Services;
using fiefapp.graphql.Types;
using GraphQL;
using GraphQL.Types;
using System;

namespace fiefapp.graphql
{
    public partial class RootMutations
    {
        partial void AddGamesessionFields(ISubscriptionService<Gamesession> subscriptionService)
        {
            FieldAsync<MutationResponseType<Gamesession, GamesessionType>>(
                "addGamesession",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<GamesessionInputType>> { Name = "gamesession" }
                ),
                resolve: async context =>
                {
                    var gamesession = context.GetArgument<Gamesession>("gamesession");
                    gamesession.UserIds.Add(gamesession.OwnerId);
                    if (string.IsNullOrEmpty(gamesession.Name))
                    {
                        gamesession.Name = "Ny spelsession";
                    }

                    return await subscriptionService.Add(gamesession);
                }
            );

            FieldAsync<MutationResponseType<Gamesession, GamesessionType>>(
                "updateGamesession",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<GamesessionInputType>> { Name = "gamesession" }
                ),
                resolve: async context =>
                {
                    return await subscriptionService.Update(
                        context.GetArgument<Gamesession>("gamesession")
                    );
                }
            );

            FieldAsync<MutationResponseType<Gamesession, GamesessionType>>(
                "deleteGamesession",
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
