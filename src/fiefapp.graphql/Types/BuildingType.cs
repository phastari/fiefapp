using fiefapp.entities;
using GraphQL.Types;

namespace fiefapp.graphql.Types
{
    public class BuildingType : ObjectGraphType<Building>
    {
        public BuildingType()
        {
            Field(_ => _.Id);
            Field(_ => _.Type);
            Field(_ => _.Upkeep);
            Field(_ => _.Stonework);
            Field(_ => _.Woodwork);
            Field(_ => _.Smithswork);
            Field(_ => _.Stone);
            Field(_ => _.Wood);
            Field(_ => _.Iron);
            Field(_ => _.Gamesessions, type: typeof(GamesessionType));
        }
    }
}
