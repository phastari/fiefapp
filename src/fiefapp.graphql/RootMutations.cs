using fiefapp.entities;
using fiefapp.graphql.Services;
using fiefapp.services.Interfaces;
using GraphQL.Types;

namespace fiefapp.graphql
{
    public partial class RootMutations : ObjectGraphType
    {
        public RootMutations(
            ISubscriptionService<Building> buildingSubscriptionService, 
            ISubscriptionService<Gamesession> gamesessionSubscriptionService, 
            IAlternativesRepository<Inheritance> inheritancesRepository,
            IAlternativesRepository<Road> roadsRepository,
            IAlternativesRepository<Livingcondition> livingconditionsRepository
        )
        {
            AddBuildingFields(buildingSubscriptionService);
            AddGamesessionFields(gamesessionSubscriptionService, inheritancesRepository, roadsRepository, livingconditionsRepository);
        }

        partial void AddBuildingFields(ISubscriptionService<Building> buildingSubscriptionService);
        partial void AddGamesessionFields(
            ISubscriptionService<Gamesession> gamesessionSubscriptionService,
            IAlternativesRepository<Inheritance> inheritancesRepository,
            IAlternativesRepository<Road> roadsRepository,
            IAlternativesRepository<Livingcondition> livingconditionsRepository
        );
    }
}
