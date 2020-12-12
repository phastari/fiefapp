using fiefapp.entities;
using GraphQL.Types;

namespace fiefapp.graphql.Types
{
    public class FiefType : ObjectGraphType<Fief>
    {
        public FiefType()
        {
            Field(_ => _.Id);
            Field(_ => _.Gamesession, type: typeof(GamesessionType));
            Field(_ => _.PlayerId);
            Field(_ => _.Name);
            Field(_ => _.ManorName);
            Field(_ => _.Acres);
            Field(_ => _.FarmlandAcres);
            Field(_ => _.PastureAcres);
            Field(_ => _.WoodlandAcres);
            Field(_ => _.FellingAcres);
            Field(_ => _.UnusableAcres);
            Field(_ => _.AnimalHusbandryQuality);
            Field(_ => _.AgriculturalQuality);
            Field(_ => _.FishingQuality);
            Field(_ => _.OreQuality);
            Field(_ => _.HuntingQuality);
            Field(_ => _.AnimalHusbandryDevelopmentLevel);
            Field(_ => _.AgriculturalDevelopmentLevel);
            Field(_ => _.FishingDevelopmentLevel);
            Field(_ => _.WoodlandDevelopmentLevel);
            Field(_ => _.OreDevelopmentLevel);
            Field(_ => _.HuntingDevelopmentLevel);
            Field(_ => _.EducationDevelopmentLevel);
            Field(_ => _.HealthcareDevelopmentLevel);
            Field(_ => _.MilitaryDevelopmentLevel);
            Field(_ => _.SeafaringDevelopmentLevel);
            Field(_ => _.Livingcondition, type: typeof(LivingconditionType));
            Field(_ => _.Road, type: typeof(RoadType));
            Field(_ => _.Inheritance, type: typeof(InheritanceType));
        }
    }
}
