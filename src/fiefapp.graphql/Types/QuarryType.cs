using fiefapp.entities;
using fiefapp.entities.Enums;
using GraphQL.Types;

namespace fiefapp.graphql.Types
{
    public class QuarryType : ObjectGraphType<Quarry>
    {
        public QuarryType()
        {
            Field(_ => _.Id);
            Field(_ => _.FiefId);
            Field(_ => _.Type, type: typeof(EnumerationGraphType<TypeOfQuarry>));
            Field(_ => _.Name);
            Field(_ => _.Silver);
            Field(_ => _.Base);
            Field(_ => _.Luxury);
            Field(_ => _.Iron);
            Field(_ => _.Stone);
            Field(_ => _.Wood);
            Field(_ => _.Quality);
            Field(_ => _.PopulationModifier);
            Field(_ => _.DevelopmentLevel);
            Field(_ => _.IsBeingDeveloped);
            Field(_ => _.IsInformationItem);
            Field(_ => _.StewardId, nullable: true);
            Field(_ => _.DevelopmentId, nullable: true);
            Field(_ => _.SoldierIds);
        }
    }
}
