using fiefapp.entities;
using GraphQL.Types;

namespace fiefapp.graphql.Types
{
    public class BuildingAlternativeType : ObjectGraphType<BuildingAlternative>
    {
        public BuildingAlternativeType()
        {
            Name = "BuildingAlternative";

            Field(_ => _.Id);
            Field(_ => _.Type).Description("The name of the type of building.");
            Field(_ => _.Upkeep).Description("Base cost each year to maintain the building.");
            Field(_ => _.Stonework).Description("The amount of days a mason has to work on the building for it to be completed.");
            Field(_ => _.Woodwork).Description("The amount of days a carpenter has to work on the building for it to be completed.");
            Field(_ => _.Smithswork).Description("The amount of days a blacksmith has to work on the building for it to be completed.");
            Field(_ => _.Stone).Description("The amount of stone required to complete the building.");
            Field(_ => _.Wood).Description("The amount of wood required to complete the building.");
            Field(_ => _.Iron).Description("The amount of iron required to complete the building.");
            Field(_ => _.IncludedInGamesessions);
        }
    }
}
