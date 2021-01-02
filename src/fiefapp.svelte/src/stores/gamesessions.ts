import { getGamesessions } from 'src/api/gamesessions/get-gamesessions';
import { writable } from 'svelte/store';
import { addGamesession } from '../api/gamesessions/add-gamesession';
import { deleteGamesession } from '../api/gamesessions/delete-gamesession';
import type { Gamesession } from '../models/gamesession';
import { userStore } from './authentication';

const store = writable<Gamesession[]>(await getGamesessions());

let userId: string | undefined;

userStore.subscribe(async (state) => {
  userId = state?.id;
  store.set(await getGamesessions(userId));
});

// ALSO SUBSCRIBE TO GAMESESSION CHANGES!! GRAPHQL SUBSCRIPTION

const gamesessionsStore = {
  subscribe: store.subscribe,
  add: async () => {
    const response = await addGamesession(userId ? userId : null);
    if (response.actionSucceeded) {
      store.update((state) => {
        state = [...state, response.entity as Gamesession];
        return state;
      });
    }
  },
  delete: async (gamesessionId: string) => {
    const response = await deleteGamesession(gamesessionId);
    if (response.actionSucceeded) {
      store.update((state) => {
        state = state.filter((item) => item.id !== response.deletedId);
        return state;
      });
    }
  },
  update: async () => {},
};

export default gamesessionsStore;
