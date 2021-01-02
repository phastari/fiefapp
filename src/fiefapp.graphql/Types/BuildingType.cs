using fiefapp.entities;
using fiefapp.services.Interfaces;
using GraphQL.Types;
using System.Collections.Generic;

namespace fiefapp.graphql.Types
{
    public class BuildingType : ObjectGraphType<Building>
    {
        public BuildingType(
            IBaseEntityRepository<Builder> builderRepository,
            IBaseEntityRepository<Gamesession> gamesessionRepository
        )
        {
            Field(_ => _.Id);
            Field(_ => _.Type);
            Field(_ => _.Upkeep);
            Field(_ => _.Stonework);
            Field(_ => _.Woodwork);
            Field(_ => _.Smithswork);
            Field(_ => _.Stone);
            Field(_ => _.Wood);
            Field(_ => _.Iron);
            Field(_ => _.GamesessionIds);
            Field(_ => _.BuilderId, nullable: true);

            FieldAsync<ListGraphType<GamesessionType>, ICollection<Gamesession>>(
                "gamesession",
                resolve: async context =>
                {
                    return await gamesessionRepository.GetListAsync(context.Source.GamesessionIds);
                }
            );
            FieldAsync<BuilderType, Builder>(
                "builder",
                resolve: async context =>
                {
                    return await builderRepository.GetByIdAsync(context.Source.BuilderId);
                }
            );
        }
    }
}
