using GraphQL.Types;

namespace fiefapp.graphql.Types.Input
{
    public class MarketInputType : InputObjectGraphType
    {
        public MarketInputType()
        {
            Field<GuidGraphType>("id");
            Field<GuidGraphType>("fiefId");
            Field<StringGraphType>("name");
            Field<IntGraphType>("developmentLevel");
            Field<BooleanGraphType>("isInformationItem");
            Field<BooleanGraphType>("isBeingDeveloped");
            Field<IntGraphType>("silver");
            Field<IntGraphType>("base");
            Field<IntGraphType>("luxury");
            Field<IntGraphType>("iron");
            Field<IntGraphType>("stone");
            Field<IntGraphType>("wood");
            Field<IntGraphType>("quality");
            Field<IntGraphType>("merchandise");
            Field<IntGraphType>("taxes");
            Field<IntGraphType>("bailiffs");
            Field<IntGraphType>("crime");
            Field<GuidGraphType>("stewardId");
            Field<StewardInputType>("steward");
            Field<GuidGraphType>("developmentId");
            Field<DevelopmentInputType>("development");
            Field<ListGraphType<GuidGraphType>>("merchantIds");
            Field<ListGraphType<MerchantInputType>>("merchants");
            Field<ListGraphType<GuidGraphType>>("soldierIds");
            Field<ListGraphType<SoldierInputType>>("soldiers");
        }
    }
}
