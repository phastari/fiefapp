using fiefapp.graphql.Enums;
using GraphQL.Types;

namespace fiefapp.graphql.Types.Input
{
    public class IndustryInputType : InputObjectGraphType
    {
        public IndustryInputType()
        {
            Field<EnumerationGraphType<TypeOfIndustry>>("type");
            Field<FellingInputType>("felling");
            Field<IncomeInputType>("income");
            Field<MarketInputType>("market");
            Field<MineInputType>("mine");
            Field<QuarryInputType>("quarry");
            Field<PortInputType>("port");
            Field<ShipyardInputType>("shipyard");
            Field<SubsidiaryInputType>("subsidiary");
            Field<TaxInputType>("tax");
        }
    }
}
