using fiefapp.entities;
using GraphQL.Types;

namespace fiefapp.graphql.Types
{
    public class SelectionAlternativesType : ObjectGraphType<SelectionAlternatives>
    {
        public SelectionAlternativesType() {
            // Field(
            //     name: "Inheritances",
            //     type: typeof(ListGraphType<InheritanceAlternativeType>),
            //     resolve: context => context.Source.Inheritances
            // );
            // Field(
            //     name: "Livingconditions",
            //     type: typeof(ListGraphType<LivingconditionAlternativeType>),
            //     resolve: context => context.Source.Livingconditions
            // );
            // Field(
            //     name: "Roads",
            //     type: typeof(ListGraphType<RoadAlternativeType>),
            //     resolve: context => context.Source.Roads
            // );
            Field<ListGraphType<InheritanceType>>("Inheritances");
            Field<ListGraphType<LivingconditionType>>("Livingconditions");
            Field<ListGraphType<RoadType>>("Roads");
        }
    }
}