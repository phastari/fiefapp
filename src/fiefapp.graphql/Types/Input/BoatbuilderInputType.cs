using GraphQL.Types;

namespace fiefapp.graphql.Types.Input
{
    public class BoatbuilderInputType : InputObjectGraphType
    {
        public BoatbuilderInputType()
        {
            Field<GuidGraphType>("id");
            Field<StringGraphType>("name");
            Field<IntGraphType>("age");
            Field<IntGraphType>("resources");
            Field<IntGraphType>("loyalty");
            Field<IntGraphType>("skill");
            Field<ListGraphType<StringGraphType>>("notes");
            Field<GuidGraphType>("shipyardId");
            Field<ShipyardInputType>("shipyard");
        }
    }
}
