using fiefapp.entities;
using GraphQL.Types;

namespace fiefapp.graphql.Types
{
    public class GamesessionType : ObjectGraphType<Gamesession>
    {
        public GamesessionType()
        {
            Field(_ => _.Id);
            Field(_ => _.OwnerId);
            Field(_ => _.UserIds);
            Field(_ => _.GamemasterId);
            Field(_ => _.PlayerIds);
            Field(_ => _.Name);
            Field(_ => _.Fiefs, type: typeof(FiefType));
            Field(_ => _.Inheritances, type: typeof(InheritanceType));
            Field(_ => _.Roads, type: typeof(RoadType));
            Field(_ => _.Livingconditions, type: typeof(LivingconditionType));
        }
    }
}
