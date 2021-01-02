using GraphQL.Types;

namespace fiefapp.graphql.Types.Input
{
    public class FiefInputType : InputObjectGraphType
    {
        public FiefInputType()
        {
            Field<GuidGraphType>("id");
            Field<GuidGraphType>("gamesessionId");
            Field<StringGraphType>("userId");
            Field<StringGraphType>("name");
            Field<StringGraphType>("manorName");
            Field<IntGraphType>("acres");
            Field<IntGraphType>("farmlandAcres");
            Field<IntGraphType>("pastureAcres");
            Field<IntGraphType>("woodlandAcres");
            Field<IntGraphType>("fellingAcres");
            Field<IntGraphType>("unusableAcres");
            Field<GuidGraphType>("marketId");
            Field<GuidGraphType>("stewardId");
            Field<GuidGraphType>("portId");
            Field<GuidGraphType>("livingconditionId");
            Field<GuidGraphType>("roadId");
            Field<GuidGraphType>("inheritanceId");
            Field<ListGraphType<GuidGraphType>>("villageIds");
            Field<ListGraphType<VillageInputType>>("villages");
            Field<ListGraphType<GuidGraphType>>("industryIds");
            Field<ListGraphType<IndustryInputType>>("industries");
            Field<ListGraphType<GuidGraphType>>("buildingIds");
            Field<ListGraphType<BuildingInputType>>("buildings");
            Field<ListGraphType<GuidGraphType>>("residentIds");
            Field<ListGraphType<ResidentInputType>>("residents");
            Field<ListGraphType<GuidGraphType>>("soldierIds");
            Field<ListGraphType<SoldierInputType>>("soldiers");
            Field<ListGraphType<GuidGraphType>>("employeeIds");
            Field<ListGraphType<EmployeeInputType>>("employees");
            Field<ListGraphType<GuidGraphType>>("builderIds");
            Field<ListGraphType<BuilderInputType>>("builders");
        }
    }
}
