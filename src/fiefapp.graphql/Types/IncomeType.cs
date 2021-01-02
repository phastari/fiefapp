using fiefapp.entities;
using fiefapp.entities.Enums;
using fiefapp.services.Interfaces;
using GraphQL.Types;

namespace fiefapp.graphql.Types
{
    public class IncomeType : ObjectGraphType<Income>
    {
        public IncomeType(
            IBaseEntityRepository<Development> developmentRepository,
            IBaseEntityRepository<Steward> stewardRepository
        )
        {
            Field(_ => _.Id);
            Field(_ => _.FiefId);
            Field(_ => _.Type, type: typeof(EnumerationGraphType<TypeOfIncome>));
            Field(_ => _.Name);
            Field(_ => _.Silver, nullable: true);
            Field(_ => _.Base, nullable: true);
            Field(_ => _.Luxury, nullable: true);
            Field(_ => _.Iron, nullable: true);
            Field(_ => _.Stone, nullable: true);
            Field(_ => _.Wood, nullable: true);
            Field(_ => _.Quality, nullable: true);
            Field(_ => _.ShowInIncomes);
            Field(_ => _.SpringModifier);
            Field(_ => _.SummerModifier);
            Field(_ => _.FallModifier);
            Field(_ => _.WinterModifier);
            Field(_ => _.DevelopmentLevel);
            Field(_ => _.IsBeingDeveloped);
            Field(_ => _.IsInformationItem);

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
