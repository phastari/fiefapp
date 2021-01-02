using fiefapp.entities;
using fiefapp.entities.BaseClasses;
using fiefapp.services.Interfaces;
using GraphQL.Types;
using System.Collections.Generic;

namespace fiefapp.graphql.Types
{
    public class FiefType : ObjectGraphType<Fief>
    {
        public FiefType(
            IBaseEntityRepository<Market> marketRepository,
            IBaseEntityRepository<Steward> stewardRepository,
            IBaseEntityRepository<Port> portRepository,
            IBaseEntityRepository<Livingcondition> livingconditionRepository,
            IBaseEntityRepository<Road> roadRepository,
            IBaseEntityRepository<Inheritance> inheritanceRepository,
            IBaseEntityRepository<Village> villageRepository,
            IIndustryRepository industryRepository,
            IBaseEntityRepository<Building> buildingRepository,
            IBaseEntityRepository<Resident> residentRepository,
            IBaseEntityRepository<Soldier> soldierRepository,
            IBaseEntityRepository<Employee> employeeRepository,
            IBaseEntityRepository<Builder> builderRepository
        )
        {
            Field(_ => _.Id);
            Field(_ => _.GamesessionId);
            Field(_ => _.UserId);
            Field(_ => _.Name);
            Field(_ => _.ManorName);
            Field(_ => _.Acres);
            Field(_ => _.FarmlandAcres);
            Field(_ => _.PastureAcres);
            Field(_ => _.WoodlandAcres);
            Field(_ => _.FellingAcres);
            Field(_ => _.UnusableAcres);
            Field(_ => _.LivingconditionId);
            Field(_ => _.RoadId);
            Field(_ => _.InheritanceId);
            Field(_ => _.BuildingIds);
            Field(_ => _.SoldierIds);
            Field(_ => _.EmployeeIds);
            Field(_ => _.StewardId, nullable: true);
            Field(_ => _.PortId, nullable: true);
            Field(_ => _.MarketId, nullable: true);
            Field(_ => _.VillageIds);
            Field(_ => _.ResidentIds);
            Field(_ => _.BuilderIds);


            FieldAsync<MarketType, Market>(
                "market",
                resolve: async context =>
                {
                    return await marketRepository.GetByIdAsync(context.Source.MarketId);
                }
            );
            FieldAsync<StewardType, Steward>(
                "steward",
                resolve: async context =>
                {
                    return await stewardRepository.GetByIdAsync(context.Source.StewardId);
                }
            );
            FieldAsync<PortType, Port>(
                "port",
                resolve: async context =>
                {
                    return await portRepository.GetByIdAsync(context.Source.PortId);
                }
            );
            FieldAsync<LivingconditionType, Livingcondition>(
                "livingcondition",
                resolve: async context =>
                {
                    return await livingconditionRepository.GetByIdAsync(context.Source.LivingconditionId);
                }
            );
            FieldAsync<RoadType, Road>(
                "road",
                resolve: async context =>
                {
                    return await roadRepository.GetByIdAsync(context.Source.RoadId);
                }
            );
            FieldAsync<InheritanceType, Inheritance>(
                "inheritance",
                resolve: async context =>
                {
                    return await inheritanceRepository.GetByIdAsync(context.Source.InheritanceId);
                }
            );
            FieldAsync<ListGraphType<VillageType>, ICollection<Village>>(
                "villages",
                resolve: async context =>
                {
                    return await villageRepository.GetListAsync(context.Source.VillageIds);
                }
            );
            FieldAsync<ListGraphType<IndustryType>, ICollection<Industry>>(
                "industries",
                resolve: async context =>
                {
                    return await industryRepository.GetIndustriesForFief(context.Source.Id);
                }
            );
            FieldAsync<ListGraphType<BuildingType>, ICollection<Building>>(
                "buildings",
                resolve: async context =>
                {
                    return await buildingRepository.GetListAsync(context.Source.BuildingIds);
                }
            );
            FieldAsync<ListGraphType<ResidentType>, ICollection<Resident>>(
                "residents",
                resolve: async context =>
                {
                    return await residentRepository.GetListAsync(context.Source.ResidentIds);
                }
            );
            FieldAsync<ListGraphType<SoldierType>, ICollection<Soldier>>(
                "soldiers",
                resolve: async context =>
                {
                    return await soldierRepository.GetListAsync(context.Source.SoldierIds);
                }
            );
            FieldAsync<ListGraphType<EmployeeType>, ICollection<Employee>>(
                "employees",
                resolve: async context =>
                {
                    return await employeeRepository.GetListAsync(context.Source.EmployeeIds);
                }
            );
            FieldAsync<ListGraphType<BuilderType>, ICollection<Builder>>(
                "builders",
                resolve: async context =>
                {
                    return await builderRepository.GetListAsync(context.Source.BuilderIds);
                }
            );
        }
    }
}
