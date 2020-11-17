import { InheritanceAlternative } from '../models/settings/inheritance-alternative';
import { LivingconditionAlternative } from '../models/settings/livingcondition-alternative';
import { RoadAlternative } from '../models/settings/road-alternative';
import {
  initialSelectionAlternatives,
  ISelectionAlternatives,
} from '../models/settings/selection-alternatives';
import { queryDataAsync } from '../api/api';

export const getSelectionAlternatives = async (): Promise<
  ISelectionAlternatives
> => {
  let selectionAlternatives: ISelectionAlternatives = initialSelectionAlternatives;

  queryDataAsync({
    query: `
    {
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
          description
          upgradeBaseCost
          upgradeStoneCost
          modificationFactor
        }
      }
    }
    `,
  })
    .then((res) => res.json())
    .then((res) => {
      try {
        for (
          let i = 0;
          i < res.data.selectionAlternatives.inheritances.length;
          i++
        ) {
          selectionAlternatives.inheritances.push(
            new InheritanceAlternative(
              res.data.selectionAlternatives.inheritances[i].type,
              res.data.selectionAlternatives.inheritances[i].name,
              res.data.selectionAlternatives.inheritances[i].description
            )
          );
        }

        for (
          let i = 0;
          i < res.data.selectionAlternatives.livingconditions.length;
          i++
        ) {
          selectionAlternatives.livingConditions.push(
            new LivingconditionAlternative(
              res.data.selectionAlternatives.livingconditions[i].type,
              res.data.selectionAlternatives.livingconditions[i].baseCost,
              res.data.selectionAlternatives.livingconditions[i].luxuryCost,
              res.data.selectionAlternatives.livingconditions[i].focusGain,
              res.data.selectionAlternatives.livingconditions[i].wellbeingGain,
              res.data.selectionAlternatives.livingconditions[i].description
            )
          );
        }

        for (let i = 0; i < res.data.selectionAlternatives.roads.length; i++) {
          selectionAlternatives.roads.push(
            new RoadAlternative(
              res.data.selectionAlternatives.roads[i].type,
              res.data.selectionAlternatives.roads[i].description,
              res.data.selectionAlternatives.roads[i].upgradeBaseCost,
              res.data.selectionAlternatives.roads[i].upgradeStoneCost,
              res.data.selectionAlternatives.roads[i].modificationFactor
            )
          );
        }
      } catch (error) {
        throw new Error();
      }
    })
    .catch((error) => console.log(error));

  return selectionAlternatives;
};
