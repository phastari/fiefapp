using fiefapp.entities;
using GraphQL.Types;

namespace fiefapp.graphql.Types
{
    public class SelectionAlternativesType : ObjectGraphType<SelectionAlternatives>
    {
        public SelectionAlternativesType() {
            Field<ListGraphType<InheritanceType>>("Inheritances");
            Field<ListGraphType<LivingconditionType>>("Livingconditions");
            Field<ListGraphType<RoadType>>("Roads");
        }
    }
}