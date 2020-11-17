using fiefapp.graphql.Mutations;
using GraphQL.Types;

namespace fiefapp.graphql
{
    public class RootMutations : ObjectGraphType<object>
    {
        public RootMutations()
        {
            Field<BuildingAlternativeMutation>(
                "buildingAlternative",
                resolve: context => new { });
        }
    }
}
