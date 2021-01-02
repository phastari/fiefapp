using fiefapp.entities;
using fiefapp.services.Interfaces;
using GraphQL.Types;
using System.Collections.Generic;

namespace fiefapp.graphql.Types
{
    public class ShipyardType : ObjectGraphType<Shipyard>
    {
        public ShipyardType(
            IBaseEntityRepository<Boatbuilder> boatbuilderRepository,
            IBaseEntityRepository<Boat> boatRepository,
            IBaseEntityRepository<Steward> stewardRepository,
            IBaseEntityRepository<Development> developmentRepository
        )
        {
            Field(_ => _.Id);
            Field(_ => _.FiefId);
            Field(_ => _.Name);
            Field(_ => _.SmallDocks);
            Field(_ => _.MediumDocks);
            Field(_ => _.LargeDocks);
            Field(_ => _.PopulationModifier);
            Field(_ => _.DevelopmentLevel);
            Field(_ => _.IsBeingDeveloped);
            Field(_ => _.Silver);
            Field(_ => _.Base);
            Field(_ => _.Luxury);
            Field(_ => _.Iron);
            Field(_ => _.Stone);
            Field(_ => _.Wood);
            Field(_ => _.Quality);
            Field(_ => _.IsInformationItem);
            Field(_ => _.BoatbuilderIds);
            Field(_ => _.BoatIds);
            Field(_ => _.StewardId);
            Field(_ => _.DevelopmentId);

            FieldAsync<ListGraphType<BoatbuilderType>, ICollection<Boatbuilder>>(
                "boatbuilders",
                resolve: async context =>
                {
                    return await boatbuilderRepository.GetListAsync(context.Source.BoatbuilderIds);
                }
            );
            FieldAsync<ListGraphType<BoatType>, ICollection<Boat>>(
                "boats",
                resolve: async context =>
                {
                    return await boatRepository.GetListAsync(context.Source.BoatIds);
                }
            );
            FieldAsync<StewardType, Steward>(
                "steward",
                resolve: async context =>
                {
                    return await stewardRepository.GetByIdAsync(context.Source.StewardId);
                }
            );
            FieldAsync<DevelopmentType, Development>(
                "development",
                resolve: async context =>
                {
                    return await developmentRepository.GetByIdAsync(context.Source.DevelopmentId);
                }
            );
        }
    }
}
