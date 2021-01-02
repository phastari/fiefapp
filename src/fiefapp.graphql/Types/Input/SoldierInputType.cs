using fiefapp.entities.Enums;
using GraphQL.Types;

namespace fiefapp.graphql.Types.Input
{
    public class SoldierInputType : InputObjectGraphType
    {
        public SoldierInputType()
        {
            Field<GuidGraphType>("id");
            Field<StringGraphType>("name");
            Field<IntGraphType>("age");
            Field<IntGraphType>("resources");
            Field<IntGraphType>("loyalty");
            Field<IntGraphType>("skill");
            Field<ListGraphType<StringGraphType>>("notes");
            Field<GuidGraphType>("assignedTo");
            Field<BooleanGraphType>("isResident");
            Field<EnumerationGraphType<TypeOfSoldier>>("type");
            Field<StringGraphType>("displayName");
            Field<IntGraphType>("silverCost");
            Field<IntGraphType>("baseCost");
        }
    }
}
