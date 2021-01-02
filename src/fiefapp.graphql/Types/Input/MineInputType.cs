using fiefapp.entities.Enums;
using GraphQL.Types;

namespace fiefapp.graphql.Types.Input
{
    public class MineInputType : InputObjectGraphType
    {
        public MineInputType()
        {
            Field<GuidGraphType>("id");
            Field<GuidGraphType>("fiefId");
            Field<EnumerationGraphType<TypeOfMine>>("type");
            Field<StringGraphType>("name");
            Field<IntGraphType>("yearsLeft");
            Field<IntGraphType>("quality");
            Field<IntGraphType>("silver");
            Field<IntGraphType>("base");
            Field<IntGraphType>("luxury");
            Field<IntGraphType>("iron");
            Field<IntGraphType>("stone");
            Field<IntGraphType>("wood");
            Field<IntGraphType>("developmentLevel");
            Field<BooleanGraphType>("isBeingDeveloped");
            Field<BooleanGraphType>("isInformationItem");
            Field<GuidGraphType>("developmentId");
            Field<DevelopmentInputType>("development");
            Field<GuidGraphType>("stewardId");
            Field<StewardInputType>("steward");
            Field<ListGraphType<GuidGraphType>>("soldierIds");
            Field<ListGraphType<SoldierInputType>>("soldiers");
        }
    }
}
