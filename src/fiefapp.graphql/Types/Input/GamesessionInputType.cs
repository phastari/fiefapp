using GraphQL.Types;

namespace fiefapp.graphql.Types
{
    public class GamesessionInputType : InputObjectGraphType
    {
        public GamesessionInputType()
        {
            Field<NonNullGraphType<GuidGraphType>>("id");
            Field<NonNullGraphType<StringGraphType>>("ownerId");
            Field<ListGraphType<StringGraphType>>("userIds");
            Field<StringGraphType>("gamemasterId");
            Field<ListGraphType<StringGraphType>>("playerIds");
            Field<StringGraphType>("name");
            Field<ListGraphType<InheritanceInputType>>("inheritances");
            Field<ListGraphType<RoadInputType>>("roads");
            Field<ListGraphType<LivingconditionInputType>>("livingconditions");
        }
    }
}
