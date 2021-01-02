using GraphQL.Types;

namespace fiefapp.graphql.Types.Input
{
    public class DevelopmentInputType : InputObjectGraphType
    {
        public DevelopmentInputType()
        {
            Field<GuidGraphType>("id");
            Field<GuidGraphType>("developingId");
            Field<IntGraphType>("difficulty");
            Field<StringGraphType>("name");
            Field<GuidGraphType>("stewardId");
            Field<StewardInputType>("steward");
        }
    }
}
