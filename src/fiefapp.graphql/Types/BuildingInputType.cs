using GraphQL.Types;

namespace fiefapp.graphql.Types
{
    public class BuildingInputType : InputObjectGraphType
    {
        public BuildingInputType()
        {
            Field<GuidGraphType>("id");
            Field<NonNullGraphType<StringGraphType>>("type");
            Field<NonNullGraphType<DecimalGraphType>>("upkeep");
            Field<NonNullGraphType<IntGraphType>>("stonework");
            Field<NonNullGraphType<IntGraphType>>("woodwork");
            Field<NonNullGraphType<IntGraphType>>("smithswork");
            Field<NonNullGraphType<IntGraphType>>("stone");
            Field<NonNullGraphType<IntGraphType>>("wood");
            Field<NonNullGraphType<IntGraphType>>("iron");
        }
    }
}
