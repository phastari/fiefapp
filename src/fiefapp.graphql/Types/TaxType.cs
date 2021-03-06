﻿using fiefapp.entities;
using fiefapp.entities.Enums;
using fiefapp.services.Interfaces;
using GraphQL.Types;

namespace fiefapp.graphql.Types
{
    public class TaxType : ObjectGraphType<Tax>
    {
        public TaxType(
            IBaseEntityRepository<Development> developmentRepository,
            IBaseEntityRepository<Steward> stewardRepository
        )
        {
            Field(_ => _.Id);
            Field(_ => _.FiefId);
            Field(_ => _.Type, type: typeof(EnumerationGraphType<TypeOfTax>));
            Field(_ => _.Name);
            Field(_ => _.Silver, nullable: true);
            Field(_ => _.Base, nullable: true);
            Field(_ => _.Luxury, nullable: true);
            Field(_ => _.Iron, nullable: true);
            Field(_ => _.Stone, nullable: true);
            Field(_ => _.Wood, nullable: true);
            Field(_ => _.Quality, nullable: true);
            Field(_ => _.DevelopmentLevel);
            Field(_ => _.IsBeingDeveloped);
            Field(_ => _.IsInformationItem);
            Field(_ => _.StewardId, nullable: true);
            Field(_ => _.DevelopmentId, nullable: true);

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
