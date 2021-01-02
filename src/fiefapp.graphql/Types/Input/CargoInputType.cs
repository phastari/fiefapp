using GraphQL.Types;

namespace fiefapp.graphql.Types.Input
{
    public class CargoInputType : InputObjectGraphType
    {
        public CargoInputType()
        {
            Field<GuidGraphType>("id");
            Field<IntGraphType>("silver");
            Field<IntGraphType>("base");
            Field<IntGraphType>("luxury");
            Field<IntGraphType>("iron");
            Field<IntGraphType>("stone");
            Field<IntGraphType>("wood");
            Field<ListGraphType<StringGraphType>>("notes");
        }
    }
}
