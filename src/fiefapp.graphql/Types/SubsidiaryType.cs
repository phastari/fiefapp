using fiefapp.entities;
using fiefapp.services.Interfaces;
using GraphQL.Types;

namespace fiefapp.graphql.Types
{
    public class SubsidiaryType : ObjectGraphType<Subsidiary>
    {
        public SubsidiaryType(
            IBaseEntityRepository<Development> developmentRepository,
            IBaseEntityRepository<Steward> stewardRepository
        )
        {
            Field(_ => _.Id);
            Field(_ => _.FiefId);
            Field(_ => _.Name);
            Field(_ => _.Silver, nullable: true);
            Field(_ => _.Base, nullable: true);
            Field(_ => _.Luxury, nullable: true);
            Field(_ => _.Iron, nullable: true);
            Field(_ => _.Stone, nullable: true);
            Field(_ => _.Wood, nullable: true);
            Field(_ => _.Quality, nullable: true);
            Field(_ => _.DevelopmentLevel);
            Field(_ => _.DaysworkThisYear);
            Field(_ => _.DaysworkBuild);
            Field(_ => _.DaysworkUpkeep);
            Field(_ => _.IncomeFactor);
            Field(_ => _.SilverPortion);
            Field(_ => _.BasePortion);
            Field(_ => _.LuxuryPortion);
            Field(_ => _.SpringModifier);
            Field(_ => _.SummerModifier);
            Field(_ => _.FallModifier);
            Field(_ => _.WinterModifier);
            Field(_ => _.IsBeingDeveloped);
            Field(_ => _.IsInformationItem);
            Field(_ => _.StewardId);
            Field(_ => _.DevelopmentId);

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
