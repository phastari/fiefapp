using GraphQL.Types;

namespace fiefapp.graphql.Types.Input
{
    public class ShipyardInputType : InputObjectGraphType
    {
        public ShipyardInputType()
        {
            Field<GuidGraphType>("id");
            Field<GuidGraphType>("fiefId");
            Field<StringGraphType>("name");
            Field<IntGraphType>("smallDocks");
            Field<IntGraphType>("mediumDocks");
            Field<IntGraphType>("largeDocks");
            Field<IntGraphType>("populationModifier");
            Field<IntGraphType>("developmentLevel");
            Field<BooleanGraphType>("isBeingDeveloped");
            Field<BooleanGraphType>("isInformationItem");
            Field<IntGraphType>("quality");
            Field<IntGraphType>("silver");
            Field<IntGraphType>("base");
            Field<IntGraphType>("luxury");
            Field<IntGraphType>("iron");
            Field<IntGraphType>("stone");
            Field<IntGraphType>("wood");
            Field<ListGraphType<GuidGraphType>>("boatbuilderIds");
            Field<ListGraphType<BoatbuilderInputType>>("boatbuilders");
            Field<ListGraphType<GuidGraphType>>("boatIds");
            Field<ListGraphType<BoatInputType>>("boats");
            Field<GuidGraphType>("stewardId");
            Field<StewardInputType>("steward");
            Field<GuidGraphType>("developmentId");
            Field<DevelopmentInputType>("development");
        }
    }
}
