using GraphQL.Types;

namespace fiefapp.graphql.Types.Input
{
    public class MerchantInputType : InputObjectGraphType
    {
        public MerchantInputType()
        {
            Field<GuidGraphType>("id");
            Field<StringGraphType>("name");
            Field<IntGraphType>("age");
            Field<IntGraphType>("resources");
            Field<IntGraphType>("loyalty");
            Field<IntGraphType>("skill");
            Field<ListGraphType<StringGraphType>>("notes");
            Field<GuidGraphType>("assignedTo");
        }
    }
}
