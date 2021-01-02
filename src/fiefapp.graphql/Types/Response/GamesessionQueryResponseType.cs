using fiefapp.graphql.Models;
using GraphQL.Types;

namespace fiefapp.graphql.Types.Response
{
    public class GamesessionQueryResponseType : ObjectGraphType<GamesessionQueryResponse>
    {
        public GamesessionQueryResponseType()
        {
            Field(_ => _.Gamesession, type: typeof(GamesessionType));
            Field(_ => _.Stewards, type: typeof(ListGraphType<StewardType>));
            Field(_ => _.Fiefs, type: typeof(ListGraphType<FiefType>));
        }
    }
}
