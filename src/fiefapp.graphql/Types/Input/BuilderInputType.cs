using GraphQL.Types;

namespace fiefapp.graphql.Types.Input
{
    public class BuilderInputType : InputObjectGraphType
    {
        public BuilderInputType()
        {
            Field<GuidGraphType>("id");
            Field<GuidGraphType>("fiefId");
            Field<StringGraphType>("name");
            Field<IntGraphType>("age");
            Field<IntGraphType>("resources");
            Field<IntGraphType>("loyalty");
            Field<IntGraphType>("skill");
            Field<ListGraphType<StringGraphType>>("notes");
            Field<GuidGraphType>("buildingId");
            Field<BuildingInputType>("building");
        }
    }
}
