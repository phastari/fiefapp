using GraphQL.Types;

namespace fiefapp.graphql.Types.Input
{
    public class FellingInputType : InputObjectGraphType
    {
        public FellingInputType()
        {
            Field<GuidGraphType>("id");
            Field<GuidGraphType>("fiefId");
            Field<StringGraphType>("name");
            Field<IntGraphType>("silver");
            Field<IntGraphType>("base");
            Field<IntGraphType>("luxury");
            Field<IntGraphType>("iron");
            Field<IntGraphType>("stone");
            Field<IntGraphType>("wood");
            Field<IntGraphType>("amountLandclearing");
            Field<IntGraphType>("amountLandclearingOfFelling");
            Field<IntGraphType>("amountFelling");
            Field<IntGraphType>("amountClearUseless");
            Field<IntGraphType>("developmentLevel");
            Field<BooleanGraphType>("isBeingDeveloped");
            Field<IntGraphType>("quality");
            Field<BooleanGraphType>("isInformationItem");
            Field<GuidGraphType>("developmentId");
            Field<DevelopmentInputType>("development");
            Field<GuidGraphType>("stewardId");
            Field<StewardInputType>("steward");
        }
    }
}
