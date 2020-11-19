using fiefapp.entities;
using GraphQL.Types;

namespace fiefapp.graphql.Types
{
    public class InheritanceType : ObjectGraphType<Inheritance>
    {
        public InheritanceType()
        {
            Field(_ => _.Id);
            Field(_ => _.Type);
            Field(_ => _.Name);
            Field(_ => _.Description);
            Field(_ => _.IncludedInGamesessions);
        }
    }
}
