import { queryDataAsync } from './api';
import type { BuildingAlternative } from '../models/settings/building-alternative';

export const getBuildingAlternatives = async (): Promise<
  BuildingAlternative[]
> => {
  return queryDataAsync({
    query: `
    {
      buildingAlternative 
      {
        buildingAlternatives
        {
          type
          upkeep
          stonework
          woodwork
          smithswork
          stone
          wood
          iron
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
          buildingAlternative: { buildingAlternatives },
        },
      } = await response.json();

      return buildingAlternatives as BuildingAlternative[];
    })
    .catch((error) => {
      throw new Error(error);
    });
};
