using fiefapp.entities;
using GraphQL.Types;

namespace fiefapp.graphql.Types
{
    public class ResidentType : ObjectGraphType<Resident>
    {
        public ResidentType()
        {
            Field(_ => _.Id);
            Field(_ => _.FiefId);
            Field(_ => _.Name);
            Field(_ => _.Age);
            Field(_ => _.Resources);
            Field(_ => _.Loyalty);
            Field(_ => _.Skill);
            Field(_ => _.Notes);
        }
    }
}
