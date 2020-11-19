using fiefapp.graphql.Queries;
using fiefapp.mongodb.Repositories.BuildingAlternative;
using GraphQL.Types;

namespace fiefapp.graphql
{
    public class RootQueries : ObjectGraphType
    {
        public RootQueries(IBuildingAlternativeRepository repository)
        {
            Field<BuildingAlternativeQuery>("buildingAlternative", resolve: context => new { });
            Field<SelectionAlternativesQuery>("selectionAlternatives", resolve: context => new { });
        }
    }
}
