using fiefapp.graphql.Types;
using fiefapp.services.Interfaces;
using GraphQL;
using GraphQL.Types;

namespace fiefapp.graphql
{
    public partial class RootQueries
    {
        partial void AddGamesessionFields(IGamesessionRepository repository)
        {
            FieldAsync<ListGraphType<GamesessionType>>(
                name: "gamesessionsAsPlayer",
                arguments: new QueryArguments(
                    new QueryArgument<StringGraphType>
                    {
                        Name = "id"
                    }
                ),
                resolve: async context =>
                {
                    var id = context.GetArgument<string>("id");

                    return await repository.GetGamesessionsAsPlayerAsync(id);
                }
            );

            FieldAsync<ListGraphType<GamesessionType>>(
                name: "gamesessionsAsGamemaster",
                arguments: new QueryArguments(
                    new QueryArgument<StringGraphType>
                    {
                        Name = "id"
                    }
                ),
                resolve: async context =>
                {
                    var id = context.GetArgument<string>("id");

                    return await repository.GetGamesessionsAsGamemasterAsync(id);
                }
            );

            FieldAsync<ListGraphType<GamesessionType>>(
                name: "gamesessionInvitations",
                arguments: new QueryArguments(
                    new QueryArgument<StringGraphType>
                    {
                        Name = "id"
                    }
                ),
                resolve: async context =>
                {
                    var id = context.GetArgument<string>("id");

                    return await repository.GetGamesessionInvitationsAsync(id);
                }
            );
        }
    }
}
