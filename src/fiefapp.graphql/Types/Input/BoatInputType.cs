using fiefapp.entities.Enums;
using GraphQL.Types;

namespace fiefapp.graphql.Types.Input
{
    public class BoatInputType : InputObjectGraphType
    {
        public BoatInputType()
        {
            Field<GuidGraphType>("id");
            Field<StringGraphType>("name");
            Field<FloatGraphType>("length");
            Field<FloatGraphType>("width");
            Field<FloatGraphType>("depth");
            Field<IntGraphType>("crewNeeded");
            Field<IntGraphType>("seamens");
            Field<IntGraphType>("mariners");
            Field<IntGraphType>("rowers");
            Field<IntGraphType>("rowersNeeded");
            Field<IntGraphType>("maxCargo");
            Field<IntGraphType>("sailors");
            Field<IntGraphType>("officers");
            Field<IntGraphType>("navigators");
            Field<IntGraphType>("amount");
            Field<IntGraphType>("costWhenFinishedSilver");
            Field<IntGraphType>("nextFinishedDays");
            Field<IntGraphType>("buildTimeInDays");
            Field<IntGraphType>("buildTimeInDaysAll");
            Field<StringGraphType>("status");
            Field<IntGraphType>("backInDays");
            Field<EnumerationGraphType<TypeOfBoat>>("type");
            Field<StringGraphType>("displayName");
            Field<IntGraphType>("masts");
            Field<IntGraphType>("lengthMin");
            Field<IntGraphType>("lengthMax");
            Field<FloatGraphType>("bL");
            Field<FloatGraphType>("dB");
            Field<IntGraphType>("crew");
            Field<FloatGraphType>("benchMod");
            Field<FloatGraphType>("benchMulti");
            Field<FloatGraphType>("oarsMulti");
            Field<FloatGraphType>("rowerMulti");
            Field<IntGraphType>("seaworthiness");
            Field<StringGraphType>("imgSrc");
            Field<GuidGraphType>("boatbuilderId");
            Field<BoatbuilderInputType>("boatbuilder");
            Field<GuidGraphType>("cargoId");
            Field<CargoInputType>("cargo");
            Field<GuidGraphType>("shipyardId");
            Field<ShipyardInputType>("shipyard");
            Field<ListGraphType<GuidGraphType>>("soldierIds");
            Field<ListGraphType<SoldierInputType>>("soldiers");
        }
    }
}
