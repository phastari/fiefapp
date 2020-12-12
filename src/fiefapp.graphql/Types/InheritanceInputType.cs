using GraphQL.Types;

namespace fiefapp.graphql.Types
{
    public class InheritanceInputType : InputObjectGraphType
    {
        public InheritanceInputType()
        {
            Field<NonNullGraphType<StringGraphType>>("type");
            Field<NonNullGraphType<StringGraphType>>("name");
            Field<NonNullGraphType<StringGraphType>>("description");
        }
    }
}
