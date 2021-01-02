import { client } from '../apollo';
import gql from 'graphql-tag';
import type { Gamesession } from '../../models/gamesession';

export const getGamesessions = async (
  userId: string | null = null
): Promise<Gamesession[]> => {
  const query = gql`
    query {
      gamesessions(${userId}) {
        id
        ownerId
        userIds
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
  `;

  const { data, errors } = await client.query({ query });

  if (errors !== undefined) {
    throw new Error();
  }

  return data.gamesessions;
};
