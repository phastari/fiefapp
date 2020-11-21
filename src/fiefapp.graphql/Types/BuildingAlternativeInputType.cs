using GraphQL.Types;

namespace fiefapp.graphql.Types
{
    public class BuildingAlternativeInputType : InputObjectGraphType
    {
        public BuildingAlternativeInputType()
        {
            Name = "BuildingAlternativeInput";

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
