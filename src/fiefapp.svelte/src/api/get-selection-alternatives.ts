import type { ISelectionAlternatives } from '../models/settings/selection-alternatives';
import { queryDataAsync } from '../api/api';

export const getSelectionAlternatives = async (): Promise<
  ISelectionAlternatives
> => {
  return queryDataAsync({
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
  })
    .then(async (response) => {
      if (!response.ok) {
        throw new Error(response.statusText);
      }

      const {
        data: {
          selectionAlternatives: { selectionAlternatives },
        },
      } = await response.json();

      return selectionAlternatives as ISelectionAlternatives;
    })
    .catch((error) => {
      throw new Error(error);
    });
};
