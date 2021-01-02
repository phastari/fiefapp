import { client } from './apollo';
import gql from 'graphql-tag';
import type { BuildingAlternative } from '../models/settings/building-alternative';
import type { DocumentNode } from 'graphql';

export const getBuildings = async (): Promise<BuildingAlternative[]> => {
  const query = gql`
    query {
      buildings {
        id
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
  `;

  const { data, errors } = await client.query({ query });

  if (errors !== undefined) {
    throw new Error();
  }

  return data.buildings;
};
