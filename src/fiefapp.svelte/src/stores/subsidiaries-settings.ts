import type { Subsidiary } from 'src/models/industries/subsidiary';
import type { SubsidiaryAlternative } from 'src/models/settings/subsidiary-alternative';
import { writable, get } from 'svelte/store';

function createSubsidiarySettingsStore() {
  const store = writable<SubsidiaryAlternative[]>([]);

  const checkSubsidiary = (subsidiary: Subsidiary): void => {
    if (!isSubsidiaryInStore(subsidiary)) {
      if (!isSubsidiaryNameInStore) {
        store.update((n) => [...n, subsidiary.createAlternative()]);
        return;
      }
    }

    // Ask to replace or not.
    console.log(`${subsidiary.name} already exists in store!`);
    return;
  };

  const isSubsidiaryInStore = (subsidiary: Subsidiary) => {
    let alternative = subsidiary.createAlternative();
    if (get(store).includes(alternative)) {
      return true;
    }

    return false;
  };

  const isSubsidiaryNameInStore = (name: string) => {
    let currentStore = get(store);
    for (let i = 0; i < currentStore.length; i++) {
      if (currentStore[i].name === name) {
        return true;
      }
    }

    return false;
  };

  return {
    subscribe: store.subscribe,
    check: (subsidiary: Subsidiary): void => checkSubsidiary(subsidiary),
    subsidiaries: get(store),
  };
}

export const subsidiariesSettingsStore = createSubsidiarySettingsStore();
