using GraphQL.Types;

namespace fiefapp.graphql.Types.Input
{
    public class SubsidiaryInputType : InputObjectGraphType
    {
        public SubsidiaryInputType()
        {
            Field<GuidGraphType>("id");
            Field<GuidGraphType>("fiefId");
            Field<StringGraphType>("name");
            Field<IntGraphType>("quality");
            Field<IntGraphType>("silver");
            Field<IntGraphType>("base");
            Field<IntGraphType>("luxury");
            Field<IntGraphType>("iron");
            Field<IntGraphType>("stone");
            Field<IntGraphType>("wood");
            Field<IntGraphType>("developmentLevel");
            Field<IntGraphType>("daysworkThisYear");
            Field<IntGraphType>("daysworkUpkeep");
            Field<IntGraphType>("daysworkBuild");
            Field<IntGraphType>("incomeFactor");
            Field<DecimalGraphType>("silverPortion");
            Field<DecimalGraphType>("basePortion");
            Field<DecimalGraphType>("luxuryPortion");
            Field<DecimalGraphType>("springModifier");
            Field<DecimalGraphType>("summerModifier");
            Field<DecimalGraphType>("fallModifier");
            Field<DecimalGraphType>("winterModifier");
            Field<BooleanGraphType>("isBeingDeveloped");
            Field<BooleanGraphType>("isInformationItem");
            Field<GuidGraphType>("stewardId");
            Field<StewardInputType>("steward");
            Field<GuidGraphType>("developmentId");
            Field<DevelopmentInputType>("development");
        }
    }
}
