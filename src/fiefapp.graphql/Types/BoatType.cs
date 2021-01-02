using fiefapp.entities;
using fiefapp.entities.Enums;
using fiefapp.services.Interfaces;
using GraphQL.Types;
using System.Collections.Generic;

namespace fiefapp.graphql.Types
{
    public class BoatType : ObjectGraphType<Boat>
    {
        public BoatType(
            IBaseEntityRepository<Boatbuilder> boatbuilderRepository,
            IBaseEntityRepository<Cargo> cargoRepository,
            IBaseEntityRepository<Shipyard> shipyardRepository,
            IBaseEntityRepository<Soldier> soldierRepository
        )
        {
            Field(_ => _.Id);
            Field(_ => _.Name);
            Field(_ => _.Length);
            Field(_ => _.Width);
            Field(_ => _.Depth);
            Field(_ => _.CrewNeeded);
            Field(_ => _.Seamens);
            Field(_ => _.Mariners);
            Field(_ => _.Rowers);
            Field(_ => _.RowersNeeded);
            Field(_ => _.MaxCargo);
            Field(_ => _.Sailors);
            Field(_ => _.Officers);
            Field(_ => _.Navigators);
            Field(_ => _.Amount);
            Field(_ => _.CostWhenFinishedSilver);
            Field(_ => _.NextFinishedDays);
            Field(_ => _.BuildTimeInDays);
            Field(_ => _.BuildTimeInDaysAll);
            Field(_ => _.Status);
            Field(_ => _.BackInDays);
            Field(_ => _.Type, type: typeof(EnumerationGraphType<TypeOfBoat>));
            Field(_ => _.DisplayName);
            Field(_ => _.Masts);
            Field(_ => _.LengthMin);
            Field(_ => _.LengthMax);
            Field(_ => _.BL);
            Field(_ => _.DB);
            Field(_ => _.Crew);
            Field(_ => _.BenchMod);
            Field(_ => _.BenchMulti);
            Field(_ => _.OarsMulti);
            Field(_ => _.RowerMulti);
            Field(_ => _.Seaworthiness);
            Field(_ => _.ImgSrc);
            Field(_ => _.BoatbuilderId, nullable: true);
            Field(_ => _.CargoId, nullable: true);
            Field(_ => _.ShipyardId, nullable: true);
            Field(_ => _.SoldierIds);

            FieldAsync<BoatbuilderType, Boatbuilder>(
                "boatbuilder",
                resolve: async context =>
                {
                    return await boatbuilderRepository.GetByIdAsync(context.Source.BoatbuilderId);
                }
            );
            FieldAsync<CargoType, Cargo>(
                "cargo",
                resolve: async context =>
                {
                    return await cargoRepository.GetByIdAsync(context.Source.CargoId);
                }
            );
            FieldAsync<ShipyardType, Shipyard>(
                "shipyard",
                resolve: async context =>
                {
                    return await shipyardRepository.GetByIdAsync(context.Source.ShipyardId);
                }
            );
            FieldAsync<ListGraphType<SoldierType>, ICollection<Soldier>>(
                "soldiers",
                resolve: async context =>
                {
                    return await soldierRepository.GetListAsync(context.Source.SoldierIds);
                }
            );
        }
    }
}
