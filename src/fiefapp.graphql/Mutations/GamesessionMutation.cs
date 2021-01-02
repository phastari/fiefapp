using fiefapp.entities;
using fiefapp.graphql.Services;
using fiefapp.graphql.Types;
using fiefapp.services.Interfaces;
using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;

namespace fiefapp.graphql
{
    public partial class RootMutations
    {
        partial void AddGamesessionFields(
            ISubscriptionService<Gamesession> subscriptionService,
            IAlternativesRepository<Inheritance> inheritancesRepository,
            IAlternativesRepository<Road> roadsRepository,
            IAlternativesRepository<Livingcondition> livingconditionsRepository
        )
        {
            FieldAsync<MutationResponseType<Gamesession, GamesessionType>>(
                "addGamesession",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "userId" }
                ),
                resolve: async context =>
                {
                    var userId = context.GetArgument<string>("userId");
                    var gamesession = new Gamesession
                    {
                        OwnerId = userId
                    };

                    gamesession.UserIds.Add(userId);
                    //gamesession.Roads = await roadsRepository.GetAsync(gamesession.Id);
                    //gamesession.Inheritances = await inheritancesRepository.GetAsync(gamesession.Id);
                    //gamesession.Livingconditions = await livingconditionsRepository.GetAsync(gamesession.Id);

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
