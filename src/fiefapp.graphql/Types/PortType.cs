using fiefapp.entities;
using fiefapp.services.Interfaces;
using GraphQL.Types;
using System.Collections.Generic;

namespace fiefapp.graphql.Types
{
    public class PortType : ObjectGraphType<Port>
    {
        public PortType(
            IBaseEntityRepository<Steward> stewardRepository,
            IBaseEntityRepository<Soldier> soldierRepository,
            IBaseEntityRepository<Development> developmentRepository,
            IBaseEntityRepository<Boat> boatRepository
        )
        {
            Field(_ => _.Id);
            Field(_ => _.FiefId);
            Field(_ => _.ShipyardId);
            Field(_ => _.Name);
            Field(_ => _.DevelopmentLevel);
            Field(_ => _.Merchandise);
            Field(_ => _.Taxes);
            Field(_ => _.Bailiffs);
            Field(_ => _.Crime);
            Field(_ => _.IsInformationItem);
            Field(_ => _.IsBeingDeveloped);
            Field(_ => _.Silver, nullable: true);
            Field(_ => _.Base, nullable: true);
            Field(_ => _.Luxury, nullable: true);
            Field(_ => _.Iron, nullable: true);
            Field(_ => _.Stone, nullable: true);
            Field(_ => _.Wood, nullable: true);
            Field(_ => _.Quality, nullable: true);
            Field(_ => _.SoldierIds);
            Field(_ => _.BoatIds);
            Field(_ => _.StewardId, nullable: true);
            Field(_ => _.DevelopmentId, nullable: true);

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
            FieldAsync<ListGraphType<SoldierType>, ICollection<Soldier>>(
                "soldiers",
                resolve: async context =>
                {
                    return await soldierRepository.GetListAsync(context.Source.SoldierIds);
                }
            );
            FieldAsync<ListGraphType<BoatType>, ICollection<Boat>>(
                "boats",
                resolve: async context =>
                {
                    return await boatRepository.GetListAsync(context.Source.BoatIds);
                }
            );
        }
    }
}
