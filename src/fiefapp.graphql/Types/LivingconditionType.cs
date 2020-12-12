using fiefapp.entities;
using GraphQL.Types;

namespace fiefapp.graphql.Types
{
    public class LivingconditionType : ObjectGraphType<Livingcondition>
    {
        public LivingconditionType() {
            Field(_ => _.Id);
            Field(_ => _.Type);
            Field(_ => _.Name);
            Field(_ => _.BaseCost);
            Field(_ => _.LuxuryCost);
            Field(_ => _.FocusGain);
            Field(_ => _.WellbeingGain);
            Field(_ => _.Description);
            Field(_ => _.Gamesessions, type: typeof(GamesessionType));
        }
    }
}