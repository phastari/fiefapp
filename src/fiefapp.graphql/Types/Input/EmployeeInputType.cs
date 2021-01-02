using fiefapp.entities.Enums;
using GraphQL.Types;

namespace fiefapp.graphql.Types.Input
{
    public class EmployeeInputType : InputObjectGraphType
    {
        public EmployeeInputType()
        {
            Field<GuidGraphType>("id");
            Field<EnumerationGraphType<TypeOfEmployee>>("type");
            Field<StringGraphType>("name");
            Field<IntGraphType>("age");
            Field<IntGraphType>("resources");
            Field<IntGraphType>("loyalty");
            Field<IntGraphType>("skill");
            Field<ListGraphType<StringGraphType>>("notes");
        }
    }
}
