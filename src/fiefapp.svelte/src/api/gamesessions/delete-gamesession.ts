import { client } from '../apollo';
import gql from 'graphql-tag';
import type { MutationResponse } from '../types';

export const deleteGamesession = async (
  gamesessionId: string
): Promise<MutationResponse> => {
  const query = gql`
    mutation {
      deleteGamesession(
        gamesessionId: ${gamesessionId}
      ) {
        type
        actionSucceeded
        deletedId
      }
    }
  `;

  const { data, errors } = await client.query({ query });

  if (errors !== undefined) {
    throw new Error();
  }

  return data as MutationResponse;
};
