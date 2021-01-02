using GraphQL.Types;

namespace fiefapp.graphql.Types.Input
{
    public class RoadInputType : InputObjectGraphType
    {
        public RoadInputType()
        {
            Field<GuidGraphType>("id");
            Field<StringGraphType>("type");
            Field<StringGraphType>("name");
            Field<IntGraphType>("upgradeBaseCost");
            Field<IntGraphType>("upgradeStoneCost");
            Field<DecimalGraphType>("modificationFactor");
            Field<IntGraphType>("dayswork");
            Field<ListGraphType<GuidGraphType>>("gamesessionIds");
        }
    }
}
