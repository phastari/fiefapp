using fiefapp.entities;
using GraphQL.Types;

namespace fiefapp.graphql.Types
{
    public class VillageType : ObjectGraphType<Village>
    {
        public VillageType()
        {
            Field(_ => _.Id);
            Field(_ => _.FiefId);
            Field(_ => _.Name);
            Field(_ => _.Serfdoms);
            Field(_ => _.Farmers);
            Field(_ => _.Boatbuilders);
            Field(_ => _.Tanners);
            Field(_ => _.Millers);
            Field(_ => _.Furriers);
            Field(_ => _.Tailors);
            Field(_ => _.Blacksmiths);
            Field(_ => _.Carpenters);
            Field(_ => _.Innkeepers);
        }
    }
}
