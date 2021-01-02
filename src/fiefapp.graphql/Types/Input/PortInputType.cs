using GraphQL.Types;

namespace fiefapp.graphql.Types.Input
{
    public class PortInputType : InputObjectGraphType
    {
        public PortInputType()
        {
            Field<GuidGraphType>("id");
            Field<GuidGraphType>("fiefId");
            Field<GuidGraphType>("shipyardId");
            Field<StringGraphType>("name");
            Field<IntGraphType>("developmentLevel");
            Field<IntGraphType>("merchandise");
            Field<IntGraphType>("taxes");
            Field<IntGraphType>("bailiffs");
            Field<IntGraphType>("crime");
            Field<BooleanGraphType>("isInformationItem");
            Field<BooleanGraphType>("isBeingDeveloped");
            Field<IntGraphType>("quality");
            Field<IntGraphType>("silver");
            Field<IntGraphType>("base");
            Field<IntGraphType>("luxury");
            Field<IntGraphType>("iron");
            Field<IntGraphType>("stone");
            Field<IntGraphType>("wood");
            Field<GuidGraphType>("stewardId");
            Field<StewardInputType>("steward");
            Field<GuidGraphType>("developmentId");
            Field<DevelopmentInputType>("development");
            Field<ListGraphType<GuidGraphType>>("soldierIds");
            Field<ListGraphType<SoldierInputType>>("soldiers");
            Field<ListGraphType<GuidGraphType>>("boatIds");
            Field<ListGraphType<BoatInputType>>("boats");
        }
    }
}
