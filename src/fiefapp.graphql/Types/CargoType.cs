using fiefapp.entities;
using GraphQL.Types;

namespace fiefapp.graphql.Types
{
    public class CargoType : ObjectGraphType<Cargo>
    {
        public CargoType()
        {
            Field(_ => _.Id);
            Field(_ => _.Silver);
            Field(_ => _.Base);
            Field(_ => _.Luxury);
            Field(_ => _.Iron);
            Field(_ => _.Stone);
            Field(_ => _.Wood);
            Field(_ => _.Notes);
        }
    }
}
