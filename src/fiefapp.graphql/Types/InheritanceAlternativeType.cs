using fiefapp.entities;
using GraphQL.Types;

namespace fiefapp.graphql.Types
{
    public class InheritanceAlternativeType : ObjectGraphType<InheritanceAlternative>
    {
        public InheritanceAlternativeType()
        {
            Field(_ => _.Id);
            Field(_ => _.Type).Description("String to be converted to ENUM in the svelte application.");
            Field(_ => _.Name).Description("Name of the alternative to be displayed. Swedish");
            Field(_ => _.Description).Description("Description of what the inheritance infers");
        }
    }
}
