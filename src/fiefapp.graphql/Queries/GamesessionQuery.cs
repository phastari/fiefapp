using fiefapp.graphql.Models;
using fiefapp.graphql.Types;
using fiefapp.graphql.Types.Response;
using fiefapp.services.Interfaces;
using GraphQL;
using GraphQL.Types;
using System;

namespace fiefapp.graphql
{
    public partial class RootQueries
    {
        partial void AddGamesessionFields(
            IGamesessionRepository gamesessionRepository,
            IStewardRepository stewardRepository,
            IFiefRepository fiefRepository
        )
        {
            FieldAsync<GamesessionQueryResponseType>(
                name: "gamesession",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<GuidGraphType>>
                    {
                        Name = "gamesessionId"
                    },
                    new QueryArgument<StringGraphType>
                    {
                        Name = "userId"
                    }
                ),
                resolve: async context =>
                {
                    var gamesessionId = context.GetArgument<Guid>("gamesessionId");
                    var userId = context.GetArgument<string>("userId");

                    return new GamesessionQueryResponse
                    {
                        Gamesession = await gamesessionRepository.GetGamesessionAsync(
                            gamesessionId
                        ),
                        Stewards = await stewardRepository.GetStewardsForGamesessionAndUser(
                            gamesessionId,
                            userId
                        ),
                        Fiefs = await fiefRepository.GetFiefsForGamesessionAndUser(
                            gamesessionId,
                            userId
                        )
                    };
                }
            );

            FieldAsync<ListGraphType<GamesessionType>>(
                name: "gamesessions",
                arguments: new QueryArguments(
                    new QueryArgument<StringGraphType>
                    {
                        Name = "id"
                    }
                ),
                resolve: async context =>
                {
                    return await gamesessionRepository.GetGamesessionsAsync(
                        context.GetArgument<string>("id")
                    );
                }
            );
        }
    }
}
