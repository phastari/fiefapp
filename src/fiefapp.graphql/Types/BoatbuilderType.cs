using fiefapp.entities;
using fiefapp.services.Interfaces;
using GraphQL.Types;

namespace fiefapp.graphql.Types
{
    public class BoatbuilderType : ObjectGraphType<Boatbuilder>
    {
        public BoatbuilderType(
            IBaseEntityRepository<Shipyard> repository
        )
        {
            Field(_ => _.Id);
            Field(_ => _.Name);
            Field(_ => _.Age);
            Field(_ => _.Resources);
            Field(_ => _.Loyalty);
            Field(_ => _.Skill);
            Field(_ => _.Notes);
            Field(_ => _.ShipyardId, nullable: true);

            FieldAsync<ShipyardType, Shipyard>(
                "shipyard",
                resolve: async context =>
                {
                    return await repository.GetByIdAsync(context.Source.ShipyardId);
                }
            );
        }
    }
}
