using fiefapp.graphql.Types;
using fiefapp.mongodb.Repositories.BuildingAlternative;
using GraphQL.Types;

namespace fiefapp.graphql
{
    public class RootQuery : ObjectGraphType
    {
        public RootQuery(IBuildingAlternativeRepository repository)
        {
            Name = "Query";

            Field<ListGraphType<BuildingAlternativeType>>("buildingAlternatives", resolve: context =>
            {
                return repository.Get();
            });
        }
    }
}
