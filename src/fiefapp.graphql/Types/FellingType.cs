using fiefapp.entities;
using fiefapp.services.Interfaces;
using GraphQL.Types;

namespace fiefapp.graphql.Types
{
    public class FellingType : ObjectGraphType<Felling>
    {
        public FellingType(
            IBaseEntityRepository<Development> developmentRepository,
            IBaseEntityRepository<Steward> stewardRepository
        )
        {
            Field(_ => _.Id);
            Field(_ => _.FiefId);
            Field(_ => _.Name);
            Field(_ => _.Silver);
            Field(_ => _.Base);
            Field(_ => _.Luxury);
            Field(_ => _.Iron);
            Field(_ => _.Stone);
            Field(_ => _.Wood);
            Field(_ => _.AmountLandclearing);
            Field(_ => _.AmountLandclearingOfFelling);
            Field(_ => _.AmountFelling);
            Field(_ => _.AmountClearUseless);
            Field(_ => _.DevelopmentLevel);
            Field(_ => _.IsBeingDeveloped);
            Field(_ => _.Quality);
            Field(_ => _.IsInformationItem);
            Field(_ => _.DevelopmentId);
            Field(_ => _.StewardId);

            FieldAsync<DevelopmentType, Development>(
                "development",
                resolve: async context =>
                {
                    return await developmentRepository.GetByIdAsync(context.Source.DevelopmentId);
                }
            );
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
