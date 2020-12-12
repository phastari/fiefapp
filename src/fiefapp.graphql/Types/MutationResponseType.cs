using fiefapp.entities;
using fiefapp.graphql.Models;
using GraphQL.Types;

namespace fiefapp.graphql.Types
{
    public class MutationResponseType<E, U> : ObjectGraphType<MutationResponse<E>> where E : IBaseEntity where U : ObjectGraphType<E>
    {
        public MutationResponseType()
        {
            Name = $"{typeof(U).Name}MutationResponseType";

            Field(_ => _.Type, type: typeof(MutationActionType));
            Field(_ => _.ActionSucceeded);
            Field(_ => _.DeletedId);
            Field(_ => _.Entity, type: typeof(U));
        }
    }
}
