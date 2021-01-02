using fiefapp.entities.Enums;
using GraphQL.Types;

namespace fiefapp.graphql.Types.Input
{
    public class IncomeInputType : InputObjectGraphType
    {
        public IncomeInputType()
        {
            Field<GuidGraphType>("id");
            Field<GuidGraphType>("fiefId");
            Field<EnumerationGraphType<TypeOfIncome>>("type");
            Field<StringGraphType>("name");
            Field<IntGraphType>("silver");
            Field<IntGraphType>("base");
            Field<IntGraphType>("luxury");
            Field<IntGraphType>("iron");
            Field<IntGraphType>("stone");
            Field<IntGraphType>("wood");
            Field<IntGraphType>("quality");
            Field<BooleanGraphType>("showInIncomes");
            Field<DecimalGraphType>("springModifier");
            Field<DecimalGraphType>("summerModifier");
            Field<DecimalGraphType>("fallModifier");
            Field<DecimalGraphType>("winterModifier");
            Field<IntGraphType>("developmentLevel");
            Field<BooleanGraphType>("isBeingDeveloped");
            Field<BooleanGraphType>("isInformationItem");
            Field<GuidGraphType>("stewardId");
            Field<StewardInputType>("steward");
            Field<GuidGraphType>("developmentId");
            Field<DevelopmentInputType>("development");
        }
    }
}
