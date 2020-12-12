using GraphQL.Types;

namespace fiefapp.graphql.Types
{
    public class GamesessionInputType : InputObjectGraphType
    {
        public GamesessionInputType()
        {
            Field<NonNullGraphType<StringGraphType>>("ownerId");
            Field<StringGraphType>("name");
        }
    }
}
