import { client } from '../apollo';
import gql from 'graphql-tag';
import type { Gamesession } from '../../models/gamesession';
import type { MutationResponse } from '../types';

export const addGamesession = async (
  userId: string | null = null
): Promise<MutationResponse> => {
  const query = gql`
    mutation {
      addGamesession() {
        type
        actionSucceeded
        deletedId
        entity {
          id
          ownerId
          userIds
          gamemasterId
          name
          inheritances {
            id
            type
            name
            description
          }
          roads {
            id
            type
            name
            upgradeBaseCost
            upgradeStoneCost
            modificationFactor
            dayswork
          }
          livingconditions {
            id
            type
            name
            baseCost
            luxuryCost
            focusGain
            wellbeingGain
            description
          }
        }
      }
    }
  `;

  const { data, errors } = await client.query({ query });

  if (errors !== undefined) {
    throw new Error();
  }

  return data as MutationResponse;
};
