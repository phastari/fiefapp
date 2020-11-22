export const holder = {
  query: `
    {
      selectionAlternatives {
        selectionAlternatives
        {
          inheritances {
            type
            name
            description
          }
          livingconditions {
            type
            baseCost
            luxuryCost
            focusGain
            wellbeingGain
            description
          }
          roads {
            type
            name
            upgradeBaseCost
            upgradeStoneCost
            modificationFactor
          }
        }
      }
    }
    `,
};
