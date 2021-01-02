using fiefapp.entities;
using GraphQL.Types;

namespace fiefapp.graphql.Types
{
    public class StewardType : ObjectGraphType<Steward>
    {
        public StewardType()
        {
            Field(_ => _.Id);
            Field(_ => _.Name);
            Field(_ => _.Age);
            Field(_ => _.Resources);
            Field(_ => _.Loyalty);
            Field(_ => _.Skill);
            Field(_ => _.Notes, type: typeof(ListGraphType<StringGraphType>));
            Field(_ => _.GamesessionId);
            Field(_ => _.AssignedTo, nullable: true);
        }
    }
}
