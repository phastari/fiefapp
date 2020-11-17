using fiefapp.graphql.Types;
using fiefapp.mongodb.Repositories.BuildingAlternative;
using GraphQL.Types;

namespace fiefapp.graphql.Queries
{
    public class BuildingAlternativeQuery : ObjectGraphType
    {
        public BuildingAlternativeQuery(IBuildingAlternativeRepository repository)
        {
            Field<ListGraphType<BuildingAlternativeType>>("buildingAlternatives", resolve: context =>
            {
                return repository.Get();
            });
        }
    }
}
