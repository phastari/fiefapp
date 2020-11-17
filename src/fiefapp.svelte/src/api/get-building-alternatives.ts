import { queryDataAsync } from './api';
import { BuildingAlternative } from '../models/settings/building-alternative';

export const getBuildingAlternatives = async (): Promise<
  BuildingAlternative[]
> => {
  let array: BuildingAlternative[] = [];

  queryDataAsync({
    query: `
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
    `,
  })
    .then((res) => res.json())
    .then((res) => {
      try {
        if (res.data.buildingAlternatives.length > 0) {
          for (let i = 0; i < res.data.buildingAlternatives.length; i++) {
            array.push(
              new BuildingAlternative(
                res.data.buildingAlternatives[i].type,
                res.data.buildingAlternatives[i].upkeep,
                res.data.buildingAlternatives[i].woodwork,
                res.data.buildingAlternatives[i].stonework,
                res.data.buildingAlternatives[i].smithswork,
                res.data.buildingAlternatives[i].wood,
                res.data.buildingAlternatives[i].stone,
                res.data.buildingAlternatives[i].iron
              )
            );
          }
        }
      } catch (error) {
        throw new Error();
      }
    })
    .catch((error) => console.log(error));

  return array;
};
