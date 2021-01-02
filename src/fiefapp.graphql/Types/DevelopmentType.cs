using fiefapp.entities;
using fiefapp.services.Interfaces;
using GraphQL.Types;

namespace fiefapp.graphql.Types
{
    public class DevelopmentType : ObjectGraphType<Development>
    {
        public DevelopmentType(IBaseEntityRepository<Steward> stewardRepository)
        {
            Field(_ => _.Id);
            Field(_ => _.DevelopingId);
            Field(_ => _.Difficulty);
            Field(_ => _.Name);
            Field(_ => _.StewardId, nullable: true);

            FieldAsync<StewardType, Steward>(
                "steward",
                resolve: async context =>
                {
                    return await stewardRepository.GetByIdAsync(context.Source.StewardId);
                }
            );
        }
    }
}
