using fiefapp.entities.Enums;
using GraphQL.Types;

namespace fiefapp.graphql.Types.Input
{
    public class QuarryInputType : InputObjectGraphType
    {
        public QuarryInputType()
        {
            Field<GuidGraphType>("id");
            Field<GuidGraphType>("fiefId");
            Field<EnumerationGraphType<TypeOfQuarry>>("type");
            Field<StringGraphType>("name");
            Field<IntGraphType>("quality");
            Field<IntGraphType>("silver");
            Field<IntGraphType>("base");
            Field<IntGraphType>("luxury");
            Field<IntGraphType>("iron");
            Field<IntGraphType>("stone");
            Field<IntGraphType>("wood");
            Field<IntGraphType>("populationModifier");
            Field<IntGraphType>("developmentLevel");
            Field<BooleanGraphType>("isInformationItem");
            Field<BooleanGraphType>("isBeingDeveloped");
            Field<GuidGraphType>("stewardId");
            Field<StewardInputType>("steward");
            Field<GuidGraphType>("developmentId");
            Field<DevelopmentInputType>("development");
            Field<ListGraphType<GuidGraphType>>("soldierIds");
            Field<ListGraphType<SoldierInputType>>("soldiers");
        }
    }
}
