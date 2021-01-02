    using fiefapp.entities;
using fiefapp.services.Interfaces;
using GraphQL.Types;
using System.Collections.Generic;

namespace fiefapp.graphql.Types
{
    public class GamesessionType : ObjectGraphType<Gamesession>
    {
        public GamesessionType(
            IAlternativesRepository<Inheritance> inheritanceRepository, 
            IAlternativesRepository<Road> roadRepository, 
            IAlternativesRepository<Livingcondition> livingconditionRepository)
        {
            Field(_ => _.Id);
            Field(_ => _.OwnerId);
            Field(_ => _.UserIds, type: typeof(ListGraphType<StringGraphType>));
            Field(_ => _.GamemasterId);
            Field(_ => _.PlayerIds, type: typeof(ListGraphType<StringGraphType>));
            Field(_ => _.Name);
            FieldAsync<ListGraphType<InheritanceType>, List<Inheritance>>(
                "inheritances",
                resolve: async context =>
                {
                    return await inheritanceRepository.GetAsync(context.Source.Id);
                }
            );
            FieldAsync<ListGraphType<RoadType>, List<Road>>(
                "roads",
                resolve: async context =>
                {
                    return await roadRepository.GetAsync(context.Source.Id);
                }
            );
            FieldAsync<ListGraphType<LivingconditionType>, List<Livingcondition>>(
                "livingconditions",
                resolve: async context =>
                {
                    return await livingconditionRepository.GetAsync(context.Source.Id);
                }
            );
        }
    }
}
