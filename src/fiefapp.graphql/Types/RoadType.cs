using fiefapp.entities;
using GraphQL.Types;

namespace fiefapp.graphql.Types
{
    public class RoadType : ObjectGraphType<Road>
    {
        public RoadType() {
            Field(_ => _.Id);
            Field(_ => _.Type);
            Field(_ => _.Name);
            Field(_ => _.UpgradeBaseCost);
            Field(_ => _.UpgradeStoneCost);
            Field(_ => _.ModificationFactor);
            Field(_ => _.Dayswork);
            Field(_ => _.GamesessionIds, type: typeof(ListGraphType<GuidGraphType>));
        }
    }
}