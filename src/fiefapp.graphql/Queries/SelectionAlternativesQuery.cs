using GraphQL.Types;
using fiefapp.graphql.Types;
using fiefapp.mongodb.Repositories.SelectionAlternatives;

namespace fiefapp.graphql.Queries
{
    public class SelectionAlternativesQuery : ObjectGraphType
    {
        public SelectionAlternativesQuery(ISelectionAlternativesRepository repository) 
        {
            Field<SelectionAlternativesType>("selectionAlternatives", resolve: context => 
            {
                return repository.Get();
            });
        }
    }
}