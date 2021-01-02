using GraphQL.Types;

namespace fiefapp.graphql.Types.Input
{
    public class VillageInputType : InputObjectGraphType
    {
        public VillageInputType()
        {
            Field<GuidGraphType>("id");
            Field<GuidGraphType>("fiefId");
            Field<StringGraphType>("name");
            Field<IntGraphType>("serfdoms");
            Field<IntGraphType>("farmers");
            Field<IntGraphType>("boatbuilders");
            Field<IntGraphType>("tanners");
            Field<IntGraphType>("millers");
            Field<IntGraphType>("furriers");
            Field<IntGraphType>("tailors");
            Field<IntGraphType>("blacksmiths");
            Field<IntGraphType>("carpenters");
            Field<IntGraphType>("innkeepers");
        }
    }
}
