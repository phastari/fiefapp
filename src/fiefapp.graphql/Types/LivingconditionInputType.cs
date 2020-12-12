using GraphQL.Types;

namespace fiefapp.graphql.Types
{
    public class LivingconditionInputType : InputObjectGraphType
    {
        public LivingconditionInputType()
        {
            Field<NonNullGraphType<StringGraphType>>("type");
            Field<NonNullGraphType<StringGraphType>>("name");
            Field<NonNullGraphType<IntGraphType>>("baseCost");
            Field<NonNullGraphType<IntGraphType>>("luxuryCost");
            Field<NonNullGraphType<IntGraphType>>("focusGain");
            Field<NonNullGraphType<IntGraphType>>("wellbeingGain");
            Field<NonNullGraphType<StringGraphType>>("description");
        }
    }
}
