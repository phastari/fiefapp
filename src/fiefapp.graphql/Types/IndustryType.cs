using fiefapp.entities;
using GraphQL.Types;

namespace fiefapp.graphql.Types
{
    public class IndustryType : UnionGraphType
    {
        public IndustryType()
        {
            Type<FellingType>();
            Type<IncomeType>();
            Type<MarketType>();
            Type<MineType>();
            Type<PortType>();
            Type<QuarryType>();
            Type<ShipyardType>();
            Type<SubsidiaryType>();
            Type<TaxType>();
        }
    }
}
