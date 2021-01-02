using GraphQL.Types;

namespace fiefapp.graphql.Types
{
    public class InheritanceInputType : InputObjectGraphType
    {
        public InheritanceInputType()
        {
            Field<GuidGraphType>("id");
            Field<NonNullGraphType<StringGraphType>>("type");
            Field<NonNullGraphType<StringGraphType>>("name");
            Field<NonNullGraphType<StringGraphType>>("description");
        }
    }
}
