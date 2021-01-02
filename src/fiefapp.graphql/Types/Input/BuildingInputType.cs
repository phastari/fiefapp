using GraphQL.Types;

namespace fiefapp.graphql.Types.Input
{
    public class BuildingInputType : InputObjectGraphType
    {
        public BuildingInputType()
        {
            Field<GuidGraphType>("id");
            Field<StringGraphType>("type");
            Field<DecimalGraphType>("upkeep");
            Field<IntGraphType>("stonework");
            Field<IntGraphType>("woodwork");
            Field<IntGraphType>("smithswork");
            Field<IntGraphType>("stone");
            Field<IntGraphType>("wood");
            Field<IntGraphType>("iron");
            Field<ListGraphType<GuidGraphType>>("gamesessionIds");
            Field<GamesessionInputType>("gamesession");
        }
    }
}
