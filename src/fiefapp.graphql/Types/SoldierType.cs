using fiefapp.entities;
using fiefapp.entities.Enums;
using GraphQL.Types;

namespace fiefapp.graphql.Types
{
    public class SoldierType : ObjectGraphType<Soldier>
    {
        public SoldierType()
        {
            Field(_ => _.Id);
            Field(_ => _.Name);
            Field(_ => _.Age);
            Field(_ => _.Resources);
            Field(_ => _.Loyalty);
            Field(_ => _.Skill);
            Field(_ => _.Notes);
            Field(_ => _.AssignedTo, nullable: true);
            Field(_ => _.IsResident);
            Field(_ => _.Type, type: typeof(EnumerationGraphType<TypeOfSoldier>));
            Field(_ => _.DisplayName);
            Field(_ => _.SilverCost);
            Field(_ => _.BaseCost);
        }
    }
}
