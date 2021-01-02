using GraphQL.Types;
using fiefapp.entities;
using fiefapp.services.Interfaces;

namespace fiefapp.graphql.Types
{
    public class BuilderType : ObjectGraphType<Builder>
    {
        public BuilderType(IBaseEntityRepository<Building> buildingRepository)
        {
            Field(_ => _.Id);
            Field(_ => _.FiefId);
            Field(_ => _.Name);
            Field(_ => _.Age);
            Field(_ => _.Resources);
            Field(_ => _.Loyalty);
            Field(_ => _.Skill);
            Field(_ => _.Notes);
            Field(_ => _.BuildingId, nullable: true);

            FieldAsync<BuildingType, Building>(
                "building",
                resolve: async context =>
                {
                    return await buildingRepository.GetByIdAsync(context.Source.Id);
                }
            );
        }
    }
}
