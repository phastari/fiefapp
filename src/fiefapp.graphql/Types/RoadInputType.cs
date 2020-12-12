using GraphQL.Types;

namespace fiefapp.graphql.Types
{
    public class RoadInputType : InputObjectGraphType
    {
        public RoadInputType()
        {
            Field<NonNullGraphType<StringGraphType>>("type");
            Field<NonNullGraphType<StringGraphType>>("name");
            Field<NonNullGraphType<IntGraphType>>("upgradeBaseCost");
            Field<NonNullGraphType<IntGraphType>>("upgradeStoneCost");
            Field<NonNullGraphType<DecimalGraphType>>("modificationFactor");
            Field<NonNullGraphType<IntGraphType>>("Dayswork");
        }
    }
}
