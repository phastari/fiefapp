using fiefapp.entities;
using fiefapp.entities.Enums;
using GraphQL.Types;

namespace fiefapp.graphql.Types
{
    public class EmployeeType : ObjectGraphType<Employee>
    {
        public EmployeeType()
        {
            Field(_ => _.Id);
            Field(_ => _.Type, type: typeof(EnumerationGraphType<TypeOfEmployee>));
            Field(_ => _.Name);
            Field(_ => _.Age);
            Field(_ => _.Resources);
            Field(_ => _.Loyalty);
            Field(_ => _.Skill);
            Field(_ => _.Notes);
        }
    }
}
